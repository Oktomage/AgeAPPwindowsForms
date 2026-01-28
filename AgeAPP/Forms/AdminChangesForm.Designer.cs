namespace AgeAPP.Forms
{
    partial class AdminChangesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminChangesForm));
            FlowLayoutPanel = new AgeAPP.Classes.SmoothFlowLayoutPanel();
            SuspendLayout();
            // 
            // FlowLayoutPanel
            // 
            FlowLayoutPanel.BackColor = Color.Transparent;
            FlowLayoutPanel.Dock = DockStyle.Fill;
            FlowLayoutPanel.Location = new Point(0, 0);
            FlowLayoutPanel.Name = "FlowLayoutPanel";
            FlowLayoutPanel.Padding = new Padding(10);
            FlowLayoutPanel.Size = new Size(504, 734);
            FlowLayoutPanel.TabIndex = 0;
            // 
            // AdminChangesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Holidays_1920x1080;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(504, 734);
            Controls.Add(FlowLayoutPanel);
            DoubleBuffered = true;
            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "AdminChangesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Histórico ADMIN";
            Load += AdminChangesForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Classes.SmoothFlowLayoutPanel FlowLayoutPanel;
    }
}