using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_and_Database
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            Classe_Usuario usuario = new Classe_Usuario();
            DataTable dtusuario = usuario.Logar(txtNome.Text, txtSenha.Text);
            MessageBox.Show("id logado: " + dtusuario.Rows[0][1].ToString());
            if (Convert.ToInt32(dtusuario.Rows[0][0]) > 0)
            {
                Principal1 principal = new Principal1(dtusuario);
                Form1 cad = new Form1();
                cad.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //chama a classe;
            Connection conexao = new Connection();
            //testa a conexão;
            if (conexao.getconexao() == null)
            {
                MessageBox.Show("Não conectou ao banco de dados.");
            }
            else
            {
                MessageBox.Show("Conexão estabelecida com sucesso.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtNome.Text = string.Empty;
            txtSenha.Text = string.Empty;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}

