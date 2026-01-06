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
            FavoriteMapListBox.DrawMode = DrawMode.OwnerDrawFixed;
            FavoriteMapListBox.ItemHeight = 50; // espaço pra imagem

            UpdateUI();
            Write_toolTips();
        }

        private void Write_toolTips()
        {
            ToolTips.SetToolTip(ConfirmButton, "Confirmar alteração.");
            ToolTips.SetToolTip(dataGridViewMaps, "Selecione os mapas que deseja atribuir ao jogador.");
            ToolTips.SetToolTip(FavoriteMapListBox, "Esses são os mapas favoritados atuais do jogador.");
            ToolTips.SetToolTip(HelpButton, "Mostra pequeno tutorial de como utilizar esta ferramenta.");
        }

        private async void UpdateUI()
        {
            dataGridViewMaps.DataSource = null;

            var maps = await local_Data_service.GetAllMaps();
            dataGridViewMaps.DataSource = maps;

            GridStyleController.ApplyTheme(dataGridViewMaps);
            GridStyleController.FixMapsHeaderNames(dataGridViewMaps);
            GridStyleController.ApplyMapTypeFormatting(dataGridViewMaps);

            // Se tiver maps favoritos, mostra na lista
            FavoriteMapListBox.Items.Clear();

            if (selectedPlayer.Favorite_maps != null && selectedPlayer.Favorite_maps.Count > 0)
            {
                foreach (FavoriteMap map in selectedPlayer.Favorite_maps.Values)
                {
                    FavoriteMapListBox.Items.Add(map);
                }
            }
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

        private async void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (selectedPlayer == null)
            {
                MessageBox.Show("Jogador inválido !", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selectedFavorite_maps = dataGridViewMaps.SelectedRows
                .Cast<DataGridViewRow>()
                .Select(r => r.DataBoundItem as Map)
                .Where(p => p != null)
                .ToList();

            selectedPlayer.Favorite_maps.Clear();

            foreach (var map in selectedFavorite_maps)
            {
                FavoriteMap new_fav_map = new FavoriteMap();
                new_fav_map.Name = map.Name;
                new_fav_map.Times_played = 0;

                selectedPlayer.Favorite_maps.Add(map.Name, new_fav_map);
            }

            await local_Data_service.Overwrite_player(selectedPlayer);

            await local_Data_service.Post_log_on_dataBase(new Log
            {
                Author_name = local_Data_service.Local_Admin_Logged.Name,
                Role = "Player_changes",
                Date = DateTime.Now.ToString(),
                Content = $"Alterou os mapas favoritdos do jogador, {selectedPlayer.Name}."
            });

            // Fecha o formulário após a criação do jogador
            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        private void HelpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Selecione os mapas que deseja aplicar ao jogador na tabela da esquerda \n\n" +
                "A lista na direita mostra os mapas atuais do jogador, se ele tiver algum !", "Ajuda", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}
