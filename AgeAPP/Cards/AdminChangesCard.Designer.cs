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
            SuspendLayout();
            // 
            // ChangeTitleLabel
            // 
            ChangeTitleLabel.AutoSize = true;
            ChangeTitleLabel.BackColor = Color.Black;
            ChangeTitleLabel.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ChangeTitleLabel.ForeColor = SystemColors.Control;
            ChangeTitleLabel.Location = new Point(3, 0);
            ChangeTitleLabel.Name = "ChangeTitleLabel";
            ChangeTitleLabel.Size = new Size(186, 24);
            ChangeTitleLabel.TabIndex = 0;
            ChangeTitleLabel.Text = "Mudança em mapa";
            // 
            // AuthorLabel
            // 
            AuthorLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AuthorLabel.AutoSize = true;
            AuthorLabel.BackColor = Color.Transparent;
            AuthorLabel.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AuthorLabel.ForeColor = SystemColors.Control;
            AuthorLabel.Location = new Point(3, 59);
            AuthorLabel.Name = "AuthorLabel";
            AuthorLabel.Size = new Size(81, 15);
            AuthorLabel.TabIndex = 0;
            AuthorLabel.Text = "Registro por: ";
            // 
            // DateLabel
            // 
            DateLabel.AutoSize = true;
            DateLabel.BackColor = Color.Transparent;
            DateLabel.Font = new Font("Arial", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            DateLabel.ForeColor = SystemColors.Control;
            DateLabel.Location = new Point(3, 24);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(79, 16);
            DateLabel.TabIndex = 0;
            DateLabel.Text = "[25/05/2025]";
            // 
            // ContentTextBox
            // 
            ContentTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ContentTextBox.BackColor = Color.Gray;
            ContentTextBox.BorderStyle = BorderStyle.None;
            ContentTextBox.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ContentTextBox.ForeColor = SystemColors.Control;
            ContentTextBox.Location = new Point(220, 30);
            ContentTextBox.Name = "ContentTextBox";
            ContentTextBox.ReadOnly = true;
            ContentTextBox.ScrollBars = RichTextBoxScrollBars.None;
            ContentTextBox.Size = new Size(251, 41);
            ContentTextBox.TabIndex = 1;
            ContentTextBox.TabStop = false;
            ContentTextBox.Text = "Teste";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(220, 12);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 0;
            label1.Text = "Descrição:";
            // 
            // AdminChangesCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(ContentTextBox);
            Controls.Add(label1);
            Controls.Add(AuthorLabel);
            Controls.Add(DateLabel);
            Controls.Add(ChangeTitleLabel);
            Margin = new Padding(0, 0, 0, 10);
            Name = "AdminChangesCard";
            Size = new Size(486, 74);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ChangeTitleLabel;
        private Label AuthorLabel;
        private Label DateLabel;
        private RichTextBox ContentTextBox;
        private Label label1;
    }
}
