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
            ListViewWinnerTeam = new ListView();
            label1 = new Label();
            ListViewLoserTeam = new ListView();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            LogAuthorLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // MapNameLabel
            // 
            MapNameLabel.AutoSize = true;
            MapNameLabel.BackColor = Color.Black;
            MapNameLabel.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MapNameLabel.ForeColor = Color.White;
            MapNameLabel.Location = new Point(161, 3);
            MapNameLabel.Name = "MapNameLabel";
            MapNameLabel.Size = new Size(178, 29);
            MapNameLabel.TabIndex = 0;
            MapNameLabel.Text = "Floresta negra";
            MapNameLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.BackgroundImage = Properties.Resources.UnkownMap;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(3, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(152, 133);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // DateLabel
            // 
            DateLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DateLabel.BackColor = Color.Black;
            DateLabel.Font = new Font("Arial", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            DateLabel.ForeColor = Color.White;
            DateLabel.Location = new Point(381, 3);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(189, 24);
            DateLabel.TabIndex = 0;
            DateLabel.Text = "[25/12/2025]";
            DateLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // DeltaRatingLabel
            // 
            DeltaRatingLabel.AutoSize = true;
            DeltaRatingLabel.Font = new Font("Arial", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DeltaRatingLabel.ForeColor = Color.White;
            DeltaRatingLabel.Location = new Point(43, 143);
            DeltaRatingLabel.Name = "DeltaRatingLabel";
            DeltaRatingLabel.Size = new Size(31, 33);
            DeltaRatingLabel.TabIndex = 0;
            DeltaRatingLabel.Text = "4";
            DeltaRatingLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // ListViewWinnerTeam
            // 
            ListViewWinnerTeam.BackColor = SystemColors.ActiveCaptionText;
            ListViewWinnerTeam.Font = new Font("Arial", 9F);
            ListViewWinnerTeam.Location = new Point(170, 60);
            ListViewWinnerTeam.Name = "ListViewWinnerTeam";
            ListViewWinnerTeam.Size = new Size(157, 81);
            ListViewWinnerTeam.TabIndex = 2;
            ListViewWinnerTeam.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9.75F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(170, 41);
            label1.Name = "label1";
            label1.Size = new Size(86, 16);
            label1.TabIndex = 0;
            label1.Text = "Time vitorioso";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // ListViewLoserTeam
            // 
            ListViewLoserTeam.BackColor = SystemColors.ActiveCaptionText;
            ListViewLoserTeam.Font = new Font("Arial", 9F);
            ListViewLoserTeam.Location = new Point(406, 60);
            ListViewLoserTeam.Name = "ListViewLoserTeam";
            ListViewLoserTeam.Size = new Size(157, 81);
            ListViewLoserTeam.TabIndex = 2;
            ListViewLoserTeam.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(406, 41);
            label2.Name = "label2";
            label2.Size = new Size(89, 16);
            label2.TabIndex = 0;
            label2.Text = "Time perdedor";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = Properties.Resources.star;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(3, 144);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(34, 34);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = Properties.Resources.Winner_icon;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(170, 142);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(38, 34);
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.BackgroundImage = Properties.Resources.Defeat_icon;
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(525, 142);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(38, 34);
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.BackgroundImage = Properties.Resources.battle_event_icon;
            pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox5.Location = new Point(333, 71);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(67, 61);
            pictureBox5.TabIndex = 3;
            pictureBox5.TabStop = false;
            // 
            // LogAuthorLabel
            // 
            LogAuthorLabel.AutoSize = true;
            LogAuthorLabel.Font = new Font("Arial", 9.75F);
            LogAuthorLabel.ForeColor = Color.White;
            LogAuthorLabel.Location = new Point(3, 181);
            LogAuthorLabel.Name = "LogAuthorLabel";
            LogAuthorLabel.Size = new Size(54, 16);
            LogAuthorLabel.TabIndex = 0;
            LogAuthorLabel.Text = "Log por:";
            LogAuthorLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // MatchHistoryCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(ListViewLoserTeam);
            Controls.Add(ListViewWinnerTeam);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(LogAuthorLabel);
            Controls.Add(label1);
            Controls.Add(DateLabel);
            Controls.Add(DeltaRatingLabel);
            Controls.Add(MapNameLabel);
            Margin = new Padding(0, 0, 0, 10);
            Name = "MatchHistoryCard";
            Size = new Size(573, 202);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MapNameLabel;
        private PictureBox pictureBox1;
        private Label DateLabel;
        private Label DeltaRatingLabel;
        private ListView ListViewWinnerTeam;
        private Label label1;
        private ListView ListViewLoserTeam;
        private Label label2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Label LogAuthorLabel;
    }
}
