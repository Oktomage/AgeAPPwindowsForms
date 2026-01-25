using AgeAPP.Classes;
using System.Globalization;
using static AgeAPP.Classes.Main_classes;
using static AgeAPP.Styles.CSS;

namespace AgeAPP.Cards
{
    public partial class PlayerCard : UserControl
    {
        public PlayerCard()
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

            // Partidas e vitórias
            PlayerMatchesLabel.Text = $"Partidas: {player.Matches} | Vitórias: {player.Wins}";

            // Win rate
            double winRate = player.Matches > 0
                ? (double)player.Wins / player.Matches * 100
                : 0;

            PlayerWinRateLabel.Text = $"[{winRate:0}%]";

            // Cor do win rate
            if (winRate < 50)
                PlayerWinRateLabel.ForeColor = Color.IndianRed;
            else if (winRate == 50)
                PlayerWinRateLabel.ForeColor = Color.Goldenrod;
            else
                PlayerWinRateLabel.ForeColor = Color.LimeGreen;

            // Última partida
            if (DateTime.TryParseExact(
                player.Last_time_played,
                "dd/MM/yyyy HH:mm",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out DateTime lastPlayed))
            {
                PlayerLastMatchDateLabel.Text = $"Última partida: {lastPlayed:dd/MM/yyyy}";
            }
            else
            {
                PlayerLastMatchDateLabel.Text = "Última partida: —";
            }

            // Avatar
            AvatarPictureBox.BackgroundImage = MainFunctions.LoadAvatar(player.AvatarId);
        }
    }
}
