using AgeAPP.Classes;
using System.Windows.Forms;
using static AgeAPP.Classes.Main_classes;

namespace AgeAPP.Cards
{
    public partial class CompactPlayerCard : UserControl
    {
        private Color defaultBackColor;

        public CompactPlayerCard()
        {
            InitializeComponent();

            defaultBackColor = this.BackColor;
        }

        public void Bind(Player player)
        {
            // Nome
            PlayerNameLabel.Text = player.Name;

            // Rating
            PlayerRatingLabel.Text = $"({player.Rating})";

            // Rank
            LeaderboardRankLabel.Text = $"#{player.Id}";

            switch (player.Id)
            {
                case 1:
                    LeaderboardRankLabel.ForeColor = Color.Gold;
                    LeaderboardRankLabel.Font = new Font(LeaderboardRankLabel.Font.FontFamily, 16f, LeaderboardRankLabel.Font.Style);
                    break;

                case 2:
                    LeaderboardRankLabel.ForeColor = Color.White;
                    LeaderboardRankLabel.Font = new Font(LeaderboardRankLabel.Font.FontFamily, 16f, LeaderboardRankLabel.Font.Style);
                    break;

                case 3:
                    LeaderboardRankLabel.ForeColor = Color.White;
                    LeaderboardRankLabel.Font = new Font(LeaderboardRankLabel.Font.FontFamily, 16f, LeaderboardRankLabel.Font.Style);
                    break;

                default:
                    LeaderboardRankLabel.ForeColor = Color.White;
                    LeaderboardRankLabel.Font = new Font(LeaderboardRankLabel.Font.FontFamily, 12f, LeaderboardRankLabel.Font.Style);
                    break;
            }

            // Avatar
            AvatarPictureBox.BackgroundImage = MainFunctions.LoadAvatar(player.AvatarId);
        }

        #region Mouse Events

        private void CompactPlayerCard_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(48, 48, 48);
        }

        private void CompactPlayerCard_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = defaultBackColor;
        }

        #endregion
    }
}
