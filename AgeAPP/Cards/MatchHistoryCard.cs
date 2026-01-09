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
            DateLabel.Text = log.Match_result.MatchDate.ToString("dd/MM/yyyy HH:mm");

            CurrentResult = log.Match_result;

            switch(CurrentResult.TeamAWon)
            {
                case true:
                    // Time A venceu
                    FillListView(ListViewWinnerTeam, CurrentResult.TeamA, true);
                    FillListView(ListViewLoserTeam, CurrentResult.TeamB, false);
                    break;

                case false:
                    // Time B venceu
                    FillListView(ListViewWinnerTeam, CurrentResult.TeamB, true);
                    FillListView(ListViewLoserTeam, CurrentResult.TeamA, false);
                    break;
            }

            int delta = log.Match_result.DeltaRating;

            DeltaRatingLabel.Text = $": {MathF.Abs(delta).ToString()}";

            LogAuthorLabel.Text = $"Registro de: {log.Author_name}";
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

        private void FillListView(ListView listView, IEnumerable<Player> players, bool winnerTeam = false)
        {
            listView.Items.Clear();
            ConfigureListView(listView);

            string ratingChangeSyntax = winnerTeam ? "+" : "-";

            foreach (var player in players)
            {
                var item = new ListViewItem($"{player.Name} {player.Rating} ({ratingChangeSyntax}{MathF.Abs(CurrentResult.DeltaRating)})");
                item.SubItems.Add(player.Rating.ToString());

                listView.Items.Add(item);
            }
        }
    }
}
