using AgeAPP.Classes;
using static AgeAPP.Classes.FiresharpData;

namespace AgeAPP.Forms
{
    public partial class AdminPanelForm : Form
    {
        //Serviços
        private FiresharpData local_Data_service = new FiresharpData();

        public AdminPanelForm(FiresharpData data_service)
        {
            InitializeComponent();
            local_Data_service = data_service;
        }

        private async void AdminPanelForm_Load(object sender, EventArgs e)
        {
            var players = await local_Data_service.GetAllPlayers();
            dataGridViewPlayers.DataSource = players;
        }

        private void dataGridViewPlayers_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewPlayers.SelectedRows.Count == 0)
                return;

            Player selectedPlayer = dataGridViewPlayers.SelectedRows[0].DataBoundItem as Player;

            // Mostra dados do jogador no painel
            if (selectedPlayer != null)
            {
                SelectedPlayerLabel.Text = $"{selectedPlayer.Name} | {selectedPlayer.Rating}";
                SelectedPlayerRatingTextBox.Text = selectedPlayer.Rating.ToString();
            }
        }

        #region PLAYER PANEL BUTTONS

        private void SelectedPlayerRatingTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite apenas números e teclas de controle (Backspace, Delete)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        #endregion
    }
}
