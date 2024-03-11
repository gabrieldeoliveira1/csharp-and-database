namespace Csharp_and_Database
{
    partial class Form2
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
            textBox1 = new TextBox();
            menuStrip1 = new MenuStrip();
            página1CadastroToolStripMenuItem = new ToolStripMenuItem();
            página2InformaçõesDoProdutoToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(179, 209);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(156, 23);
            textBox1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { página1CadastroToolStripMenuItem, página2InformaçõesDoProdutoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(914, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // página1CadastroToolStripMenuItem
            // 
            página1CadastroToolStripMenuItem.Name = "página1CadastroToolStripMenuItem";
            página1CadastroToolStripMenuItem.Size = new Size(122, 20);
            página1CadastroToolStripMenuItem.Text = "Página 1 - Cadastro";
            // 
            // página2InformaçõesDoProdutoToolStripMenuItem
            // 
            página2InformaçõesDoProdutoToolStripMenuItem.Name = "página2InformaçõesDoProdutoToolStripMenuItem";
            página2InformaçõesDoProdutoToolStripMenuItem.Size = new Size(204, 20);
            página2InformaçõesDoProdutoToolStripMenuItem.Text = "Página 2 - Informações do Produto";
            página2InformaçõesDoProdutoToolStripMenuItem.Click += página2InformaçõesDoProdutoToolStripMenuItem_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 540);
            Controls.Add(textBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem página1CadastroToolStripMenuItem;
        private ToolStripMenuItem página2InformaçõesDoProdutoToolStripMenuItem;
    }
}