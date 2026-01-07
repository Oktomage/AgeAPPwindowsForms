namespace AgeAPP.Cards
{
    partial class CompactPlayerCard
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
            PlayerRatingLabel = new Label();
            PlayerNameLabel = new Label();
            pictureBox1 = new PictureBox();
            LeaderboardRankLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)AvatarPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // AvatarPictureBox
            // 
            AvatarPictureBox.BackgroundImage = Properties.Resources.PR1_001;
            AvatarPictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            AvatarPictureBox.Location = new Point(-117, 45);
            AvatarPictureBox.Name = "AvatarPictureBox";
            AvatarPictureBox.Size = new Size(60, 60);
            AvatarPictureBox.TabIndex = 2;
            AvatarPictureBox.TabStop = false;
            // 
            // PlayerRatingLabel
            // 
            PlayerRatingLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PlayerRatingLabel.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PlayerRatingLabel.ForeColor = SystemColors.Control;
            PlayerRatingLabel.Location = new Point(370, 9);
            PlayerRatingLabel.Name = "PlayerRatingLabel";
            PlayerRatingLabel.Size = new Size(76, 24);
            PlayerRatingLabel.TabIndex = 10;
            PlayerRatingLabel.Text = "(2000)";
            // 
            // PlayerNameLabel
            // 
            PlayerNameLabel.AutoSize = true;
            PlayerNameLabel.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PlayerNameLabel.ForeColor = SystemColors.Control;
            PlayerNameLabel.Location = new Point(109, 9);
            PlayerNameLabel.Name = "PlayerNameLabel";
            PlayerNameLabel.Size = new Size(94, 24);
            PlayerNameLabel.TabIndex = 13;
            PlayerNameLabel.Text = "pedreiro";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.PR1_001;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(67, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 30);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // LeaderboardRankLabel
            // 
            LeaderboardRankLabel.AutoSize = true;
            LeaderboardRankLabel.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LeaderboardRankLabel.ForeColor = SystemColors.Control;
            LeaderboardRankLabel.Location = new Point(3, 9);
            LeaderboardRankLabel.Name = "LeaderboardRankLabel";
            LeaderboardRankLabel.Size = new Size(58, 24);
            LeaderboardRankLabel.TabIndex = 10;
            LeaderboardRankLabel.Text = "#100";
            // 
            // CompactPlayerCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(LeaderboardRankLabel);
            Controls.Add(PlayerRatingLabel);
            Controls.Add(PlayerNameLabel);
            Controls.Add(pictureBox1);
            Controls.Add(AvatarPictureBox);
            Name = "CompactPlayerCard";
            Size = new Size(449, 40);
            ((System.ComponentModel.ISupportInitialize)AvatarPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox AvatarPictureBox;
        private Label PlayerRatingLabel;
        private Label PlayerNameLabel;
        private PictureBox pictureBox1;
        private Label LeaderboardRankLabel;
    }
}
