namespace AgeAPP.Forms
{
    partial class MatchesHistoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MatchesHistoryForm));
            FlowLayouPanel = new AgeAPP.Classes.SmoothFlowLayoutPanel();
            SuspendLayout();
            // 
            // FlowLayouPanel
            // 
            FlowLayouPanel.BackColor = Color.Transparent;
            FlowLayouPanel.Location = new Point(1, 2);
            FlowLayouPanel.Name = "FlowLayouPanel";
            FlowLayouPanel.Size = new Size(614, 844);
            FlowLayouPanel.TabIndex = 0;
            // 
            // MatchesHistoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.admin_bg;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(614, 846);
            Controls.Add(FlowLayouPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MatchesHistoryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Histórico";
            Load += MatchesHistoryForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Classes.SmoothFlowLayoutPanel FlowLayouPanel;
    }
}