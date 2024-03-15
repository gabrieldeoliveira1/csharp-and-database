using MySql.Data.MySqlClient;

namespace Csharp_and_Database
{
    public partial class Form1 : Form
    {
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
            //testa a conexão;
            if (conexao.getconexao() == null)
            {
                MessageBox.Show("Não conectou ao banco de dados.");
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
                if (cn.Cadastrar(txtNome.Text, txtEmail.Text, Idade, txtSenha.Text) > 0)
                {
                    MessageBox.Show("Dados armazenados com sucesso!");
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
            
        }
    }
}
