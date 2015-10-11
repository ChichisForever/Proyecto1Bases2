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
using Oracle.Web;
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

            //se crea el string connection para pasarle la información de la bd al OracleConnection
            string oradb = "Data Source=basesdos;User Id=hr;Password=hr;";
            OracleConnection conn = new OracleConnection(oradb);

            // La conexión es guardada en la variable myConnection para luego ser evaluada
            OleDbConnection myConnection = new OleDbConnection(oradb);
            try
            {
                myConnection.Open();
            }
            catch (Exception)
            {
                Console.WriteLine("ta malo");
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
