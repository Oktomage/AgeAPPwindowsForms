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
            panel1 = new Panel();
            ListSizeComboBox = new ComboBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // FlowLayouPanel
            // 
            FlowLayouPanel.BackColor = Color.Transparent;
            FlowLayouPanel.Dock = DockStyle.Bottom;
            FlowLayouPanel.Location = new Point(0, 44);
            FlowLayouPanel.Name = "FlowLayouPanel";
            FlowLayouPanel.Size = new Size(614, 802);
            FlowLayouPanel.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(ListSizeComboBox);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(614, 38);
            panel1.TabIndex = 0;
            // 
            // ListSizeComboBox
            // 
            ListSizeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ListSizeComboBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ListSizeComboBox.FormattingEnabled = true;
            ListSizeComboBox.Items.AddRange(new object[] { "10", "30", "50" });
            ListSizeComboBox.Location = new Point(176, 6);
            ListSizeComboBox.Name = "ListSizeComboBox";
            ListSizeComboBox.Size = new Size(67, 29);
            ListSizeComboBox.TabIndex = 1;
            ListSizeComboBox.SelectedIndexChanged += ListSizeComboBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(158, 25);
            label1.TabIndex = 0;
            label1.Text = "Tamanho da lista:";
            // 
            // MatchesHistoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.admin_bg;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(614, 846);
            Controls.Add(panel1);
            Controls.Add(FlowLayouPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MatchesHistoryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Histórico de partidas";
            Load += MatchesHistoryForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Classes.SmoothFlowLayoutPanel FlowLayouPanel;
        private Panel panel1;
        private Label label1;
        private ComboBox ListSizeComboBox;
    }
}