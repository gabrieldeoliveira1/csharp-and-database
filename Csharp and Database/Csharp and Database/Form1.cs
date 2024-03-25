using MySql.Data.MySqlClient;
using System.Data;

namespace Csharp_and_Database
{
    public partial class Form1 : Form
    {
        Connection com = new Connection();
        int cod = 0;
        int perfil;
        string caminhofoto = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Connection cn = new Connection();
            dataGridView1.DataSource = cn.obterdados("Select usuario.id_usuario, usuario.nome, usuario.email, usuario.senha, usuario.idade, perfil.cargo, usuario.foto from usuario inner join perfil on usuario.cod_perfila=perfil.cod_perfil");
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
                dataGridView1.DataSource = conexao.obterdados("Select usuario.id_usuario, usuario.nome, usuario.email, usuario.senha, usuario.idade, perfil.cargo from usuario inner join perfil on usuario.cod_perfila=perfil.cod_perfil");
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
                if (cn.Cadastrar(txtNome.Text, txtEmail.Text, Idade, txtSenha.Text, perfil, caminhofoto) > 0)
                {
                    MessageBox.Show("Dados armazenados com sucesso!");
                    dataGridView1.DataSource = cn.obterdados("Select usuario.id_usuario, usuario.nome, usuario.email, usuario.senha, usuario.idade, perfil.cargo from usuario inner join perfil on usuario.cod_perfila=perfil.cod_perfil");
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
            comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["cargo"].Value.ToString();
            caminhofoto = (dataGridView1.Rows[e.RowIndex].Cells["foto"].Value.ToString());
            pictureBox1.Image = Image.FromFile(caminhofoto);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

            if (cod > 0)





            {


                Classe_Usuario usu = new Classe_Usuario();
                if (usu.alterar(txtNome.Text, txtEmail.Text, txtSenha.Text, txtIdade.Text, cod, perfil, caminhofoto) > 0)
                {
                    MessageBox.Show("Alterado com Sucesso.");
                    Connection connection = new Connection();
                    dataGridView1.DataSource = connection.obterdados("Select usuario.id_usuario, usuario.nome, usuario.email, usuario.senha, usuario.idade, perfil.cargo, usuario.foto from usuario inner join perfil on usuario.cod_perfila=perfil.cod_perfil order by id_usuario ASC");

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
                dataGridView1.DataSource = connection.obterdados("Select usuario.id_usuario, usuario.nome, usuario.email, usuario.senha, usuario.idade, perfil.cargo from usuario inner join perfil on usuario.cod_perfila=perfil.cod_perfil");
            }
            else

                MessageBox.Show("Erro ao excluir");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            perfil = Convert.ToInt32(((DataRowView)comboBox1.SelectedItem)["cod_perfil"]);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                //abre caixa de diálogo;
                OpenFileDialog foto = new OpenFileDialog();
                //filtro de arquivos;
                foto.Filter = "Image file(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
                if (foto.ShowDialog() == DialogResult.OK)
                {
                    //caminho do arquivo;
                    Image arquivo = Image.FromFile(foto.FileName);
                    caminhofoto = foto.FileName.Replace("\\", "\\\\");
                    //adiciona a imagem na picture;
                    pictureBox1.Image = arquivo;
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    MessageBox.Show("Nenhuma imagem selecionada.");
                }

            }
            catch (Exception ex) { MessageBox.Show("Erro: " + ex.Message); }
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }
    }
}
