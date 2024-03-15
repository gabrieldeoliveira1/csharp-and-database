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
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(12, 92);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(120, 23);
            txtNome.TabIndex = 0;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(12, 190);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(120, 23);
            txtSenha.TabIndex = 1;
            // 
            // btnLogar
            // 
            btnLogar.Location = new Point(182, 115);
            btnLogar.Name = "btnLogar";
            btnLogar.Size = new Size(76, 72);
            btnLogar.TabIndex = 4;
            btnLogar.Text = "Logar";
            btnLogar.UseVisualStyleBackColor = true;
            btnLogar.Click += btnLogar_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(335, 287);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 73);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 327);
            button1.Name = "button1";
            button1.Size = new Size(120, 33);
            button1.TabIndex = 6;
            button1.Text = "Teste a conexão";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(447, 372);
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
    }
}