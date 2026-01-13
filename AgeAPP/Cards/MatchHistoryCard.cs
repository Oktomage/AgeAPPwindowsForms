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

            int delta = Math.Abs(CurrentResult.DeltaRating);

            // Time A
            FillListView(
                ListViewTeamA,
                CurrentResult.TeamA,
                CurrentResult.TeamAWon ? +delta : -delta
            );

            // Time B
            FillListView(
                ListViewTeamB,
                CurrentResult.TeamB,
                CurrentResult.TeamAWon ? -delta : +delta
            );

            UpdateWinnerIcons(CurrentResult.TeamAWon);

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

        private void FillListView(ListView listView, IEnumerable<Player> players, int delta)
        {
            listView.Items.Clear();
            ConfigureListView(listView);

            string deltaText = delta > 0 ? $"+{delta}" : delta.ToString();
            Color color = delta >= 0 ? Color.LimeGreen : Color.IndianRed;

            foreach (var player in players)
            {
                var item = new ListViewItem($"{player.Name} ({deltaText})")
                {
                    ForeColor = color
                };

                listView.Items.Add(item);
            }
        }

        private void UpdateWinnerIcons(bool teamAWon)
        {
            TeamAsymbolPictureBox.BackgroundImage = teamAWon ? Properties.Resources.Winner_icon : Properties.Resources.Defeat_icon;
            TeamBsymbolPictureBox.BackgroundImage = teamAWon ? Properties.Resources.Defeat_icon : Properties.Resources.Winner_icon;
        }
    }
}
