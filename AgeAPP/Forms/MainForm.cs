using AgeAPP.Cards;
using AgeAPP.Classes;
using AgeAPP.Forms;
using System.Globalization;
using System.Windows.Forms;
using static AgeAPP.Classes.FiresharpData;
using static AgeAPP.Classes.Main_classes;

namespace AgeAPP
{
    public partial class FMain : Form
    {
        // Serviços
        public static FiresharpData Data_service = new FiresharpData();
        public static AgeApp_settings AgeApp_settings_service = new AgeApp_settings();
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

            AgeAppLabel.Text = "Interno app v" + Local_app_Version;

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

            // Pega settings do app direto do banco
            AgeApp_settings_service.Get_settings();

            // Baixa backup
            Data_service.Download_dataBase_Backup();

            // Atualiza a tabela inicial
            await UpdateLocalData();

            GridStyleController.ApplyTheme(dataGridViewMaps);

            // Escreve tooltips
            Write_toolTips();

            // Verifica atualizações
            bool has_updates = local_Main_functions_service.Check_for_updates();

            if (has_updates)
                MessageBox.Show("Existe uma atualização obrigatória do aplicativo pendente !", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Write_toolTips()
        {
            ToolTips.SetToolTip(ForceGridRefreshButton, "Força a atualização das tabelas de jogadores e mapas.");
            ToolTips.SetToolTip(ToggleAppThemeButton, "Alterna entre tema claro e escuro.");
            ToolTips.SetToolTip(SplitButton, "Abre a janela de divisão de times.");
            ToolTips.SetToolTip(MatchesButton, "Abre a janela de histórico de partidas.");
            ToolTips.SetToolTip(AdminPanelButton, "Abre o painel de administração (requer login).");
            ToolTips.SetToolTip(LoginButton, "Abre a janela de login de administradores.");
            ToolTips.SetToolTip(AdminConnectedLabel, "Mostra o admin conectado atualmente.");
            ToolTips.SetToolTip(SettingsButton, "Abre o menu de configurações do app.");
            ToolTips.SetToolTip(FilterPlayerTextBox, "Filtra a lista de jogadores pelo nome.");
            ToolTips.SetToolTip(HelpButton, "Mostra um breve tutorial do aplicativo.");
            ToolTips.SetToolTip(SignOutButton, "Desconecta o admin atualmente conectado.");
        }

        private async Task UpdateLocalData()
        {
            // Get updated data
            allPlayers = await Data_service.GetAllPlayers();

            UpdateDataGridViewMaps();
            UpdatePlayersFlow();
        }

        private List<Player> GetActivePlayers()
        {
            DateTime limitDate = DateTime.Now.AddDays(-30);

            List<Player> activePlayers = allPlayers
                                    .Where(p =>
                                        !string.IsNullOrWhiteSpace(p.Last_time_played) &&
                                        DateTime.TryParseExact(
                                            p.Last_time_played,
                                            "dd/MM/yyyy HH:mm",
                                            CultureInfo.InvariantCulture,
                                            DateTimeStyles.None,
                                            out DateTime lastPlayed
                                        ) &&
                                        lastPlayed.Date >= limitDate
                                    )
                                    .ToList();

            return activePlayers;
        }

        private void UpdatePlayersFlow()
        {
            FlowLayoutPlayers.AutoScroll = true;
            FlowLayoutPlayers.WrapContents = false;
            FlowLayoutPlayers.FlowDirection = FlowDirection.TopDown;

            FlowLayoutPlayers.SuspendLayout();
            FlowLayoutPlayers.Controls.Clear();

            IEnumerable<Player> source = Show_only_active_players ? GetActivePlayers() : allPlayers;

            foreach (var player in source)
            {
                var card = new PlayerCard();
                card.Bind(player);

                // Fix Width
                card.Width = FlowLayoutPlayers.ClientSize.Width - 25;

                FlowLayoutPlayers.Controls.Add(card);
            }

            FlowLayoutPlayers.ResumeLayout();
        }


        private async void UpdateDataGridViewMaps()
        {
            dataGridViewMaps.DataSource = null;

            var maps = await Data_service.GetAllMaps();
            dataGridViewMaps.DataSource = maps;

            GridStyleController.FixMapsHeaderNames(dataGridViewMaps);
            GridStyleController.ApplyMapTypeFormatting(dataGridViewMaps);
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
            // Verifica atualizações
            bool has_updates = local_Main_functions_service.Check_for_updates();

            if (has_updates)
            {
                MessageBox.Show("Existe uma atualização obrigatória do aplicativo pendente !", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            AdminPanelForm adminForm = new AdminPanelForm(Data_service);
            adminForm.ShowDialog();
        }

        private void MatchesButton_Click(object sender, EventArgs e)
        {
            MatchesHistoryForm historyForm = new MatchesHistoryForm(Data_service);
            historyForm.ShowDialog();
        }

        private async void ForceGridRefreshButton_Click(object sender, EventArgs e)
        {
            await UpdateLocalData();
        }

        private void ToggleAppThemeButton_Click(object sender, EventArgs e)
        {
            // Alterna tema das grids
            GridStyleController.ToggleTheme();

            GridStyleController.ApplyTheme(dataGridViewMaps);
        }

        private void AdminConnectedLabel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Informações sobre o admin conectado atualmente.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bem-vindo ao AgeAPP! [Feito por: Pedro_win]\n\n" +
                "1. Dividir Times: Use o botão 'Dividir Times' para criar equipes balanceadas com base no rating dos jogadores.\n\n" +
                "2. Histórico de Partidas: Acesse o histórico completo de partidas para analisar desempenhos anteriores.\n\n" +
                "3. Painel de Administração: Faça login como administrador para gerenciar jogadores, mapas e visualizar logs de atividades.\n\n" +
                "4. Filtragem de Jogadores: Utilize a caixa de filtro para encontrar rapidamente jogadores pelo nome.\n\n" +
                "5. Atualizações: Mantenha o aplicativo atualizado para garantir acesso às últimas funcionalidades e melhorias.",
                "Ajuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                SignOutButton.Visible = true;
                AdminPanelButton.Enabled = true;

                AdminConnectedLabel.Text = $"Conectado como: {Data_service.Local_Admin_Logged.Name}";
            }
            else
            {
                LoginButton.Enabled = true;
                LoginButton.Visible = true;
                SignOutButton.Visible = false;
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
                //dataGridViewPlayers.DataSource = allPlayers;
            }
            else
            {
                //dataGridViewPlayers.DataSource = allPlayers
                    //.Where(p => p.Name.ToLower().Contains(search))
                    //.ToList();
            }
        }

        #endregion

        #region CHECK BOXES

        private async void ShowOnlyActivePlayersCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Show_only_active_players = ShowOnlyActivePlayersCheckBox.Checked;

            await UpdateLocalData();
        }

        #endregion
    }
}
