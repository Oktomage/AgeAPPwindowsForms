using AgeAPP.Classes;
using static AgeAPP.Classes.FiresharpData;
using static AgeAPP.Classes.Main_classes;

namespace AgeAPP.Forms
{
    public partial class AdminPanelForm : Form
    {
        // Serviços
        private FiresharpData local_Data_service = new FiresharpData();

        // Local data
        private Player selectedPlayer = null;
        private List<Player> allPlayers = new List<Player>();

        public AdminPanelForm(FiresharpData data_service)
        {
            InitializeComponent();
            local_Data_service = data_service;
        }

        private async void AdminPanelForm_Load(object sender, EventArgs e)
        {
            // Atualiza a tabela inicial
            await UpdateLocalData();

            FavoriteMapListBox.DrawMode = DrawMode.OwnerDrawFixed;
            FavoriteMapListBox.ItemHeight = 50; // espaço pra imagem

            Write_toolTips();
        }

        private void Write_toolTips()
        {
            ToolTips.SetToolTip(DeleteSelectedPlayerButton, "Deleta o jogador selecionado permanentemente do banco de dados.");
            ToolTips.SetToolTip(ChangeSelectedPlayerRating, "Aplica a mudança de rating para o jogador selecionado.");
            ToolTips.SetToolTip(EditPlayerFavoriteMapsButton, "Abre a janela para editar os mapas favoritos do jogador selecionado.");
            ToolTips.SetToolTip(DuplicateSelectedPlayerButton, "Cria uma cópia do jogador selecionado.");
            ToolTips.SetToolTip(ApplyMatchResultButton, "Abre a janela para aplicar o resultado de uma partida entre dois times.");
            ToolTips.SetToolTip(CreateNewPlayerButton, "Abre a janela para criar um novo jogador.");
            ToolTips.SetToolTip(CreateNewMapButton, "Abre a janela para criar um novo mapa.");
            ToolTips.SetToolTip(AdminChangesButton, "Abre o histórico de mudanças feitas pelos admins.");
        }

        private async Task UpdateLocalData()
        {
            // Get updated data
            allPlayers = await local_Data_service.GetAllPlayers();

            UpdateDataGridViewPlayers();
        }

        private void UpdateDataGridViewPlayers()
        {
            dataGridViewPlayers.DataSource = null;
            dataGridViewPlayers.DataSource = allPlayers;

            GridStyleController.FixPlayersHeaderNames(dataGridViewPlayers);
            GridStyleController.ApplyWinRateColoring(dataGridViewPlayers);

            GridStyleController.ApplyTheme(dataGridViewPlayers);
        }

        private void dataGridViewPlayers_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewPlayers.SelectedRows.Count == 0)
                return;

            selectedPlayer = dataGridViewPlayers.SelectedRows[0].DataBoundItem as Player;

            // Mostra dados do jogador no painel
            if (selectedPlayer != null)
            {
                SelectedPlayerLabel.Text = $"{selectedPlayer.Name} - [{selectedPlayer.Rating}]";
                SelectedPlayerRatingTextBox.Text = selectedPlayer.Rating.ToString();
                AvatarPictureBox.BackgroundImage = MainFunctions.LoadAvatar(selectedPlayer.AvatarId);

                // Se tiver maps favoritos, mostra na lista
                FavoriteMapListBox.Items.Clear();

                if (selectedPlayer.Favorite_maps != null && selectedPlayer.Favorite_maps.Count > 0)
                {
                    foreach (FavoriteMap map in selectedPlayer.Favorite_maps.Values)
                    {
                        //FavoriteMapListBox.Items.Add($"{map.Name} - Jogado {map.Times_played} vezes");

                        FavoriteMapListBox.Items.Add(map);
                    }
                }
            }
        }

        #region PANEL BUTTONS

        private void ApplyMatchResultButton_Click(object sender, EventArgs e)
        {
            ApplyMatchResultForm match_result_form = new ApplyMatchResultForm(local_Data_service, null);

            match_result_form.ShowDialog(this);
        }

        private async void CreateNewPlayerButton_Click(object sender, EventArgs e)
        {
            CreateNewPlayerForm creationForm = new CreateNewPlayerForm(local_Data_service);

            if (creationForm.ShowDialog(this) == DialogResult.OK)
            {
                await UpdateLocalData();
            }
        }

        private async void CreateNewMapButton_Click(object sender, EventArgs e)
        {
            CreateNewMapForm creationForm = new CreateNewMapForm(local_Data_service);

            if (creationForm.ShowDialog(this) == DialogResult.OK)
            {
                await UpdateLocalData();
            }
        }

        private void AdminChangesButton_Click(object sender, EventArgs e)
        {
            AdminChangesForm adminChangesForm = new AdminChangesForm(local_Data_service);

            adminChangesForm.ShowDialog(this);
        }

        #endregion

        #region PLAYER PANEL BUTTONS

        private async void AvatarPictureBox_Click(object sender, EventArgs e)
        {
            using (EditPlayerAvatarForm editForm = new EditPlayerAvatarForm(local_Data_service, selectedPlayer))
            {
                editForm.ShowDialog(this);
            }

            await UpdateLocalData();
        }

        private void SelectedPlayerRatingTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite apenas números e teclas de controle (Backspace, Delete)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private async void ChangeSelectedPlayerRating_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show($"Tem certeza que deseja mudar o rating do jogador {selectedPlayer.Name} ? \nEssa ação não pode ser desfeita.", "Confirmar mudança", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return;

            await local_Data_service.Overwrite_playerData(selectedPlayer, "Rating", int.Parse(SelectedPlayerRatingTextBox.Text));
            await local_Data_service.Post_log_on_dataBase(new Log
            {
                Author_name = local_Data_service.Local_Admin_Logged.Name,
                Role = "Player_changes",
                Date = DateTime.Now.ToString(),
                Content = $"Alterou o rating do jogador {selectedPlayer.Name} para {SelectedPlayerRatingTextBox.Text}"
            });

            await UpdateLocalData();
        }

        private async void DeleteSelectedPlayerButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show($"Tem certeza que deseja excluir o jogador {selectedPlayer.Name} ? \nEssa ação não pode ser desfeita.", "Confirmar exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return;

            // Deleta o jogador
            await local_Data_service.Delete_player(selectedPlayer);
            await local_Data_service.Post_log_on_dataBase(new Log
            {
                Author_name = local_Data_service.Local_Admin_Logged.Name,
                Role = "Player_changes",
                Date = DateTime.Now.ToString(),
                Content = $"Deletou o jogador: {selectedPlayer.Name}"
            });

            await UpdateLocalData();
        }

        private void SelectedPlayerLabel_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Você está olhando o jogador: {selectedPlayer.Name}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private async void EditPlayerFavoriteMapsButton_Click(object sender, EventArgs e)
        {
            EditPlayerFavoriteMapForm edit_player_maps_form = new EditPlayerFavoriteMapForm(local_Data_service, selectedPlayer);

            if (edit_player_maps_form.ShowDialog(this) == DialogResult.OK)
            {
                await UpdateLocalData();
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
