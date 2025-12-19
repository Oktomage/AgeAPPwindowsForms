using AgeAPP.Classes;
using static AgeAPP.Classes.FiresharpData;
using static AgeAPP.Classes.Main_classes;

namespace AgeAPP.Forms
{
    public partial class CreateNewPlayerForm : Form
    {
        // Serviços
        private FiresharpData local_Data_service = new FiresharpData();

        public CreateNewPlayerForm(FiresharpData data_service)
        {
            InitializeComponent();
            local_Data_service = data_service;
        }

        private async void CreateNewPlayerForm_Load(object sender, EventArgs e)
        {
            dataGridViewMaps.DataSource = null;

            var maps = await local_Data_service.GetAllMaps();
            dataGridViewMaps.DataSource = maps;

            GridStyleController.ApplyTheme(dataGridViewMaps);
        }

        private async void CreateButton_Click(object sender, EventArgs e)
        {
            if (TextBoxPlayerName.Text == "" || TextBoxPlayerRating.Text == "")
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selectedFavorite_maps = dataGridViewMaps.SelectedRows
                .Cast<DataGridViewRow>()
                .Select(r => r.DataBoundItem as Map)
                .Where(p => p != null)
                .ToList();

            Player newPlayer = new Player
            {
                Id = 0, // O ID será atribuído automaticamente pelo serviço de dados
                Name = TextBoxPlayerName.Text.Trim().ToLower(),
                Rating = int.Parse(TextBoxPlayerRating.Text),
                Matches = 0,
                Wins = 0,
                WinRate = 0f,
                Favorite_maps = selectedFavorite_maps.ToDictionary(
                    map => map.Name,
                    map => new FavoriteMap
                    {
                        Name = map.Name,
                        Times_played = 0
                    })
            };

            await local_Data_service.Add_new_player(newPlayer);

            await local_Data_service.Post_log_on_dataBase(new Log
            {
                Author_name = local_Data_service.Local_Admin_Logged.Name,
                Role = "Player_changes",
                Date = DateTime.Now.ToString(),
                Content = $"Criou um novo jogador, {newPlayer.Name}."
            });

            // Fecha o formulário após a criação do jogador
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void TextBoxPlayerRating_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite apenas números e teclas de controle (Backspace, Delete)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
