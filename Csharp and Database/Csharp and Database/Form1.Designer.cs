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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            menuStrip1 = new MenuStrip();
            página1CadastroToolStripMenuItem = new ToolStripMenuItem();
            página3ToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            btnAlterar = new Button();
            button1 = new Button();
            comboBox1 = new ComboBox();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BtnConnection
            // 
            BtnConnection.BackColor = Color.Black;
            BtnConnection.FlatStyle = FlatStyle.System;
            BtnConnection.Font = new Font("Segoe UI", 10.2F, FontStyle.Underline, GraphicsUnit.Point);
            BtnConnection.ForeColor = Color.DodgerBlue;
            BtnConnection.Location = new Point(0, 27);
            BtnConnection.Margin = new Padding(2, 3, 2, 3);
            BtnConnection.Name = "BtnConnection";
            BtnConnection.Size = new Size(130, 628);
            BtnConnection.TabIndex = 0;
            BtnConnection.Text = "Teste de conexão";
            BtnConnection.UseVisualStyleBackColor = false;
            BtnConnection.Click += BtnConnection_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(336, 103);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(70, 28);
            label1.TabIndex = 1;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(336, 157);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(65, 28);
            label2.TabIndex = 2;
            label2.Text = "Idade:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(578, 103);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(63, 28);
            label3.TabIndex = 3;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(578, 157);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(69, 28);
            label4.TabIndex = 4;
            label4.Text = "Senha:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(314, 134);
            txtNome.Margin = new Padding(2, 3, 2, 3);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(105, 28);
            txtNome.TabIndex = 5;
            // 
            // txtIdade
            // 
            txtIdade.Location = new Point(314, 187);
            txtIdade.Margin = new Padding(2, 3, 2, 3);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(105, 28);
            txtIdade.TabIndex = 6;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(554, 187);
            txtSenha.Margin = new Padding(2, 3, 2, 3);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(105, 28);
            txtSenha.TabIndex = 7;
            txtSenha.TextChanged += txtSenha_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(554, 134);
            txtEmail.Margin = new Padding(2, 3, 2, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(105, 28);
            txtEmail.TabIndex = 8;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(423, 134);
            button2.Margin = new Padding(2, 3, 2, 3);
            button2.Name = "button2";
            button2.Size = new Size(126, 78);
            button2.TabIndex = 10;
            button2.Text = "Cadastrar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { página1CadastroToolStripMenuItem, página3ToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(969, 28);
            menuStrip1.TabIndex = 11;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // página1CadastroToolStripMenuItem
            // 
            página1CadastroToolStripMenuItem.Name = "página1CadastroToolStripMenuItem";
            página1CadastroToolStripMenuItem.Size = new Size(152, 24);
            página1CadastroToolStripMenuItem.Text = "Página 1 - Cadastro";
            // 
            // página3ToolStripMenuItem
            // 
            página3ToolStripMenuItem.Name = "página3ToolStripMenuItem";
            página3ToolStripMenuItem.Size = new Size(145, 24);
            página3ToolStripMenuItem.Text = "Página 2 - Porduto";
            página3ToolStripMenuItem.Click += página3ToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(55, 24);
            helpToolStripMenuItem.Text = "Help";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(149, 381);
            dataGridView1.Margin = new Padding(2, 3, 2, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 202);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnAlterar
            // 
            btnAlterar.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnAlterar.Location = new Point(423, 218);
            btnAlterar.Margin = new Padding(2, 3, 2, 3);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(126, 29);
            btnAlterar.TabIndex = 13;
            btnAlterar.Text = "Alterar dados";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(423, 253);
            button1.Margin = new Padding(2, 3, 2, 3);
            button1.Name = "button1";
            button1.Size = new Size(126, 29);
            button1.TabIndex = 14;
            button1.Text = "Excluir dados";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(423, 288);
            comboBox1.Margin = new Padding(2, 3, 2, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(126, 30);
            comboBox1.TabIndex = 15;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(720, 76);
            pictureBox1.Margin = new Padding(2, 3, 2, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(205, 256);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(969, 595);
            Controls.Add(pictureBox1);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(btnAlterar);
            Controls.Add(dataGridView1);
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
            Controls.Add(menuStrip1);
            Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2, 3, 2, 3);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private MenuStrip menuStrip1;
        private ToolStripMenuItem página1CadastroToolStripMenuItem;
        private DataGridView dataGridView1;
        private Button btnAlterar;
        private Button button1;
        private ComboBox comboBox1;
        private PictureBox pictureBox1;
        private ToolStripMenuItem página3ToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
    }
}
