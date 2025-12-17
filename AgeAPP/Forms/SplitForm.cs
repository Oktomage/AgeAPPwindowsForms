using AgeAPP.Classes;
using System.Threading.Tasks;
using static AgeAPP.Classes.FiresharpData;

namespace AgeAPP.Forms
{
    public partial class SplitForm : Form
    {
        // Serviços
        private MainFunctions Main_functions_service = new MainFunctions();
        private FiresharpData local_Data_service;

        public SplitForm(FiresharpData Data_service)
        {
            InitializeComponent();
            local_Data_service = Data_service;
        }

        private async void SplitForm_Load(object sender, EventArgs e)
        {
            var players = await local_Data_service.GetAllPlayers();

            dataGridViewPlayers.DataSource = players;
        }

        private async void ConfirmSplitTeamsButton_Click(object sender, EventArgs e)
        {
            var selectedPlayers = dataGridViewPlayers.SelectedRows
                .Cast<DataGridViewRow>()
                .Select(r => r.DataBoundItem as Player)
                .Where(p => p != null)
                .ToList();

            if (selectedPlayers.Count < 3)
            {
                MessageBox.Show("Selecione pelo menos 4 jogadores.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (selectedPlayers.Count > 8)
            {
                MessageBox.Show($"Muitos jogadores selecionados. Você selecionou: {selectedPlayers.Count}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (selectedPlayers.Count % 2 != 0)
            {
                MessageBox.Show("Número ímpar de jogadores selecionados. Selecione um número par de jogadores.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Pega mapa
            var allmaps = await local_Data_service.GetAllMaps();
            var selectedMap = Main_functions_service.Get_mapBased_on_players_favoriteMaps(selectedPlayers, allmaps);

            TextBoxMap.Text = $"Mapa: [{selectedMap.Name}]";

            // Pega a divisão de times
            var (teamA, teamB) = Main_functions_service.SplitTeamsBruteForce(selectedPlayers);

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
    }
}
