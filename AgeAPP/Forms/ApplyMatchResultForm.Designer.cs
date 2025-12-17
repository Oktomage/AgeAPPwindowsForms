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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplyMatchResultForm));
            dataGridViewPlayers1 = new DataGridView();
            dataGridViewPlayers2 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ApplyResultButton = new Button();
            TeamVictoriousBox = new ComboBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPlayers1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPlayers2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewPlayers1
            // 
            dataGridViewPlayers1.AllowUserToAddRows = false;
            dataGridViewPlayers1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPlayers1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dataGridViewPlayers1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPlayers1.Location = new Point(12, 48);
            dataGridViewPlayers1.Name = "dataGridViewPlayers1";
            dataGridViewPlayers1.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewPlayers1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewPlayers1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPlayers1.Size = new Size(344, 471);
            dataGridViewPlayers1.TabIndex = 2;
            // 
            // dataGridViewPlayers2
            // 
            dataGridViewPlayers2.AllowUserToAddRows = false;
            dataGridViewPlayers2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPlayers2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dataGridViewPlayers2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPlayers2.Location = new Point(555, 48);
            dataGridViewPlayers2.Name = "dataGridViewPlayers2";
            dataGridViewPlayers2.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewPlayers2.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewPlayers2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPlayers2.Size = new Size(344, 471);
            dataGridViewPlayers2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(112, 36);
            label1.TabIndex = 4;
            label1.Text = "Time A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(785, 9);
            label2.Name = "label2";
            label2.Size = new Size(114, 36);
            label2.TabIndex = 4;
            label2.Text = "Time B";
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
            ApplyResultButton.Location = new Point(362, 472);
            ApplyResultButton.Name = "ApplyResultButton";
            ApplyResultButton.Size = new Size(187, 46);
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
            TeamVictoriousBox.Location = new Point(362, 244);
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
            label3.Location = new Point(362, 219);
            label3.Name = "label3";
            label3.Size = new Size(145, 22);
            label3.TabIndex = 4;
            label3.Text = "Quem ganhou ?";
            // 
            // ApplyMatchResultForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Holidays_1920x1080;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 533);
            Controls.Add(TeamVictoriousBox);
            Controls.Add(ApplyResultButton);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(dataGridViewPlayers2);
            Controls.Add(dataGridViewPlayers1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "ApplyMatchResultForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Aplicando resultado...";
            Load += ApplyMatchResultForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPlayers1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPlayers2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewPlayers1;
        private DataGridView dataGridViewPlayers2;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button ApplyResultButton;
        private ComboBox TeamVictoriousBox;
        private Label label3;
    }
}