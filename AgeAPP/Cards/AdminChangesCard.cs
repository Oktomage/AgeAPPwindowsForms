using AgeAPP.Classes;

namespace AgeAPP.Cards
{
    public partial class AdminChangesCard : UserControl
    {
        public AdminChangesCard()
        {
            InitializeComponent();
        }

        public void Bind(Main_classes.Log log)
        {
            AuthorLabel.Text = $"Registro por: {log.Author_name}";
            ContentTextBox.Text = log.Content;
            DateLabel.Text = log.Date;

            // Ícone ou texto baseado na Role
            switch (log.Role)
            {
                case "Player_changes":
                    ChangeIconPictureBox.BackgroundImage = Properties.Resources.Player_icon1;
                    ChangeTitleLabel.Text = "Alteração de jogador";
                    break;

                case "Map_changes":
                    ChangeIconPictureBox.BackgroundImage = Properties.Resources.UnkownMap;
                    ChangeTitleLabel.Text = "Alteração de mapa";
                    break;

                case "Match_results":
                    ChangeIconPictureBox.BackgroundImage = Properties.Resources.UnkownMap;
                    ChangeTitleLabel.Text = "Resultado de partida";
                    break;

                default:
                    ChangeTitleLabel.Text = log.Role;
                    break;
            }
        }
    }
}
