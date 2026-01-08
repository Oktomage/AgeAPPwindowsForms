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
                    //RoleIcon.Image = Properties.Resources.player_icon;
                    ChangeTitleLabel.Text = "Alteração de jogador";
                    break;

                case "Map_changes":
                    //RoleIcon.Image = Properties.Resources.map_icon;
                    ChangeTitleLabel.Text = "Alteração de mapa";
                    break;

                case "Match_results":
                    //RoleIcon.Image = Properties.Resources.match_icon;
                    ChangeTitleLabel.Text = "Resultado de partida";
                    break;

                default:
                    ChangeTitleLabel.Text = log.Role;
                    break;
            }
        }
    }
}
