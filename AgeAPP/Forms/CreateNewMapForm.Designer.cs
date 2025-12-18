namespace AgeAPP.Forms
{
    partial class CreateNewMapForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateNewMapForm));
            panel1 = new Panel();
            MapTypeComboBox = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            TextBoxMapName = new TextBox();
            CreateButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(MapTypeComboBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(TextBoxMapName);
            panel1.Controls.Add(CreateButton);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(243, 271);
            panel1.TabIndex = 2;
            // 
            // MapTypeComboBox
            // 
            MapTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            MapTypeComboBox.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MapTypeComboBox.FormattingEnabled = true;
            MapTypeComboBox.Items.AddRange(new object[] { "Padrão", "QS", "Nomade", "Arena", "Hibrido", "Agua" });
            MapTypeComboBox.Location = new Point(12, 88);
            MapTypeComboBox.Name = "MapTypeComboBox";
            MapTypeComboBox.Size = new Size(223, 30);
            MapTypeComboBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9F);
            label2.Location = new Point(12, 70);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 2;
            label2.Text = "Tipo do mapa";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9F);
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 2;
            label1.Text = "Nome";
            // 
            // TextBoxMapName
            // 
            TextBoxMapName.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBoxMapName.Location = new Point(12, 29);
            TextBoxMapName.Name = "TextBoxMapName";
            TextBoxMapName.PlaceholderText = "Nome do mapa";
            TextBoxMapName.Size = new Size(223, 29);
            TextBoxMapName.TabIndex = 1;
            // 
            // CreateButton
            // 
            CreateButton.BackgroundImage = Properties.Resources.button_wide_normal;
            CreateButton.BackgroundImageLayout = ImageLayout.Stretch;
            CreateButton.FlatStyle = FlatStyle.Flat;
            CreateButton.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CreateButton.ForeColor = SystemColors.Control;
            CreateButton.Location = new Point(89, 215);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new Size(146, 44);
            CreateButton.TabIndex = 3;
            CreateButton.Text = "Criar";
            CreateButton.UseVisualStyleBackColor = true;
            CreateButton.Click += CreateButton_Click;
            // 
            // CreateNewMapForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(243, 271);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "CreateNewMapForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Novo mapa";
            Load += CreateNewMapForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private TextBox TextBoxMapName;
        private Button CreateButton;
        private ComboBox MapTypeComboBox;
    }
}