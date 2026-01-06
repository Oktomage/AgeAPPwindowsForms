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

        public ApplyMatchResultForm(FiresharpData data_service, Log persistent_log)
        {
            InitializeComponent();
            local_Data_service = data_service;

            if (persistent_log != null)
            {
                selected_log = persistent_log;
                UpdateUIbased_on_log(selected_log);
            }

            GridStyleController.ApplyTheme(dataGridViewMaps);
            GridStyleController.FixMapsHeaderNames(dataGridViewMaps);
            GridStyleController.ApplyMapTypeFormatting(dataGridViewMaps);

            UpdateDataGridViewMaps();
        }

        private void ApplyMatchResultForm_Load(object sender, EventArgs e)
        {
            Write_toolTips();

            // Configura ComboBox
            TeamVictoriousBox.SelectedIndex = 0;

            // Configura DataGridView
            dataGridViewMatchLog.AutoGenerateColumns = false;
            dataGridViewMatchLog.Columns.Clear();

            dataGridViewMatchLog.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TeamA",
                HeaderText = "TimeA"
            });

            dataGridViewMatchLog.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "RatingA",
                HeaderText = "Rating"
            });

            dataGridViewMatchLog.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Rating_changes",
                HeaderText = "Valor da partida"
            });

            dataGridViewMatchLog.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TeamB",
                HeaderText = "TimeB"
            });

            dataGridViewMatchLog.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "RatingB",
                HeaderText = "Rating"
            });

            GridStyleController.ApplyTheme(dataGridViewMatchLog);
        }

        private void Write_toolTips()
        {
            ToolTips.SetToolTip(HelpButton, "Mostra um pequeno tutorial.");
            ToolTips.SetToolTip(FindLogsButton, "Abre o seletor de arquivos, dentro da pasta de registros de logs.");
            ToolTips.SetToolTip(ChangeMapButton, "Muda o mapa do log, para o mapa selecionado na lista.");
            ToolTips.SetToolTip(ApplyResultButton, "Aplica o resultado do log no banco.");
        }

        private async void UpdateDataGridViewMaps()
        {
            dataGridViewMaps.DataSource = null;

            var maps = await local_Data_service.GetAllMaps();
            dataGridViewMaps.DataSource = maps;
        }

        public class MatchRowView
        {
            public string TeamA { get; set; }
            public int RatingA { get; set; }

            public string Rating_changes { get; set; }

            public string TeamB { get; set; }
            public int RatingB { get; set; }
        }
        private List<MatchRowView> BuildMatchRows(Log log)
        {
            var rows = new List<MatchRowView>();

            int max = Math.Max(log.TeamA_players.Count, log.TeamB_players.Count);

            int teamRatingA = log.TeamA_players.Sum(p => p.Rating);
            int teamRatingB = log.TeamB_players.Sum(p => p.Rating);
            int delta = local_Main_functions_service.Calculate_expected_rating_changes(teamRatingA, teamRatingB);

            for (int i = 0; i < max; i++)
            {
                rows.Add(new MatchRowView
                {
                    TeamA = i < log.TeamA_players.Count
                        ? log.TeamA_players[i].Name
                        : "",

                    RatingA = i < log.TeamA_players.Count
                        ? log.TeamA_players[i].Rating
                        : 0,

                    Rating_changes = $"+-{delta}",

                    TeamB = i < log.TeamB_players.Count
                        ? log.TeamB_players[i].Name
                        : "",

                    RatingB = i < log.TeamB_players.Count
                        ? log.TeamB_players[i].Rating
                        : 0
                });
            }

            return rows;
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

            var rows = BuildMatchRows(log);

            dataGridViewMatchLog.DataSource = null;
            dataGridViewMatchLog.DataSource = rows;

            PlayedMapLabel.Text = log.Played_map != null ? $"Mapa: {log.Played_map.Name}" : "Desconhecido";
        }

        #region BUTTONS

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
                Author_name = local_Data_service.Local_Admin_Logged.Name,
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

        private void ChangeMapButton_Click(object sender, EventArgs e)
        {
            if(selected_log == null)
            {
                MessageBox.Show("Selecione um log primeiro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dataGridViewMaps.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um mapa primeiro.");
                return;
            }

            var selectedMap = dataGridViewMaps.SelectedRows[0].DataBoundItem as Map;

            if (selectedMap == null)
                return;

            selected_log.Played_map = selectedMap;
            PlayedMapLabel.Text = selected_log.Played_map != null ? $"Mapa: {selected_log.Played_map.Name}" : "Desconhecido";

            System.Media.SystemSounds.Exclamation.Play();
        }

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
