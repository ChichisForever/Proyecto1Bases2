using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class mssLog : Form
    {
        public mssLog()
        {
            InitializeComponent();
        }

        private void mssLog_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nomUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void entrar_Click(object sender, EventArgs e)
        {
            try
            {

                //Conexión usando usuario y contraseña de SQL
                //SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=bd2;user id=sa;password=1");
                //Conexión usando autentificación de windows
                SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=bd2;Integrated Security=True");
                cn.Open();
                Console.WriteLine("Exito");


            }
            catch (Exception ex)
            {
                Console.WriteLine("Fallo" + ex.ToString());
            }
        }
    }
}
