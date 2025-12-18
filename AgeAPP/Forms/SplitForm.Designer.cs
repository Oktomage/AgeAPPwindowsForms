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
            ListBoxRoom = new ListBox();
            label5 = new Label();
            panel2 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            FilterPlayerTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPlayers).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // ConfirmSplitTeamsButton
            // 
            ConfirmSplitTeamsButton.BackColor = Color.Transparent;
            ConfirmSplitTeamsButton.BackgroundImage = Properties.Resources.button_wide_normal;
            ConfirmSplitTeamsButton.BackgroundImageLayout = ImageLayout.Stretch;
            ConfirmSplitTeamsButton.Font = new Font("Arial", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ConfirmSplitTeamsButton.ForeColor = SystemColors.Control;
            ConfirmSplitTeamsButton.Location = new Point(21, 55);
            ConfirmSplitTeamsButton.Name = "ConfirmSplitTeamsButton";
            ConfirmSplitTeamsButton.Size = new Size(228, 48);
            ConfirmSplitTeamsButton.TabIndex = 0;
            ConfirmSplitTeamsButton.Text = "Dividir jogadores";
            ConfirmSplitTeamsButton.UseVisualStyleBackColor = false;
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
            dataGridViewPlayers.Size = new Size(456, 398);
            dataGridViewPlayers.TabIndex = 1;
            dataGridViewPlayers.CellDoubleClick += dataGridViewPlayers_CellDoubleClick;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.BackgroundImage = Properties.Resources.Panel_bg2;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(ConfirmSplitTeamsButton);
            panel1.Location = new Point(749, 12);
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
            label1.Size = new Size(242, 36);
            label1.TabIndex = 1;
            label1.Text = "Clique na lista de jogadores para \r\nadicionar na sala";
            // 
            // TextBoxTeam1
            // 
            TextBoxTeam1.Font = new Font("Arial", 16F);
            TextBoxTeam1.Location = new Point(3, 27);
            TextBoxTeam1.Name = "TextBoxTeam1";
            TextBoxTeam1.PlaceholderText = "Time A";
            TextBoxTeam1.ReadOnly = true;
            TextBoxTeam1.Size = new Size(495, 32);
            TextBoxTeam1.TabIndex = 6;
            // 
            // TextBoxTeam2
            // 
            TextBoxTeam2.Font = new Font("Arial", 16F);
            TextBoxTeam2.Location = new Point(3, 80);
            TextBoxTeam2.Name = "TextBoxTeam2";
            TextBoxTeam2.PlaceholderText = "Time B";
            TextBoxTeam2.ReadOnly = true;
            TextBoxTeam2.Size = new Size(495, 32);
            TextBoxTeam2.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(3, 9);
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
            label3.Location = new Point(3, 62);
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
            label4.Location = new Point(3, 126);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 8;
            label4.Text = "Mapa";
            // 
            // TextBoxMap
            // 
            TextBoxMap.Font = new Font("Arial", 16F);
            TextBoxMap.Location = new Point(3, 144);
            TextBoxMap.Name = "TextBoxMap";
            TextBoxMap.PlaceholderText = "Mapa ex: { Floresta negra }";
            TextBoxMap.ReadOnly = true;
            TextBoxMap.Size = new Size(307, 32);
            TextBoxMap.TabIndex = 7;
            // 
            // ListBoxRoom
            // 
            ListBoxRoom.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ListBoxRoom.FormattingEnabled = true;
            ListBoxRoom.Location = new Point(474, 37);
            ListBoxRoom.Name = "ListBoxRoom";
            ListBoxRoom.Size = new Size(269, 202);
            ListBoxRoom.TabIndex = 9;
            ListBoxRoom.DoubleClick += ListBoxRoom_DoubleClick;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(474, 12);
            label5.Name = "label5";
            label5.Size = new Size(166, 22);
            label5.TabIndex = 8;
            label5.Text = "Jogadores da sala";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(TextBoxTeam1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(TextBoxTeam2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(TextBoxMap);
            panel2.Location = new Point(474, 257);
            panel2.Name = "panel2";
            panel2.Size = new Size(543, 181);
            panel2.TabIndex = 10;
            // 
            // button3
            // 
            button3.BackgroundImage = Properties.Resources.Link_icon;
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Location = new Point(316, 144);
            button3.Name = "button3";
            button3.Size = new Size(34, 32);
            button3.TabIndex = 9;
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.Link_icon;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Location = new Point(504, 80);
            button2.Name = "button2";
            button2.Size = new Size(34, 32);
            button2.TabIndex = 9;
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.Link_icon;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(504, 27);
            button1.Name = "button1";
            button1.Size = new Size(34, 32);
            button1.TabIndex = 9;
            button1.UseVisualStyleBackColor = true;
            // 
            // FilterPlayerTextBox
            // 
            FilterPlayerTextBox.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FilterPlayerTextBox.Location = new Point(12, 416);
            FilterPlayerTextBox.Name = "FilterPlayerTextBox";
            FilterPlayerTextBox.PlaceholderText = "Filtrar jogador ex: Kakashi";
            FilterPlayerTextBox.Size = new Size(200, 22);
            FilterPlayerTextBox.TabIndex = 11;
            // 
            // SplitForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.mainmenu_paphos_bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1031, 450);
            Controls.Add(FilterPlayerTextBox);
            Controls.Add(panel2);
            Controls.Add(ListBoxRoom);
            Controls.Add(label5);
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
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
        private ListBox ListBoxRoom;
        private Label label5;
        private Panel panel2;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox FilterPlayerTextBox;
    }
}