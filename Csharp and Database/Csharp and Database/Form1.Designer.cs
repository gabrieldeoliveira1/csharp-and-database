namespace Csharp_and_Database
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnConnection = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNome = new TextBox();
            txtIdade = new TextBox();
            txtSenha = new TextBox();
            txtEmail = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // BtnConnection
            // 
            BtnConnection.BackColor = Color.Gray;
            BtnConnection.FlatStyle = FlatStyle.System;
            BtnConnection.Font = new Font("Sitka Small", 9F, FontStyle.Underline, GraphicsUnit.Point);
            BtnConnection.ForeColor = Color.Gray;
            BtnConnection.Location = new Point(-1, 0);
            BtnConnection.Name = "BtnConnection";
            BtnConnection.Size = new Size(167, 542);
            BtnConnection.TabIndex = 0;
            BtnConnection.Text = "Teste de conexão";
            BtnConnection.UseVisualStyleBackColor = false;
            BtnConnection.Click += BtnConnection_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(303, 127);
            label1.Name = "label1";
            label1.Size = new Size(46, 18);
            label1.TabIndex = 1;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(303, 309);
            label2.Name = "label2";
            label2.Size = new Size(47, 18);
            label2.TabIndex = 2;
            label2.Text = "Idade:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(694, 127);
            label3.Name = "label3";
            label3.Size = new Size(47, 18);
            label3.TabIndex = 3;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(694, 309);
            label4.Name = "label4";
            label4.Size = new Size(51, 18);
            label4.TabIndex = 4;
            label4.Text = "Senha:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(260, 148);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(130, 25);
            txtNome.TabIndex = 5;
            // 
            // txtIdade
            // 
            txtIdade.Location = new Point(260, 330);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(130, 25);
            txtIdade.TabIndex = 6;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(654, 330);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(130, 25);
            txtSenha.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(654, 148);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(130, 25);
            txtEmail.TabIndex = 8;
            // 
            // button2
            // 
            button2.Location = new Point(437, 428);
            button2.Name = "button2";
            button2.Size = new Size(157, 78);
            button2.TabIndex = 10;
            button2.Text = "Cadastrar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(914, 540);
            Controls.Add(button2);
            Controls.Add(txtEmail);
            Controls.Add(txtSenha);
            Controls.Add(txtIdade);
            Controls.Add(txtNome);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnConnection);
            Font = new Font("Swis721 BlkCn BT", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnConnection;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNome;
        private TextBox txtIdade;
        private TextBox txtSenha;
        private TextBox txtEmail;
        private Button button2;
    }
}
