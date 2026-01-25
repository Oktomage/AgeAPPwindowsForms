using AgeAPP.Classes;
using static AgeAPP.Classes.Main_classes;
using static AgeAPP.Styles.CSS;

namespace AgeAPP.Cards
{
    public partial class CompactPlayerCard : UserControl
    {
        public CompactPlayerCard()
        {
            InitializeComponent();
            HoverStyles.CardHover(this);
        }

        public void Bind(Player player, int rank)
        {
            // Nome
            PlayerNameLabel.Text = player.Name;

            // Rating
            PlayerRatingLabel.Text = $"({player.Rating})";

            // Rank
            LeaderboardRankLabel.Text = $"#{rank}";

            switch (rank)
            {
                case 1:
                    LeaderboardRankLabel.ForeColor = Color.Gold;
                    LeaderboardRankLabel.Font = new Font(LeaderboardRankLabel.Font.FontFamily, 16f, FontStyle.Bold);
                    break;

                case 2:
                case 3:
                    LeaderboardRankLabel.ForeColor = Color.WhiteSmoke;
                    LeaderboardRankLabel.Font = new Font(LeaderboardRankLabel.Font.FontFamily, 14f, FontStyle.Bold);
                    break;

                default:
                    LeaderboardRankLabel.ForeColor = Color.White;
                    LeaderboardRankLabel.Font = new Font(LeaderboardRankLabel.Font.FontFamily, 12f, FontStyle.Regular);
                    break;
            }

            // Avatar
            AvatarPictureBox.BackgroundImage = MainFunctions.LoadAvatar(player.AvatarId);
        }
    }
}
