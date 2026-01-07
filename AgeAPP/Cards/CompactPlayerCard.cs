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

            /*
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
            */

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
