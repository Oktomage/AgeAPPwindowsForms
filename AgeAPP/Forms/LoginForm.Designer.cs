
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
            label2 = new Label();
            label1 = new Label();
            TextBoxPassword = new TextBox();
            TextBoxLoginName = new TextBox();
            LogInButton = new Button();
            RegisterButton = new Button();
            panel2 = new Panel();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Segoe UI", 9F);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(9, 71);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 2;
            label2.Text = "Senha";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Segoe UI", 9F);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(9, 8);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 2;
            label1.Text = "Nome";
            // 
            // TextBoxPassword
            // 
            TextBoxPassword.Font = new Font("Segoe UI", 14.25F);
            TextBoxPassword.Location = new Point(9, 89);
            TextBoxPassword.Name = "TextBoxPassword";
            TextBoxPassword.PlaceholderText = "Senha de admin";
            TextBoxPassword.Size = new Size(260, 33);
            TextBoxPassword.TabIndex = 2;
            // 
            // TextBoxLoginName
            // 
            TextBoxLoginName.Font = new Font("Segoe UI", 14.25F);
            TextBoxLoginName.Location = new Point(9, 26);
            TextBoxLoginName.Name = "TextBoxLoginName";
            TextBoxLoginName.PlaceholderText = "Nome de usuario";
            TextBoxLoginName.Size = new Size(260, 33);
            TextBoxLoginName.TabIndex = 1;
            // 
            // LogInButton
            // 
            LogInButton.BackgroundImage = Properties.Resources.button_wide_normal;
            LogInButton.BackgroundImageLayout = ImageLayout.Stretch;
            LogInButton.FlatStyle = FlatStyle.Flat;
            LogInButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LogInButton.ForeColor = Color.White;
            LogInButton.Location = new Point(155, 153);
            LogInButton.Name = "LogInButton";
            LogInButton.Size = new Size(113, 45);
            LogInButton.TabIndex = 3;
            LogInButton.Text = "Entrar";
            LogInButton.UseVisualStyleBackColor = true;
            LogInButton.Click += LogInButton_Click;
            // 
            // RegisterButton
            // 
            RegisterButton.BackgroundImage = Properties.Resources.button_wide_normal;
            RegisterButton.BackgroundImageLayout = ImageLayout.Stretch;
            RegisterButton.FlatStyle = FlatStyle.Flat;
            RegisterButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RegisterButton.ForeColor = Color.White;
            RegisterButton.Location = new Point(9, 153);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(113, 45);
            RegisterButton.TabIndex = 3;
            RegisterButton.Text = "Registrar";
            RegisterButton.UseVisualStyleBackColor = true;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(LogInButton);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(RegisterButton);
            panel2.Controls.Add(TextBoxPassword);
            panel2.Controls.Add(TextBoxLoginName);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(280, 210);
            panel2.TabIndex = 4;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(280, 210);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += LoginForm_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button LogInButton;
        private TextBox TextBoxLoginName;
        private Label label1;
        private Label label2;
        private TextBox TextBoxPassword;
        private Button RegisterButton;
        private Panel panel2;
    }
}