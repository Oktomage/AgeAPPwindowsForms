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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditPlayerFavoriteMapForm));
            dataGridViewMaps = new DataGridView();
            label3 = new Label();
            FavoriteMapListBox = new ListBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ConfirmButton = new Button();
            panel1 = new Panel();
            label2 = new Label();
            ToolTips = new ToolTip(components);
            HelpButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMaps).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            label3.Font = new Font("Segoe UI", 15.75F);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(12, 5);
            label3.Name = "label3";
            label3.Size = new Size(281, 30);
            label3.TabIndex = 5;
            label3.Text = "Selecione os mapas favoritos";
            // 
            // FavoriteMapListBox
            // 
            FavoriteMapListBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FavoriteMapListBox.FormattingEnabled = true;
            FavoriteMapListBox.Location = new Point(465, 36);
            FavoriteMapListBox.Name = "FavoriteMapListBox";
            FavoriteMapListBox.Size = new Size(273, 151);
            FavoriteMapListBox.TabIndex = 7;
            FavoriteMapListBox.DrawItem += FavoriteMapListBox_DrawItem;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Segoe UI", 15.75F);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(465, 5);
            label1.Name = "label1";
            label1.Size = new Size(95, 30);
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
            // ConfirmButton
            // 
            ConfirmButton.Anchor = AnchorStyles.Top;
            ConfirmButton.BackColor = Color.Transparent;
            ConfirmButton.BackgroundImage = Properties.Resources.button_wide_normal;
            ConfirmButton.BackgroundImageLayout = ImageLayout.Stretch;
            ConfirmButton.FlatStyle = FlatStyle.Flat;
            ConfirmButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ConfirmButton.ForeColor = SystemColors.Control;
            ConfirmButton.Location = new Point(216, 46);
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
            panel1.Controls.Add(ConfirmButton);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(381, 208);
            panel1.Name = "panel1";
            panel1.Size = new Size(357, 92);
            panel1.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(329, 21);
            label2.TabIndex = 5;
            label2.Text = "Selecione multiplos mapas segurando o CTRL.";
            // 
            // ToolTips
            // 
            ToolTips.AutoPopDelay = 5000;
            ToolTips.InitialDelay = 300;
            ToolTips.ReshowDelay = 100;
            // 
            // HelpButton
            // 
            HelpButton.BackgroundImage = Properties.Resources.Help_icon;
            HelpButton.BackgroundImageLayout = ImageLayout.Stretch;
            HelpButton.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HelpButton.Location = new Point(710, 5);
            HelpButton.Name = "HelpButton";
            HelpButton.Size = new Size(28, 28);
            HelpButton.TabIndex = 11;
            HelpButton.UseVisualStyleBackColor = true;
            HelpButton.Click += HelpButton_Click;
            // 
            // EditPlayerFavoriteMapForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.mainmenu_paphos_bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(747, 309);
            Controls.Add(HelpButton);
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
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewMaps;
        private Label label3;
        private ListBox FavoriteMapListBox;
        private Label label1;
        private PictureBox pictureBox1;
        private Button ConfirmButton;
        private Panel panel1;
        private ToolTip ToolTips;
        private Button HelpButton;
        private Label label2;
    }
}