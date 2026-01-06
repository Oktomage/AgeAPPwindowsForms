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
            FlowLayouPanel = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // FlowLayouPanel
            // 
            FlowLayouPanel.AutoScroll = true;
            FlowLayouPanel.Dock = DockStyle.Fill;
            FlowLayouPanel.FlowDirection = FlowDirection.TopDown;
            FlowLayouPanel.Location = new Point(0, 0);
            FlowLayouPanel.Name = "FlowLayouPanel";
            FlowLayouPanel.Size = new Size(913, 846);
            FlowLayouPanel.TabIndex = 0;
            FlowLayouPanel.WrapContents = false;
            // 
            // MatchesHistoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(913, 846);
            Controls.Add(FlowLayouPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MatchesHistoryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registros";
            Load += MatchesHistoryForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel FlowLayouPanel;
    }
}