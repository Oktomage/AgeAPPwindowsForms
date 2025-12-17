using AgeAPP.Classes;
using AgeAPP.Forms;
using static AgeAPP.Classes.FiresharpData;

namespace AgeAPP
{
    public partial class FMain : Form
    {
        // Serviços
        public FiresharpData Data_service = new FiresharpData();
        private MainFunctions local_Main_functions_service = new MainFunctions();

        public FMain()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            // Cria pastas necessárias
            local_Main_functions_service.Create_Required_folders();

            // Tentar persistencia de login
            Data_service.Local_Admin_Logged = local_Main_functions_service.Load_session();

            if (Data_service.Local_Admin_Logged != null)
            {
                Admin adm = Data_service.Try_login(Data_service.Local_Admin_Logged.Name, Data_service.Local_Admin_Logged.Password);

                if (adm != null)
                    Data_service.Connect_to_firesharp("admin");
                else
                {
                    local_Main_functions_service.Delete_session();
                    Data_service.Connect_to_firesharp("user");
                }
            }
            else
                Data_service.Connect_to_firesharp("user");

            // Baixa backup
            Data_service.Download_dataBase_Backup();

            // Atualiza a tabela inicial
            UpdateDataGridViewPlayers();
        }

        private async void UpdateDataGridViewPlayers()
        {
            dataGridViewPlayers.DataSource = null;

            var players = await Data_service.GetAllPlayers();
            dataGridViewPlayers.DataSource = players;
        }

        #region BUTTONS

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
            AdminPanelForm adminForm = new AdminPanelForm(Data_service);
            adminForm.ShowDialog();
        }

        #endregion

        #region TIMERS

        private void ConnectionTimer_Tick(object sender, EventArgs e)
        {
            // Atualiza estado de login
            if (Data_service.Admin_LoggedIn)
            {
                LoginButton.Enabled = false;
                AdminPanelButton.Enabled = true;

                AdminConnectedLabel.Text = $"Conectado como: {Data_service.Local_Admin_Logged.Name}";
            }
            else
            {
                LoginButton.Enabled = true;
                AdminPanelButton.Enabled = false;

                AdminConnectedLabel.Text = "Nenhum admin conectado";
            }
        }

        private async void AutoRefresh_Tick(object sender, EventArgs e)
        {
            // Atualiza lista de jogadores
            if (AutoPlayerListRefresh.Checked)
            {
                UpdateDataGridViewPlayers();
            }
        }

        #endregion
    }
}
