namespace Csharp_and_Database
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            txtNome = new TextBox();
            txtSenha = new TextBox();
            btnLogar = new Button();
            btnCancel = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(538, 195);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(215, 23);
            txtNome.TabIndex = 0;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(538, 141);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(215, 23);
            txtSenha.TabIndex = 1;
            // 
            // btnLogar
            // 
            btnLogar.BackColor = Color.Transparent;
            btnLogar.FlatStyle = FlatStyle.Popup;
            btnLogar.ForeColor = Color.White;
            btnLogar.Location = new Point(538, 256);
            btnLogar.Name = "btnLogar";
            btnLogar.Size = new Size(215, 29);
            btnLogar.TabIndex = 4;
            btnLogar.UseVisualStyleBackColor = false;
            btnLogar.Click += btnLogar_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Transparent;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.Black;
            btnCancel.Location = new Point(713, 398);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(109, 73);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 181, 255);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(-7, -2);
            button1.Name = "button1";
            button1.Size = new Size(120, 33);
            button1.TabIndex = 6;
            button1.Text = "Teste a conexão";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(527, 229);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(244, 16);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(523, 293);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(244, 16);
            textBox2.TabIndex = 8;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(803, 450);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(btnCancel);
            Controls.Add(btnLogar);
            Controls.Add(txtSenha);
            Controls.Add(txtNome);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtSenha;
        private Button btnLogar;
        private Button btnCancel;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}