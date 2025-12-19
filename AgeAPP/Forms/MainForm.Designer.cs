
namespace AgeAPP
{
    partial class FMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMain));
            dataGridViewPlayers = new DataGridView();
            SplitButton = new Button();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            SignOutButton = new Button();
            AdminConnectedLabel = new Label();
            MatchesButton = new Button();
            AdminPanelButton = new Button();
            LoginButton = new Button();
            ForceGridRefreshButton = new Button();
            ConnectionTimer = new System.Windows.Forms.Timer(components);
            dataGridViewMaps = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            ToggleAppThemeButton = new Button();
            ToolTips = new ToolTip(components);
            FilterPlayerTextBox = new TextBox();
            AgeAppLabel = new Label();
            HelpButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPlayers).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMaps).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewPlayers
            // 
            dataGridViewPlayers.AllowUserToAddRows = false;
            dataGridViewPlayers.AllowUserToDeleteRows = false;
            dataGridViewPlayers.AllowUserToResizeColumns = false;
            dataGridViewPlayers.AllowUserToResizeRows = false;
            dataGridViewPlayers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPlayers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dataGridViewPlayers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewPlayers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridViewPlayers.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewPlayers.Location = new Point(12, 52);
            dataGridViewPlayers.MultiSelect = false;
            dataGridViewPlayers.Name = "dataGridViewPlayers";
            dataGridViewPlayers.ReadOnly = true;
            dataGridViewPlayers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPlayers.Size = new Size(420, 492);
            dataGridViewPlayers.TabIndex = 0;
            // 
            // SplitButton
            // 
            SplitButton.AutoSize = true;
            SplitButton.BackColor = Color.Black;
            SplitButton.BackgroundImage = Properties.Resources.button_wide_normal;
            SplitButton.BackgroundImageLayout = ImageLayout.Stretch;
            SplitButton.FlatStyle = FlatStyle.Flat;
            SplitButton.Font = new Font("Arial", 14.25F);
            SplitButton.ForeColor = SystemColors.Control;
            SplitButton.Location = new Point(22, 50);
            SplitButton.Name = "SplitButton";
            SplitButton.Size = new Size(227, 45);
            SplitButton.TabIndex = 1;
            SplitButton.Text = "Divisor de times";
            SplitButton.UseVisualStyleBackColor = false;
            SplitButton.Click += SplitButton_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.news_splash;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(SignOutButton);
            panel1.Controls.Add(AdminConnectedLabel);
            panel1.Controls.Add(MatchesButton);
            panel1.Controls.Add(AdminPanelButton);
            panel1.Controls.Add(LoginButton);
            panel1.Controls.Add(SplitButton);
            panel1.Location = new Point(869, 52);
            panel1.Name = "panel1";
            panel1.Size = new Size(268, 492);
            panel1.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = Properties.Resources.seperator2;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(22, 164);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(227, 41);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.seperator2;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(22, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(227, 41);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // SignOutButton
            // 
            SignOutButton.AutoSize = true;
            SignOutButton.BackgroundImage = Properties.Resources.SignOut_icon;
            SignOutButton.BackgroundImageLayout = ImageLayout.Stretch;
            SignOutButton.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SignOutButton.Location = new Point(231, 456);
            SignOutButton.Name = "SignOutButton";
            SignOutButton.Size = new Size(30, 29);
            SignOutButton.TabIndex = 4;
            SignOutButton.UseVisualStyleBackColor = true;
            SignOutButton.Visible = false;
            // 
            // AdminConnectedLabel
            // 
            AdminConnectedLabel.AutoSize = true;
            AdminConnectedLabel.BackColor = Color.Transparent;
            AdminConnectedLabel.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AdminConnectedLabel.ForeColor = Color.White;
            AdminConnectedLabel.Location = new Point(3, 467);
            AdminConnectedLabel.Name = "AdminConnectedLabel";
            AdminConnectedLabel.Size = new Size(41, 16);
            AdminConnectedLabel.TabIndex = 4;
            AdminConnectedLabel.Text = "label1";
            AdminConnectedLabel.Click += AdminConnectedLabel_Click;
            // 
            // MatchesButton
            // 
            MatchesButton.AutoSize = true;
            MatchesButton.BackColor = Color.Transparent;
            MatchesButton.BackgroundImage = Properties.Resources.button_wide_normal;
            MatchesButton.BackgroundImageLayout = ImageLayout.Stretch;
            MatchesButton.Enabled = false;
            MatchesButton.FlatStyle = FlatStyle.Flat;
            MatchesButton.Font = new Font("Arial", 14.25F);
            MatchesButton.ForeColor = SystemColors.Control;
            MatchesButton.Location = new Point(22, 101);
            MatchesButton.Name = "MatchesButton";
            MatchesButton.Size = new Size(227, 45);
            MatchesButton.TabIndex = 2;
            MatchesButton.Text = "Histórico de partidas";
            MatchesButton.UseVisualStyleBackColor = false;
            MatchesButton.Click += AdminPanelButton_Click;
            // 
            // AdminPanelButton
            // 
            AdminPanelButton.AutoSize = true;
            AdminPanelButton.BackColor = Color.Transparent;
            AdminPanelButton.BackgroundImage = Properties.Resources.button_wide_normal;
            AdminPanelButton.BackgroundImageLayout = ImageLayout.Stretch;
            AdminPanelButton.Enabled = false;
            AdminPanelButton.FlatStyle = FlatStyle.Flat;
            AdminPanelButton.Font = new Font("Arial", 14.25F);
            AdminPanelButton.ForeColor = SystemColors.Control;
            AdminPanelButton.Location = new Point(22, 211);
            AdminPanelButton.Name = "AdminPanelButton";
            AdminPanelButton.Size = new Size(227, 45);
            AdminPanelButton.TabIndex = 3;
            AdminPanelButton.Text = "Painel de admin";
            AdminPanelButton.UseVisualStyleBackColor = false;
            AdminPanelButton.Click += AdminPanelButton_Click;
            // 
            // LoginButton
            // 
            LoginButton.AutoSize = true;
            LoginButton.BackgroundImage = Properties.Resources.button_wide_normal;
            LoginButton.BackgroundImageLayout = ImageLayout.Stretch;
            LoginButton.FlatStyle = FlatStyle.Flat;
            LoginButton.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoginButton.ForeColor = SystemColors.Control;
            LoginButton.Location = new Point(167, 450);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(94, 35);
            LoginButton.TabIndex = 4;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // ForceGridRefreshButton
            // 
            ForceGridRefreshButton.AutoSize = true;
            ForceGridRefreshButton.BackgroundImage = Properties.Resources.Refresh_icon;
            ForceGridRefreshButton.BackgroundImageLayout = ImageLayout.Stretch;
            ForceGridRefreshButton.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForceGridRefreshButton.Location = new Point(808, 1);
            ForceGridRefreshButton.Name = "ForceGridRefreshButton";
            ForceGridRefreshButton.Size = new Size(31, 29);
            ForceGridRefreshButton.TabIndex = 4;
            ForceGridRefreshButton.UseVisualStyleBackColor = true;
            ForceGridRefreshButton.Click += ForceGridRefreshButton_Click;
            // 
            // ConnectionTimer
            // 
            ConnectionTimer.Enabled = true;
            ConnectionTimer.Interval = 500;
            ConnectionTimer.Tick += ConnectionTimer_Tick;
            // 
            // dataGridViewMaps
            // 
            dataGridViewMaps.AllowUserToAddRows = false;
            dataGridViewMaps.AllowUserToDeleteRows = false;
            dataGridViewMaps.AllowUserToResizeColumns = false;
            dataGridViewMaps.AllowUserToResizeRows = false;
            dataGridViewMaps.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMaps.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dataGridViewMaps.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewMaps.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewMaps.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewMaps.Location = new Point(438, 52);
            dataGridViewMaps.MultiSelect = false;
            dataGridViewMaps.Name = "dataGridViewMaps";
            dataGridViewMaps.ReadOnly = true;
            dataGridViewMaps.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewMaps.Size = new Size(420, 492);
            dataGridViewMaps.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 15.75F);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(3, 5);
            label1.Name = "label1";
            label1.Size = new Size(127, 24);
            label1.TabIndex = 3;
            label1.Text = "| Jogadores:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 15.75F);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(424, 5);
            label2.Name = "label2";
            label2.Size = new Size(91, 24);
            label2.TabIndex = 3;
            label2.Text = "| Mapas:";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(ToggleAppThemeButton);
            panel2.Controls.Add(ForceGridRefreshButton);
            panel2.Location = new Point(12, 9);
            panel2.Name = "panel2";
            panel2.Size = new Size(846, 37);
            panel2.TabIndex = 5;
            // 
            // ToggleAppThemeButton
            // 
            ToggleAppThemeButton.AutoSize = true;
            ToggleAppThemeButton.BackgroundImage = Properties.Resources.Dark_mode_icon;
            ToggleAppThemeButton.BackgroundImageLayout = ImageLayout.Stretch;
            ToggleAppThemeButton.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ToggleAppThemeButton.Location = new Point(771, 1);
            ToggleAppThemeButton.Name = "ToggleAppThemeButton";
            ToggleAppThemeButton.Size = new Size(31, 29);
            ToggleAppThemeButton.TabIndex = 4;
            ToggleAppThemeButton.UseVisualStyleBackColor = true;
            ToggleAppThemeButton.Click += ToggleAppThemeButton_Click;
            // 
            // ToolTips
            // 
            ToolTips.AutoPopDelay = 5000;
            ToolTips.InitialDelay = 250;
            ToolTips.ReshowDelay = 100;
            // 
            // FilterPlayerTextBox
            // 
            FilterPlayerTextBox.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FilterPlayerTextBox.Location = new Point(14, 548);
            FilterPlayerTextBox.Name = "FilterPlayerTextBox";
            FilterPlayerTextBox.PlaceholderText = "Filtrar jogador ex: Kakashi";
            FilterPlayerTextBox.Size = new Size(200, 22);
            FilterPlayerTextBox.TabIndex = 6;
            FilterPlayerTextBox.TextChanged += FilterPlayerTextBox_TextChanged;
            // 
            // AgeAppLabel
            // 
            AgeAppLabel.AutoSize = true;
            AgeAppLabel.BackColor = Color.Black;
            AgeAppLabel.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AgeAppLabel.ForeColor = Color.White;
            AgeAppLabel.Location = new Point(869, 19);
            AgeAppLabel.Name = "AgeAppLabel";
            AgeAppLabel.Size = new Size(191, 27);
            AgeAppLabel.TabIndex = 4;
            AgeAppLabel.Text = "Interno App V5.3";
            // 
            // HelpButton
            // 
            HelpButton.AutoSize = true;
            HelpButton.BackgroundImage = Properties.Resources.Help_icon;
            HelpButton.BackgroundImageLayout = ImageLayout.Stretch;
            HelpButton.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HelpButton.Location = new Point(1107, 17);
            HelpButton.Name = "HelpButton";
            HelpButton.Size = new Size(30, 29);
            HelpButton.TabIndex = 4;
            HelpButton.UseVisualStyleBackColor = true;
            HelpButton.Click += HelpButton_Click;
            // 
            // FMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.mainmenu_paphos_bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1149, 577);
            Controls.Add(FilterPlayerTextBox);
            Controls.Add(panel2);
            Controls.Add(HelpButton);
            Controls.Add(AgeAppLabel);
            Controls.Add(panel1);
            Controls.Add(dataGridViewMaps);
            Controls.Add(dataGridViewPlayers);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AgeAPP - SOBERANO";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPlayers).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMaps).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewPlayers;
        private Button SplitButton;
        private Panel panel1;
        private Button LoginButton;
        private Button AdminPanelButton;
        private System.Windows.Forms.Timer ConnectionTimer;
        private Label AdminConnectedLabel;
        private PictureBox pictureBox1;
        private DataGridView dataGridViewMaps;
        private Button MatchesButton;
        private Label label1;
        private Label label2;
        private Button ForceGridRefreshButton;
        private Panel panel2;
        private ToolTip ToolTips;
        private TextBox FilterPlayerTextBox;
        private PictureBox pictureBox2;
        private Label AgeAppLabel;
        private Button HelpButton;
        private Button SignOutButton;
        private Button ToggleAppThemeButton;
    }
}
