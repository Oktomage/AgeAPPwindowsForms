namespace AgeAPP.Cards
{
    partial class AdminChangesCard
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            ChangeTitleLabel = new Label();
            AuthorLabel = new Label();
            DateLabel = new Label();
            ContentTextBox = new RichTextBox();
            label1 = new Label();
            ChangeIconPictureBox = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)ChangeIconPictureBox).BeginInit();
            SuspendLayout();
            // 
            // ChangeTitleLabel
            // 
            ChangeTitleLabel.AutoSize = true;
            ChangeTitleLabel.BackColor = Color.Black;
            ChangeTitleLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ChangeTitleLabel.ForeColor = SystemColors.Control;
            ChangeTitleLabel.Location = new Point(56, 6);
            ChangeTitleLabel.Name = "ChangeTitleLabel";
            ChangeTitleLabel.Size = new Size(143, 21);
            ChangeTitleLabel.TabIndex = 0;
            ChangeTitleLabel.Text = "Mudança em mapa";
            // 
            // AuthorLabel
            // 
            AuthorLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AuthorLabel.AutoSize = true;
            AuthorLabel.BackColor = Color.Black;
            AuthorLabel.Font = new Font("Segoe UI", 9F);
            AuthorLabel.ForeColor = SystemColors.Control;
            AuthorLabel.Location = new Point(3, 69);
            AuthorLabel.Name = "AuthorLabel";
            AuthorLabel.Size = new Size(77, 15);
            AuthorLabel.TabIndex = 0;
            AuthorLabel.Text = "Registro por: ";
            // 
            // DateLabel
            // 
            DateLabel.AutoSize = true;
            DateLabel.BackColor = Color.Black;
            DateLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            DateLabel.ForeColor = SystemColors.Control;
            DateLabel.Location = new Point(56, 29);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(82, 17);
            DateLabel.TabIndex = 0;
            DateLabel.Text = "[25/05/2025]";
            // 
            // ContentTextBox
            // 
            ContentTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ContentTextBox.BackColor = Color.Gray;
            ContentTextBox.BorderStyle = BorderStyle.None;
            ContentTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ContentTextBox.ForeColor = SystemColors.Control;
            ContentTextBox.Location = new Point(220, 34);
            ContentTextBox.Name = "ContentTextBox";
            ContentTextBox.ReadOnly = true;
            ContentTextBox.ScrollBars = RichTextBoxScrollBars.None;
            ContentTextBox.Size = new Size(242, 50);
            ContentTextBox.TabIndex = 1;
            ContentTextBox.TabStop = false;
            ContentTextBox.Text = "Teste";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Segoe UI", 9F);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(220, 12);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 0;
            label1.Text = "Descrição:";
            // 
            // ChangeIconPictureBox
            // 
            ChangeIconPictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            ChangeIconPictureBox.BorderStyle = BorderStyle.FixedSingle;
            ChangeIconPictureBox.Location = new Point(3, 6);
            ChangeIconPictureBox.Name = "ChangeIconPictureBox";
            ChangeIconPictureBox.Size = new Size(47, 48);
            ChangeIconPictureBox.TabIndex = 2;
            ChangeIconPictureBox.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 90);
            panel1.Name = "panel1";
            panel1.Size = new Size(465, 5);
            panel1.TabIndex = 3;
            // 
            // AdminChangesCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(panel1);
            Controls.Add(ChangeIconPictureBox);
            Controls.Add(ContentTextBox);
            Controls.Add(label1);
            Controls.Add(AuthorLabel);
            Controls.Add(DateLabel);
            Controls.Add(ChangeTitleLabel);
            Margin = new Padding(0, 0, 0, 10);
            Name = "AdminChangesCard";
            Size = new Size(465, 95);
            ((System.ComponentModel.ISupportInitialize)ChangeIconPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ChangeTitleLabel;
        private Label AuthorLabel;
        private Label DateLabel;
        private RichTextBox ContentTextBox;
        private Label label1;
        private PictureBox ChangeIconPictureBox;
        private Panel panel1;
    }
}
