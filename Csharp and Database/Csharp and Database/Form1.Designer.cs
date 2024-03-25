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
            página2InformaçõesDoProdutoToolStripMenuItem = new ToolStripMenuItem();
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
            BtnConnection.Font = new Font("Sitka Small", 9F, FontStyle.Underline, GraphicsUnit.Point);
            BtnConnection.ForeColor = Color.DodgerBlue;
            BtnConnection.Location = new Point(0, 27);
            BtnConnection.Name = "BtnConnection";
            BtnConnection.Size = new Size(162, 628);
            BtnConnection.TabIndex = 0;
            BtnConnection.Text = "Teste de conexão";
            BtnConnection.UseVisualStyleBackColor = false;
            BtnConnection.Click += BtnConnection_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Courier New", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(420, 113);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 1;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Courier New", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(406, 167);
            label2.Name = "label2";
            label2.Size = new Size(96, 25);
            label2.TabIndex = 2;
            label2.Text = "Idade:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Courier New", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(711, 113);
            label3.Name = "label3";
            label3.Size = new Size(96, 25);
            label3.TabIndex = 3;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Courier New", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(711, 166);
            label4.Name = "label4";
            label4.Size = new Size(96, 25);
            label4.TabIndex = 4;
            label4.Text = "Senha:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(393, 134);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(130, 30);
            txtNome.TabIndex = 5;
            // 
            // txtIdade
            // 
            txtIdade.Location = new Point(393, 187);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(130, 30);
            txtIdade.TabIndex = 6;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(692, 187);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(130, 30);
            txtSenha.TabIndex = 7;
            txtSenha.TextChanged += txtSenha_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(692, 134);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(130, 30);
            txtEmail.TabIndex = 8;
            // 
            // button2
            // 
            button2.Font = new Font("Courier New", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(529, 134);
            button2.Name = "button2";
            button2.Size = new Size(157, 78);
            button2.TabIndex = 10;
            button2.Text = "Cadastrar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { página1CadastroToolStripMenuItem, página2InformaçõesDoProdutoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1211, 28);
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
            // página2InformaçõesDoProdutoToolStripMenuItem
            // 
            página2InformaçõesDoProdutoToolStripMenuItem.Name = "página2InformaçõesDoProdutoToolStripMenuItem";
            página2InformaçõesDoProdutoToolStripMenuItem.Size = new Size(130, 24);
            página2InformaçõesDoProdutoToolStripMenuItem.Text = "Página 2 - Login";
            página2InformaçõesDoProdutoToolStripMenuItem.Click += página2InformaçõesDoProdutoToolStripMenuItem_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(187, 381);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(953, 202);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnAlterar
            // 
            btnAlterar.Font = new Font("Courier New", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnAlterar.Location = new Point(529, 218);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(157, 29);
            btnAlterar.TabIndex = 13;
            btnAlterar.Text = "Alterar dados";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Courier New", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(529, 253);
            button1.Name = "button1";
            button1.Size = new Size(157, 29);
            button1.TabIndex = 14;
            button1.Text = "Excluir dados";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(529, 288);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(157, 30);
            comboBox1.TabIndex = 15;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(900, 76);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(256, 256);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1211, 595);
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
            Font = new Font("Swis721 BlkCn BT", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            MainMenuStrip = menuStrip1;
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
        private ToolStripMenuItem página2InformaçõesDoProdutoToolStripMenuItem;
        private DataGridView dataGridView1;
        private Button btnAlterar;
        private Button button1;
        private ComboBox comboBox1;
        private PictureBox pictureBox1;
    }
}
