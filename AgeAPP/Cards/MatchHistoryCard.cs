using AgeAPP.Classes;
using static AgeAPP.Classes.Main_classes;
using static AgeAPP.Classes.MainFunctions;

namespace AgeAPP.Cards
{
    public partial class MatchHistoryCard : UserControl
    {
        private Main_classes.MatchResult CurrentResult;

        public MatchHistoryCard()
        {
            InitializeComponent();

            this.BackColor = Color.FromArgb(180, 0, 0, 0);
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

            MapPictureBox.BackgroundImage = MapImageDictionary.Get(CurrentResult.PlayedMap_name);
            UpdateWinnerIcons(CurrentResult.TeamAWon);

            LogAuthorLabel.Text = $"Registro de: {log.Author_name}";

            DeltaRatingLabel.Text = $"{MathF.Abs(log.Match_result.DeltaRating)}";
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

            Color color = delta >= 0 ? Color.LimeGreen : Color.IndianRed;
            string deltaText = delta > 0 ? $"+{delta}" : delta.ToString();

            foreach (var player in players)
            {
                int ratingAfter = player.Rating;
                int ratingBefore = ratingAfter - delta;   
                
                string text = $"{player.Name} {ratingBefore} ({deltaText}) → {ratingAfter}";

                var item = new ListViewItem(text)
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
