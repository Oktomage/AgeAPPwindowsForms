using static AgeAPP.Classes.Main_classes;

namespace AgeAPP.Cards
{
    public partial class CompactPlayerCard : UserControl
    {
        public CompactPlayerCard()
        {
            InitializeComponent();
        }

        public void Bind(Player player)
        {
            // Nome
            PlayerNameLabel.Text = player.Name;

            // Rating
            PlayerRatingLabel.Text = $"({player.Rating})";

            // Rank
            LeaderboardRankLabel.Text = $"#{player.Id}";
            
            switch(player.Id)
            {
                case 1:
                    LeaderboardRankLabel.ForeColor = Color.Gold;
                    LeaderboardRankLabel.Font = new Font(LeaderboardRankLabel.Font.FontFamily, 16f, LeaderboardRankLabel.Font.Style);
                    break;

                case 2:
                    LeaderboardRankLabel.ForeColor = Color.LightGray;
                    LeaderboardRankLabel.Font = new Font(LeaderboardRankLabel.Font.FontFamily, 16f, LeaderboardRankLabel.Font.Style);
                    break;

                case 3:
                    LeaderboardRankLabel.ForeColor = Color.Brown;
                    LeaderboardRankLabel.Font = new Font(LeaderboardRankLabel.Font.FontFamily, 16f, LeaderboardRankLabel.Font.Style);
                    break;

                default:
                    LeaderboardRankLabel.ForeColor = Color.White;
                    LeaderboardRankLabel.Font = new Font(LeaderboardRankLabel.Font.FontFamily, 12f, LeaderboardRankLabel.Font.Style);
                    break;
            }

            /*
            // Partidas e vitórias
            PlayerMatchesLabel.Text = $"Partidas: {player.Matches} | Vitórias: {player.Wins}";

            /*
            // Avatar
            if (!string.IsNullOrWhiteSpace(player.AvatarPath) &&
                File.Exists(player.AvatarPath))
            {
                AvatarPictureBox.Image = Image.FromFile(player.AvatarPath);
            }
            else
            {
                AvatarPictureBox.Image = Properties.Resources.default_avatar;
            }*/
        }
    }
}
