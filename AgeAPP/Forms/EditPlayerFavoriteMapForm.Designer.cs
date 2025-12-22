namespace AgeAPP.Forms
{
    partial class EditPlayerFavoriteMapForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditPlayerFavoriteMapForm));
            dataGridViewMaps = new DataGridView();
            label3 = new Label();
            FavoriteMapListBox = new ListBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ConfirmButton = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMaps).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
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
            dataGridViewMaps.Location = new Point(12, 36);
            dataGridViewMaps.Name = "dataGridViewMaps";
            dataGridViewMaps.ReadOnly = true;
            dataGridViewMaps.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewMaps.Size = new Size(363, 264);
            dataGridViewMaps.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(288, 24);
            label3.TabIndex = 5;
            label3.Text = "Selecione os mapas favoritos";
            // 
            // FavoriteMapListBox
            // 
            FavoriteMapListBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FavoriteMapListBox.FormattingEnabled = true;
            FavoriteMapListBox.Location = new Point(465, 36);
            FavoriteMapListBox.Name = "FavoriteMapListBox";
            FavoriteMapListBox.Size = new Size(273, 166);
            FavoriteMapListBox.TabIndex = 7;
            FavoriteMapListBox.DrawItem += FavoriteMapListBox_DrawItem;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(465, 9);
            label1.Name = "label1";
            label1.Size = new Size(99, 24);
            label1.TabIndex = 5;
            label1.Text = "Favoritos";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Arrow_icon;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(381, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(78, 73);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.Arrow2_icon;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(381, 129);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(78, 73);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // ConfirmButton
            // 
            ConfirmButton.Anchor = AnchorStyles.Top;
            ConfirmButton.BackColor = Color.Transparent;
            ConfirmButton.BackgroundImage = Properties.Resources.button_wide_normal;
            ConfirmButton.BackgroundImageLayout = ImageLayout.Stretch;
            ConfirmButton.FlatStyle = FlatStyle.Flat;
            ConfirmButton.Font = new Font("Arial", 12F);
            ConfirmButton.ForeColor = SystemColors.Control;
            ConfirmButton.Location = new Point(214, 46);
            ConfirmButton.Name = "ConfirmButton";
            ConfirmButton.Size = new Size(134, 39);
            ConfirmButton.TabIndex = 9;
            ConfirmButton.Text = "Confirmar";
            ConfirmButton.UseVisualStyleBackColor = false;
            ConfirmButton.Click += ConfirmButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(ConfirmButton);
            panel1.Location = new Point(381, 208);
            panel1.Name = "panel1";
            panel1.Size = new Size(357, 92);
            panel1.TabIndex = 10;
            // 
            // EditPlayerFavoriteMapForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.mainmenu_paphos_bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(747, 309);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(FavoriteMapListBox);
            Controls.Add(dataGridViewMaps);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "EditPlayerFavoriteMapForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editando mapas favoritos...";
            Load += EditPlayerFavoriteMapForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewMaps).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewMaps;
        private Label label3;
        private ListBox FavoriteMapListBox;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button ConfirmButton;
        private Panel panel1;
    }
}