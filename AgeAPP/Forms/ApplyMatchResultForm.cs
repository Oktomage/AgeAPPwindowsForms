using AgeAPP.Classes;
using static AgeAPP.Classes.FiresharpData;

namespace AgeAPP.Forms
{
    public partial class ApplyMatchResultForm : Form
    {
        // Serviços
        private FiresharpData local_Data_service = new FiresharpData();
        private MainFunctions local_Main_functions_service = new MainFunctions();

        public ApplyMatchResultForm(FiresharpData data_service)
        {
            InitializeComponent();
            local_Data_service = data_service;
        }

        private void ApplyMatchResultForm_Load(object sender, EventArgs e)
        {
            UpdateDataGridViewPlayers();

            TeamVictoriousBox.SelectedIndex = 0;
        }

        private async void UpdateDataGridViewPlayers()
        {
            dataGridViewPlayers1.DataSource = null;
            dataGridViewPlayers2.DataSource = null;

            var players = await local_Data_service.GetAllPlayers();

            dataGridViewPlayers1.DataSource = players.Select(p => p).ToList();
            dataGridViewPlayers2.DataSource = players.Select(p => p).ToList();
        }

        private async void ApplyResultButton_Click(object sender, EventArgs e)
        {
            // Verifica seleção dos times
            bool teamAWon;

            if (TeamVictoriousBox.SelectedItem == null)
            {
                MessageBox.Show("Selecione o time vencedor.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            teamAWon = TeamVictoriousBox.SelectedItem.ToString() == "Team A";

            // Verifica seleção dos jogadores
            var selectedPlayers_grid1 = dataGridViewPlayers1.SelectedRows
                .Cast<DataGridViewRow>()
                .Select(r => r.DataBoundItem as Player)
                .Where(p => p != null)
                .ToList();

            if (selectedPlayers_grid1.Count < 2)
            {
                MessageBox.Show("Selecione pelo menos 2 jogadores.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (selectedPlayers_grid1.Count > 4)
            {
                MessageBox.Show("O número máximo de jogadores por time é 4.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (selectedPlayers_grid1.Count % 2 != 0)
            {
                MessageBox.Show("Número ímpar de jogadores selecionados. Selecione um número par de jogadores.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selectedPlayers_grid2 = dataGridViewPlayers2.SelectedRows
                .Cast<DataGridViewRow>()
                .Select(r => r.DataBoundItem as Player)
                .Where(p => p != null)
                .ToList();

            if (selectedPlayers_grid2.Count < 2)
            {
                MessageBox.Show("Selecione pelo menos 2 jogadores.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (selectedPlayers_grid2.Count > 4)
            {
                MessageBox.Show("O número máximo de jogadores por time é 4.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (selectedPlayers_grid2.Count % 2 != 0)
            {
                MessageBox.Show("Número ímpar de jogadores selecionados. Selecione um número par de jogadores.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(selectedPlayers_grid1.Count != selectedPlayers_grid2.Count)
            { 
                MessageBox.Show("O número de jogadores selecionados em cada lista deve ser igual.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var result = MessageBox.Show($"Tem certeza que deseja aplicar esse resultado ? \n Essa ação não pode ser desfeita.", "Confirmar mudança", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return;

            ApplyResultButton.Enabled = false;

            // Aplicar resultado da partida
            List<Player> updated_players = local_Main_functions_service.Apply_match_result(
                dataGridViewPlayers1.SelectedRows.Cast<DataGridViewRow>().Select(r => r.DataBoundItem as Player).ToList(),
                dataGridViewPlayers2.SelectedRows.Cast<DataGridViewRow>().Select(r => r.DataBoundItem as Player).ToList(),
                teamAWon
            );

            // Salvar alterações no banco
            foreach (var player in updated_players)
            {
                await local_Data_service.Overwrite_player(player);
            }

            await local_Data_service.Post_log(new Log
            {
                Author_name = local_Data_service.Local_Admin_Logged.Name,
                Role = "Match_results",
                Date = DateTime.Now.ToString(),
                Content = $"Lançou um resultado de partida"
            });

            // Fechar painel
            this.Close();
        }
    }
}
