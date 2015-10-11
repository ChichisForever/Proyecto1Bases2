using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.ManagedDataAccess;
//using Oracle.Web;
using System.Data.OleDb;

namespace WindowsFormsApplication1
{
    public partial class oracleLog : Form
    {
        public oracleLog()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void entrar_Click(object sender, EventArgs e)
        {
            
            string user = NomUsuario.Text;//Request["user"];
            string contrasennia = password.Text;//Request["password"];
            string database = BD.Text;//Request["database"];

            Conexion_Oracle oracle = new Conexion_Oracle(user, database, contrasennia);
            try
            {
                oracle.myConnection.Open();
                Administrador frm = new Administrador();
                frm.Show();
                this.Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No hubo conexión, intentelo nuevamente"+ex.ToString());
            }

                

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void NomUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
