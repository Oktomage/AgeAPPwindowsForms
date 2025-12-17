using AgeAPP.Classes;
using static AgeAPP.Classes.FiresharpData;

namespace AgeAPP.Forms
{
    public partial class AdminPanelForm : Form
    {
        // Serviços
        private FiresharpData local_Data_service = new FiresharpData();

        // Local data
        private Player selectedPlayer = null;

        public AdminPanelForm(FiresharpData data_service)
        {
            InitializeComponent();
            local_Data_service = data_service;
        }

        private void AdminPanelForm_Load(object sender, EventArgs e)
        {
            UpdateGridViewPlayers();
        }

        private async void UpdateGridViewPlayers()
        {
            dataGridViewPlayers.DataSource = null;

            var players = await local_Data_service.GetAllPlayers();
            dataGridViewPlayers.DataSource = players;
        }

        private void dataGridViewPlayers_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewPlayers.SelectedRows.Count == 0)
                return;

            selectedPlayer = dataGridViewPlayers.SelectedRows[0].DataBoundItem as Player;

            // Mostra dados do jogador no painel
            if (selectedPlayer != null)
            {
                SelectedPlayerLabel.Text = $"{selectedPlayer.Name} - [{selectedPlayer.Rating}]";
                SelectedPlayerRatingTextBox.Text = selectedPlayer.Rating.ToString();

                // Se tiver maps favoritos, mostra na lista
                FavoriteMapListBox.Items.Clear();

                if (selectedPlayer.Favorite_maps != null && selectedPlayer.Favorite_maps.Count > 0)
                {
                    foreach (FavoriteMap map in selectedPlayer.Favorite_maps.Values)
                    {
                        FavoriteMapListBox.Items.Add($"{map.Name} - Jogado {map.Times_played} vezes");
                    }
                }
            }
        }

        private async void CreateNewPlayerButton_Click(object sender, EventArgs e)
        {
            CreateNewPlayerForm creationForm = new CreateNewPlayerForm(local_Data_service);

            if (creationForm.ShowDialog(this) == DialogResult.OK)
            {
                await local_Data_service.Post_log(new Log
                {
                    Author_name = local_Data_service.Local_Admin_Logged.Name,
                    Role = "Player_changes",
                    Date = DateTime.Now.ToString(),
                    Content = $"Criou um novo jogador"
                });

                UpdateGridViewPlayers();
            }
        }

        #region MATCH PANEL BUTTONS

        private void ApplyMatchResultButton_Click(object sender, EventArgs e)
        {
            ApplyMatchResultForm match_result_form = new ApplyMatchResultForm(local_Data_service);

            match_result_form.ShowDialog(this);
        }

        #endregion

        #region PLAYER PANEL BUTTONS

        private void SelectedPlayerRatingTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite apenas números e teclas de controle (Backspace, Delete)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private async void ChangeSelectedPlayerRating_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show($"Tem certeza que deseja mudar o rating do jogador {selectedPlayer.Name} ? \nEssa ação não pode ser desfeita.", "Confirmar mudança", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return;

            await local_Data_service.Overwrite_playerData(selectedPlayer, "Rating", int.Parse(SelectedPlayerRatingTextBox.Text));
            await local_Data_service.Post_log(new Log
            {
                Author_name = local_Data_service.Local_Admin_Logged.Name,
                Role = "Player_changes",
                Date = DateTime.Now.ToString(),
                Content = $"Alterou o rating do jogador {selectedPlayer.Name} para {SelectedPlayerRatingTextBox.Text}"
            });

            UpdateGridViewPlayers();
        }

        private async void DeleteSelectedPlayerButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show($"Tem certeza que deseja excluir o jogador {selectedPlayer.Name} ? \nEssa ação não pode ser desfeita.", "Confirmar exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return;

            // Deleta o jogador
            await local_Data_service.Delete_player(selectedPlayer);
            await local_Data_service.Post_log(new Log
            {
                Author_name = local_Data_service.Local_Admin_Logged.Name,
                Role = "Player_changes",
                Date = DateTime.Now.ToString(),
                Content = $"Deletou o jogador {selectedPlayer.Name}"
            });

            UpdateGridViewPlayers();
        }

        private void SelectedPlayerLabel_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Você está olhando o jogador: {selectedPlayer.Name}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion
    }
}
