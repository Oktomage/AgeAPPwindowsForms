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
        private Main_classes local_Main_classes = new Main_classes();

        // Local data
        private List<Player> allPlayers = new List<Player>();

        public FMain()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            // Cria pastas necessárias
            local_Main_functions_service.Create_Required_folders();

            AgeAppLabel.Text = "Interno app v" + local_Main_classes.App_Version;

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
            await UpdateLocalData();
            UpdateDataGridViewPlayers();
            UpdateDataGridViewMaps();

            // Escreve tooltips
            Write_toolTips();

            // Verifica atualizações
            bool has_updates = await Data_service.Check_for_updates();

            if(has_updates)
                MessageBox.Show("Existe uma atualização obrigatória do aplicativo pendente !", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Write_toolTips()
        {
            ToolTips.SetToolTip(ForceGridRefreshButton, "Força a atualização das tabelas de jogadores e mapas.");
            ToolTips.SetToolTip(SplitButton, "Abre a janela de divisão de times.");
            ToolTips.SetToolTip(MatchesButton, "Abre a janela de histórico de partidas.");
            ToolTips.SetToolTip(AdminPanelButton, "Abre o painel de administração (requer login).");
            ToolTips.SetToolTip(LoginButton, "Abre a janela de login de administradores.");
            ToolTips.SetToolTip(AdminConnectedLabel, "Mostra o admin conectado atualmente.");
            ToolTips.SetToolTip(FilterPlayerTextBox, "Filtra a lista de jogadores pelo nome.");
            ToolTips.SetToolTip(HelpButton, "Mostra um breve tutorial do aplicativo.");
        }

        private async Task UpdateLocalData()
        {
            // Get updated data
            allPlayers = await Data_service.GetAllPlayers();
        }

        private void UpdateDataGridViewPlayers()
        {
            dataGridViewPlayers.DataSource = null;
            dataGridViewPlayers.DataSource = allPlayers;
        }

        private async void UpdateDataGridViewMaps()
        {
            dataGridViewMaps.DataSource = null;

            var maps = await Data_service.GetAllMaps();
            dataGridViewMaps.DataSource = maps;
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

        private async void AdminPanelButton_Click(object sender, EventArgs e)
        {
            // Verifica atualizações
            bool has_updates = await Data_service.Check_for_updates();

            if (has_updates)
            {
                MessageBox.Show("Existe uma atualização obrigatória do aplicativo pendente !", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            AdminPanelForm adminForm = new AdminPanelForm(Data_service);
            adminForm.ShowDialog();
        }

        private async void ForceGridRefreshButton_Click(object sender, EventArgs e)
        {
            await UpdateLocalData();

            UpdateDataGridViewPlayers();
            UpdateDataGridViewMaps();
        }

        private void AdminConnectedLabel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Informações sobre o admin conectado atualmente.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        #region TIMERS

        private void ConnectionTimer_Tick(object sender, EventArgs e)
        {
            // Atualiza estado de login
            if (Data_service.Admin_LoggedIn)
            {
                LoginButton.Enabled = false;
                LoginButton.Visible = false;
                AdminPanelButton.Enabled = true;

                AdminConnectedLabel.Text = $"Conectado como: {Data_service.Local_Admin_Logged.Name}";
            }
            else
            {
                LoginButton.Enabled = true;
                LoginButton.Visible = true;
                AdminPanelButton.Enabled = false;

                AdminConnectedLabel.Text = "Nenhum admin conectado";
            }
        }

        #endregion

        #region TEXT BOXES
        private void FilterPlayerTextBox_TextChanged(object sender, EventArgs e)
        {
            string search = FilterPlayerTextBox.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(search))
            {
                dataGridViewPlayers.DataSource = allPlayers;
            }
            else
            {
                dataGridViewPlayers.DataSource = allPlayers
                    .Where(p => p.Name.ToLower().Contains(search))
                    .ToList();
            }
        }

        #endregion
    }
}
