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
            ListSizeComboBox = new ComboBox();
            label1 = new Label();
            LoadingLabel = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // FlowLayoutPanel
            // 
            FlowLayoutPanel.BackColor = Color.Transparent;
            FlowLayoutPanel.Dock = DockStyle.Bottom;
            FlowLayoutPanel.Location = new Point(0, 51);
            FlowLayoutPanel.Name = "FlowLayoutPanel";
            FlowLayoutPanel.Padding = new Padding(10);
            FlowLayoutPanel.Size = new Size(504, 683);
            FlowLayoutPanel.TabIndex = 0;
            // 
            // ListSizeComboBox
            // 
            ListSizeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ListSizeComboBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ListSizeComboBox.FormattingEnabled = true;
            ListSizeComboBox.Items.AddRange(new object[] { "10", "30", "50" });
            ListSizeComboBox.Location = new Point(176, 9);
            ListSizeComboBox.Name = "ListSizeComboBox";
            ListSizeComboBox.Size = new Size(67, 29);
            ListSizeComboBox.TabIndex = 1;
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
            // LoadingLabel
            // 
            LoadingLabel.AutoSize = true;
            LoadingLabel.BackColor = Color.Transparent;
            LoadingLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoadingLabel.ForeColor = Color.White;
            LoadingLabel.Location = new Point(368, 9);
            LoadingLabel.Name = "LoadingLabel";
            LoadingLabel.Size = new Size(124, 25);
            LoadingLabel.TabIndex = 0;
            LoadingLabel.Text = "Carregando...";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(LoadingLabel);
            panel1.Controls.Add(ListSizeComboBox);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(504, 45);
            panel1.TabIndex = 2;
            // 
            // AdminChangesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Holidays_1920x1080;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(504, 734);
            Controls.Add(panel1);
            Controls.Add(FlowLayoutPanel);
            DoubleBuffered = true;
            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "AdminChangesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Histórico administrativo";
            Load += AdminChangesForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Classes.SmoothFlowLayoutPanel FlowLayoutPanel;
        private ComboBox ListSizeComboBox;
        private Label label1;
        private Label LoadingLabel;
        private Panel panel1;
    }
}