using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
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

        public int cadastro(string sql, string[]campos, Object[] valores)
        {
            int registro = 0;
            try
            {
                connection = getconexao();
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                for (int i = 0; i < valores.Length; i++)
                {
                    cmd.Parameters.AddWithValue(campos[i], valores[i]);
                }
                registro = cmd.ExecuteNonQuery();
                connection.Close();
                return registro;

            }catch (Exception Ex)
            {
                MessageBox.Show("Erro: ", Ex.Message);
                throw new Exception(Ex.Message);
            }

            
            
        }
        public int Cadastrar(string nome, string email, int idade, string senha, int perfil, string foto)
        {
            //delcara o registro do cadastro;
            int registro = 0; 
            try
            {
                //pega a conexão;
                connection = getconexao();
                
                connection.Open(); //abre-se a conexão com o banco de dados;
                
                string Sql = "Insert into usuario(nome, email, idade, senha, cod_perfila, foto) values ('"+nome+"','"+ email+"',"+idade+",'"+senha+"', "+perfil+", '"+foto+"')";
                 


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

        public DataTable obterdados(string Sql)
        {
            //cria a tabela de dados
            DataTable dt = new DataTable();
            connection = getconexao();//obtenho a conexão
            connection.Open();//abro a conexão
            //prepara o script para o Sql
            MySqlCommand cmd = new MySqlCommand(Sql, connection);  
            //executa as informações na tabela
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);   
            adapter.Fill(dt);
            return dt; 
        }
    }
}
