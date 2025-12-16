using AgeAPP.Classes;
using static AgeAPP.Classes.FiresharpData;

namespace AgeAPP.Forms
{
    public partial class LoginForm : Form
    {
        // Serviços
        public FiresharpData local_data_service = new FiresharpData();

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
            // Testar login
            string user = TextBoxLoginName.Text.Trim();
            string pass = TextBoxPassword.Text;

            Admin admin = local_data_service.Admins.FirstOrDefault(a =>
                a.Name.Equals(user, StringComparison.OrdinalIgnoreCase) &&
                a.Password == pass
            );

            if (admin != null)
            {
                local_data_service.Admin_Logged = admin;
                local_data_service.Connect_to_firesharp("admin");

                //MessageBox.Show($"Bem-vindo, {admin.Name}!");

                // Fechar login form
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos.");
            }
        }
    }
}
