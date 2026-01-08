namespace AgeAPP.Cards
{
    partial class PlayerCard
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
            AvatarPictureBox = new PictureBox();
            PlayerNameLabel = new Label();
            PlayerRatingLabel = new Label();
            PlayerLastMatchDateLabel = new Label();
            PlayerWinRateLabel = new Label();
            PlayerMatchesLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)AvatarPictureBox).BeginInit();
            SuspendLayout();
            // 
            // AvatarPictureBox
            // 
            AvatarPictureBox.BackgroundImage = Properties.Resources.Player_icon1;
            AvatarPictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            AvatarPictureBox.Location = new Point(3, 3);
            AvatarPictureBox.Name = "AvatarPictureBox";
            AvatarPictureBox.Size = new Size(60, 60);
            AvatarPictureBox.TabIndex = 0;
            AvatarPictureBox.TabStop = false;
            // 
            // PlayerNameLabel
            // 
            PlayerNameLabel.AutoSize = true;
            PlayerNameLabel.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PlayerNameLabel.ForeColor = SystemColors.Control;
            PlayerNameLabel.Location = new Point(69, 3);
            PlayerNameLabel.Name = "PlayerNameLabel";
            PlayerNameLabel.Size = new Size(94, 24);
            PlayerNameLabel.TabIndex = 1;
            PlayerNameLabel.Text = "pedreiro";
            // 
            // PlayerRatingLabel
            // 
            PlayerRatingLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PlayerRatingLabel.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PlayerRatingLabel.ForeColor = SystemColors.Control;
            PlayerRatingLabel.Location = new Point(311, 3);
            PlayerRatingLabel.Name = "PlayerRatingLabel";
            PlayerRatingLabel.Size = new Size(76, 24);
            PlayerRatingLabel.TabIndex = 1;
            PlayerRatingLabel.Text = "(2000)";
            // 
            // PlayerLastMatchDateLabel
            // 
            PlayerLastMatchDateLabel.AutoSize = true;
            PlayerLastMatchDateLabel.Font = new Font("Arial", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            PlayerLastMatchDateLabel.ForeColor = SystemColors.Control;
            PlayerLastMatchDateLabel.Location = new Point(69, 48);
            PlayerLastMatchDateLabel.Name = "PlayerLastMatchDateLabel";
            PlayerLastMatchDateLabel.Size = new Size(152, 15);
            PlayerLastMatchDateLabel.TabIndex = 1;
            PlayerLastMatchDateLabel.Text = "Ultima partida: 30/12/2025";
            // 
            // PlayerWinRateLabel
            // 
            PlayerWinRateLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PlayerWinRateLabel.AutoSize = true;
            PlayerWinRateLabel.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PlayerWinRateLabel.ForeColor = SystemColors.Control;
            PlayerWinRateLabel.Location = new Point(329, 27);
            PlayerWinRateLabel.Name = "PlayerWinRateLabel";
            PlayerWinRateLabel.Size = new Size(38, 15);
            PlayerWinRateLabel.TabIndex = 1;
            PlayerWinRateLabel.Text = "[42%]";
            // 
            // PlayerMatchesLabel
            // 
            PlayerMatchesLabel.AutoSize = true;
            PlayerMatchesLabel.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PlayerMatchesLabel.ForeColor = SystemColors.Control;
            PlayerMatchesLabel.Location = new Point(69, 33);
            PlayerMatchesLabel.Name = "PlayerMatchesLabel";
            PlayerMatchesLabel.Size = new Size(157, 15);
            PlayerMatchesLabel.TabIndex = 1;
            PlayerMatchesLabel.Text = "Partidas: 999 | Vitórias: 500";
            // 
            // PlayerCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(PlayerWinRateLabel);
            Controls.Add(PlayerRatingLabel);
            Controls.Add(PlayerMatchesLabel);
            Controls.Add(PlayerLastMatchDateLabel);
            Controls.Add(PlayerNameLabel);
            Controls.Add(AvatarPictureBox);
            Name = "PlayerCard";
            Size = new Size(390, 68);
            ((System.ComponentModel.ISupportInitialize)AvatarPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox AvatarPictureBox;
        private Label PlayerNameLabel;
        private Label PlayerRatingLabel;
        private Label PlayerLastMatchDateLabel;
        private Label PlayerWinRateLabel;
        private Label PlayerMatchesLabel;
    }
}
