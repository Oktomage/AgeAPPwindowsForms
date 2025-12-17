
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
            dataGridViewPlayers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPlayers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dataGridViewPlayers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewPlayers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridViewPlayers.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewPlayers.Location = new Point(12, 33);
            dataGridViewPlayers.Name = "dataGridViewPlayers";
            dataGridViewPlayers.ReadOnly = true;
            dataGridViewPlayers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPlayers.Size = new Size(420, 492);
            dataGridViewPlayers.TabIndex = 0;
            // 
            // SplitButton
            // 
            SplitButton.AutoSize = true;
            SplitButton.Font = new Font("Arial", 14.25F);
            SplitButton.Location = new Point(22, 50);
            SplitButton.Name = "SplitButton";
            SplitButton.Size = new Size(227, 45);
            SplitButton.TabIndex = 1;
            SplitButton.Text = "Divisor de times";
            SplitButton.UseVisualStyleBackColor = true;
            SplitButton.Click += SplitButton_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.Panel_bg2;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(AdminConnectedLabel);
            panel1.Controls.Add(MatchesButton);
            panel1.Controls.Add(AdminPanelButton);
            panel1.Controls.Add(LoginButton);
            panel1.Controls.Add(SplitButton);
            panel1.Location = new Point(869, 33);
            panel1.Name = "panel1";
            panel1.Size = new Size(268, 492);
            panel1.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = Properties.Resources.seperator_grey;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(22, 168);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(227, 16);
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
            // AdminConnectedLabel
            // 
            AdminConnectedLabel.AutoSize = true;
            AdminConnectedLabel.BackColor = Color.Transparent;
            AdminConnectedLabel.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AdminConnectedLabel.ForeColor = Color.Lime;
            AdminConnectedLabel.Location = new Point(3, 467);
            AdminConnectedLabel.Name = "AdminConnectedLabel";
            AdminConnectedLabel.Size = new Size(41, 16);
            AdminConnectedLabel.TabIndex = 4;
            AdminConnectedLabel.Text = "label1";
            // 
            // MatchesButton
            // 
            MatchesButton.AutoSize = true;
            MatchesButton.Enabled = false;
            MatchesButton.Font = new Font("Arial", 14.25F);
            MatchesButton.Location = new Point(22, 101);
            MatchesButton.Name = "MatchesButton";
            MatchesButton.Size = new Size(227, 45);
            MatchesButton.TabIndex = 2;
            MatchesButton.Text = "Histórico de partidas";
            MatchesButton.UseVisualStyleBackColor = true;
            MatchesButton.Click += AdminPanelButton_Click;
            // 
            // AdminPanelButton
            // 
            AdminPanelButton.AutoSize = true;
            AdminPanelButton.Enabled = false;
            AdminPanelButton.Font = new Font("Arial", 14.25F);
            AdminPanelButton.Location = new Point(22, 190);
            AdminPanelButton.Name = "AdminPanelButton";
            AdminPanelButton.Size = new Size(227, 45);
            AdminPanelButton.TabIndex = 3;
            AdminPanelButton.Text = "Painel de admin";
            AdminPanelButton.UseVisualStyleBackColor = true;
            AdminPanelButton.Click += AdminPanelButton_Click;
            // 
            // LoginButton
            // 
            LoginButton.AutoSize = true;
            LoginButton.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoginButton.Location = new Point(185, 457);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(76, 28);
            LoginButton.TabIndex = 4;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // ForceGridRefreshButton
            // 
            ForceGridRefreshButton.AutoSize = true;
            ForceGridRefreshButton.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForceGridRefreshButton.Location = new Point(746, 1);
            ForceGridRefreshButton.Name = "ForceGridRefreshButton";
            ForceGridRefreshButton.Size = new Size(93, 24);
            ForceGridRefreshButton.TabIndex = 4;
            ForceGridRefreshButton.Text = "Forçar atualizar";
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
            dataGridViewMaps.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMaps.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dataGridViewMaps.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewMaps.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewMaps.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewMaps.Location = new Point(438, 33);
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
            label1.ForeColor = Color.Black;
            label1.Location = new Point(0, 1);
            label1.Name = "label1";
            label1.Size = new Size(115, 24);
            label1.TabIndex = 3;
            label1.Text = "Jogadores:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 15.75F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(424, 1);
            label2.Name = "label2";
            label2.Size = new Size(79, 24);
            label2.TabIndex = 3;
            label2.Text = "Mapas:";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(ForceGridRefreshButton);
            panel2.Location = new Point(12, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(846, 28);
            panel2.TabIndex = 5;
            // 
            // FMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Civ_details_bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1149, 537);
            Controls.Add(panel2);
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
        private PictureBox pictureBox2;
    }
}
