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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplyMatchResultForm));
            dataGridViewMatchLog = new DataGridView();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ApplyResultButton = new Button();
            TeamVictoriousBox = new ComboBox();
            label3 = new Label();
            FindLogButton = new Button();
            OpenFileDialog = new OpenFileDialog();
            PlayedMapLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatchLog).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewMatchLog
            // 
            dataGridViewMatchLog.AllowUserToAddRows = false;
            dataGridViewMatchLog.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMatchLog.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dataGridViewMatchLog.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatchLog.Location = new Point(12, 48);
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
            dataGridViewMatchLog.Size = new Size(344, 267);
            dataGridViewMatchLog.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(307, 36);
            label1.TabIndex = 4;
            label1.Text = "Jogadores da partida";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.loading_slash;
            pictureBox1.Location = new Point(362, 48);
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
            pictureBox2.Location = new Point(362, 161);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(187, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // ApplyResultButton
            // 
            ApplyResultButton.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ApplyResultButton.Location = new Point(362, 324);
            ApplyResultButton.Name = "ApplyResultButton";
            ApplyResultButton.Size = new Size(187, 33);
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
            TeamVictoriousBox.Location = new Point(362, 224);
            TeamVictoriousBox.Name = "TeamVictoriousBox";
            TeamVictoriousBox.Size = new Size(187, 35);
            TeamVictoriousBox.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(362, 199);
            label3.Name = "label3";
            label3.Size = new Size(145, 22);
            label3.TabIndex = 4;
            label3.Text = "Quem ganhou ?";
            // 
            // FindLogButton
            // 
            FindLogButton.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FindLogButton.Location = new Point(446, 8);
            FindLogButton.Name = "FindLogButton";
            FindLogButton.Size = new Size(103, 34);
            FindLogButton.TabIndex = 6;
            FindLogButton.Text = "Buscar log";
            FindLogButton.UseVisualStyleBackColor = true;
            FindLogButton.Click += FindLogButton_Click;
            // 
            // OpenFileDialog
            // 
            OpenFileDialog.FileName = "openFileDialog1";
            // 
            // PlayedMapLabel
            // 
            PlayedMapLabel.AutoSize = true;
            PlayedMapLabel.BackColor = Color.Transparent;
            PlayedMapLabel.Font = new Font("Arial", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PlayedMapLabel.ForeColor = SystemColors.Control;
            PlayedMapLabel.Location = new Point(12, 324);
            PlayedMapLabel.Name = "PlayedMapLabel";
            PlayedMapLabel.Size = new Size(189, 33);
            PlayedMapLabel.TabIndex = 4;
            PlayedMapLabel.Text = "Mapa: { Null }";
            // 
            // ApplyMatchResultForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Holidays_1920x1080;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(567, 364);
            Controls.Add(TeamVictoriousBox);
            Controls.Add(FindLogButton);
            Controls.Add(ApplyResultButton);
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
        private Button FindLogButton;
        private OpenFileDialog OpenFileDialog;
        private Label PlayedMapLabel;
    }
}