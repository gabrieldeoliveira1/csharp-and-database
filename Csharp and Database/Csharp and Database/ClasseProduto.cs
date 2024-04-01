using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_and_Database
{
    internal class ClasseProduto
    {
        public int codigo;
        public string nome;
        public decimal preco;
        public int quantidade;
        public string foto;
        public int fornecedor;

        public ClasseProduto()
        {
            //inicializar as variáveis;
            codigo = 0;
            nome = "0";
            preco = 0;
            quantidade = 0;
            foto = "0";



        }

        public int cadastrar(ClasseProduto produto)
        {
            int registro = 0;
            string sql = "insert into produto(nome_produto, quantidade, preco, foto, cod_fornecedor)values(@nome, @quantidade, @preco, @foto, @fornecedor)";
            string[] campos = { "@nome", "@quantidade", "@preco", "@foto", "@fornecedor" };
            Object[] valores = { produto.nome, produto.quantidade, produto.preco, produto.foto, produto.fornecedor };
            Connection conn = new Connection();
            if(conn.cadastro(sql, campos, valores) >= 1)
            {
                MessageBox.Show("Cadastro com sucesso");
            }
            else
            {
                MessageBox.Show("Erro no cadastro");
            }
            return registro;
        }
    }
}
