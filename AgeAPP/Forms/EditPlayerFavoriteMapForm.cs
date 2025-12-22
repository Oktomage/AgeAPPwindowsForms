using AgeAPP.Classes;
using static AgeAPP.Classes.Main_classes;

namespace AgeAPP.Forms
{
    public partial class EditPlayerFavoriteMapForm : Form
    {
        // Serviços
        private FiresharpData local_Data_service = new FiresharpData();

        // Local data
        private Player selectedPlayer = null;

        public EditPlayerFavoriteMapForm(FiresharpData Data_service, Player player)
        {
            InitializeComponent();

            local_Data_service = Data_service;
            selectedPlayer = player;
        }

        private void EditPlayerFavoriteMapForm_Load(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private async void UpdateUI()
        {
            dataGridViewMaps.DataSource = null;

            var maps = await local_Data_service.GetAllMaps();
            dataGridViewMaps.DataSource = maps;

            GridStyleController.ApplyTheme(dataGridViewMaps);


        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (TextBoxPlayerName.Text == "" || TextBoxPlayerRating.Text == "")
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selectedFavorite_maps = dataGridViewMaps.SelectedRows
                .Cast<DataGridViewRow>()
                .Select(r => r.DataBoundItem as Map)
                .Where(p => p != null)
                .ToList();

            Player newPlayer = new Player
            {
                Id = 0, // O ID será atribuído automaticamente pelo serviço de dados
                Name = TextBoxPlayerName.Text.Trim().ToLower(),
                Rating = int.Parse(TextBoxPlayerRating.Text),
                Matches = 0,
                Wins = 0,
                WinRate = 0f,
                Favorite_maps = selectedFavorite_maps.ToDictionary(
                    map => map.Name,
                    map => new FavoriteMap
                    {
                        Name = map.Name,
                        Times_played = 0
                    })
            };

            await local_Data_service.Add_new_player(newPlayer);

            await local_Data_service.Post_log_on_dataBase(new Log
            {
                Author_name = local_Data_service.Local_Admin_Logged.Name,
                Role = "Player_changes",
                Date = DateTime.Now.ToString(),
                Content = $"Criou um novo jogador, {newPlayer.Name}."
            });

            // Fecha o formulário após a criação do jogador
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void FavoriteMapListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            e.DrawBackground();

            var listBox = (ListBox)sender;
            var item = (FavoriteMap)listBox.Items[e.Index];
            Image thumbnail = Properties.Resources.UnkownMap;

            // Área da imagem
            Rectangle imgRect = new Rectangle(
                e.Bounds.X + 5,
                e.Bounds.Y + 5,
                40,
                40
            );

            // Área do texto
            Rectangle textRect = new Rectangle(
                imgRect.Right + 10,
                e.Bounds.Y + 15,
                e.Bounds.Width - imgRect.Right - 10,
                20
            );

            // Desenha imagem
            if (thumbnail != null)
                e.Graphics.DrawImage(thumbnail, imgRect);

            // Cor do texto
            Color textColor = (e.State & DrawItemState.Selected) == DrawItemState.Selected
                ? Color.White
                : Color.Black;

            TextRenderer.DrawText(
                e.Graphics,
                item.Name,
                e.Font,
                textRect,
                textColor,
                TextFormatFlags.VerticalCenter | TextFormatFlags.Left
            );

            e.DrawFocusRectangle();
        }
    }
}
