using MySql.Data.MySqlClient;
using System.Data;

namespace Csharp_and_Database
{
    public partial class Form1 : Form
    {
        Connection com = new Connection();
        int cod = 0;
        int perfil = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Connection cn = new Connection();
            dataGridView1.DataSource = cn.obterdados("Select * from usuario.nome, usuario.email, usuario.senha, usuario.idade, perfil.cargo from usuario" + "inner join cargo on usuario.cod_perfila=perfil.cod_perfil");
            comboBox1.DataSource = cn.obterdados("select * from perfil");
            comboBox1.DisplayMember = "cargo";
            comboBox1.ValueMember = "cod_perfil";
        }

        private void BtnConnection_Click(object sender, EventArgs e)
        {
            //chama a classe;
            Connection conexao = new Connection();
            //testa a conexão;
            if (conexao.getconexao() == null)
            {
                MessageBox.Show("Não conectou ao banco de dados.");
                dataGridView1.DataSource = conexao.obterdados("Select * from usuario");
            }
            else
            {
                MessageBox.Show("Conexão estabelecida com sucesso");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            int Idade = 0;
            try
            {



                Idade = Convert.ToInt32(txtIdade.Text);
                Connection cn = new Connection();
                if (cn.Cadastrar(txtNome.Text, txtEmail.Text, Idade, txtSenha.Text, perfil) > 0)
                {
                    MessageBox.Show("Dados armazenados com sucesso!");
                    dataGridView1.DataSource = cn.obterdados("Select * from usuario");
                }
                else
                {
                    MessageBox.Show("Não foi possível concluir o cadastro.");
                }




            }
            catch (Exception ex)
            {
                MessageBox.Show("Problema encontrado" + ex.Message);
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void página2InformaçõesDoProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            this.Hide();
            log.ShowDialog();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cod = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
            txtEmail.Text = dataGridView1.Rows[e.RowIndex].Cells["email"].Value.ToString();
            txtNome.Text = dataGridView1.Rows[e.RowIndex].Cells["nome"].Value.ToString();
            txtSenha.Text = dataGridView1.Rows[e.RowIndex].Cells["senha"].Value.ToString();
            txtIdade.Text = dataGridView1.Rows[e.RowIndex].Cells["idade"].Value.ToString();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

            if (cod > 0)

                



            {


                Classe_Usuario usu = new Classe_Usuario();
                if (usu.alterar(txtNome.Text, txtEmail.Text, txtSenha.Text, txtIdade.Text, cod) > 0)
                {
                    MessageBox.Show("Alterado com Sucesso.");
                    Connection connection = new Connection();
                    dataGridView1.DataSource = connection.obterdados("Select * from usuario");

                }
                else

                    MessageBox.Show("Não foi possível alterarar o cadastro.");
            }
            else

                MessageBox.Show("Escolha um usuário para alterar!");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Classe_Usuario usu = new Classe_Usuario();
            if (usu.excluir(cod) > 0)
            {
                MessageBox.Show("Usuario excluido com sucesso");
                Connection connection = new Connection();
                dataGridView1.DataSource = connection.obterdados("Select * from usuario");
            }
            else

                MessageBox.Show("Erro ao excluir");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            perfil = Convert.ToInt32(((DataRowView)comboBox1.SelectedItem)["cod_perfil"]); 
        }
    }
}
