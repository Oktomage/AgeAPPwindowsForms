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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplitForm));
            ConfirmSplitTeamsButton = new Button();
            dataGridViewPlayers = new DataGridView();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            TextBoxTeam1 = new TextBox();
            TextBoxTeam2 = new TextBox();
            TextBoxMap = new TextBox();
            ListBoxRoom = new ListBox();
            label5 = new Label();
            panel2 = new Panel();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            ToApplyResultFormButton = new Button();
            pictureBox2 = new PictureBox();
            CopyMapTextButton = new Button();
            CopyTeamBTextButton = new Button();
            CopyTeamATextButton = new Button();
            FilterPlayerTextBox = new TextBox();
            panel3 = new Panel();
            RemovePlayerFromTheRoomButton = new Button();
            AddPlayerToRoomButton = new Button();
            RoomSizeLabel = new Label();
            label6 = new Label();
            ToolTips = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)dataGridViewPlayers).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // ConfirmSplitTeamsButton
            // 
            ConfirmSplitTeamsButton.BackColor = Color.Transparent;
            ConfirmSplitTeamsButton.BackgroundImage = Properties.Resources.button_wide_normal;
            ConfirmSplitTeamsButton.BackgroundImageLayout = ImageLayout.Stretch;
            ConfirmSplitTeamsButton.FlatStyle = FlatStyle.Flat;
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
            dataGridViewPlayers.Location = new Point(12, 38);
            dataGridViewPlayers.MultiSelect = false;
            dataGridViewPlayers.Name = "dataGridViewPlayers";
            dataGridViewPlayers.ReadOnly = true;
            dataGridViewPlayers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPlayers.Size = new Size(456, 372);
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
            label1.Size = new Size(244, 36);
            label1.TabIndex = 1;
            label1.Text = "Clique duplo na lista de jogadores\r\npara adiconar o jogador a sala";
            // 
            // TextBoxTeam1
            // 
            TextBoxTeam1.Font = new Font("Arial", 16F);
            TextBoxTeam1.Location = new Point(47, 3);
            TextBoxTeam1.Name = "TextBoxTeam1";
            TextBoxTeam1.PlaceholderText = "Time A";
            TextBoxTeam1.ReadOnly = true;
            TextBoxTeam1.Size = new Size(451, 32);
            TextBoxTeam1.TabIndex = 6;
            // 
            // TextBoxTeam2
            // 
            TextBoxTeam2.Font = new Font("Arial", 16F);
            TextBoxTeam2.Location = new Point(47, 55);
            TextBoxTeam2.Name = "TextBoxTeam2";
            TextBoxTeam2.PlaceholderText = "Time B";
            TextBoxTeam2.ReadOnly = true;
            TextBoxTeam2.Size = new Size(451, 32);
            TextBoxTeam2.TabIndex = 7;
            // 
            // TextBoxMap
            // 
            TextBoxMap.Font = new Font("Arial", 16F);
            TextBoxMap.Location = new Point(50, 143);
            TextBoxMap.Name = "TextBoxMap";
            TextBoxMap.PlaceholderText = "Mapa ex: { Floresta negra }";
            TextBoxMap.ReadOnly = true;
            TextBoxMap.Size = new Size(330, 32);
            TextBoxMap.TabIndex = 7;
            // 
            // ListBoxRoom
            // 
            ListBoxRoom.BackColor = Color.PaleGoldenrod;
            ListBoxRoom.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ListBoxRoom.FormattingEnabled = true;
            ListBoxRoom.Location = new Point(0, 25);
            ListBoxRoom.Name = "ListBoxRoom";
            ListBoxRoom.Size = new Size(269, 166);
            ListBoxRoom.TabIndex = 9;
            ListBoxRoom.DoubleClick += ListBoxRoom_DoubleClick;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.BackColor = Color.Black;
            label5.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(-2, 0);
            label5.Name = "label5";
            label5.Size = new Size(166, 22);
            label5.TabIndex = 8;
            label5.Text = "Jogadores da sala";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(ToApplyResultFormButton);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(CopyMapTextButton);
            panel2.Controls.Add(CopyTeamBTextButton);
            panel2.Controls.Add(CopyTeamATextButton);
            panel2.Controls.Add(TextBoxTeam1);
            panel2.Controls.Add(TextBoxTeam2);
            panel2.Controls.Add(TextBoxMap);
            panel2.Location = new Point(474, 257);
            panel2.Name = "panel2";
            panel2.Size = new Size(543, 181);
            panel2.TabIndex = 10;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = Properties.Resources.star;
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(3, 137);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(41, 39);
            pictureBox4.TabIndex = 10;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.team_shield_02;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(3, 55);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(41, 46);
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // ToApplyResultFormButton
            // 
            ToApplyResultFormButton.BackColor = Color.Transparent;
            ToApplyResultFormButton.BackgroundImage = Properties.Resources.button_wide_normal;
            ToApplyResultFormButton.BackgroundImageLayout = ImageLayout.Stretch;
            ToApplyResultFormButton.Enabled = false;
            ToApplyResultFormButton.FlatStyle = FlatStyle.Flat;
            ToApplyResultFormButton.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ToApplyResultFormButton.ForeColor = SystemColors.Control;
            ToApplyResultFormButton.Location = new Point(438, 143);
            ToApplyResultFormButton.Name = "ToApplyResultFormButton";
            ToApplyResultFormButton.Size = new Size(100, 32);
            ToApplyResultFormButton.TabIndex = 0;
            ToApplyResultFormButton.Text = "Aplicar...";
            ToApplyResultFormButton.UseVisualStyleBackColor = false;
            ToApplyResultFormButton.Click += ToApplyResultFormButton_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.team_shield_01;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(41, 46);
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // CopyMapTextButton
            // 
            CopyMapTextButton.BackgroundImage = Properties.Resources.Link_icon;
            CopyMapTextButton.BackgroundImageLayout = ImageLayout.Stretch;
            CopyMapTextButton.Location = new Point(386, 143);
            CopyMapTextButton.Name = "CopyMapTextButton";
            CopyMapTextButton.Size = new Size(34, 32);
            CopyMapTextButton.TabIndex = 9;
            CopyMapTextButton.UseVisualStyleBackColor = true;
            CopyMapTextButton.Click += CopyMapTextButton_Click;
            // 
            // CopyTeamBTextButton
            // 
            CopyTeamBTextButton.BackgroundImage = Properties.Resources.Link_icon;
            CopyTeamBTextButton.BackgroundImageLayout = ImageLayout.Stretch;
            CopyTeamBTextButton.Location = new Point(504, 55);
            CopyTeamBTextButton.Name = "CopyTeamBTextButton";
            CopyTeamBTextButton.Size = new Size(34, 32);
            CopyTeamBTextButton.TabIndex = 9;
            CopyTeamBTextButton.UseVisualStyleBackColor = true;
            CopyTeamBTextButton.Click += CopyTeamBTextButton_Click;
            // 
            // CopyTeamATextButton
            // 
            CopyTeamATextButton.BackgroundImage = Properties.Resources.Link_icon;
            CopyTeamATextButton.BackgroundImageLayout = ImageLayout.Stretch;
            CopyTeamATextButton.Location = new Point(504, 3);
            CopyTeamATextButton.Name = "CopyTeamATextButton";
            CopyTeamATextButton.Size = new Size(34, 32);
            CopyTeamATextButton.TabIndex = 9;
            CopyTeamATextButton.UseVisualStyleBackColor = true;
            CopyTeamATextButton.Click += CopyTeamATextButton_Click;
            // 
            // FilterPlayerTextBox
            // 
            FilterPlayerTextBox.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FilterPlayerTextBox.Location = new Point(12, 416);
            FilterPlayerTextBox.Name = "FilterPlayerTextBox";
            FilterPlayerTextBox.PlaceholderText = "Filtrar jogador ex: Kakashi";
            FilterPlayerTextBox.Size = new Size(200, 22);
            FilterPlayerTextBox.TabIndex = 11;
            FilterPlayerTextBox.TextChanged += FilterPlayerTextBox_TextChanged;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(RemovePlayerFromTheRoomButton);
            panel3.Controls.Add(AddPlayerToRoomButton);
            panel3.Controls.Add(RoomSizeLabel);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(ListBoxRoom);
            panel3.Location = new Point(474, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(269, 237);
            panel3.TabIndex = 12;
            // 
            // RemovePlayerFromTheRoomButton
            // 
            RemovePlayerFromTheRoomButton.BackgroundImage = Properties.Resources.remove_iron_4k_normal;
            RemovePlayerFromTheRoomButton.BackgroundImageLayout = ImageLayout.Stretch;
            RemovePlayerFromTheRoomButton.FlatStyle = FlatStyle.Flat;
            RemovePlayerFromTheRoomButton.Location = new Point(47, 197);
            RemovePlayerFromTheRoomButton.Name = "RemovePlayerFromTheRoomButton";
            RemovePlayerFromTheRoomButton.Size = new Size(41, 39);
            RemovePlayerFromTheRoomButton.TabIndex = 10;
            RemovePlayerFromTheRoomButton.UseVisualStyleBackColor = true;
            RemovePlayerFromTheRoomButton.Click += RemovePlayerFromTheRoomButton_Click;
            // 
            // AddPlayerToRoomButton
            // 
            AddPlayerToRoomButton.BackgroundImage = Properties.Resources.add_iron_4k_normal;
            AddPlayerToRoomButton.BackgroundImageLayout = ImageLayout.Stretch;
            AddPlayerToRoomButton.FlatStyle = FlatStyle.Flat;
            AddPlayerToRoomButton.Location = new Point(0, 197);
            AddPlayerToRoomButton.Name = "AddPlayerToRoomButton";
            AddPlayerToRoomButton.Size = new Size(41, 39);
            AddPlayerToRoomButton.TabIndex = 10;
            AddPlayerToRoomButton.UseVisualStyleBackColor = true;
            AddPlayerToRoomButton.Click += AddPlayerToRoomButton_Click;
            // 
            // RoomSizeLabel
            // 
            RoomSizeLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            RoomSizeLabel.AutoSize = true;
            RoomSizeLabel.BackColor = Color.Black;
            RoomSizeLabel.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RoomSizeLabel.ForeColor = SystemColors.Control;
            RoomSizeLabel.Location = new Point(94, 203);
            RoomSizeLabel.Name = "RoomSizeLabel";
            RoomSizeLabel.Size = new Size(114, 32);
            RoomSizeLabel.TabIndex = 8;
            RoomSizeLabel.Text = "Sala 0/8";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.BackColor = Color.Black;
            label6.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(12, 12);
            label6.Name = "label6";
            label6.Size = new Size(167, 22);
            label6.TabIndex = 8;
            label6.Text = "Lista de jogadores";
            // 
            // ToolTips
            // 
            ToolTips.AutoPopDelay = 5000;
            ToolTips.InitialDelay = 300;
            ToolTips.ReshowDelay = 100;
            // 
            // SplitForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.mainmenu_paphos_bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1031, 450);
            Controls.Add(label6);
            Controls.Add(FilterPlayerTextBox);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dataGridViewPlayers);
            Controls.Add(panel3);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
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
        private PictureBox pictureBox1;
        private TextBox TextBoxMap;
        private ListBox ListBoxRoom;
        private Label label5;
        private Panel panel2;
        private Button CopyTeamATextButton;
        private Button CopyTeamBTextButton;
        private Button CopyMapTextButton;
        private TextBox FilterPlayerTextBox;
        private Panel panel3;
        private Label label6;
        private Button AddPlayerToRoomButton;
        private Button RemovePlayerFromTheRoomButton;
        private Label RoomSizeLabel;
        private ToolTip ToolTips;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Button ToApplyResultFormButton;
    }
}