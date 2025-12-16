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
            }
        }

        private void CreateNewPlayerButton_Click(object sender, EventArgs e)
        {
            CreateNewPlayerForm creationForm = new CreateNewPlayerForm(local_Data_service);

            if (creationForm.ShowDialog(this) == DialogResult.OK)
            {
                UpdateGridViewPlayers();
            }
        }

        #region MATCH PANEL BUTTONS

        private void ApplyMatchResultButton_Click(object sender, EventArgs e)
        {

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

            UpdateGridViewPlayers();
        }

        private async void DeleteSelectedPlayerButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show($"Tem certeza que deseja excluir o jogador {selectedPlayer.Name} ? \nEssa ação não pode ser desfeita.", "Confirmar exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return;

            // Deleta o jogador
            await local_Data_service.Delete_player(selectedPlayer);

            UpdateGridViewPlayers();
        }

        private void SelectedPlayerLabel_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Você está olhando o jogador: {selectedPlayer.Name}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion


    }
}
