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
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)AvatarPictureBox).BeginInit();
            SuspendLayout();
            // 
            // AvatarPictureBox
            // 
            AvatarPictureBox.BackgroundImage = Properties.Resources.Player_icon1;
            AvatarPictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            AvatarPictureBox.Location = new Point(11, 3);
            AvatarPictureBox.Name = "AvatarPictureBox";
            AvatarPictureBox.Size = new Size(60, 60);
            AvatarPictureBox.TabIndex = 0;
            AvatarPictureBox.TabStop = false;
            // 
            // PlayerNameLabel
            // 
            PlayerNameLabel.AutoSize = true;
            PlayerNameLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PlayerNameLabel.ForeColor = SystemColors.Control;
            PlayerNameLabel.Location = new Point(77, 0);
            PlayerNameLabel.Name = "PlayerNameLabel";
            PlayerNameLabel.Size = new Size(96, 30);
            PlayerNameLabel.TabIndex = 1;
            PlayerNameLabel.Text = "pedreiro";
            // 
            // PlayerRatingLabel
            // 
            PlayerRatingLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PlayerRatingLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PlayerRatingLabel.ForeColor = SystemColors.Control;
            PlayerRatingLabel.Location = new Point(668, 3);
            PlayerRatingLabel.Name = "PlayerRatingLabel";
            PlayerRatingLabel.Size = new Size(69, 32);
            PlayerRatingLabel.TabIndex = 1;
            PlayerRatingLabel.Text = "(2000)";
            // 
            // PlayerLastMatchDateLabel
            // 
            PlayerLastMatchDateLabel.AutoSize = true;
            PlayerLastMatchDateLabel.Font = new Font("Segoe UI", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            PlayerLastMatchDateLabel.ForeColor = SystemColors.Control;
            PlayerLastMatchDateLabel.Location = new Point(79, 50);
            PlayerLastMatchDateLabel.Name = "PlayerLastMatchDateLabel";
            PlayerLastMatchDateLabel.Size = new Size(139, 13);
            PlayerLastMatchDateLabel.TabIndex = 1;
            PlayerLastMatchDateLabel.Text = "Ultima partida: 30/12/2025";
            // 
            // PlayerWinRateLabel
            // 
            PlayerWinRateLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PlayerWinRateLabel.AutoSize = true;
            PlayerWinRateLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PlayerWinRateLabel.ForeColor = SystemColors.Control;
            PlayerWinRateLabel.Location = new Point(684, 35);
            PlayerWinRateLabel.Name = "PlayerWinRateLabel";
            PlayerWinRateLabel.Size = new Size(37, 15);
            PlayerWinRateLabel.TabIndex = 1;
            PlayerWinRateLabel.Text = "[42%]";
            // 
            // PlayerMatchesLabel
            // 
            PlayerMatchesLabel.AutoSize = true;
            PlayerMatchesLabel.Font = new Font("Segoe UI", 8.25F);
            PlayerMatchesLabel.ForeColor = SystemColors.Control;
            PlayerMatchesLabel.Location = new Point(79, 37);
            PlayerMatchesLabel.Name = "PlayerMatchesLabel";
            PlayerMatchesLabel.Size = new Size(144, 13);
            PlayerMatchesLabel.TabIndex = 1;
            PlayerMatchesLabel.Text = "Partidas: 999 | Vitórias: 500";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(5, 68);
            panel1.TabIndex = 2;
            // 
            // PlayerCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(panel1);
            Controls.Add(PlayerWinRateLabel);
            Controls.Add(PlayerRatingLabel);
            Controls.Add(PlayerMatchesLabel);
            Controls.Add(PlayerLastMatchDateLabel);
            Controls.Add(PlayerNameLabel);
            Controls.Add(AvatarPictureBox);
            Margin = new Padding(3, 3, 3, 10);
            Name = "PlayerCard";
            Size = new Size(740, 68);
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
        private Panel panel1;
    }
}
