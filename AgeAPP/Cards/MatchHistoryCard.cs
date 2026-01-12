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

            var deltas = CurrentResult.RatingChangesPerPlayer;

            if (CurrentResult.TeamAWon)
            {
                FillListView(ListViewWinnerTeam, CurrentResult.TeamA, deltas);
                FillListView(ListViewLoserTeam, CurrentResult.TeamB, deltas);
            }
            else
            {
                FillListView(ListViewWinnerTeam, CurrentResult.TeamB, deltas);
                FillListView(ListViewLoserTeam, CurrentResult.TeamA, deltas);
            }

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

        private void FillListView(ListView listView, IEnumerable<Player> players, Dictionary<string, int> ratingChanges)
        {
            listView.Items.Clear();
            ConfigureListView(listView);

            foreach (var player in players)
            {
                int delta = 0;

                if (ratingChanges != null &&
                    ratingChanges.TryGetValue(player.Name, out int value))
                {
                    delta = value;
                }

                string deltaText = delta > 0 ? $"+{delta}" : delta.ToString();

                var item = new ListViewItem($"{player.Name} ({deltaText})");
                item.ForeColor = delta >= 0 ? Color.LimeGreen : Color.IndianRed;

                listView.Items.Add(item);
            }
        }
    }
}
