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
            dataGridViewPlayers = new DataGridView();
            SplitButton = new Button();
            panel1 = new Panel();
            AdminPanelButton = new Button();
            LoginButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPlayers).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewPlayers
            // 
            dataGridViewPlayers.AllowUserToAddRows = false;
            dataGridViewPlayers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPlayers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPlayers.Location = new Point(12, 12);
            dataGridViewPlayers.Name = "dataGridViewPlayers";
            dataGridViewPlayers.ReadOnly = true;
            dataGridViewPlayers.Size = new Size(456, 492);
            dataGridViewPlayers.TabIndex = 0;
            // 
            // SplitButton
            // 
            SplitButton.AutoSize = true;
            SplitButton.Location = new Point(28, 81);
            SplitButton.Name = "SplitButton";
            SplitButton.Size = new Size(227, 55);
            SplitButton.TabIndex = 2;
            SplitButton.Text = "Splitar times";
            SplitButton.UseVisualStyleBackColor = true;
            SplitButton.Click += SplitButton_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(AdminPanelButton);
            panel1.Controls.Add(LoginButton);
            panel1.Controls.Add(SplitButton);
            panel1.Location = new Point(484, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(268, 237);
            panel1.TabIndex = 2;
            // 
            // AdminPanelButton
            // 
            AdminPanelButton.AutoSize = true;
            AdminPanelButton.Enabled = false;
            AdminPanelButton.Location = new Point(28, 142);
            AdminPanelButton.Name = "AdminPanelButton";
            AdminPanelButton.Size = new Size(227, 55);
            AdminPanelButton.TabIndex = 3;
            AdminPanelButton.Text = "Painel de admin";
            AdminPanelButton.UseVisualStyleBackColor = true;
            // 
            // LoginButton
            // 
            LoginButton.AutoSize = true;
            LoginButton.Location = new Point(28, 20);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(227, 55);
            LoginButton.TabIndex = 1;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // FMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(775, 516);
            Controls.Add(panel1);
            Controls.Add(dataGridViewPlayers);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPlayers).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewPlayers;
        private Button SplitButton;
        private Panel panel1;
        private Button LoginButton;
        private Button AdminPanelButton;
    }
}
