using AgeAPP.Classes;
using AgeAPP.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace AgeAPP
{
    public partial class FMain : Form
    {
        // Serviços
        public FiresharpData Data_service = new FiresharpData();

        public FMain()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            Data_service.Connect_to_firesharp("user");

            var players = await Data_service.GetAllPlayers();
            dataGridViewPlayers.DataSource = players;
        }

        private void SplitButton_Click(object sender, EventArgs e)
        {
            SplitForm splitForm = new SplitForm(Data_service);

            splitForm.ShowDialog();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm(Data_service);

            loginForm.ShowDialog();
        }

        private void AdminPanelButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidade em desenvolvimento.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //AdminForm adminForm = new AdminForm();
            //adminForm.ShowDialog();
        }

        private void ConnectionTimer_Tick(object sender, EventArgs e)
        {
            if (Data_service.Admin_LoggedIn)
            {
                LoginButton.Enabled = false;
                AdminPanelButton.Enabled = true;
            }
            else
            {
                LoginButton.Enabled = true;
                AdminPanelButton.Enabled = false;
            }
        }
    }
}
