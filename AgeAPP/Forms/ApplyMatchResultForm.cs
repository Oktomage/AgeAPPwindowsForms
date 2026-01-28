using AgeAPP.Classes;
using System.Text.Json;
using static AgeAPP.Classes.Main_classes;
using static AgeAPP.Classes.MainFunctions;

namespace AgeAPP.Forms
{
    public partial class ApplyMatchResultForm : Form
    {
        // Serviços
        private FiresharpData local_Data_service = new FiresharpData();
        private MainFunctions local_Main_functions_service = new MainFunctions();

        // Local data
        private Log selected_log;
        private ImageList avatarList;
        private ImageList mapImageList;

        public ApplyMatchResultForm(FiresharpData data_service, Log persistent_log)
        {
            InitializeComponent();

            local_Data_service = data_service;

            if (persistent_log != null)
            {
                selected_log = persistent_log;
                UpdateUIbased_on_log(selected_log);
            }

            // Configura ListView de preview
            PreviewListView.View = View.Details;
            PreviewListView.FullRowSelect = true;
            PreviewListView.MultiSelect = false;
            PreviewListView.HeaderStyle = ColumnHeaderStyle.Nonclickable;

            PreviewListView.Columns.Clear();
            PreviewListView.Columns.Add("", 40);          // Avatar
            PreviewListView.Columns.Add("Jogador", 120);
            PreviewListView.Columns.Add("Rating", 70);
            PreviewListView.Columns.Add("Δ", -2);

            // Avatar
            avatarList = new ImageList();
            avatarList.ImageSize = new Size(32, 32);
            avatarList.ColorDepth = ColorDepth.Depth32Bit;
            PreviewListView.SmallImageList = avatarList;

            // Configura ListView de mapas
            MapsListView.View = View.Details;
            MapsListView.FullRowSelect = true;
            MapsListView.MultiSelect = false;
            MapsListView.HeaderStyle = ColumnHeaderStyle.Nonclickable;

            MapsListView.Columns.Clear();
            MapsListView.Columns.Add("", 50);        // Miniatura
            MapsListView.Columns.Add("Mapa", 140);
            MapsListView.Columns.Add("Tipo", -2);

            MapsListView.Scrollable = true;
            MapsListView.HideSelection = false;

            // Miniatura de mapas
            mapImageList = new ImageList();
            mapImageList.ImageSize = new Size(32, 32);
            mapImageList.ColorDepth = ColorDepth.Depth32Bit;

            MapsListView.SmallImageList = mapImageList;

            LoadMapsList();
        }

        private void ApplyMatchResultForm_Load(object sender, EventArgs e)
        {
            Write_toolTips();

            // Configura ComboBox
            TeamVictoriousBox.SelectedIndex = 0;

            ControlPanel.Visible = false;
            PreviewListView.Visible = false;
            MapsListView.Visible = false;
        }

        private void Write_toolTips()
        {
            ToolTips.SetToolTip(HelpButton, "Mostra um pequeno tutorial.");
            ToolTips.SetToolTip(FindLogsButton, "Abre o seletor de arquivos, dentro da pasta de registros de logs.");
            ToolTips.SetToolTip(ApplyResultButton, "Aplica o resultado do log no banco.");
        }

        private string GetMapTypeName(int type)
        {
            return type switch
            {
                0 => "Padrão",
                1 => "Arena",
                2 => "Híbrido",
                3 => "Nômade",
                _ => "Desconhecido"
            };
        }

        private async void LoadMapsList()
        {
            MapsListView.Items.Clear();
            mapImageList.Images.Clear();

            var maps = await local_Data_service.GetAllMaps();

            foreach (var map in maps)
            {
                Image thumb = MapImageDictionary.Get(map.Name);
                mapImageList.Images.Add(map.Name, thumb);

                var item = new ListViewItem("") // coluna da imagem
                {
                    ImageKey = map.Name,
                    ForeColor = Color.White
                };

                item.SubItems.Add(map.Name);                 // nome
                item.SubItems.Add(GetMapTypeName(map.Type)); // tipo
                item.Tag = map;

                if (selected_log?.Played_map != null && map.Name == selected_log.Played_map.Name)
                {
                    item.BackColor = Color.FromArgb(40, 40, 40);
                    item.ForeColor = Color.Gold;
                }

                MapsListView.Items.Add(item);
            }
        }

        private void BuildPreview(List<Player> teamA, List<Player> teamB, bool teamAWon)
        {
            PreviewListView.Items.Clear();
            avatarList.Images.Clear();
            PreviewListView.BeginUpdate();

            var teamAClone = teamA.Select(p => p.Clone()).ToList();
            var teamBClone = teamB.Select(p => p.Clone()).ToList();

            MatchResult previewResult =
                local_Main_functions_service.Get_match_result(
                    teamAClone,
                    teamBClone,
                    teamAWon,
                    "Preview"
                );

            int delta = previewResult.PerPlayerDelta;

            void AddPlayer(Player p, int playerDelta)
            {
                int newRating = p.Rating + playerDelta;

                Image avatar = MainFunctions.LoadAvatar(p.AvatarId);
                avatarList.Images.Add(p.Name, avatar);

                var item = new ListViewItem { ImageKey = p.Name };
                item.SubItems.Add(p.Name);
                item.SubItems.Add((p.Rating - playerDelta).ToString()); // rating antigo
                item.SubItems.Add(playerDelta > 0 ? $"+{playerDelta}" : playerDelta.ToString());

                item.ForeColor = playerDelta >= 0 ? Color.LimeGreen : Color.IndianRed;

                PreviewListView.Items.Add(item);
            }

            // VENCEDORES (sempre TeamA do resultado)
            foreach (var p in previewResult.TeamA)
                AddPlayer(p, +delta);

            // PERDEDORES (sempre TeamB do resultado)
            foreach (var p in previewResult.TeamB)
                AddPlayer(p, -delta);

            PreviewListView.EndUpdate();
        }

