namespace AgeAPP.Forms
{
    partial class CreateNewPlayerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateNewPlayerForm));
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            TextBoxPlayerRating = new TextBox();
            TextBoxPlayerName = new TextBox();
            CreateButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(TextBoxPlayerRating);
            panel1.Controls.Add(TextBoxPlayerName);
            panel1.Controls.Add(CreateButton);
            panel1.Location = new Point(3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(244, 145);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 61);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 2;
            label2.Text = "Rating";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 2;
            label1.Text = "Nome";
            // 
            // TextBoxPlayerRating
            // 
            TextBoxPlayerRating.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBoxPlayerRating.Location = new Point(12, 79);
            TextBoxPlayerRating.Name = "TextBoxPlayerRating";
            TextBoxPlayerRating.PlaceholderText = "Rating do jogador";
            TextBoxPlayerRating.Size = new Size(223, 29);
            TextBoxPlayerRating.TabIndex = 2;
            TextBoxPlayerRating.KeyPress += TextBoxPlayerRating_KeyPress;
            // 
            // TextBoxPlayerName
            // 
            TextBoxPlayerName.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBoxPlayerName.Location = new Point(12, 29);
            TextBoxPlayerName.Name = "TextBoxPlayerName";
            TextBoxPlayerName.PlaceholderText = "Nome do jogador";
            TextBoxPlayerName.Size = new Size(223, 29);
            TextBoxPlayerName.TabIndex = 1;
            // 
            // CreateButton
            // 
            CreateButton.Location = new Point(133, 113);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new Size(102, 29);
            CreateButton.TabIndex = 3;
            CreateButton.Text = "Criar";
            CreateButton.UseVisualStyleBackColor = true;
            CreateButton.Click += CreateButton_Click;
            // 
            // CreateNewPlayerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(247, 146);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "CreateNewPlayerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Novo jogador";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private TextBox TextBoxPlayerRating;
        private TextBox TextBoxPlayerName;
        private Button CreateButton;
    }
}