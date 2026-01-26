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
            label2 = new Label();
            ToolTips = new ToolTip(components);
            HelpButton = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMaps).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            dataGridViewMaps.MultiSelect = false;
            dataGridViewMaps.Name = "dataGridViewMaps";
            dataGridViewMaps.ReadOnly = true;
            dataGridViewMaps.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewMaps.Size = new Size(363, 264);
            dataGridViewMaps.TabIndex = 6;
            dataGridViewMaps.CellDoubleClick += dataGridViewMaps_CellDoubleClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.Font = new Font("Segoe UI", 15.75F);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(12, 5);
            label3.Name = "label3";
            label3.Size = new Size(151, 30);
            label3.TabIndex = 5;
            label3.Text = "Lista de mapas";
            // 
            // FavoriteMapListBox
            // 
            FavoriteMapListBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FavoriteMapListBox.FormattingEnabled = true;
            FavoriteMapListBox.Location = new Point(465, 36);
            FavoriteMapListBox.Name = "FavoriteMapListBox";
            FavoriteMapListBox.Size = new Size(273, 214);
            FavoriteMapListBox.TabIndex = 7;
            FavoriteMapListBox.DrawItem += FavoriteMapListBox_DrawItem;
            FavoriteMapListBox.DoubleClick += FavoriteMapListBox_DoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Segoe UI", 15.75F);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(465, 5);
            label1.Name = "label1";
            label1.Size = new Size(118, 30);
            label1.TabIndex = 5;
            label1.Text = "Favoritados";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Arrow_icon;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(381, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(78, 55);
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
            ConfirmButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ConfirmButton.ForeColor = SystemColors.Control;
            ConfirmButton.Location = new Point(574, 271);
            ConfirmButton.Name = "ConfirmButton";
            ConfirmButton.Size = new Size(166, 53);
            ConfirmButton.TabIndex = 9;
            ConfirmButton.Text = "Confirmar";
            ConfirmButton.UseVisualStyleBackColor = false;
            ConfirmButton.Click += ConfirmButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(12, 303);
            label2.Name = "label2";
            label2.Size = new Size(336, 21);
            label2.TabIndex = 5;
            label2.Text = "Clique duplo para adicionar ou remover mapas";
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
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.Arrow2_icon;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(381, 97);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(78, 55);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // EditPlayerFavoriteMapForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.mainmenu_paphos_bg;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(750, 334);
            Controls.Add(ConfirmButton);
            Controls.Add(HelpButton);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(FavoriteMapListBox);
            Controls.Add(dataGridViewMaps);
            Controls.Add(label1);
            Controls.Add(label3);
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
        private ToolTip ToolTips;
        private Button HelpButton;
        private Label label2;
        private PictureBox pictureBox2;
    }
}