        private void UpdateUIbased_on_log(Log log)
        {
            if (log == null ||
                log.All_players == null ||
                log.TeamA_players == null ||
                log.TeamB_players == null)
            {
                MessageBox.Show("Log inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool teamAWon = TeamVictoriousBox.SelectedItem?.ToString() == "Team A";

            BuildPreview(log.TeamA_players, log.TeamB_players, teamAWon);

            PlayedMapLabel.Text = log.Played_map != null ? $"Mapa: {log.Played_map.Name}" : "Desconhecido";

            ControlPanel.Visible = true;
            PreviewListView.Visible = true;
            MapsListView.Visible = true;
        }

        #region BUTTONS

        private void MapsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MapsListView.SelectedItems.Count == 0) return;
            if (selected_log == null) return;

            var item = MapsListView.SelectedItems[0];
            var selectedMap = item.Tag as Map;

            if (selectedMap == null) return;

            selected_log.Played_map = selectedMap;
            PlayedMapLabel.Text = $"Mapa: {selectedMap.Name}";

            System.Media.SystemSounds.Asterisk.Play();
        }

        private void TeamVictoriousBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selected_log == null) return;

            bool teamAWon = TeamVictoriousBox.SelectedItem.ToString() == "Team A";

            BuildPreview(selected_log.TeamA_players, selected_log.TeamB_players, teamAWon);
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. Clique em 'Procurar Log' para selecionar um arquivo de log de partida no formato JSON.\n\n" +
                "2. Após selecionar o log, os detalhes da partida serão exibidos na tabela abaixo.\n\n" +
                "3. Selecione o time vencedor na caixa de seleção 'Time Vencedor'.\n\n" +
                "4. Clique em 'Aplicar Resultado' para atualizar os ratings dos jogadores e salvar o resultado da partida no banco de dados.\n\n" +
                "5. Confirme a ação na janela de confirmação que aparecerá.\n\n" +
                "Observação: Certifique-se de que o log selecionado seja válido e contenha todas as informações necessárias.", "Ajuda - Aplicar Resultado da Partida", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FindLogButton_Click(object sender, EventArgs e)
        {
            using OpenFileDialog dialog = new OpenFileDialog();

            dialog.InitialDirectory = local_Main_functions_service.LogsFolder_path; // pasta dos logs
            dialog.Filter = "Arquivos JSON (*.json)|*.json|Todos os arquivos (*.*)|*.*";
            dialog.Title = "Selecionar log";
            dialog.Multiselect = false;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFile = dialog.FileName;
                string json = File.ReadAllText(dialog.FileName);

                Log log = JsonSerializer.Deserialize<Log>(json);

                if (log == null)
                {
                    MessageBox.Show("Log inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Armazena log selecionado
                selected_log = log;

                // Atualiza UI
                UpdateUIbased_on_log(selected_log);
            }
        }

        private async void ApplyResultButton_Click(object sender, EventArgs e)
        {
            if (selected_log == null)
            {
                MessageBox.Show("Nenhum log selecionado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verifica seleção dos times
            bool teamAWon;

            if (TeamVictoriousBox.SelectedItem == null)
            {
                MessageBox.Show("Selecione o time vencedor.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Pega a definição do time vencedor
            teamAWon = TeamVictoriousBox.SelectedItem.ToString() == "Team A";

            var result = MessageBox.Show($"Tem certeza que deseja aplicar esse resultado ? \n Essa ação não pode ser desfeita.", "Confirmar mudança", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return;

            // Desabilita o botão (EVITAR DUPLICAÇÃO)
            ApplyResultButton.Enabled = false;

            var progressTask = FakeProgress();

            // Aplicar resultado da partida
            MatchResult match_result = local_Main_functions_service.Get_match_result(selected_log.TeamA_players, selected_log.TeamB_players, teamAWon, selected_log.Played_map?.Name ?? "Desconhecido");

            // Salvar alterações no banco
            foreach (var player in match_result.TeamA)
                await local_Data_service.Overwrite_player(player);

            foreach (var player in match_result.TeamB)
                await local_Data_service.Overwrite_player(player);

            // Aplicar mudanças no mapa
            Map played_map = await local_Data_service.Get_map(match_result.PlayedMap_name);
            played_map.Matches += 1;

            await local_Data_service.Overwrite_map(played_map);

            // Salvar log da partida no banco
            await local_Data_service.Post_log_on_dataBase(new Log
            {
                Author_name = local_Data_service.LocalAccount.Username,
                Role = "Match_results",
                Date = DateTime.Now.ToString(),
                Content = $"Lançou um resultado de partida",
                Match_result = match_result
            });

            // Garante que a barra terminou
            await progressTask;

            ProgressBar.Value = 100;
            await Task.Delay(200);

            // Fechar painel
            this.Close();
        }

        #endregion

        private async Task FakeProgress(int durationMs = 1200)
        {
            ProgressBar.Visible = true;
            ProgressBar.Value = 0;

            int steps = 20;
            int delay = durationMs / steps;

            for (int i = 1; i <= steps; i++)
            {
                ProgressBar.Value = i * (100 / steps);
                await Task.Delay(delay);
            }
        }
    }
}
