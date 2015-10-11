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
        int tipo;
        public mssLog()
        {
            InitializeComponent();
            this.cboxtipo.Items.Add("Autentificación Windows");
            this.cboxtipo.Items.Add("Autentificacion SQL");
            

         
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
            String user = nomUsuario.Text;
            String pass = password.Text;
            String nbase = txtbase.Text;

            Conexion_MSS conexion = new Conexion_MSS(user, pass, nbase, tipo);
            try
            {




                conexion.conexion.Open();
                Administrador frm = new Administrador();
                frm.Show();
                this.Hide();


            }
            catch (Exception ex)
            {
                MessageBox.Show("No hubo conexión, intentelo nuevamente" + ex.ToString());
            }
        }

        private void cboxtipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxtipo.SelectedItem.ToString() == "Autentificación Windows")
            {
                nomUsuario.Enabled = false;
                password.Enabled = false;
                tipo = 0;
            }

            if (cboxtipo.SelectedItem.ToString() == "Autentificacion SQL")
            {
                nomUsuario.Enabled = true;
                password.Enabled = true;
                tipo = 1;
            }
        }
    }
}
