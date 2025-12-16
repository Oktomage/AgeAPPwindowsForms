using AgeAPP.Classes;
using static AgeAPP.Classes.FiresharpData;

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

        private async void CreateButton_Click(object sender, EventArgs e)
        {
            if(TextBoxPlayerName.Text == "" || TextBoxPlayerRating.Text == "")
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Player newPlayer = new Player
            {
                Id = 0, // O ID será atribuído automaticamente pelo serviço de dados
                Name = TextBoxPlayerName.Text,
                Rating = int.Parse(TextBoxPlayerRating.Text),
                Matches = 0,
                Wins = 0,
                WinRate = 0f
            };

            await local_Data_service.Add_new_player(newPlayer);

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
