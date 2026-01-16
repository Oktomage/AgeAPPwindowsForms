using AgeAPP.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static AgeAPP.Classes.Main_classes;

namespace AgeAPP.Cards
{
    public partial class PlayerCard : UserControl
    {
        private Color defaultBackColor;

        public PlayerCard()
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

        #region Mouse Events

        private void PlayerCard_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(48, 48, 48);
        }

        private void PlayerCard_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = defaultBackColor;
        }

        #endregion
    }
}
