using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Bcpg;

namespace Csharp_and_Database
{
    public class Produto
    {
        //local host
        static private string servidor = "127.0.0.1";
        static private string bd = "csharp_database";
        static private string usuario = "root";
        static private string senha = "";
        public MySqlConnection connection = null;
        static private string strcon = "server=" + servidor + ";database=" + bd + ";user id=" + usuario + ";password=" + senha;


        public MySqlConnection getconexao()
        {
            connection = new MySqlConnection(strcon);
            return connection;
        }

        public int Produt(string nome_produto, int quantidade, int estoque)
        {
            //delcara o registro do cadastro;
            int registro = 0;
            try
            {
                //pega a conexão;
                connection = getconexao();

                connection.Open(); //abre-se a conexão com o banco de dados;

                string Pao = "Insert into produto(nome, quantidade, estoque) values ('" +nome_produto+ "','" + quantidade + "'," + estoque + "')";



                MySqlCommand cmd = new MySqlCommand(Pao, connection);

                //executa a instrução;
                registro = cmd.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro." + ex.Message);
            }
            return registro;
        }
    }
}