namespace AgeAPP.Forms
{
    partial class AdminPanelForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanelForm));
            dataGridViewPlayers = new DataGridView();
            SelectedPlayerLabel = new Label();
            panel1 = new Panel();
            panel5 = new Panel();
            DuplicateSelectedPlayerButton = new Button();
            DeleteSelectedPlayerButton = new Button();
            AvatarPictureBox = new PictureBox();
            label5 = new Label();
            ChangeSelectedPlayerRating = new Button();
            SelectedPlayerRatingTextBox = new TextBox();
            label1 = new Label();
            panel3 = new Panel();
            EditPlayerFavoriteMapsButton = new Button();
            FavoriteMapListBox = new ListBox();
            label3 = new Label();
            label2 = new Label();
            CreateNewPlayerButton = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            AdminChangesButton = new Button();
            CreateNewMapButton = new Button();
            ApplyMatchResultButton = new Button();
            label4 = new Label();
            ToolTips = new ToolTip(components);
            FilterPlayerTextBox = new TextBox();
            panel4 = new Panel();
            MenuSelectionComboBox = new ComboBox();
            PlayersPanelControl = new Panel();
            MapsPanelControl = new Panel();
            panel6 = new Panel();
            dataGridViewMaps = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPlayers).BeginInit();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AvatarPictureBox).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            PlayersPanelControl.SuspendLayout();
            MapsPanelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMaps).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewPlayers
            // 
            dataGridViewPlayers.AllowUserToAddRows = false;
            dataGridViewPlayers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPlayers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dataGridViewPlayers.BackgroundColor = Color.Black;
            dataGridViewPlayers.BorderStyle = BorderStyle.None;
            dataGridViewPlayers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPlayers.Location = new Point(3, 3);
            dataGridViewPlayers.MultiSelect = false;
            dataGridViewPlayers.Name = "dataGridViewPlayers";
            dataGridViewPlayers.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewPlayers.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewPlayers.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewPlayers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPlayers.Size = new Size(456, 473);
            dataGridViewPlayers.TabIndex = 1;
            dataGridViewPlayers.SelectionChanged += dataGridViewPlayers_SelectionChanged;
            // 
            // SelectedPlayerLabel
            // 
            SelectedPlayerLabel.AutoSize = true;
            SelectedPlayerLabel.BackColor = Color.Black;
            SelectedPlayerLabel.Cursor = Cursors.Hand;
            SelectedPlayerLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SelectedPlayerLabel.ForeColor = SystemColors.Control;
            SelectedPlayerLabel.Location = new Point(72, 12);
            SelectedPlayerLabel.Name = "SelectedPlayerLabel";
            SelectedPlayerLabel.Size = new Size(80, 32);
            SelectedPlayerLabel.TabIndex = 2;
            SelectedPlayerLabel.Text = "Nome";
            SelectedPlayerLabel.Click += SelectedPlayerLabel_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(AvatarPictureBox);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(ChangeSelectedPlayerRating);
            panel1.Controls.Add(SelectedPlayerRatingTextBox);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(SelectedPlayerLabel);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(465, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(371, 473);
            panel1.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Transparent;
            panel5.Controls.Add(DuplicateSelectedPlayerButton);
            panel5.Controls.Add(DeleteSelectedPlayerButton);
            panel5.Location = new Point(3, 400);
            panel5.Name = "panel5";
            panel5.Size = new Size(365, 66);
            panel5.TabIndex = 8;
            // 
            // DuplicateSelectedPlayerButton
            // 
            DuplicateSelectedPlayerButton.BackColor = Color.Transparent;
            DuplicateSelectedPlayerButton.BackgroundImage = Properties.Resources.Duplicate_icon;
            DuplicateSelectedPlayerButton.BackgroundImageLayout = ImageLayout.Stretch;
            DuplicateSelectedPlayerButton.Cursor = Cursors.Hand;
            DuplicateSelectedPlayerButton.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DuplicateSelectedPlayerButton.Location = new Point(9, 5);
            DuplicateSelectedPlayerButton.Name = "DuplicateSelectedPlayerButton";
            DuplicateSelectedPlayerButton.Size = new Size(61, 58);
            DuplicateSelectedPlayerButton.TabIndex = 4;
            DuplicateSelectedPlayerButton.UseVisualStyleBackColor = false;
            // 
            // DeleteSelectedPlayerButton
            // 
            DeleteSelectedPlayerButton.BackColor = Color.Transparent;
            DeleteSelectedPlayerButton.BackgroundImage = Properties.Resources.Kill_icon;
            DeleteSelectedPlayerButton.BackgroundImageLayout = ImageLayout.Stretch;
            DeleteSelectedPlayerButton.Cursor = Cursors.Hand;
            DeleteSelectedPlayerButton.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DeleteSelectedPlayerButton.Location = new Point(301, 5);
            DeleteSelectedPlayerButton.Name = "DeleteSelectedPlayerButton";
            DeleteSelectedPlayerButton.Size = new Size(61, 58);
            DeleteSelectedPlayerButton.TabIndex = 4;
            DeleteSelectedPlayerButton.UseVisualStyleBackColor = false;
            DeleteSelectedPlayerButton.Click += DeleteSelectedPlayerButton_Click;
            // 
            // AvatarPictureBox
            // 
            AvatarPictureBox.BackColor = Color.Transparent;
            AvatarPictureBox.BackgroundImage = Properties.Resources.Player_icon1;
            AvatarPictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            AvatarPictureBox.Cursor = Cursors.Hand;
            AvatarPictureBox.Location = new Point(12, 12);
            AvatarPictureBox.Name = "AvatarPictureBox";
            AvatarPictureBox.Size = new Size(52, 56);
            AvatarPictureBox.TabIndex = 7;
            AvatarPictureBox.TabStop = false;
            AvatarPictureBox.Click += AvatarPictureBox_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Black;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(7, 376);
            label5.Name = "label5";
            label5.Size = new Size(88, 21);
            label5.TabIndex = 2;
            label5.Text = "Comandos:";
            // 
            // ChangeSelectedPlayerRating
            // 
            ChangeSelectedPlayerRating.BackgroundImage = Properties.Resources.Hand_icon2;
            ChangeSelectedPlayerRating.BackgroundImageLayout = ImageLayout.Stretch;
            ChangeSelectedPlayerRating.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ChangeSelectedPlayerRating.Location = new Point(137, 97);
            ChangeSelectedPlayerRating.Name = "ChangeSelectedPlayerRating";
            ChangeSelectedPlayerRating.Size = new Size(39, 39);
            ChangeSelectedPlayerRating.TabIndex = 4;
            ChangeSelectedPlayerRating.UseVisualStyleBackColor = true;
            ChangeSelectedPlayerRating.Click += ChangeSelectedPlayerRating_Click;
            // 
            // SelectedPlayerRatingTextBox
            // 
            SelectedPlayerRatingTextBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SelectedPlayerRatingTextBox.Location = new Point(12, 97);
            SelectedPlayerRatingTextBox.Name = "SelectedPlayerRatingTextBox";
            SelectedPlayerRatingTextBox.PlaceholderText = "Rating";
            SelectedPlayerRatingTextBox.Size = new Size(119, 39);
            SelectedPlayerRatingTextBox.TabIndex = 3;
            SelectedPlayerRatingTextBox.KeyPress += SelectedPlayerRatingTextBox_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(12, 73);
            label1.Name = "label1";
            label1.Size = new Size(58, 21);
            label1.TabIndex = 2;
            label1.Text = "Rating:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(EditPlayerFavoriteMapsButton);
            panel3.Controls.Add(FavoriteMapListBox);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(3, 152);
            panel3.Name = "panel3";
            panel3.Size = new Size(365, 211);
            panel3.TabIndex = 6;
            // 
            // EditPlayerFavoriteMapsButton
            // 
            EditPlayerFavoriteMapsButton.Anchor = AnchorStyles.Top;
            EditPlayerFavoriteMapsButton.BackColor = Color.Transparent;
            EditPlayerFavoriteMapsButton.BackgroundImage = Properties.Resources.button_wide_normal;
            EditPlayerFavoriteMapsButton.BackgroundImageLayout = ImageLayout.Stretch;
            EditPlayerFavoriteMapsButton.FlatStyle = FlatStyle.Flat;
            EditPlayerFavoriteMapsButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EditPlayerFavoriteMapsButton.ForeColor = SystemColors.Control;
            EditPlayerFavoriteMapsButton.Location = new Point(9, 160);
            EditPlayerFavoriteMapsButton.Name = "EditPlayerFavoriteMapsButton";
            EditPlayerFavoriteMapsButton.Size = new Size(134, 39);
            EditPlayerFavoriteMapsButton.TabIndex = 4;
            EditPlayerFavoriteMapsButton.Text = "Editar";
            EditPlayerFavoriteMapsButton.UseVisualStyleBackColor = false;
            EditPlayerFavoriteMapsButton.Click += EditPlayerFavoriteMapsButton_Click;
            // 
            // FavoriteMapListBox
            // 
            FavoriteMapListBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FavoriteMapListBox.FormattingEnabled = true;
            FavoriteMapListBox.Location = new Point(8, 24);
            FavoriteMapListBox.Name = "FavoriteMapListBox";
            FavoriteMapListBox.Size = new Size(273, 130);
            FavoriteMapListBox.TabIndex = 5;
            FavoriteMapListBox.DrawItem += FavoriteMapListBox_DrawItem;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(9, 0);
            label3.Name = "label3";
            label3.Size = new Size(124, 21);
            label3.TabIndex = 2;
            label3.Text = "Mapas favoritos:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Segoe UI", 20.25F);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(3, 5);
            label2.Name = "label2";
            label2.Size = new Size(107, 37);
            label2.TabIndex = 2;
            label2.Text = "| Painel:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CreateNewPlayerButton
            // 
            CreateNewPlayerButton.Anchor = AnchorStyles.Top;
            CreateNewPlayerButton.BackColor = Color.Transparent;
            CreateNewPlayerButton.BackgroundImage = Properties.Resources.button_wide_normal;
            CreateNewPlayerButton.BackgroundImageLayout = ImageLayout.Stretch;
            CreateNewPlayerButton.FlatStyle = FlatStyle.Flat;
            CreateNewPlayerButton.Font = new Font("Segoe UI", 12F);
            CreateNewPlayerButton.ForeColor = SystemColors.Control;
            CreateNewPlayerButton.Location = new Point(3, 107);
            CreateNewPlayerButton.Name = "CreateNewPlayerButton";
            CreateNewPlayerButton.Size = new Size(255, 54);
            CreateNewPlayerButton.TabIndex = 4;
            CreateNewPlayerButton.Text = "Registrar novo jogador";
            CreateNewPlayerButton.UseVisualStyleBackColor = false;
            CreateNewPlayerButton.Click += CreateNewPlayerButton_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(AdminChangesButton);
            panel2.Controls.Add(CreateNewMapButton);
            panel2.Controls.Add(CreateNewPlayerButton);
            panel2.Controls.Add(ApplyMatchResultButton);
            panel2.Location = new Point(851, 56);
            panel2.Name = "panel2";
            panel2.Size = new Size(265, 473);
            panel2.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.seperator2;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(252, 41);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // AdminChangesButton
            // 
            AdminChangesButton.Anchor = AnchorStyles.Top;
            AdminChangesButton.BackColor = Color.Transparent;
            AdminChangesButton.BackgroundImage = Properties.Resources.button_wide_normal;
            AdminChangesButton.BackgroundImageLayout = ImageLayout.Stretch;
            AdminChangesButton.FlatStyle = FlatStyle.Flat;
            AdminChangesButton.Font = new Font("Segoe UI", 12F);
            AdminChangesButton.ForeColor = SystemColors.Control;
            AdminChangesButton.Location = new Point(3, 227);
            AdminChangesButton.Name = "AdminChangesButton";
            AdminChangesButton.Size = new Size(255, 54);
            AdminChangesButton.TabIndex = 4;
            AdminChangesButton.Text = "Histórico dos admins";
            AdminChangesButton.UseVisualStyleBackColor = false;
            AdminChangesButton.Click += AdminChangesButton_Click;
            // 
            // CreateNewMapButton
            // 
            CreateNewMapButton.Anchor = AnchorStyles.Top;
            CreateNewMapButton.BackColor = Color.Transparent;
            CreateNewMapButton.BackgroundImage = Properties.Resources.button_wide_normal;
            CreateNewMapButton.BackgroundImageLayout = ImageLayout.Stretch;
            CreateNewMapButton.FlatStyle = FlatStyle.Flat;
            CreateNewMapButton.Font = new Font("Segoe UI", 12F);
            CreateNewMapButton.ForeColor = SystemColors.Control;
            CreateNewMapButton.Location = new Point(3, 167);
            CreateNewMapButton.Name = "CreateNewMapButton";
            CreateNewMapButton.Size = new Size(255, 54);
            CreateNewMapButton.TabIndex = 4;
            CreateNewMapButton.Text = "Registrar novo mapa";
            CreateNewMapButton.UseVisualStyleBackColor = false;
            CreateNewMapButton.Click += CreateNewMapButton_Click;
            // 
            // ApplyMatchResultButton
            // 
            ApplyMatchResultButton.Anchor = AnchorStyles.Top;
            ApplyMatchResultButton.BackColor = Color.Transparent;
            ApplyMatchResultButton.BackgroundImage = Properties.Resources.button_wide_normal;
            ApplyMatchResultButton.BackgroundImageLayout = ImageLayout.Stretch;
            ApplyMatchResultButton.FlatStyle = FlatStyle.Flat;
            ApplyMatchResultButton.Font = new Font("Segoe UI", 12F);
            ApplyMatchResultButton.ForeColor = SystemColors.Control;
            ApplyMatchResultButton.Location = new Point(3, 47);
            ApplyMatchResultButton.Name = "ApplyMatchResultButton";
            ApplyMatchResultButton.Size = new Size(255, 54);
            ApplyMatchResultButton.TabIndex = 4;
            ApplyMatchResultButton.Text = "Aplicar resultado de partida";
            ApplyMatchResultButton.UseVisualStyleBackColor = false;
            ApplyMatchResultButton.Click += ApplyMatchResultButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Black;
            label4.Font = new Font("Segoe UI", 20.25F);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(851, 5);
            label4.Name = "label4";
            label4.Size = new Size(249, 37);
            label4.TabIndex = 2;
            label4.Text = "| Painel de controle:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ToolTips
            // 
            ToolTips.AutoPopDelay = 5000;
            ToolTips.InitialDelay = 300;
            ToolTips.ReshowDelay = 100;
            // 
            // FilterPlayerTextBox
            // 
            FilterPlayerTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FilterPlayerTextBox.Location = new Point(3, 482);
            FilterPlayerTextBox.Name = "FilterPlayerTextBox";
            FilterPlayerTextBox.PlaceholderText = "Filtrar jogador ex: Kakashi";
            FilterPlayerTextBox.Size = new Size(200, 25);
            FilterPlayerTextBox.TabIndex = 7;
            FilterPlayerTextBox.TextChanged += FilterPlayerTextBox_TextChanged;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Controls.Add(MenuSelectionComboBox);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(label4);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1123, 49);
            panel4.TabIndex = 8;
            // 
            // MenuSelectionComboBox
            // 
            MenuSelectionComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            MenuSelectionComboBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MenuSelectionComboBox.FormattingEnabled = true;
            MenuSelectionComboBox.Items.AddRange(new object[] { "Jogadores", "Mapas" });
            MenuSelectionComboBox.Location = new Point(116, 12);
            MenuSelectionComboBox.Name = "MenuSelectionComboBox";
            MenuSelectionComboBox.Size = new Size(135, 29);
            MenuSelectionComboBox.TabIndex = 6;
            MenuSelectionComboBox.SelectedIndexChanged += MenuSelectionComboBox_SelectedIndexChanged;
            // 
            // PlayersPanelControl
            // 
            PlayersPanelControl.BackColor = Color.Transparent;
            PlayersPanelControl.Controls.Add(dataGridViewPlayers);
            PlayersPanelControl.Controls.Add(panel1);
            PlayersPanelControl.Controls.Add(FilterPlayerTextBox);
            PlayersPanelControl.Location = new Point(9, 53);
            PlayersPanelControl.Name = "PlayersPanelControl";
            PlayersPanelControl.Size = new Size(836, 516);
            PlayersPanelControl.TabIndex = 9;
            // 
            // MapsPanelControl
            // 
            MapsPanelControl.BackColor = Color.Transparent;
            MapsPanelControl.Controls.Add(panel6);
            MapsPanelControl.Controls.Add(dataGridViewMaps);
            MapsPanelControl.Location = new Point(9, 53);
            MapsPanelControl.Name = "MapsPanelControl";
            MapsPanelControl.Size = new Size(836, 516);
            MapsPanelControl.TabIndex = 8;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Black;
            panel6.Location = new Point(465, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(374, 477);
            panel6.TabIndex = 3;
            // 
            // dataGridViewMaps
            // 
            dataGridViewMaps.AllowUserToAddRows = false;
            dataGridViewMaps.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMaps.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dataGridViewMaps.BackgroundColor = Color.Black;
            dataGridViewMaps.BorderStyle = BorderStyle.None;
            dataGridViewMaps.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMaps.Location = new Point(3, 3);
            dataGridViewMaps.MultiSelect = false;
            dataGridViewMaps.Name = "dataGridViewMaps";
            dataGridViewMaps.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewMaps.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewMaps.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewMaps.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewMaps.Size = new Size(456, 476);
            dataGridViewMaps.TabIndex = 2;
            // 
            // AdminPanelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.admin_bg;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1123, 574);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(MapsPanelControl);
            Controls.Add(PlayersPanelControl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "AdminPanelForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Painel de administrador";
            Load += AdminPanelForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPlayers).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)AvatarPictureBox).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            PlayersPanelControl.ResumeLayout(false);
            PlayersPanelControl.PerformLayout();
            MapsPanelControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewMaps).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewPlayers;
        private Label SelectedPlayerLabel;
        private Panel panel1;
        private TextBox SelectedPlayerRatingTextBox;
        private Label label1;
        private Button ChangeSelectedPlayerRating;
        private Button DeleteSelectedPlayerButton;
        private Label label2;
        private Button CreateNewPlayerButton;
        private Panel panel2;
        private Button ApplyMatchResultButton;
        private Label label3;
        private Button CreateNewMapButton;
        private ListBox FavoriteMapListBox;
        private PictureBox pictureBox1;
        private Label label4;
        private ToolTip ToolTips;
        private TextBox FilterPlayerTextBox;
        private Button DuplicateSelectedPlayerButton;
        private Panel panel3;
        private PictureBox AvatarPictureBox;
        private Button EditPlayerFavoriteMapsButton;
        private Button AdminChangesButton;
        private Panel panel4;
        private Panel PlayersPanelControl;
        private Panel panel5;
        private Label label5;
        private ComboBox MenuSelectionComboBox;
        private Panel MapsPanelControl;
        private DataGridView dataGridViewMaps;
        private Panel panel6;
    }
}