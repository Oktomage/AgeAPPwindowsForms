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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanelForm));
            dataGridViewPlayers = new DataGridView();
            SelectedPlayerLabel = new Label();
            panel1 = new Panel();
            FavoriteMapListBox = new ListBox();
            DeleteSelectedPlayerButton = new Button();
            ChangeSelectedPlayerRating = new Button();
            SelectedPlayerRatingTextBox = new TextBox();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            CreateNewPlayerButton = new Button();
            panel2 = new Panel();
            button1 = new Button();
            ApplyMatchResultButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPlayers).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewPlayers
            // 
            dataGridViewPlayers.AllowUserToAddRows = false;
            dataGridViewPlayers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPlayers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dataGridViewPlayers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPlayers.Location = new Point(12, 10);
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
            dataGridViewPlayers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPlayers.Size = new Size(456, 471);
            dataGridViewPlayers.TabIndex = 1;
            dataGridViewPlayers.SelectionChanged += dataGridViewPlayers_SelectionChanged;
            // 
            // SelectedPlayerLabel
            // 
            SelectedPlayerLabel.AutoSize = true;
            SelectedPlayerLabel.BackColor = SystemColors.Control;
            SelectedPlayerLabel.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SelectedPlayerLabel.ForeColor = SystemColors.ControlText;
            SelectedPlayerLabel.Location = new Point(12, 10);
            SelectedPlayerLabel.Name = "SelectedPlayerLabel";
            SelectedPlayerLabel.Size = new Size(77, 27);
            SelectedPlayerLabel.TabIndex = 2;
            SelectedPlayerLabel.Text = "label1";
            SelectedPlayerLabel.Click += SelectedPlayerLabel_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.news_splash;
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(FavoriteMapListBox);
            panel1.Controls.Add(DeleteSelectedPlayerButton);
            panel1.Controls.Add(ChangeSelectedPlayerRating);
            panel1.Controls.Add(SelectedPlayerRatingTextBox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(SelectedPlayerLabel);
            panel1.Location = new Point(474, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(358, 426);
            panel1.TabIndex = 3;
            // 
            // FavoriteMapListBox
            // 
            FavoriteMapListBox.FormattingEnabled = true;
            FavoriteMapListBox.Location = new Point(11, 158);
            FavoriteMapListBox.Name = "FavoriteMapListBox";
            FavoriteMapListBox.Size = new Size(223, 139);
            FavoriteMapListBox.TabIndex = 5;
            // 
            // DeleteSelectedPlayerButton
            // 
            DeleteSelectedPlayerButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            DeleteSelectedPlayerButton.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DeleteSelectedPlayerButton.Location = new Point(220, 384);
            DeleteSelectedPlayerButton.Name = "DeleteSelectedPlayerButton";
            DeleteSelectedPlayerButton.Size = new Size(131, 35);
            DeleteSelectedPlayerButton.TabIndex = 4;
            DeleteSelectedPlayerButton.Text = "Deletar jogador";
            DeleteSelectedPlayerButton.UseVisualStyleBackColor = true;
            DeleteSelectedPlayerButton.Click += DeleteSelectedPlayerButton_Click;
            // 
            // ChangeSelectedPlayerRating
            // 
            ChangeSelectedPlayerRating.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ChangeSelectedPlayerRating.Location = new Point(170, 84);
            ChangeSelectedPlayerRating.Name = "ChangeSelectedPlayerRating";
            ChangeSelectedPlayerRating.Size = new Size(64, 35);
            ChangeSelectedPlayerRating.TabIndex = 4;
            ChangeSelectedPlayerRating.Text = "Mudar";
            ChangeSelectedPlayerRating.UseVisualStyleBackColor = true;
            ChangeSelectedPlayerRating.Click += ChangeSelectedPlayerRating_Click;
            // 
            // SelectedPlayerRatingTextBox
            // 
            SelectedPlayerRatingTextBox.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SelectedPlayerRatingTextBox.Location = new Point(12, 84);
            SelectedPlayerRatingTextBox.Name = "SelectedPlayerRatingTextBox";
            SelectedPlayerRatingTextBox.PlaceholderText = "Rating";
            SelectedPlayerRatingTextBox.Size = new Size(152, 35);
            SelectedPlayerRatingTextBox.TabIndex = 3;
            SelectedPlayerRatingTextBox.KeyPress += SelectedPlayerRatingTextBox_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 137);
            label3.Name = "label3";
            label3.Size = new Size(119, 18);
            label3.TabIndex = 2;
            label3.Text = "Mapas favoritos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 63);
            label1.Name = "label1";
            label1.Size = new Size(53, 18);
            label1.TabIndex = 2;
            label1.Text = "Rating";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
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
            CreateNewPlayerButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CreateNewPlayerButton.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CreateNewPlayerButton.Location = new Point(18, 87);
            CreateNewPlayerButton.Name = "CreateNewPlayerButton";
            CreateNewPlayerButton.Size = new Size(247, 73);
            CreateNewPlayerButton.TabIndex = 4;
            CreateNewPlayerButton.Text = "Registrar novo jogador";
            CreateNewPlayerButton.UseVisualStyleBackColor = true;
            CreateNewPlayerButton.Click += CreateNewPlayerButton_Click;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.Panel_bg2;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(CreateNewPlayerButton);
            panel2.Controls.Add(ApplyMatchResultButton);
            panel2.Location = new Point(851, 55);
            panel2.Name = "panel2";
            panel2.Size = new Size(282, 426);
            panel2.TabIndex = 5;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(18, 166);
            button1.Name = "button1";
            button1.Size = new Size(247, 73);
            button1.TabIndex = 4;
            button1.Text = "Registrar novo mapa";
            button1.UseVisualStyleBackColor = true;
            button1.Click += ApplyMatchResultButton_Click;
            // 
            // ApplyMatchResultButton
            // 
            ApplyMatchResultButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ApplyMatchResultButton.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ApplyMatchResultButton.Location = new Point(18, 8);
            ApplyMatchResultButton.Name = "ApplyMatchResultButton";
            ApplyMatchResultButton.Size = new Size(247, 73);
            ApplyMatchResultButton.TabIndex = 4;
            ApplyMatchResultButton.Text = "Aplicar resultado de partida";
            ApplyMatchResultButton.UseVisualStyleBackColor = true;
            ApplyMatchResultButton.Click += ApplyMatchResultButton_Click;
            // 
            // AdminPanelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.admin_bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1150, 493);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dataGridViewPlayers);
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
            panel2.ResumeLayout(false);
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
        private Button button1;
        private ListBox FavoriteMapListBox;
    }
}