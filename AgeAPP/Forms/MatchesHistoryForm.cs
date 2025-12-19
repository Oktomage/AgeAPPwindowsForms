using static AgeAPP.Classes.FiresharpData;
using static AgeAPP.Classes.Main_classes;

namespace AgeAPP.Forms
{
    public partial class MatchesHistoryForm : Form
    {
        public MatchesHistoryForm()
        {
            InitializeComponent();

            // Configuração do layout
            FlowLayouPanel.FlowDirection = FlowDirection.TopDown;
            FlowLayouPanel.WrapContents = false;
            FlowLayouPanel.AutoScroll = true;
        }

        private void MatchesHistoryForm_Load(object sender, EventArgs e)
        {
            LoadMatchHistory();
        }

        public class MatchHistory
        {
            public string MatchId { get; set; }
            public DateTime MatchDate { get; set; }

            // Mapa
            public string MapName { get; set; }
            public string MapImagePath { get; set; }

            // Resultado
            public bool TeamAWon { get; set; }
            public int DeltaRating { get; set; }

            // Times
            public List<Player> TeamA { get; set; } = new();
            public List<Player> TeamB { get; set; } = new();
        }

        private List<MatchHistory> GetMatchHistory()
        {
            return new List<MatchHistory>
    {
        new MatchHistory
        {
            MapName = "Arabia",
            MatchDate = DateTime.Now,
            DeltaRating = +32,
            MapImagePath = @"Maps\arabia.png"
        },
        new MatchHistory
        {
            MapName = "Arena",
            MatchDate = DateTime.Now.AddDays(-1),
            DeltaRating = -18,
            MapImagePath = @"Maps\arena.png"
        }
    };
        }

        private void LoadMatchHistory()
        {
            FlowLayouPanel.Controls.Clear();

            List<MatchHistory> history = GetMatchHistory();

            /*
            foreach (var match in history)
            {
                var card = new MatchHistoryCard(match);
                flowLayoutPanelHistory.Controls.Add(card);
            }*/
        }
    }
}
