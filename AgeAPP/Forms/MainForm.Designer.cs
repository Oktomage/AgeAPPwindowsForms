
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMain));
            dataGridViewPlayers = new DataGridView();
            SplitButton = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            AdminConnectedLabel = new Label();
            AdminPanelButton = new Button();
            LoginButton = new Button();
            ConnectionTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dataGridViewPlayers).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            dataGridViewPlayers.Location = new Point(12, 12);
            dataGridViewPlayers.Name = "dataGridViewPlayers";
            dataGridViewPlayers.ReadOnly = true;
            dataGridViewPlayers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPlayers.Size = new Size(456, 492);
            dataGridViewPlayers.TabIndex = 0;
            // 
            // SplitButton
            // 
            SplitButton.AutoSize = true;
            SplitButton.Font = new Font("Arial", 16F);
            SplitButton.Location = new Point(22, 66);
            SplitButton.Name = "SplitButton";
            SplitButton.Size = new Size(227, 55);
            SplitButton.TabIndex = 1;
            SplitButton.Text = "Splitar times";
            SplitButton.UseVisualStyleBackColor = true;
            SplitButton.Click += SplitButton_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.Panel_bg2;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(AdminConnectedLabel);
            panel1.Controls.Add(AdminPanelButton);
            panel1.Controls.Add(LoginButton);
            panel1.Controls.Add(SplitButton);
            panel1.Location = new Point(484, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(268, 492);
            panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.seperator2;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(22, 19);
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
            AdminConnectedLabel.Location = new Point(3, 473);
            AdminConnectedLabel.Name = "AdminConnectedLabel";
            AdminConnectedLabel.Size = new Size(41, 16);
            AdminConnectedLabel.TabIndex = 4;
            AdminConnectedLabel.Text = "label1";
            // 
            // AdminPanelButton
            // 
            AdminPanelButton.AutoSize = true;
            AdminPanelButton.Enabled = false;
            AdminPanelButton.Font = new Font("Arial", 16F);
            AdminPanelButton.Location = new Point(22, 127);
            AdminPanelButton.Name = "AdminPanelButton";
            AdminPanelButton.Size = new Size(227, 55);
            AdminPanelButton.TabIndex = 2;
            AdminPanelButton.Text = "Painel de admin";
            AdminPanelButton.UseVisualStyleBackColor = true;
            AdminPanelButton.Click += AdminPanelButton_Click;
            // 
            // LoginButton
            // 
            LoginButton.AutoSize = true;
            LoginButton.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoginButton.Location = new Point(189, 461);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(76, 28);
            LoginButton.TabIndex = 3;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // ConnectionTimer
            // 
            ConnectionTimer.Enabled = true;
            ConnectionTimer.Interval = 500;
            ConnectionTimer.Tick += ConnectionTimer_Tick;
            // 
            // FMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Civ_details_bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(775, 516);
            Controls.Add(panel1);
            Controls.Add(dataGridViewPlayers);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AgeAPP - Menu";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPlayers).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
    }
}
