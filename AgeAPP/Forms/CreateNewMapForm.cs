using AgeAPP.Classes;
using static AgeAPP.Classes.FiresharpData;
using static AgeAPP.Classes.Main_classes;

namespace AgeAPP.Forms
{
    public partial class CreateNewMapForm : Form
    {
        // Serviços
        private FiresharpData local_Data_service = new FiresharpData();

        public CreateNewMapForm(FiresharpData Data_service)
        {
            InitializeComponent();
            local_Data_service = Data_service;
        }

        private void CreateNewMapForm_Load(object sender, EventArgs e)
        {
            MapTypeComboBox.SelectedIndex = 0;
        }

        private async void CreateButton_Click(object sender, EventArgs e)
        {
            if (TextBoxMapName.Text == "" || MapTypeComboBox.SelectedIndex.ToString() == "")
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Desabilita botão
            CreateButton.Enabled = false;

            var newMap = new Map
            {
                Name = TextBoxMapName.Text,
                Matches = 0,
                Type = MapTypeComboBox.SelectedIndex,
            };

            await local_Data_service.Add_new_map(newMap);

            await local_Data_service.Post_log_on_dataBase(new Log
            {
                Author_name = local_Data_service.LocalAccount.Username,
                Role = "Map_changes",
                Date = DateTime.Now.ToString(),
                Content = $"Criou um novo mapa: {newMap.Name}."
            });

            // Fechar form
            this.Close();
        }
    }
}
