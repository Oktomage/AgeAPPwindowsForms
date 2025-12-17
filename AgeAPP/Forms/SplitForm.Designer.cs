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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplitForm));
            ConfirmSplitTeamsButton = new Button();
            dataGridViewPlayers = new DataGridView();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            TextBoxTeam1 = new TextBox();
            TextBoxTeam2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            TextBoxMap = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPlayers).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ConfirmSplitTeamsButton
            // 
            ConfirmSplitTeamsButton.Font = new Font("Arial", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ConfirmSplitTeamsButton.Location = new Point(21, 55);
            ConfirmSplitTeamsButton.Name = "ConfirmSplitTeamsButton";
            ConfirmSplitTeamsButton.Size = new Size(228, 48);
            ConfirmSplitTeamsButton.TabIndex = 0;
            ConfirmSplitTeamsButton.Text = "Dividir times";
            ConfirmSplitTeamsButton.UseVisualStyleBackColor = true;
            ConfirmSplitTeamsButton.Click += ConfirmSplitTeamsButton_Click;
            // 
            // dataGridViewPlayers
            // 
            dataGridViewPlayers.AllowUserToAddRows = false;
            dataGridViewPlayers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPlayers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
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
            dataGridViewPlayers.Size = new Size(456, 426);
            dataGridViewPlayers.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.Panel_bg2;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(ConfirmSplitTeamsButton);
            panel1.Location = new Point(483, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(268, 237);
            panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.seperator2;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(22, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(227, 41);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(3, 188);
            label1.Name = "label1";
            label1.Size = new Size(217, 36);
            label1.TabIndex = 1;
            label1.Text = "Segure CTRL, e selecione os \r\njogadores da sala";
            // 
            // TextBoxTeam1
            // 
            TextBoxTeam1.Font = new Font("Arial", 16F);
            TextBoxTeam1.Location = new Point(483, 282);
            TextBoxTeam1.Name = "TextBoxTeam1";
            TextBoxTeam1.PlaceholderText = "Time A";
            TextBoxTeam1.ReadOnly = true;
            TextBoxTeam1.Size = new Size(268, 32);
            TextBoxTeam1.TabIndex = 6;
            // 
            // TextBoxTeam2
            // 
            TextBoxTeam2.Font = new Font("Arial", 16F);
            TextBoxTeam2.Location = new Point(483, 335);
            TextBoxTeam2.Name = "TextBoxTeam2";
            TextBoxTeam2.PlaceholderText = "Time B";
            TextBoxTeam2.ReadOnly = true;
            TextBoxTeam2.Size = new Size(268, 32);
            TextBoxTeam2.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(483, 264);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 8;
            label2.Text = "Time A";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(483, 317);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 8;
            label3.Text = "Time B";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(483, 381);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 8;
            label4.Text = "Mapa";
            // 
            // TextBoxMap
            // 
            TextBoxMap.Font = new Font("Arial", 16F);
            TextBoxMap.Location = new Point(483, 399);
            TextBoxMap.Name = "TextBoxMap";
            TextBoxMap.PlaceholderText = "Mapa ex: { Floresta negra }";
            TextBoxMap.ReadOnly = true;
            TextBoxMap.Size = new Size(268, 32);
            TextBoxMap.TabIndex = 7;
            // 
            // SplitForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.mainmenu_paphos_bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(765, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(TextBoxMap);
            Controls.Add(TextBoxTeam2);
            Controls.Add(TextBoxTeam1);
            Controls.Add(panel1);
            Controls.Add(dataGridViewPlayers);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "SplitForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Divisor de times";
            Load += SplitForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPlayers).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ConfirmSplitTeamsButton;
        private DataGridView dataGridViewPlayers;
        private Panel panel1;
        private TextBox TextBoxTeam1;
        private TextBox TextBoxTeam2;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label4;
        private TextBox TextBoxMap;
    }
}