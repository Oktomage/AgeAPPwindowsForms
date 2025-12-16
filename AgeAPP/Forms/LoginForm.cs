using AgeAPP.Classes;
using static AgeAPP.Classes.FiresharpData;

namespace AgeAPP.Forms
{
    public partial class LoginForm : Form
    {
        // Serviços
        private FiresharpData local_data_service = new FiresharpData();
        private MainFunctions local_main_functions_service = new MainFunctions();

        public LoginForm(FiresharpData Data_service)
        {
            InitializeComponent();
            local_data_service = Data_service;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            string user = TextBoxLoginName.Text.Trim();
            string pass = TextBoxPassword.Text;

            // Tentar logar
            Admin admin = local_data_service.Try_login(user, pass);

            if (admin != null)
            {
                // LogIn
                local_data_service.Local_Admin_Logged = admin;

                local_data_service.Connect_to_firesharp("admin");

                // Savar sessão
                local_main_functions_service.Save_session(admin);

                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
