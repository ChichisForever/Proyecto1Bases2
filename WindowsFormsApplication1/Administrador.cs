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
    public partial class Administrador : Form
    {
        public Conexion_Oracle orc;
        private Conexion_MSS server;

       
        public Administrador(Conexion_Oracle o,Conexion_MSS m)
        {
            //Se inicializan las variables con el objeto creado anteriormente
            orc = o;
            server = m;                
            InitializeComponent();
            if (orc != null)
            {
                mostrar_datos_oracle();
            }
        }

        private void Administrador_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        //Función que realiza ma muestra de datos
        private void mostrar_datos_oracle()
        {

            this.dbname.Text = orc.database;
            //Crea el objeto para la conexion y poder enviar comandos
            //orc.cmd = orc.myConnection.CreateCommand();
            //Se le inserta el query
            orc.cmd.CommandText = "Select Table_Name from user_tables";
            //Ejecuta el query ingresado y lo almacena en un reader
            orc.reader = orc.cmd.ExecuteReader();
            //Para administrar varias filas
            while (orc.reader.Read())
            {
                tablas.Items.Add(orc.reader.GetString(0)); //Usar mejor GetValue(Posiciòn de la columna de oracle)
            }
            //Indices
            orc.cmd = orc.myConnection.CreateCommand();
            orc.cmd.CommandText = "Select i.index_name,i.uniqueness,i.Table_name,col.column_name from user_indexes i inner join user_ind_columns col on i.Index_name = col.Index_name";
            orc.reader = orc.cmd.ExecuteReader();
            while (orc.reader.Read())
            {
                indices.Rows.Add(orc.reader.GetValue(0), orc.reader.GetValue(3), orc.reader.GetValue(2), orc.reader.GetValue(1));
            }

            //Vistas
            orc.cmd = orc.myConnection.CreateCommand();
            orc.cmd.CommandText = "select view_name from user_views";
            orc.reader = orc.cmd.ExecuteReader();
            while (orc.reader.Read())
            {
                this.cboxvista.Items.Add(orc.reader.GetValue(0));
            }




        }

        private void tablas_SelectedIndexChanged(object sender, EventArgs e)
        {

            tablaEscogida.Rows.Clear();
            if (orc != null)
            {
                orc.cmd = orc.myConnection.CreateCommand();
                orc.cmd.CommandText = "Select column_name,Data_Type,data_length,nullable from user_tab_columns where Table_name ='" +
                tablas.SelectedItem.ToString() + "'";
                orc.reader = orc.cmd.ExecuteReader();
                while (orc.reader.Read())
                {
                    tablaEscogida.Rows.Add(orc.reader.GetString(0), orc.reader.GetString(1), orc.reader.GetValue(2), orc.reader.GetValue(3));
                }
            }



        }

        private void cboxvista_SelectedIndexChanged(object sender, EventArgs e)
        {
            vista.Rows.Clear();
            if (orc != null)
            {
                orc.cmd = orc.myConnection.CreateCommand();
                orc.cmd.CommandText = "Select column_name,Data_Type,data_length,nullable from user_tab_columns where Table_name ='" +
                cboxvista.SelectedItem.ToString() + "'";
                orc.reader = orc.cmd.ExecuteReader();
                while (orc.reader.Read())
                {
                    vista.Rows.Add(orc.reader.GetString(0), orc.reader.GetString(1), orc.reader.GetValue(2), orc.reader.GetValue(3));
                }
            }
        }
    }


    
}
