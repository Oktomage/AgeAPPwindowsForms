namespace AgeAPP.Forms
{
    partial class AnalyzePlayerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnalyzePlayerForm));
            PlayerNameLabel = new Label();
            FormChartPlot = new ScottPlot.WinForms.FormsPlot();
            panel1 = new Panel();
            LoadingLabel = new Label();
            panel2 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // PlayerNameLabel
            // 
            PlayerNameLabel.AutoSize = true;
            PlayerNameLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PlayerNameLabel.ForeColor = Color.White;
            PlayerNameLabel.Location = new Point(10, 7);
            PlayerNameLabel.Name = "PlayerNameLabel";
            PlayerNameLabel.Size = new Size(78, 32);
            PlayerNameLabel.TabIndex = 0;
            PlayerNameLabel.Text = "label1";
            // 
            // FormChartPlot
            // 
            FormChartPlot.DisplayScale = 1F;
            FormChartPlot.Location = new Point(2, 44);
            FormChartPlot.Name = "FormChartPlot";
            FormChartPlot.Size = new Size(721, 391);
            FormChartPlot.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(LoadingLabel);
            panel1.Controls.Add(PlayerNameLabel);
            panel1.Location = new Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(721, 45);
            panel1.TabIndex = 2;
            // 
            // LoadingLabel
            // 
            LoadingLabel.AutoSize = true;
            LoadingLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoadingLabel.ForeColor = Color.White;
            LoadingLabel.Location = new Point(554, 7);
            LoadingLabel.Name = "LoadingLabel";
            LoadingLabel.Size = new Size(153, 32);
            LoadingLabel.TabIndex = 0;
            LoadingLabel.Text = "Carregando...";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(2, 433);
            panel2.Name = "panel2";
            panel2.Size = new Size(721, 40);
            panel2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(10, 9);
            label1.Name = "label1";
            label1.Size = new Size(323, 21);
            label1.TabIndex = 0;
            label1.Text = "Este são os ultimos 200 registros do jogador...";
            // 
            // AnalyzePlayerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(721, 472);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(FormChartPlot);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "AnalyzePlayerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Analisando jogador...";
            Load += AnalyzePlayerForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ScottPlot.WinForms.FormsPlot FormChartPlot;
        private Label PlayerNameLabel;
        private Panel panel1;
        private Label LoadingLabel;
        private Panel panel2;
        private Label label1;
    }
}