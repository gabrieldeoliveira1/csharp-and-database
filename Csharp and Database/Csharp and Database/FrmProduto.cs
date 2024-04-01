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
    public partial class FrmProduto : Form
    {

        string caminhofoto = "";
        public FrmProduto()
        {
            InitializeComponent();
        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClasseProduto produto = new ClasseProduto();
            produto.foto = caminhofoto;
            produto.nome = textBox1.Text;
            produto.preco = Convert.ToDecimal(textBox2.Text);
            produto.fornecedor = Convert.ToInt32(textBox3.Text);
            produto.quantidade = Convert.ToInt32(textBox4.Text);

            produto.cadastrar(produto);

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
    }
    }
