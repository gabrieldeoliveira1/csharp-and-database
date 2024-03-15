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
    public partial class Principal1 : Form
    {
        DataTable login;//tabela para armazenar as informações
        //cria-se parametro para receber login
        public Principal1(DataTable Usuario)
        {
            this.login = Usuario;
            MessageBox.Show("Seja bem-vindo: " + this.login.Rows[0][1].ToString());
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }
    }
}
