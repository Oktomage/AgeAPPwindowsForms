namespace AgeAPP.Forms
{
    partial class CreateNewPlayerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateNewPlayerForm));
            panel1 = new Panel();
            dataGridViewMaps = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            TextBoxPlayerRating = new TextBox();
            TextBoxPlayerName = new TextBox();
            CreateButton = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMaps).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridViewMaps);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(TextBoxPlayerRating);
            panel1.Controls.Add(TextBoxPlayerName);
            panel1.Controls.Add(CreateButton);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(622, 307);
            panel1.TabIndex = 1;
            // 
            // dataGridViewMaps
            // 
            dataGridViewMaps.AllowUserToAddRows = false;
            dataGridViewMaps.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMaps.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dataGridViewMaps.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewMaps.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridViewMaps.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewMaps.Location = new Point(241, 29);
            dataGridViewMaps.Name = "dataGridViewMaps";
            dataGridViewMaps.ReadOnly = true;
            dataGridViewMaps.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewMaps.Size = new Size(363, 264);
            dataGridViewMaps.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9F);
            label2.Location = new Point(12, 61);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 2;
            label2.Text = "Rating";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9F);
            label3.Location = new Point(241, 11);
            label3.Name = "label3";
            label3.Size = new Size(170, 15);
            label3.TabIndex = 2;
            label3.Text = "Selecione os mapas favoritos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9F);
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 2;
            label1.Text = "Nome";
            // 
            // TextBoxPlayerRating
            // 
            TextBoxPlayerRating.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBoxPlayerRating.Location = new Point(12, 79);
            TextBoxPlayerRating.Name = "TextBoxPlayerRating";
            TextBoxPlayerRating.PlaceholderText = "Rating do jogador";
            TextBoxPlayerRating.Size = new Size(223, 29);
            TextBoxPlayerRating.TabIndex = 2;
            TextBoxPlayerRating.KeyPress += TextBoxPlayerRating_KeyPress;
            // 
            // TextBoxPlayerName
            // 
            TextBoxPlayerName.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBoxPlayerName.Location = new Point(12, 29);
            TextBoxPlayerName.Name = "TextBoxPlayerName";
            TextBoxPlayerName.PlaceholderText = "Nome do jogador";
            TextBoxPlayerName.Size = new Size(223, 29);
            TextBoxPlayerName.TabIndex = 1;
            // 
            // CreateButton
            // 
            CreateButton.BackgroundImage = Properties.Resources.button_wide_normal;
            CreateButton.BackgroundImageLayout = ImageLayout.Stretch;
            CreateButton.FlatStyle = FlatStyle.Flat;
            CreateButton.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CreateButton.ForeColor = SystemColors.Control;
            CreateButton.Location = new Point(89, 249);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new Size(146, 44);
            CreateButton.TabIndex = 3;
            CreateButton.Text = "Criar";
            CreateButton.UseVisualStyleBackColor = true;
            CreateButton.Click += CreateButton_Click;
            // 
            // CreateNewPlayerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 307);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "CreateNewPlayerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Novo jogador";
            Load += CreateNewPlayerForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMaps).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private TextBox TextBoxPlayerRating;
        private TextBox TextBoxPlayerName;
        private Button CreateButton;
        private DataGridView dataGridViewMaps;
        private Label label3;
    }
}