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
            pictureBox1 = new PictureBox();
            FlowLayouPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // FlowLayouPanel
            // 
            FlowLayouPanel.AutoScroll = true;
            FlowLayouPanel.Controls.Add(pictureBox1);
            FlowLayouPanel.Dock = DockStyle.Fill;
            FlowLayouPanel.FlowDirection = FlowDirection.TopDown;
            FlowLayouPanel.Location = new Point(0, 0);
            FlowLayouPanel.Name = "FlowLayouPanel";
            FlowLayouPanel.Size = new Size(432, 450);
            FlowLayouPanel.TabIndex = 0;
            FlowLayouPanel.WrapContents = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.BackgroundImage = Properties.Resources.UnkownMap;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(196, 188);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // MatchesHistoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 450);
            Controls.Add(FlowLayouPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MatchesHistoryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registros";
            Load += MatchesHistoryForm_Load;
            FlowLayouPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel FlowLayouPanel;
        private PictureBox pictureBox1;
    }
}