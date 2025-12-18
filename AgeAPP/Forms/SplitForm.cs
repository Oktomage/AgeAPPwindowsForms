using AgeAPP.Classes;
using static AgeAPP.Classes.FiresharpData;

namespace AgeAPP.Forms
{
    public partial class SplitForm : Form
    {
        // Serviços
        private MainFunctions Main_functions_service = new MainFunctions();
        private FiresharpData local_Data_service;

        // Local data
        private List<Player> room_players = new List<Player>();
        private List<Player> allPlayers = new List<Player>();

        public SplitForm(FiresharpData Data_service)
        {
            InitializeComponent();
            local_Data_service = Data_service;
        }

        private async void SplitForm_Load(object sender, EventArgs e)
        {
            room_players.Clear();

            // Atualiza a tabela inicial
            await UpdateLocalData();
            UpdateDataGridViewPlayers();
        }

        private async Task UpdateLocalData()
        {
            // Get updated data
            allPlayers = await local_Data_service.GetAllPlayers();
        }

        private void UpdateDataGridViewPlayers()
        {
            dataGridViewPlayers.DataSource = null;
            dataGridViewPlayers.DataSource = allPlayers;
        }

        #region Action Methods

        private void Add_player_to_room(Player player)
        {
            // Evita adicionar o mesmo jogador duas vezes
            if (!ListBoxRoom.Items.Contains(player.Name))
            {
                ListBoxRoom.Items.Add(player.Name);
                room_players.Add(player);
            }
            else
                MessageBox.Show("Este jogador já está na sala.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        
            // Atualiza tamanho da sala
            RoomSizeLabel.Text = $"Sala: {room_players.Count}/8";
        }

        private void Remove_player_from_the_room()
        {
            if (ListBoxRoom.SelectedItem != null)
            {
                room_players.RemoveAt(room_players.FindIndex(p => p.Name == ListBoxRoom.SelectedItem.ToString()));

                ListBoxRoom.Items.Remove(ListBoxRoom.SelectedItem);
            }

            // Atualiza tamanho da sala
            RoomSizeLabel.Text = $"Sala: {room_players.Count}/8";
        }

        private async void ConfirmSplitTeamsButton_Click(object sender, EventArgs e)
        {
            if (room_players.Count < 3)
            {
                MessageBox.Show("Selecione pelo menos 4 jogadores.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (room_players.Count > 8)
            {
                MessageBox.Show($"Muitos jogadores selecionados. Você selecionou: {room_players.Count}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (room_players.Count % 2 != 0)
            {
                MessageBox.Show("Número ímpar de jogadores selecionados. Selecione um número par de jogadores.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Pega mapa
            var allmaps = await local_Data_service.GetAllMaps();
            var selectedMap = Main_functions_service.Get_mapBased_on_players_favoriteMaps(room_players, allmaps);

            TextBoxMap.Text = $"Mapa: [{selectedMap.Name}]";

            // Pega a divisão de times
            var (teamA, teamB) = Main_functions_service.SplitTeamsBruteForce(room_players);

            string BuildTeamLine(string teamName, List<Player> team)
            {
                var playersPart = string.Join(" - ",
                    team.Select(p => $"{p.Name} ({p.Rating})"));

                int total = team.Sum(p => p.Rating);

                return $"{teamName}: {playersPart} - TOTAL: {total}";
            }

            TextBoxTeam1.Text = BuildTeamLine("TIME A", teamA);
            TextBoxTeam2.Text = BuildTeamLine("TIME B", teamB);

            // Salvar log
            Request_save_splitLog(teamA, teamB, selectedMap);
        }

        private void Request_save_splitLog(List<Player> teamA, List<Player> teamB, Map playedMap)
        {
            Log log = new Log
            {
                Author_name = local_Data_service.Local_Admin_Logged?.Name ?? "Sistema",
                Date = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss"),
                All_players = teamA.Concat(teamB).ToList(),
                TeamA_players = teamA,
                TeamB_players = teamB,
                Played_map = playedMap,
                Role = "Split_log"
            };

            // Salvar
            Main_functions_service.Save_log_to_file(log);
        }

        private void dataGridViewPlayers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignora clique no header
            if (e.RowIndex < 0)
                return;

            // Ignora se listBoxRoom estiver cheio
            if (room_players.Count >= 8)
            {
                MessageBox.Show("A sala já está cheia. Remova um jogador antes de adicionar outro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Pega o player da linha clicada
            var row = dataGridViewPlayers.Rows[e.RowIndex];
            var player = row.DataBoundItem as Player;

            if (player == null)
                return;

            Add_player_to_room(player);
        }

        private void ListBoxRoom_DoubleClick(object sender, EventArgs e)
        {
            Remove_player_from_the_room();
        }

        private void AddPlayerToRoomButton_Click(object sender, EventArgs e)
        {
            if (dataGridViewPlayers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um jogador da lista para adicionar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Pega a primeira linha selecionada
            DataGridViewRow row = dataGridViewPlayers.SelectedRows[0];

            Player player = row.DataBoundItem as Player;

            if (player == null)
                return;

            Add_player_to_room(player);
        }

        private void RemovePlayerFromTheRoomButton_Click(object sender, EventArgs e)
        {
            if (ListBoxRoom.SelectedItem == null)
            {
                MessageBox.Show("Selecione um jogador da sala para remover.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Remove_player_from_the_room();
        }

        #endregion

        #region TEXT BOXES

        private void FilterPlayerTextBox_TextChanged(object sender, EventArgs e)
        {
            string search = FilterPlayerTextBox.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(search))
            {
                dataGridViewPlayers.DataSource = allPlayers;
            }
            else
            {
                dataGridViewPlayers.DataSource = allPlayers
                    .Where(p => p.Name.ToLower().Contains(search))
                    .ToList();
            }
        }

        #endregion

        #region EXTRA BUTTONS

        private void CopyTeamATextButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxTeam1.Text))
            {
                MessageBox.Show("Nada para copiar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Clipboard.SetText(TextBoxTeam1.Text);
            MessageBox.Show("Texto copiado para a área de transferência!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CopyTeamBTextButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxTeam2.Text))
            {
                MessageBox.Show("Nada para copiar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Clipboard.SetText(TextBoxTeam2.Text);
            MessageBox.Show("Texto copiado para a área de transferência!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CopyMapTextButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxMap.Text))
            {
                MessageBox.Show("Nada para copiar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Clipboard.SetText(TextBoxMap.Text);
            MessageBox.Show("Texto copiado para a área de transferência!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion
    }
}
