using AgeAPP.Cards;
using AgeAPP.Classes;
using System.Windows.Forms;
using static AgeAPP.Classes.FiresharpData;
using static AgeAPP.Classes.Main_classes;

namespace AgeAPP.Forms
{
    public partial class MatchesHistoryForm : Form
    {
        // Serviços
        private FiresharpData local_Data_service;

        public MatchesHistoryForm(FiresharpData Data_service)
        {
            InitializeComponent();

            local_Data_service = Data_service;

            // Configuração do layout
            FlowLayouPanel.Dock = DockStyle.Fill;
            FlowLayouPanel.AutoScroll = true;
            FlowLayouPanel.WrapContents = false;
            FlowLayouPanel.FlowDirection = FlowDirection.TopDown;
            FlowLayouPanel.Padding = new Padding(10);
        }

        private async void MatchesHistoryForm_Load(object sender, EventArgs e)
        {
            await Load_history();
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

        private async Task Load_history()
        {
            var logs = await local_Data_service.GetMatchHistory("oldtime");

            FlowLayouPanel.SuspendLayout();
            FlowLayouPanel.Controls.Clear();

            foreach (var log in logs)
            {
                var card = new MatchHistoryCard();
                card.Bind(log);
                FlowLayouPanel.Controls.Add(card);
            }

            FlowLayouPanel.ResumeLayout();
        }
    }
}
