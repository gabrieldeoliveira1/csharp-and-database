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
    }
}
