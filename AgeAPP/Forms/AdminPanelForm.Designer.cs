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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanelForm));
            dataGridViewPlayers = new DataGridView();
            SelectedPlayerLabel = new Label();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            DuplicateSelectedPlayerButton = new Button();
            ChangeSelectedPlayerRating = new Button();
            SelectedPlayerRatingTextBox = new TextBox();
            DeleteSelectedPlayerButton = new Button();
            label1 = new Label();
            panel3 = new Panel();
            EditPlayerFavoriteMapsButton = new Button();
            FavoriteMapListBox = new ListBox();
            label3 = new Label();
            label2 = new Label();
            CreateNewPlayerButton = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            CreateNewMapButton = new Button();
            ApplyMatchResultButton = new Button();
            label4 = new Label();
            ToolTips = new ToolTip(components);
            FilterPlayerTextBox = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPlayers).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewPlayers
            // 
            dataGridViewPlayers.AllowUserToAddRows = false;
            dataGridViewPlayers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPlayers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dataGridViewPlayers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPlayers.Location = new Point(12, 55);
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
            SelectedPlayerLabel.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SelectedPlayerLabel.ForeColor = SystemColors.Control;
            SelectedPlayerLabel.Location = new Point(55, 17);
            SelectedPlayerLabel.Name = "SelectedPlayerLabel";
            SelectedPlayerLabel.Size = new Size(75, 27);
            SelectedPlayerLabel.TabIndex = 2;
            SelectedPlayerLabel.Text = "Nome";
            SelectedPlayerLabel.Click += SelectedPlayerLabel_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.mainmenu_paphos_bg;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(DuplicateSelectedPlayerButton);
            panel1.Controls.Add(ChangeSelectedPlayerRating);
            panel1.Controls.Add(SelectedPlayerRatingTextBox);
            panel1.Controls.Add(DeleteSelectedPlayerButton);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(SelectedPlayerLabel);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(474, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(358, 473);
            panel1.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = Properties.Resources.mvp;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(13, 17);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(37, 41);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // DuplicateSelectedPlayerButton
            // 
            DuplicateSelectedPlayerButton.BackColor = Color.Transparent;
            DuplicateSelectedPlayerButton.BackgroundImage = Properties.Resources.Duplicate_icon;
            DuplicateSelectedPlayerButton.BackgroundImageLayout = ImageLayout.Stretch;
            DuplicateSelectedPlayerButton.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DuplicateSelectedPlayerButton.Location = new Point(223, 408);
            DuplicateSelectedPlayerButton.Name = "DuplicateSelectedPlayerButton";
            DuplicateSelectedPlayerButton.Size = new Size(61, 58);
            DuplicateSelectedPlayerButton.TabIndex = 4;
            DuplicateSelectedPlayerButton.UseVisualStyleBackColor = false;
            // 
            // ChangeSelectedPlayerRating
            // 
            ChangeSelectedPlayerRating.BackgroundImage = Properties.Resources.Hand_icon2;
            ChangeSelectedPlayerRating.BackgroundImageLayout = ImageLayout.Stretch;
            ChangeSelectedPlayerRating.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ChangeSelectedPlayerRating.Location = new Point(137, 84);
            ChangeSelectedPlayerRating.Name = "ChangeSelectedPlayerRating";
            ChangeSelectedPlayerRating.Size = new Size(37, 35);
            ChangeSelectedPlayerRating.TabIndex = 4;
            ChangeSelectedPlayerRating.UseVisualStyleBackColor = true;
            ChangeSelectedPlayerRating.Click += ChangeSelectedPlayerRating_Click;
            // 
            // SelectedPlayerRatingTextBox
            // 
            SelectedPlayerRatingTextBox.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SelectedPlayerRatingTextBox.Location = new Point(12, 84);
            SelectedPlayerRatingTextBox.Name = "SelectedPlayerRatingTextBox";
            SelectedPlayerRatingTextBox.PlaceholderText = "Rating";
            SelectedPlayerRatingTextBox.Size = new Size(119, 35);
            SelectedPlayerRatingTextBox.TabIndex = 3;
            SelectedPlayerRatingTextBox.KeyPress += SelectedPlayerRatingTextBox_KeyPress;
            // 
            // DeleteSelectedPlayerButton
            // 
            DeleteSelectedPlayerButton.BackColor = Color.Transparent;
            DeleteSelectedPlayerButton.BackgroundImage = Properties.Resources.Kill_icon;
            DeleteSelectedPlayerButton.BackgroundImageLayout = ImageLayout.Stretch;
            DeleteSelectedPlayerButton.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DeleteSelectedPlayerButton.Location = new Point(290, 408);
            DeleteSelectedPlayerButton.Name = "DeleteSelectedPlayerButton";
            DeleteSelectedPlayerButton.Size = new Size(61, 58);
            DeleteSelectedPlayerButton.TabIndex = 4;
            DeleteSelectedPlayerButton.UseVisualStyleBackColor = false;
            DeleteSelectedPlayerButton.Click += DeleteSelectedPlayerButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(12, 63);
            label1.Name = "label1";
            label1.Size = new Size(53, 18);
            label1.TabIndex = 2;
            label1.Text = "Rating";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(EditPlayerFavoriteMapsButton);
            panel3.Controls.Add(FavoriteMapListBox);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(3, 137);
            panel3.Name = "panel3";
            panel3.Size = new Size(348, 265);
            panel3.TabIndex = 6;
            // 
            // EditPlayerFavoriteMapsButton
            // 
            EditPlayerFavoriteMapsButton.Anchor = AnchorStyles.Top;
            EditPlayerFavoriteMapsButton.BackColor = Color.Transparent;
            EditPlayerFavoriteMapsButton.BackgroundImage = Properties.Resources.button_wide_normal;
            EditPlayerFavoriteMapsButton.BackgroundImageLayout = ImageLayout.Stretch;
            EditPlayerFavoriteMapsButton.FlatStyle = FlatStyle.Flat;
            EditPlayerFavoriteMapsButton.Font = new Font("Arial", 12F);
            EditPlayerFavoriteMapsButton.ForeColor = SystemColors.Control;
            EditPlayerFavoriteMapsButton.Location = new Point(9, 203);
            EditPlayerFavoriteMapsButton.Name = "EditPlayerFavoriteMapsButton";
            EditPlayerFavoriteMapsButton.Size = new Size(134, 39);
            EditPlayerFavoriteMapsButton.TabIndex = 4;
            EditPlayerFavoriteMapsButton.Text = "Editar";
            EditPlayerFavoriteMapsButton.UseVisualStyleBackColor = false;
            EditPlayerFavoriteMapsButton.Click += EditPlayerFavoriteMapsButton_Click;
            // 
            // FavoriteMapListBox
            // 
            FavoriteMapListBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FavoriteMapListBox.FormattingEnabled = true;
            FavoriteMapListBox.Location = new Point(9, 31);
            FavoriteMapListBox.Name = "FavoriteMapListBox";
            FavoriteMapListBox.Size = new Size(273, 166);
            FavoriteMapListBox.TabIndex = 5;
            FavoriteMapListBox.DrawItem += FavoriteMapListBox_DrawItem;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(9, 7);
            label3.Name = "label3";
            label3.Size = new Size(119, 18);
            label3.TabIndex = 2;
            label3.Text = "Mapas favoritos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(474, 17);
            label2.Name = "label2";
            label2.Size = new Size(224, 32);
            label2.TabIndex = 2;
            label2.Text = "Painel do jogador";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CreateNewPlayerButton
            // 
            CreateNewPlayerButton.Anchor = AnchorStyles.Top;
            CreateNewPlayerButton.BackColor = Color.Transparent;
            CreateNewPlayerButton.BackgroundImage = Properties.Resources.button_wide_normal;
            CreateNewPlayerButton.BackgroundImageLayout = ImageLayout.Stretch;
            CreateNewPlayerButton.FlatStyle = FlatStyle.Flat;
            CreateNewPlayerButton.Font = new Font("Arial", 12F);
            CreateNewPlayerButton.ForeColor = SystemColors.Control;
            CreateNewPlayerButton.Location = new Point(3, 109);
            CreateNewPlayerButton.Name = "CreateNewPlayerButton";
            CreateNewPlayerButton.Size = new Size(255, 53);
            CreateNewPlayerButton.TabIndex = 4;
            CreateNewPlayerButton.Text = "Registrar novo jogador";
            CreateNewPlayerButton.UseVisualStyleBackColor = false;
            CreateNewPlayerButton.Click += CreateNewPlayerButton_Click;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.aoe2_de_uhd_2;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(CreateNewMapButton);
            panel2.Controls.Add(CreateNewPlayerButton);
            panel2.Controls.Add(ApplyMatchResultButton);
            panel2.Location = new Point(851, 55);
            panel2.Name = "panel2";
            panel2.Size = new Size(265, 230);
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
            // CreateNewMapButton
            // 
            CreateNewMapButton.Anchor = AnchorStyles.Top;
            CreateNewMapButton.BackColor = Color.Transparent;
            CreateNewMapButton.BackgroundImage = Properties.Resources.button_wide_normal;
            CreateNewMapButton.BackgroundImageLayout = ImageLayout.Stretch;
            CreateNewMapButton.FlatStyle = FlatStyle.Flat;
            CreateNewMapButton.Font = new Font("Arial", 12F);
            CreateNewMapButton.ForeColor = SystemColors.Control;
            CreateNewMapButton.Location = new Point(3, 168);
            CreateNewMapButton.Name = "CreateNewMapButton";
            CreateNewMapButton.Size = new Size(255, 53);
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
            ApplyMatchResultButton.Font = new Font("Arial", 12F);
            ApplyMatchResultButton.ForeColor = SystemColors.Control;
            ApplyMatchResultButton.Location = new Point(3, 50);
            ApplyMatchResultButton.Name = "ApplyMatchResultButton";
            ApplyMatchResultButton.Size = new Size(255, 53);
            ApplyMatchResultButton.TabIndex = 4;
            ApplyMatchResultButton.Text = "Aplicar resultado de partida";
            ApplyMatchResultButton.UseVisualStyleBackColor = false;
            ApplyMatchResultButton.Click += ApplyMatchResultButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Black;
            label4.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(851, 17);
            label4.Name = "label4";
            label4.Size = new Size(231, 32);
            label4.TabIndex = 2;
            label4.Text = "Painel de controle";
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
            FilterPlayerTextBox.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FilterPlayerTextBox.Location = new Point(12, 534);
            FilterPlayerTextBox.Name = "FilterPlayerTextBox";
            FilterPlayerTextBox.PlaceholderText = "Filtrar jogador ex: Kakashi";
            FilterPlayerTextBox.Size = new Size(200, 22);
            FilterPlayerTextBox.TabIndex = 7;
            FilterPlayerTextBox.TextChanged += FilterPlayerTextBox_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Black;
            label5.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(12, 20);
            label5.Name = "label5";
            label5.Size = new Size(237, 32);
            label5.TabIndex = 2;
            label5.Text = "Lista de jogadores";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AdminPanelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.admin_bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1125, 565);
            Controls.Add(FilterPlayerTextBox);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dataGridViewPlayers);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label2);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Label label5;
        private Panel panel3;
        private PictureBox pictureBox2;
        private Button EditPlayerFavoriteMapsButton;
    }
}