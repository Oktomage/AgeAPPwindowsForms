using AgeAPP.Classes;
using static AgeAPP.Classes.Main_classes;

namespace AgeAPP.Forms
{
    public partial class EditPlayerAvatarForm : Form
    {
        // Serviços
        private FiresharpData local_Data_service;

        private Main_classes.Player currentPlayer;
        private string selectedAvatarName = "Player_icon1";

        public EditPlayerAvatarForm(FiresharpData Data_service, Main_classes.Player player)
        {
            InitializeComponent();

            local_Data_service = Data_service;
            currentPlayer = player;
        }

        private void EditPlayerAvatarForm_Load(object sender, EventArgs e)
        {
            MainFunctions.LoadAvatarsOnLayoutPanel(AvatarsLayoutPanel, OnAvatarSelected);
        }

        #region EVENTS

        private void OnAvatarSelected(PictureBox pic)
        {
            // Limpa seleção
            foreach (Control c in AvatarsLayoutPanel.Controls)
                c.BackColor = Color.Transparent;

            // Marca selecionado
            pic.BackColor = Color.Gold;

            selectedAvatarName = pic.Tag.ToString();

            System.Media.SystemSounds.Beep.Play();
        }

        #endregion

        #region BUTTONS

        private async void ConfirmButton_Click(object sender, EventArgs e)
        {
            currentPlayer.AvatarId = selectedAvatarName;

            await local_Data_service.Overwrite_player(currentPlayer);

            if(local_Data_service.LocalAccount != null)
            {
                // Publica o log da alteração do avatar
                await local_Data_service.Post_log_on_dataBase(new Log
                {
                    Author_name = local_Data_service.LocalAccount.Username,
                    Role = "Player_changes",
                    Date = DateTime.Now.ToString(),
                    Content = $"Alterou o avatar do jogador: {currentPlayer.Name}"
                });
            }

            MessageBox.Show("Avatar atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion
    }
}
