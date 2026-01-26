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

        private int maxItemsToShow = 10;

        public MatchesHistoryForm(FiresharpData Data_service)
        {
            InitializeComponent();

            local_Data_service = Data_service;

            // Configuração do layout
            FlowLayouPanel.Dock = DockStyle.Bottom;
            FlowLayouPanel.AutoScroll = true;
            FlowLayouPanel.WrapContents = false;
            FlowLayouPanel.FlowDirection = FlowDirection.TopDown;
            FlowLayouPanel.Padding = new Padding(10);
        }

        private async void MatchesHistoryForm_Load(object sender, EventArgs e)
        {
            ListSizeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            ListSizeComboBox.Items.Clear();
            ListSizeComboBox.Items.AddRange(new object[]
            {
                10,
                20,
                30,
                50,
                100
            });

            ListSizeComboBox.SelectedItem = 10;

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
            LoadingLabel.Visible = true;
            ListSizeComboBox.Enabled = false;

            var admins = new List<string>
            {
                "oldtime",
                "pedreiro",
                "biel",
                "gomes",
                "kakashi",
                "snow"
            };

            var logs = await local_Data_service.GetGlobalMatchHistory(admins);

            FlowLayouPanel.SuspendLayout();
            FlowLayouPanel.Controls.Clear();

            var limitedLogs = logs
                .OrderByDescending(l => l.Date)
                .Take(maxItemsToShow)
                .ToList();

            foreach (var log in limitedLogs)
            {
                var card = new MatchHistoryCard();
                card.Bind(log);
                FlowLayouPanel.Controls.Add(card);
            }

            FlowLayouPanel.ResumeLayout();

            ListSizeComboBox.Enabled = true;
            LoadingLabel.Visible = false;
        }

        private async void ListSizeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListSizeComboBox.SelectedItem is int value)
            {
                maxItemsToShow = value;

                await Load_history();
            }
        }
    }
}
