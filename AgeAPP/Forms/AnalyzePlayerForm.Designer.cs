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
            smoothFlowLayoutPanel1 = new AgeAPP.Classes.SmoothFlowLayoutPanel();
            PlayerNameLabel = new Label();
            FormChartPlot = new ScottPlot.WinForms.FormsPlot();
            smoothFlowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // smoothFlowLayoutPanel1
            // 
            smoothFlowLayoutPanel1.BackColor = Color.Black;
            smoothFlowLayoutPanel1.Controls.Add(PlayerNameLabel);
            smoothFlowLayoutPanel1.Dock = DockStyle.Top;
            smoothFlowLayoutPanel1.Location = new Point(0, 0);
            smoothFlowLayoutPanel1.Name = "smoothFlowLayoutPanel1";
            smoothFlowLayoutPanel1.Size = new Size(721, 48);
            smoothFlowLayoutPanel1.TabIndex = 0;
            // 
            // PlayerNameLabel
            // 
            PlayerNameLabel.AutoSize = true;
            PlayerNameLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PlayerNameLabel.ForeColor = Color.White;
            PlayerNameLabel.Location = new Point(3, 0);
            PlayerNameLabel.Name = "PlayerNameLabel";
            PlayerNameLabel.Size = new Size(78, 32);
            PlayerNameLabel.TabIndex = 0;
            PlayerNameLabel.Text = "label1";
            // 
            // FormChartPlot
            // 
            FormChartPlot.DisplayScale = 1F;
            FormChartPlot.Location = new Point(0, 48);
            FormChartPlot.Name = "FormChartPlot";
            FormChartPlot.Size = new Size(721, 391);
            FormChartPlot.TabIndex = 1;
            // 
            // AnalyzePlayerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Holidays_1920x1080;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(721, 439);
            Controls.Add(FormChartPlot);
            Controls.Add(smoothFlowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "AnalyzePlayerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AnalyzePlayerForm";
            Load += AnalyzePlayerForm_Load;
            smoothFlowLayoutPanel1.ResumeLayout(false);
            smoothFlowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Classes.SmoothFlowLayoutPanel smoothFlowLayoutPanel1;
        private ScottPlot.WinForms.FormsPlot FormChartPlot;
        private Label PlayerNameLabel;
    }
}