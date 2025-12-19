
namespace AgeAPP.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            TextBoxPassword = new TextBox();
            TextBoxLoginName = new TextBox();
            LogInButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.Civ_details_bg;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(TextBoxPassword);
            panel1.Controls.Add(TextBoxLoginName);
            panel1.Controls.Add(LogInButton);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(245, 161);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(12, 61);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 2;
            label2.Text = "Senha";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 2;
            label1.Text = "Nome";
            // 
            // TextBoxPassword
            // 
            TextBoxPassword.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBoxPassword.Location = new Point(12, 79);
            TextBoxPassword.Name = "TextBoxPassword";
            TextBoxPassword.PlaceholderText = "Senha de admin";
            TextBoxPassword.Size = new Size(223, 29);
            TextBoxPassword.TabIndex = 2;
            // 
            // TextBoxLoginName
            // 
            TextBoxLoginName.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBoxLoginName.Location = new Point(12, 29);
            TextBoxLoginName.Name = "TextBoxLoginName";
            TextBoxLoginName.PlaceholderText = "Nome de usuario";
            TextBoxLoginName.Size = new Size(223, 29);
            TextBoxLoginName.TabIndex = 1;
            // 
            // LogInButton
            // 
            LogInButton.BackgroundImage = Properties.Resources.button_wide_normal;
            LogInButton.BackgroundImageLayout = ImageLayout.Stretch;
            LogInButton.FlatStyle = FlatStyle.Flat;
            LogInButton.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LogInButton.ForeColor = SystemColors.Control;
            LogInButton.Location = new Point(122, 113);
            LogInButton.Name = "LogInButton";
            LogInButton.Size = new Size(113, 45);
            LogInButton.TabIndex = 3;
            LogInButton.Text = "Entrar";
            LogInButton.UseVisualStyleBackColor = true;
            LogInButton.Click += LogInButton_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(245, 161);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += LoginForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button LogInButton;
        private TextBox TextBoxLoginName;
        private Label label1;
        private Label label2;
        private TextBox TextBoxPassword;
    }
}