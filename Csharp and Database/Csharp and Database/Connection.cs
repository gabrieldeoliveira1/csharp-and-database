using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Bcpg;

namespace Csharp_and_Database
{
    public class Connection
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

        public int Cadastrar(string nome, string email, int idade, string senha)
        {
            //delcara o registro do cadastro;
            int registro = 0; 
            try
            {
                //pega a conexão;
                connection = getconexao();
                
                connection.Open(); //abre-se a conexão c    om o banco de dados;
                
                string Sql = "Insert into usuario(nome, email, idade, senha) values ('"+nome+"','"+ email+"',"+idade+",'"+senha+"')";
                
                MySqlCommand cmd = new MySqlCommand(Sql, connection);
               
                //executa a instrução;
               registro = cmd.ExecuteNonQuery();

                connection.Close();
            }catch(Exception ex)
            {
                MessageBox.Show("Erro." + ex.Message);
            }
            return registro;
        }
    }
}
