namespace AgeAPP.Forms
{
    partial class EditPlayerAvatarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditPlayerAvatarForm));
            AvatarsLayoutPanel = new FlowLayoutPanel();
            label4 = new Label();
            ConfirmButton = new Button();
            SuspendLayout();
            // 
            // AvatarsLayoutPanel
            // 
            AvatarsLayoutPanel.AutoScroll = true;
            AvatarsLayoutPanel.BackColor = SystemColors.ControlDark;
            AvatarsLayoutPanel.Location = new Point(12, 34);
            AvatarsLayoutPanel.Name = "AvatarsLayoutPanel";
            AvatarsLayoutPanel.Padding = new Padding(5);
            AvatarsLayoutPanel.Size = new Size(512, 257);
            AvatarsLayoutPanel.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Black;
            label4.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(262, 22);
            label4.TabIndex = 6;
            label4.Text = "Selecione o avatar do jogador";
            // 
            // ConfirmButton
            // 
            ConfirmButton.BackgroundImage = Properties.Resources.button_wide_normal;
            ConfirmButton.BackgroundImageLayout = ImageLayout.Stretch;
            ConfirmButton.FlatStyle = FlatStyle.Flat;
            ConfirmButton.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ConfirmButton.ForeColor = SystemColors.Control;
            ConfirmButton.Location = new Point(378, 297);
            ConfirmButton.Name = "ConfirmButton";
            ConfirmButton.Size = new Size(146, 44);
            ConfirmButton.TabIndex = 8;
            ConfirmButton.Text = "Confirmar";
            ConfirmButton.UseVisualStyleBackColor = true;
            ConfirmButton.Click += ConfirmButton_Click;
            // 
            // EditPlayerAvatarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.aoe2_de_uhd_2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(532, 348);
            Controls.Add(ConfirmButton);
            Controls.Add(AvatarsLayoutPanel);
            Controls.Add(label4);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "EditPlayerAvatarForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editando avatar...";
            Load += EditPlayerAvatarForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel AvatarsLayoutPanel;
        private Label label4;
        private Button ConfirmButton;
    }
}