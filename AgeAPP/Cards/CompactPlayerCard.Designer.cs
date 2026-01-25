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
            PlayerRatingLabel = new Label();
            PlayerNameLabel = new Label();
            AvatarPictureBox = new PictureBox();
            LeaderboardRankLabel = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)AvatarPictureBox).BeginInit();
            SuspendLayout();
            // 
            // PlayerRatingLabel
            // 
            PlayerRatingLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PlayerRatingLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PlayerRatingLabel.ForeColor = SystemColors.Control;
            PlayerRatingLabel.Location = new Point(661, 4);
            PlayerRatingLabel.Name = "PlayerRatingLabel";
            PlayerRatingLabel.Size = new Size(76, 29);
            PlayerRatingLabel.TabIndex = 10;
            PlayerRatingLabel.Text = "(2000)";
            // 
            // PlayerNameLabel
            // 
            PlayerNameLabel.AutoSize = true;
            PlayerNameLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PlayerNameLabel.ForeColor = SystemColors.Control;
            PlayerNameLabel.Location = new Point(117, 4);
            PlayerNameLabel.Name = "PlayerNameLabel";
            PlayerNameLabel.Size = new Size(96, 30);
            PlayerNameLabel.TabIndex = 13;
            PlayerNameLabel.Text = "pedreiro";
            // 
            // AvatarPictureBox
            // 
            AvatarPictureBox.BackgroundImage = Properties.Resources.Player_icon1;
            AvatarPictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            AvatarPictureBox.Location = new Point(75, 3);
            AvatarPictureBox.Name = "AvatarPictureBox";
            AvatarPictureBox.Size = new Size(36, 30);
            AvatarPictureBox.TabIndex = 8;
            AvatarPictureBox.TabStop = false;
            // 
            // LeaderboardRankLabel
            // 
            LeaderboardRankLabel.AutoSize = true;
            LeaderboardRankLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LeaderboardRankLabel.ForeColor = SystemColors.Control;
            LeaderboardRankLabel.Location = new Point(11, 3);
            LeaderboardRankLabel.Name = "LeaderboardRankLabel";
            LeaderboardRankLabel.Size = new Size(58, 30);
            LeaderboardRankLabel.TabIndex = 10;
            LeaderboardRankLabel.Text = "#100";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(5, 40);
            panel1.TabIndex = 14;
            // 
            // CompactPlayerCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(panel1);
            Controls.Add(LeaderboardRankLabel);
            Controls.Add(PlayerRatingLabel);
            Controls.Add(PlayerNameLabel);
            Controls.Add(AvatarPictureBox);
            Margin = new Padding(3, 3, 3, 6);
            Name = "CompactPlayerCard";
            Size = new Size(740, 40);
            ((System.ComponentModel.ISupportInitialize)AvatarPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PlayerRatingLabel;
        private Label PlayerNameLabel;
        private PictureBox AvatarPictureBox;
        private Label LeaderboardRankLabel;
        private Panel panel1;
    }
}
