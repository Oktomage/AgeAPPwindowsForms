namespace AgeAPP.Forms
{
    partial class AdminPanelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanelForm));
            dataGridViewPlayers = new DataGridView();
            SelectedPlayerLabel = new Label();
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            SelectedPlayerRatingTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPlayers).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewPlayers
            // 
            dataGridViewPlayers.AllowUserToAddRows = false;
            dataGridViewPlayers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPlayers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dataGridViewPlayers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPlayers.Location = new Point(12, 10);
            dataGridViewPlayers.Name = "dataGridViewPlayers";
            dataGridViewPlayers.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewPlayers.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewPlayers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPlayers.Size = new Size(456, 471);
            dataGridViewPlayers.TabIndex = 1;
            dataGridViewPlayers.SelectionChanged += dataGridViewPlayers_SelectionChanged;
            // 
            // SelectedPlayerLabel
            // 
            SelectedPlayerLabel.AutoSize = true;
            SelectedPlayerLabel.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SelectedPlayerLabel.Location = new Point(12, 10);
            SelectedPlayerLabel.Name = "SelectedPlayerLabel";
            SelectedPlayerLabel.Size = new Size(77, 27);
            SelectedPlayerLabel.TabIndex = 2;
            SelectedPlayerLabel.Text = "label1";
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.news_splash;
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(SelectedPlayerRatingTextBox);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(SelectedPlayerLabel);
            panel1.Location = new Point(474, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(358, 426);
            panel1.TabIndex = 3;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(220, 384);
            button2.Name = "button2";
            button2.Size = new Size(131, 35);
            button2.TabIndex = 4;
            button2.Text = "Deletar jogador";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(170, 84);
            button1.Name = "button1";
            button1.Size = new Size(64, 35);
            button1.TabIndex = 4;
            button1.Text = "Mudar";
            button1.UseVisualStyleBackColor = true;
            // 
            // SelectedPlayerRatingTextBox
            // 
            SelectedPlayerRatingTextBox.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SelectedPlayerRatingTextBox.Location = new Point(12, 84);
            SelectedPlayerRatingTextBox.Name = "SelectedPlayerRatingTextBox";
            SelectedPlayerRatingTextBox.PlaceholderText = "0000";
            SelectedPlayerRatingTextBox.Size = new Size(152, 35);
            SelectedPlayerRatingTextBox.TabIndex = 3;
            SelectedPlayerRatingTextBox.KeyPress += SelectedPlayerRatingTextBox_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 63);
            label1.Name = "label1";
            label1.Size = new Size(53, 18);
            label1.TabIndex = 2;
            label1.Text = "Rating";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(474, 12);
            label2.Name = "label2";
            label2.Size = new Size(279, 40);
            label2.TabIndex = 2;
            label2.Text = "Painel do jogador";
            // 
            // AdminPanelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.admin_bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1338, 493);
            Controls.Add(panel1);
            Controls.Add(dataGridViewPlayers);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "AdminPanelForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Painel de administrador";
            Load += AdminPanelForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPlayers).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewPlayers;
        private Label SelectedPlayerLabel;
        private Panel panel1;
        private TextBox SelectedPlayerRatingTextBox;
        private Label label1;
        private Button button1;
        private Button button2;
        private Label label2;
    }
}