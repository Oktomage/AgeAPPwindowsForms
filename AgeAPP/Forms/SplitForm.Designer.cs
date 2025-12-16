namespace AgeAPP.Forms
{
    partial class SplitForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplitForm));
            ConfirmSplitTeamsButton = new Button();
            dataGridViewPlayers = new DataGridView();
            panel1 = new Panel();
            TextBoxTeam1 = new TextBox();
            TextBoxTeam2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPlayers).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // ConfirmSplitTeamsButton
            // 
            ConfirmSplitTeamsButton.Font = new Font("Arial", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ConfirmSplitTeamsButton.Location = new Point(22, 13);
            ConfirmSplitTeamsButton.Name = "ConfirmSplitTeamsButton";
            ConfirmSplitTeamsButton.Size = new Size(228, 48);
            ConfirmSplitTeamsButton.TabIndex = 0;
            ConfirmSplitTeamsButton.Text = "Splitar";
            ConfirmSplitTeamsButton.UseVisualStyleBackColor = true;
            ConfirmSplitTeamsButton.Click += ConfirmSplitTeamsButton_Click;
            // 
            // dataGridViewPlayers
            // 
            dataGridViewPlayers.AllowUserToAddRows = false;
            dataGridViewPlayers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPlayers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dataGridViewPlayers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPlayers.Location = new Point(12, 12);
            dataGridViewPlayers.Name = "dataGridViewPlayers";
            dataGridViewPlayers.ReadOnly = true;
            dataGridViewPlayers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPlayers.Size = new Size(456, 426);
            dataGridViewPlayers.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.Panel_bg2;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(ConfirmSplitTeamsButton);
            panel1.Location = new Point(483, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(268, 237);
            panel1.TabIndex = 3;
            // 
            // TextBoxTeam1
            // 
            TextBoxTeam1.Font = new Font("Arial", 16F);
            TextBoxTeam1.Location = new Point(483, 267);
            TextBoxTeam1.Name = "TextBoxTeam1";
            TextBoxTeam1.ReadOnly = true;
            TextBoxTeam1.Size = new Size(268, 32);
            TextBoxTeam1.TabIndex = 6;
            TextBoxTeam1.Text = "Time 1";
            // 
            // TextBoxTeam2
            // 
            TextBoxTeam2.Font = new Font("Arial", 16F);
            TextBoxTeam2.Location = new Point(483, 309);
            TextBoxTeam2.Name = "TextBoxTeam2";
            TextBoxTeam2.ReadOnly = true;
            TextBoxTeam2.Size = new Size(268, 32);
            TextBoxTeam2.TabIndex = 7;
            TextBoxTeam2.Text = "Time 2";
            // 
            // SplitForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.mainmenu_paphos_bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(765, 450);
            Controls.Add(TextBoxTeam2);
            Controls.Add(TextBoxTeam1);
            Controls.Add(panel1);
            Controls.Add(dataGridViewPlayers);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "SplitForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Split de times";
            Load += SplitForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPlayers).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ConfirmSplitTeamsButton;
        private DataGridView dataGridViewPlayers;
        private Panel panel1;
        private TextBox TextBoxTeam1;
        private TextBox TextBoxTeam2;
    }
}