namespace AgeAPP.Forms
{
    partial class ApplyMatchResultForm
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplyMatchResultForm));
            dataGridViewMatchLog = new DataGridView();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ApplyResultButton = new Button();
            TeamVictoriousBox = new ComboBox();
            label3 = new Label();
            OpenFileDialog = new OpenFileDialog();
            PlayedMapLabel = new Label();
            HelpButton = new Button();
            ToolTips = new ToolTip(components);
            FindLogsButton = new Button();
            dataGridViewMaps = new DataGridView();
            ChangeMapButton = new Button();
            pictureBox3 = new PictureBox();
            ProgressBar = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatchLog).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMaps).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewMatchLog
            // 
            dataGridViewMatchLog.AllowUserToAddRows = false;
            dataGridViewMatchLog.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMatchLog.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dataGridViewMatchLog.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatchLog.Location = new Point(12, 48);
            dataGridViewMatchLog.MultiSelect = false;
            dataGridViewMatchLog.Name = "dataGridViewMatchLog";
            dataGridViewMatchLog.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewMatchLog.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewMatchLog.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewMatchLog.Size = new Size(344, 228);
            dataGridViewMatchLog.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(132, 36);
            label1.TabIndex = 4;
            label1.Text = "Registro";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.loading_slash;
            pictureBox1.Location = new Point(362, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(187, 107);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.seperator2;
            pictureBox2.Location = new Point(362, 125);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(187, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // ApplyResultButton
            // 
            ApplyResultButton.BackgroundImage = Properties.Resources.button_wide_normal;
            ApplyResultButton.BackgroundImageLayout = ImageLayout.Stretch;
            ApplyResultButton.FlatStyle = FlatStyle.Flat;
            ApplyResultButton.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ApplyResultButton.ForeColor = SystemColors.Control;
            ApplyResultButton.Location = new Point(362, 229);
            ApplyResultButton.Name = "ApplyResultButton";
            ApplyResultButton.Size = new Size(187, 47);
            ApplyResultButton.TabIndex = 6;
            ApplyResultButton.Text = "Aplicar";
            ApplyResultButton.UseVisualStyleBackColor = true;
            ApplyResultButton.Click += ApplyResultButton_Click;
            // 
            // TeamVictoriousBox
            // 
            TeamVictoriousBox.DropDownStyle = ComboBoxStyle.DropDownList;
            TeamVictoriousBox.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TeamVictoriousBox.FormattingEnabled = true;
            TeamVictoriousBox.Items.AddRange(new object[] { "Team A", "Team B" });
            TeamVictoriousBox.Location = new Point(362, 188);
            TeamVictoriousBox.Name = "TeamVictoriousBox";
            TeamVictoriousBox.Size = new Size(187, 35);
            TeamVictoriousBox.TabIndex = 7;
            TeamVictoriousBox.SelectedIndexChanged += TeamVictoriousBox_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(362, 163);
            label3.Name = "label3";
            label3.Size = new Size(145, 22);
            label3.TabIndex = 4;
            label3.Text = "Quem ganhou ?";
            // 
            // OpenFileDialog
            // 
            OpenFileDialog.FileName = "openFileDialog1";
            // 
            // PlayedMapLabel
            // 
            PlayedMapLabel.AutoSize = true;
            PlayedMapLabel.BackColor = Color.Black;
            PlayedMapLabel.Font = new Font("Arial", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PlayedMapLabel.ForeColor = SystemColors.Control;
            PlayedMapLabel.Location = new Point(12, 329);
            PlayedMapLabel.Name = "PlayedMapLabel";
            PlayedMapLabel.Size = new Size(189, 33);
            PlayedMapLabel.TabIndex = 4;
            PlayedMapLabel.Text = "Mapa: { Null }";
            // 
            // HelpButton
            // 
            HelpButton.BackgroundImage = Properties.Resources.Help_icon;
            HelpButton.BackgroundImageLayout = ImageLayout.Stretch;
            HelpButton.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HelpButton.Location = new Point(318, 7);
            HelpButton.Name = "HelpButton";
            HelpButton.Size = new Size(38, 38);
            HelpButton.TabIndex = 6;
            HelpButton.UseVisualStyleBackColor = true;
            HelpButton.Click += HelpButton_Click;
            // 
            // ToolTips
            // 
            ToolTips.AutoPopDelay = 5000;
            ToolTips.InitialDelay = 300;
            ToolTips.ReshowDelay = 100;
            // 
            // FindLogsButton
            // 
            FindLogsButton.BackgroundImage = Properties.Resources.Open_folder_icon;
            FindLogsButton.BackgroundImageLayout = ImageLayout.Stretch;
            FindLogsButton.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FindLogsButton.Location = new Point(150, 7);
            FindLogsButton.Name = "FindLogsButton";
            FindLogsButton.Size = new Size(38, 38);
            FindLogsButton.TabIndex = 6;
            FindLogsButton.UseVisualStyleBackColor = true;
            FindLogsButton.Click += FindLogButton_Click;
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
            dataGridViewMaps.Location = new Point(12, 365);
            dataGridViewMaps.MultiSelect = false;
            dataGridViewMaps.Name = "dataGridViewMaps";
            dataGridViewMaps.ReadOnly = true;
            dataGridViewMaps.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewMaps.Size = new Size(344, 234);
            dataGridViewMaps.TabIndex = 8;
            // 
            // ChangeMapButton
            // 
            ChangeMapButton.BackgroundImage = Properties.Resources.button_wide_normal;
            ChangeMapButton.BackgroundImageLayout = ImageLayout.Stretch;
            ChangeMapButton.FlatStyle = FlatStyle.Flat;
            ChangeMapButton.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ChangeMapButton.ForeColor = SystemColors.Control;
            ChangeMapButton.Location = new Point(362, 552);
            ChangeMapButton.Name = "ChangeMapButton";
            ChangeMapButton.Size = new Size(187, 47);
            ChangeMapButton.TabIndex = 6;
            ChangeMapButton.Text = "Trocar mapa";
            ChangeMapButton.UseVisualStyleBackColor = true;
            ChangeMapButton.Click += ChangeMapButton_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.seperator_grey;
            pictureBox3.Location = new Point(15, 291);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(534, 35);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // ProgressBar
            // 
            ProgressBar.Location = new Point(12, 606);
            ProgressBar.Name = "ProgressBar";
            ProgressBar.Size = new Size(537, 23);
            ProgressBar.TabIndex = 9;
            // 
            // ApplyMatchResultForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Holidays_1920x1080;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(567, 638);
            Controls.Add(ProgressBar);
            Controls.Add(dataGridViewMaps);
            Controls.Add(TeamVictoriousBox);
            Controls.Add(FindLogsButton);
            Controls.Add(HelpButton);
            Controls.Add(ChangeMapButton);
            Controls.Add(ApplyResultButton);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(PlayedMapLabel);
            Controls.Add(label1);
            Controls.Add(dataGridViewMatchLog);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "ApplyMatchResultForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Aplicando resultado...";
            Load += ApplyMatchResultForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatchLog).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMaps).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewMatchLog;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button ApplyResultButton;
        private ComboBox TeamVictoriousBox;
        private Label label3;
        private OpenFileDialog OpenFileDialog;
        private Label PlayedMapLabel;
        private Button HelpButton;
        private ToolTip ToolTips;
        private Button FindLogsButton;
        private DataGridView dataGridViewMaps;
        private Button ChangeMapButton;
        private PictureBox pictureBox3;
        private ProgressBar ProgressBar;
    }
}