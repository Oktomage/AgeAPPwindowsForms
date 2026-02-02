namespace AgeAPP.Cards
{
    partial class MapCard
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
            panel1 = new Panel();
            MapMatchesLabel = new Label();
            MapNameLabel = new Label();
            MapPictureBox = new PictureBox();
            MapStyleLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)MapPictureBox).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(5, 97);
            panel1.TabIndex = 7;
            // 
            // MapMatchesLabel
            // 
            MapMatchesLabel.Anchor = AnchorStyles.Left;
            MapMatchesLabel.AutoSize = true;
            MapMatchesLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MapMatchesLabel.ForeColor = SystemColors.Control;
            MapMatchesLabel.Location = new Point(117, 77);
            MapMatchesLabel.Name = "MapMatchesLabel";
            MapMatchesLabel.Size = new Size(83, 17);
            MapMatchesLabel.TabIndex = 4;
            MapMatchesLabel.Text = "Partidas: 999";
            // 
            // MapNameLabel
            // 
            MapNameLabel.Anchor = AnchorStyles.Left;
            MapNameLabel.AutoSize = true;
            MapNameLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MapNameLabel.ForeColor = SystemColors.Control;
            MapNameLabel.Location = new Point(117, 3);
            MapNameLabel.Name = "MapNameLabel";
            MapNameLabel.Size = new Size(171, 30);
            MapNameLabel.TabIndex = 6;
            MapNameLabel.Text = "Clareira africana";
            // 
            // MapPictureBox
            // 
            MapPictureBox.Anchor = AnchorStyles.Left;
            MapPictureBox.BackgroundImage = Properties.Resources.UnkownMap;
            MapPictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            MapPictureBox.Location = new Point(11, 3);
            MapPictureBox.Name = "MapPictureBox";
            MapPictureBox.Size = new Size(100, 91);
            MapPictureBox.TabIndex = 3;
            MapPictureBox.TabStop = false;
            // 
            // MapStyleLabel
            // 
            MapStyleLabel.Anchor = AnchorStyles.Left;
            MapStyleLabel.AutoSize = true;
            MapStyleLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MapStyleLabel.ForeColor = SystemColors.Control;
            MapStyleLabel.Location = new Point(117, 33);
            MapStyleLabel.Name = "MapStyleLabel";
            MapStyleLabel.Size = new Size(70, 21);
            MapStyleLabel.TabIndex = 4;
            MapStyleLabel.Text = "Nomade";
            // 
            // MapCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(panel1);
            Controls.Add(MapStyleLabel);
            Controls.Add(MapMatchesLabel);
            Controls.Add(MapNameLabel);
            Controls.Add(MapPictureBox);
            Margin = new Padding(3, 3, 3, 10);
            Name = "MapCard";
            Size = new Size(740, 97);
            ((System.ComponentModel.ISupportInitialize)MapPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label MapMatchesLabel;
        private Label MapNameLabel;
        private PictureBox MapPictureBox;
        private Label MapStyleLabel;
    }
}
