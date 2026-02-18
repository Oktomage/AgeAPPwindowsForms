using AgeAPP.Cards;
using AgeAPP.Classes;
using System.Windows.Forms;

namespace AgeAPP.Forms
{
    public partial class AdminChangesForm : Form
    {
        private FiresharpData local_Data_service;

        private int maxItemsToShow = 10;

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

        private async Task Load_history()
        {
            LoadingLabel.Visible = true;
            ListSizeComboBox.Enabled = false;

            var logs = await local_Data_service.GetGlobalAdminLogs(local_Data_service.Admins_names, maxItemsToShow);

            FlowLayoutPanel.SuspendLayout();
            FlowLayoutPanel.Controls.Clear();

            foreach (var log in logs)
            {
                var card = new AdminChangesCard();
                card.Bind(log);

                FlowLayoutPanel.Controls.Add(card);
            }

            FlowLayoutPanel.ResumeLayout();

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
