using AgeAPP.Cards;
using AgeAPP.Classes;
using System.Windows.Forms;

namespace AgeAPP.Forms
{
    public partial class AdminChangesForm : Form
    {
        private FiresharpData local_Data_service;

        public AdminChangesForm(FiresharpData Data_service)
        {
            InitializeComponent();

            local_Data_service = Data_service;

            // Configuração do layout
            FlowLayoutPanel.AutoScroll = true;
            FlowLayoutPanel.WrapContents = false;
            FlowLayoutPanel.FlowDirection = FlowDirection.TopDown;
        }

        private async void AdminChangesForm_Load(object sender, EventArgs e)
        {
            await Load_history();
        }

        private async Task Load_history()
        {
            var admins = new List<string>
            {
                "oldtime",
                "pedreiro",
                "biel",
                "gomes",
                "kakashi",
                "snow"
            };

            var logs = await local_Data_service.GetGlobalAdminLogs(admins);

            FlowLayoutPanel.SuspendLayout();
            FlowLayoutPanel.Controls.Clear();

            foreach (var log in logs)
            {
                var card = new AdminChangesCard();
                card.Bind(log);

                FlowLayoutPanel.Controls.Add(card);
            }

            FlowLayoutPanel.ResumeLayout();
        }
    }
}
