using AgeAPP.Classes;

namespace AgeAPP.Cards
{
    public partial class MatchHistoryCard : UserControl
    {
        public MatchHistoryCard()
        {
            InitializeComponent();
        }

        public void Bind(Main_classes.Log log)
        {
            MapNameLabel.Text = log.Match_result.PlayedMap_name;
            DateLabel.Text = log.Match_result.MatchDate.ToString("dd/MM/yyyy HH:mm");

            TeamWonLabel.Text = log.Match_result.TeamAWon
                ? "Time A venceu"
                : "Time B venceu";

            int delta = log.Match_result.DeltaRating;

            DeltaRatingLabel.Text = $"Alterção no rating: {MathF.Abs(delta).ToString()}";

            //DeltaRatingLabel.Text = delta > 0 ? $"Rating: +{delta}" : $"Rating: {delta.ToString()}";
            //DeltaRatingLabel.ForeColor = delta >= 0 ? Color.LimeGreen : Color.IndianRed;
        }
    }
}
