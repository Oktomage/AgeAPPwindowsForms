namespace AgeAPP.Cards
{
    partial class MatchHistoryCard
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
            MapNameLabel = new Label();
            pictureBox1 = new PictureBox();
            DateLabel = new Label();
            DeltaRatingLabel = new Label();
            TeamWonLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // MapNameLabel
            // 
            MapNameLabel.AutoSize = true;
            MapNameLabel.Font = new Font("Arial", 14.25F);
            MapNameLabel.Location = new Point(100, 3);
            MapNameLabel.Name = "MapNameLabel";
            MapNameLabel.Size = new Size(126, 22);
            MapNameLabel.TabIndex = 0;
            MapNameLabel.Text = "Mega random";
            MapNameLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.BackgroundImage = Properties.Resources.UnkownMap;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(91, 84);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // DateLabel
            // 
            DateLabel.AutoSize = true;
            DateLabel.Font = new Font("Arial", 14.25F);
            DateLabel.Location = new Point(283, 3);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(118, 22);
            DateLabel.TabIndex = 0;
            DateLabel.Text = "[25/12/2025]";
            DateLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // DeltaRatingLabel
            // 
            DeltaRatingLabel.AutoSize = true;
            DeltaRatingLabel.Font = new Font("Arial", 14.25F);
            DeltaRatingLabel.Location = new Point(100, 35);
            DeltaRatingLabel.Name = "DeltaRatingLabel";
            DeltaRatingLabel.Size = new Size(126, 22);
            DeltaRatingLabel.TabIndex = 0;
            DeltaRatingLabel.Text = "Delta rating: 4";
            DeltaRatingLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // TeamWonLabel
            // 
            TeamWonLabel.AutoSize = true;
            TeamWonLabel.Font = new Font("Arial", 14.25F);
            TeamWonLabel.Location = new Point(283, 35);
            TeamWonLabel.Name = "TeamWonLabel";
            TeamWonLabel.Size = new Size(134, 22);
            TeamWonLabel.TabIndex = 0;
            TeamWonLabel.Text = "Time A venceu";
            TeamWonLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // MatchHistoryCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            Controls.Add(pictureBox1);
            Controls.Add(DateLabel);
            Controls.Add(TeamWonLabel);
            Controls.Add(DeltaRatingLabel);
            Controls.Add(MapNameLabel);
            Margin = new Padding(0, 0, 0, 10);
            Name = "MatchHistoryCard";
            Size = new Size(650, 90);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MapNameLabel;
        private PictureBox pictureBox1;
        private Label DateLabel;
        private Label DeltaRatingLabel;
        private Label TeamWonLabel;
    }
}
