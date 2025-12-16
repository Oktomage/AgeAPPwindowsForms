using AgeAPP.Classes;
using AgeAPP.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace AgeAPP
{
    public partial class FMain : Form
    {
        // Firesharp connection
        public IFirebaseConfig config = new FirebaseConfig
        {
            BasePath = "https://internoapp-e8138-default-rtdb.firebaseio.com/",
            AuthSecret = ""
            //AuthSecret = "wG6kd0l3gfUtBDqu4g1xqXPpm4gl5tMsXTLqIl99"
        };

        public static IFirebaseClient client;

        // Serviços
        public FiresharpData Data_service = new FiresharpData();

        public FMain()
        {
            InitializeComponent();
        }

        private void Connect_to_firesharp()
        {
            client = new FireSharp.FirebaseClient(config);

            /*
            if (client != null)
                MessageBox.Show("Connection to database successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);*/
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            Connect_to_firesharp();

            var players = await Data_service.GetAllPlayers();

            dataGridViewPlayers.DataSource = players;
        }

        private void SplitButton_Click(object sender, EventArgs e)
        {
            SplitForm splitForm = new SplitForm();

            splitForm.ShowDialog();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidade em desenvolvimento.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //LoginForm loginForm = new LoginForm();
            //loginForm.ShowDialog();
        }

        private void AdminPanelButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidade em desenvolvimento.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            //AdminForm adminForm = new AdminForm();
            //adminForm.ShowDialog();
        }
    }
}
