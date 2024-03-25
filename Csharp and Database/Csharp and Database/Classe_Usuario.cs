using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Csharp_and_Database
{
    internal class Classe_Usuario
    {
        Connection conn = new Connection();

        public DataTable Logar(string email, string senha)
        {
             DataTable dt = new DataTable();
             int registro = 0;

            try
            {
                string sql = "select * from usuario where email = @email and senha = @senha";
                MySqlConnection com = conn.getconexao();
                com.Open();
                MySqlCommand cmd = new MySqlCommand(sql, com);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@senha", senha);
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                adp.Fill(dt);
                //registro=Convert.ToInt32(cmd.ExecuteScalar());  



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }

            return dt;

        }

        public int alterar(string nome, string email, string senha, string idade, int cod, int perfil, string foto)
        {//cria variável do código sql
            int registro = 0;
            string sql = "Update Usuario set nome = @nome, email=@email, senha = @senha, idade = @idade, cod_perfila = @perfil, foto=@foto where id_usuario = @codigo";
            MySqlConnection com = conn.getconexao();

            MySqlCommand cmd = new MySqlCommand(sql, com);
            com.Open();
            //substtitui os valores do SQL pelo parâmetro passado;
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@idade", idade);
            cmd.Parameters.AddWithValue("@senha", senha);
            cmd.Parameters.AddWithValue("@codigo", cod);
            cmd.Parameters.AddWithValue("@perfil", perfil);
            cmd.Parameters.AddWithValue("@foto", foto);
            //executa a consulta para alterar todas as informações;
            registro = Convert.ToInt32(cmd.ExecuteNonQuery()); 
            com.Close();
            return registro;
        }

        public int excluir(int cod)
        {
            int registro = 0;
            MySqlConnection com = conn.getconexao(); 
            com.Open();
            string sql = "DELETE from usuario where id_usuario=@codigo";
            MySqlCommand cmd = new MySqlCommand(sql, com);
            cmd.Parameters.AddWithValue("@codigo", cod);
            registro = Convert.ToInt32(cmd.ExecuteNonQuery());
            com.Close();
            return registro;
        }
    }
}
