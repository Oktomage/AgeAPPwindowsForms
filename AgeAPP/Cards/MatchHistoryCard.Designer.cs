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
            MapPictureBox = new PictureBox();
            DateLabel = new Label();
            DeltaRatingLabel = new Label();
            ListViewTeamA = new ListView();
            label1 = new Label();
            ListViewTeamB = new ListView();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            TeamAsymbolPictureBox = new PictureBox();
            TeamBsymbolPictureBox = new PictureBox();
            pictureBox5 = new PictureBox();
            LogAuthorLabel = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)MapPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TeamAsymbolPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TeamBsymbolPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // MapNameLabel
            // 
            MapNameLabel.AutoSize = true;
            MapNameLabel.BackColor = Color.Black;
            MapNameLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MapNameLabel.ForeColor = Color.White;
            MapNameLabel.Location = new Point(170, 0);
            MapNameLabel.Name = "MapNameLabel";
            MapNameLabel.Size = new Size(177, 32);
            MapNameLabel.TabIndex = 0;
            MapNameLabel.Text = "Floresta negra";
            MapNameLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // MapPictureBox
            // 
            MapPictureBox.Anchor = AnchorStyles.Left;
            MapPictureBox.BackColor = Color.Transparent;
            MapPictureBox.BackgroundImage = Properties.Resources.UnkownMap;
            MapPictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            MapPictureBox.Location = new Point(3, 30);
            MapPictureBox.Name = "MapPictureBox";
            MapPictureBox.Size = new Size(152, 133);
            MapPictureBox.TabIndex = 1;
            MapPictureBox.TabStop = false;
            // 
            // DateLabel
            // 
            DateLabel.Anchor = AnchorStyles.Left;
            DateLabel.BackColor = Color.Black;
            DateLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            DateLabel.ForeColor = Color.White;
            DateLabel.Location = new Point(76, 177);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(189, 24);
            DateLabel.TabIndex = 0;
            DateLabel.Text = "[25/12/2025]";
            DateLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // DeltaRatingLabel
            // 
            DeltaRatingLabel.AutoSize = true;
            DeltaRatingLabel.BackColor = Color.Black;
            DeltaRatingLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DeltaRatingLabel.ForeColor = Color.White;
            DeltaRatingLabel.Location = new Point(43, 171);
            DeltaRatingLabel.Name = "DeltaRatingLabel";
            DeltaRatingLabel.Size = new Size(27, 32);
            DeltaRatingLabel.TabIndex = 0;
            DeltaRatingLabel.Text = "4";
            DeltaRatingLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // ListViewTeamA
            // 
            ListViewTeamA.BackColor = SystemColors.ActiveCaptionText;
            ListViewTeamA.Font = new Font("Arial", 9F);
            ListViewTeamA.Location = new Point(170, 60);
            ListViewTeamA.Name = "ListViewTeamA";
            ListViewTeamA.Size = new Size(209, 81);
            ListViewTeamA.TabIndex = 2;
            ListViewTeamA.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Segoe UI", 9.75F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(170, 41);
            label1.Name = "label1";
            label1.Size = new Size(48, 17);
            label1.TabIndex = 0;
            label1.Text = "Time A";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // ListViewTeamB
            // 
            ListViewTeamB.BackColor = SystemColors.ActiveCaptionText;
            ListViewTeamB.Font = new Font("Arial", 9F);
            ListViewTeamB.Location = new Point(458, 61);
            ListViewTeamB.Name = "ListViewTeamB";
            ListViewTeamB.Size = new Size(209, 81);
            ListViewTeamB.TabIndex = 2;
            ListViewTeamB.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Segoe UI", 9.75F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(458, 41);
            label2.Name = "label2";
            label2.Size = new Size(47, 17);
            label2.TabIndex = 0;
            label2.Text = "Time B";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = Properties.Resources.delta2;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(3, 168);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(34, 34);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // TeamAsymbolPictureBox
            // 
            TeamAsymbolPictureBox.BackColor = Color.Transparent;
            TeamAsymbolPictureBox.BackgroundImage = Properties.Resources.Winner_icon;
            TeamAsymbolPictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            TeamAsymbolPictureBox.Location = new Point(341, 143);
            TeamAsymbolPictureBox.Name = "TeamAsymbolPictureBox";
            TeamAsymbolPictureBox.Size = new Size(38, 34);
            TeamAsymbolPictureBox.TabIndex = 3;
            TeamAsymbolPictureBox.TabStop = false;
            // 
            // TeamBsymbolPictureBox
            // 
            TeamBsymbolPictureBox.BackColor = Color.Transparent;
            TeamBsymbolPictureBox.BackgroundImage = Properties.Resources.Defeat_icon;
            TeamBsymbolPictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            TeamBsymbolPictureBox.Location = new Point(458, 143);
            TeamBsymbolPictureBox.Name = "TeamBsymbolPictureBox";
            TeamBsymbolPictureBox.Size = new Size(38, 34);
            TeamBsymbolPictureBox.TabIndex = 3;
            TeamBsymbolPictureBox.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.BackgroundImage = Properties.Resources.battle_event_icon;
            pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox5.Location = new Point(385, 80);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(67, 61);
            pictureBox5.TabIndex = 3;
            pictureBox5.TabStop = false;
            // 
            // LogAuthorLabel
            // 
            LogAuthorLabel.AutoSize = true;
            LogAuthorLabel.BackColor = Color.Black;
            LogAuthorLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LogAuthorLabel.ForeColor = Color.White;
            LogAuthorLabel.Location = new Point(3, 0);
            LogAuthorLabel.Name = "LogAuthorLabel";
            LogAuthorLabel.Size = new Size(58, 17);
            LogAuthorLabel.TabIndex = 0;
            LogAuthorLabel.Text = "Log por:";
            LogAuthorLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 208);
            panel1.Name = "panel1";
            panel1.Size = new Size(679, 5);
            panel1.TabIndex = 4;
            // 
            // MatchHistoryCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BackgroundImageLayout = ImageLayout.None;
            Controls.Add(panel1);
            Controls.Add(TeamBsymbolPictureBox);
            Controls.Add(pictureBox5);
            Controls.Add(TeamAsymbolPictureBox);
            Controls.Add(pictureBox2);
            Controls.Add(ListViewTeamB);
            Controls.Add(ListViewTeamA);
            Controls.Add(MapPictureBox);
            Controls.Add(label2);
            Controls.Add(LogAuthorLabel);
            Controls.Add(label1);
            Controls.Add(DateLabel);
            Controls.Add(DeltaRatingLabel);
            Controls.Add(MapNameLabel);
            Margin = new Padding(0, 0, 0, 15);
            Name = "MatchHistoryCard";
            Size = new Size(679, 213);
            ((System.ComponentModel.ISupportInitialize)MapPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)TeamAsymbolPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)TeamBsymbolPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MapNameLabel;
        private PictureBox MapPictureBox;
        private Label DateLabel;
        private Label DeltaRatingLabel;
        private ListView ListViewTeamA;
        private Label label1;
        private ListView ListViewTeamB;
        private Label label2;
        private PictureBox pictureBox2;
        private PictureBox TeamAsymbolPictureBox;
        private PictureBox TeamBsymbolPictureBox;
        private PictureBox pictureBox5;
        private Label LogAuthorLabel;
        private Panel panel1;
    }
}
