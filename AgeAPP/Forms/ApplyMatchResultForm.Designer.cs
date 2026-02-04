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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplyMatchResultForm));
            label1 = new Label();
            pictureBox2 = new PictureBox();
            ApplyResultButton = new Button();
            TeamVictoriousBox = new ComboBox();
            label3 = new Label();
            OpenFileDialog = new OpenFileDialog();
            PlayedMapLabel = new Label();
            HelpButton = new Button();
            ToolTips = new ToolTip(components);
            FindLogsButton = new Button();
            ProgressBar = new ProgressBar();
            ControlPanel = new Panel();
            panel2 = new Panel();
            PreviewListView = new ListView();
            MapsListView = new ListView();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ControlPanel.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Segoe UI", 18F);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(184, 32);
            label1.TabIndex = 4;
            label1.Text = "Pré-visualização";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.seperator2;
            pictureBox2.Location = new Point(3, 3);
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
            ApplyResultButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ApplyResultButton.ForeColor = SystemColors.Control;
            ApplyResultButton.Location = new Point(0, 253);
            ApplyResultButton.Name = "ApplyResultButton";
            ApplyResultButton.Size = new Size(190, 47);
            ApplyResultButton.TabIndex = 6;
            ApplyResultButton.Text = "Aplicar";
            ApplyResultButton.UseVisualStyleBackColor = true;
            ApplyResultButton.Click += ApplyResultButton_Click;
            // 
            // TeamVictoriousBox
            // 
            TeamVictoriousBox.DropDownStyle = ComboBoxStyle.DropDownList;
            TeamVictoriousBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TeamVictoriousBox.FormattingEnabled = true;
            TeamVictoriousBox.Items.AddRange(new object[] { "Team A", "Team B" });
            TeamVictoriousBox.Location = new Point(3, 73);
            TeamVictoriousBox.Name = "TeamVictoriousBox";
            TeamVictoriousBox.Size = new Size(187, 33);
            TeamVictoriousBox.TabIndex = 7;
            TeamVictoriousBox.SelectedIndexChanged += TeamVictoriousBox_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(3, 45);
            label3.Name = "label3";
            label3.Size = new Size(147, 25);
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
            PlayedMapLabel.Font = new Font("Segoe UI", 18F);
            PlayedMapLabel.ForeColor = SystemColors.Control;
            PlayedMapLabel.Location = new Point(362, 9);
            PlayedMapLabel.Name = "PlayedMapLabel";
            PlayedMapLabel.Size = new Size(237, 32);
            PlayedMapLabel.TabIndex = 4;
            PlayedMapLabel.Text = "Mapa: Desconhecido";
            // 
            // HelpButton
            // 
            HelpButton.BackgroundImage = Properties.Resources.Help_icon;
            HelpButton.BackgroundImageLayout = ImageLayout.Stretch;
            HelpButton.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HelpButton.Location = new Point(868, 7);
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
            FindLogsButton.Location = new Point(824, 7);
            FindLogsButton.Name = "FindLogsButton";
            FindLogsButton.Size = new Size(38, 38);
            FindLogsButton.TabIndex = 6;
            FindLogsButton.UseVisualStyleBackColor = true;
            FindLogsButton.Click += FindLogButton_Click;
            // 
            // ProgressBar
            // 
            ProgressBar.Location = new Point(0, 306);
            ProgressBar.Name = "ProgressBar";
            ProgressBar.Size = new Size(190, 21);
            ProgressBar.TabIndex = 9;
            // 
            // ControlPanel
            // 
            ControlPanel.BackColor = Color.Transparent;
            ControlPanel.Controls.Add(ProgressBar);
            ControlPanel.Controls.Add(pictureBox2);
            ControlPanel.Controls.Add(TeamVictoriousBox);
            ControlPanel.Controls.Add(label3);
            ControlPanel.Controls.Add(ApplyResultButton);
            ControlPanel.Location = new Point(716, 54);
            ControlPanel.Name = "ControlPanel";
            ControlPanel.Size = new Size(197, 327);
            ControlPanel.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Controls.Add(HelpButton);
            panel2.Controls.Add(FindLogsButton);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(PlayedMapLabel);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(919, 48);
            panel2.TabIndex = 11;
            // 
            // PreviewListView
            // 
            PreviewListView.BackColor = Color.Black;
            PreviewListView.BorderStyle = BorderStyle.None;
            PreviewListView.Location = new Point(12, 54);
            PreviewListView.Name = "PreviewListView";
            PreviewListView.Size = new Size(344, 327);
            PreviewListView.TabIndex = 13;
            PreviewListView.UseCompatibleStateImageBehavior = false;
            // 
            // MapsListView
            // 
            MapsListView.BackColor = Color.Black;
            MapsListView.BorderStyle = BorderStyle.None;
            MapsListView.Location = new Point(362, 54);
            MapsListView.Name = "MapsListView";
            MapsListView.Size = new Size(344, 327);
            MapsListView.TabIndex = 13;
            MapsListView.UseCompatibleStateImageBehavior = false;
            MapsListView.SelectedIndexChanged += MapsListView_SelectedIndexChanged;
            // 
            // ApplyMatchResultForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Holidays_1920x1080;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(919, 392);
            Controls.Add(MapsListView);
            Controls.Add(PreviewListView);
            Controls.Add(panel2);
            Controls.Add(ControlPanel);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "ApplyMatchResultForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Aplicando resultado...";
            Load += ApplyMatchResultForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ControlPanel.ResumeLayout(false);
            ControlPanel.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private PictureBox pictureBox2;
        private Button ApplyResultButton;
        private ComboBox TeamVictoriousBox;
        private Label label3;
        private OpenFileDialog OpenFileDialog;
        private Label PlayedMapLabel;
        private Button HelpButton;
        private ToolTip ToolTips;
        private Button FindLogsButton;
        private ProgressBar ProgressBar;
        private Panel ControlPanel;
        private Panel panel2;
        private ListView PreviewListView;
        private ListView MapsListView;
    }
}