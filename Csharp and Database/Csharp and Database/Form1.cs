using MySql.Data.MySqlClient;

namespace Csharp_and_Database
{
    public partial class Form1 : Form
    {
        int cod;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Connection cn = new Connection();
            dataGridView1.DataSource = cn.obterdados("Select * from usuario");
        }

        private void BtnConnection_Click(object sender, EventArgs e)
        {
            //chama a classe;
            Connection conexao = new Connection();
            //testa a conex�o;
            if (conexao.getconexao() == null)
            {
                MessageBox.Show("N�o conectou ao banco de dados.");
            }
            else
            {
                MessageBox.Show("Conex�o estabelecida com sucesso");
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
                if (cn.Cadastrar(txtNome.Text, txtEmail.Text, Idade, txtSenha.Text) > 0)
                {
                    MessageBox.Show("Dados armazenados com sucesso!");
                }
                else
                {
                    MessageBox.Show("N�o foi poss�vel concluir o cadastro.");
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

        private void p�gina2Informa��esDoProdutoToolStripMenuItem_Click(object sender, EventArgs e)
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


                }
                else

                    MessageBox.Show("N�o foi poss�vel alterarar o cadastro.");
            }
            else

                MessageBox.Show("Escolha um usu�rio para alterar!");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Classe_Usuario usu = new Classe_Usuario();
            if (usu.excluir(cod) > 0)
            {
                MessageBox.Show("Usuario excluido com sucesso");
            } else

                MessageBox.Show("Erro ao excluir");
        }
    }
}
