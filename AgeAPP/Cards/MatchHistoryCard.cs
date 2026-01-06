using AgeAPP.Classes;
using static AgeAPP.Classes.Main_classes;

namespace AgeAPP.Cards
{
    public partial class MatchHistoryCard : UserControl
    {
        private Main_classes.MatchResult CurrentResult;

        public MatchHistoryCard()
        {
            InitializeComponent();
        }

        public void Bind(Main_classes.Log log)
        {
            MapNameLabel.Text = log.Match_result.PlayedMap_name;
            DateLabel.Text = log.Match_result.MatchDate.ToString("dd/MM/yyyy");

            CurrentResult = log.Match_result;

            switch(CurrentResult.TeamAWon)
            {
                case true:
                    // Time A venceu
                    FillListView(ListViewWinnerTeam, CurrentResult.TeamA);
                    FillListView(ListViewLoserTeam, CurrentResult.TeamB);
                    break;

                case false:
                    // Time B venceu
                    FillListView(ListViewWinnerTeam, CurrentResult.TeamB);
                    FillListView(ListViewLoserTeam, CurrentResult.TeamA);
                    break;
            }

            int delta = log.Match_result.DeltaRating;

            DeltaRatingLabel.Text = $": {MathF.Abs(delta).ToString()}";

            //DeltaRatingLabel.Text = delta > 0 ? $"Rating: +{delta}" : $"Rating: {delta.ToString()}";
            //DeltaRatingLabel.ForeColor = delta >= 0 ? Color.LimeGreen : Color.IndianRed;
        }

        private void ConfigureListView(ListView lv)
        {
            lv.View = View.Details;
            lv.FullRowSelect = true;
            lv.MultiSelect = false;
            lv.HeaderStyle = ColumnHeaderStyle.None;
            lv.Scrollable = true;

            lv.Columns.Clear();
            lv.Columns.Add("", lv.Width - 4); // coluna única
        }

        private void FillListView(ListView listView, IEnumerable<Player> players)
        {
            listView.Items.Clear();
            ConfigureListView(listView);

            foreach (var player in players)
            {
                var item = new ListViewItem($"{player.Name} [{player.Rating}] ({CurrentResult.DeltaRating})");
                item.SubItems.Add(player.Rating.ToString());

                listView.Items.Add(item);
            }
        }
    }
}
