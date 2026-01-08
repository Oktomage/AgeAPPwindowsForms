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
            // AdminChangesCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(ChangeTitleLabel);
            Name = "AdminChangesCard";
            Size = new Size(486, 150);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ChangeTitleLabel;
    }
}
