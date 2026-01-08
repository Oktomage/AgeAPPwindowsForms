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
