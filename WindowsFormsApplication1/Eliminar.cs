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
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace WindowsFormsApplication1
{
    public partial class Eliminar : Form
    {

        public Conexion_Oracle orc;
        private Conexion_MSS server;

        public Eliminar(Conexion_Oracle o, Conexion_MSS m)
        {
            //Se inicializan las variables con el objeto creado anteriormente
            orc = o;
            server = m;
            InitializeComponent();

            if (orc != null)
            {
                Datos_oracle();
            }

            if (server != null)
            {
                Datos_sqlserver();
            }

        }

        public void Datos_oracle()
        {
            try
            {
                //Llenar ComboEliminar con las tablas
                this.ComboEliminar.Items.Clear();
                orc.cmd.CommandText = "Select Table_Name from user_tables";
                orc.reader = orc.cmd.ExecuteReader();
                while (orc.reader.Read())
                {
                    ComboEliminar.Items.Add(orc.reader.GetString(0));
                }
                orc.reader.Close();
            }
            catch
            {
                MessageBox.Show("No se pudieron cargar los datos de la base de datos.");
            }
        }

        public void Datos_sqlserver()
        {
            this.ComboEliminar.Items.Clear();
            server.cmd = new SqlCommand("SELECT table_name FROM information_schema.tables", server.conexion);
            server.reader = server.cmd.ExecuteReader();
            while (server.reader.Read())
            {
                this.ComboEliminar.Items.Add(server.reader[0]);
            }
            server.reader.Close();
        }

        //Funcion que borra los datos de las tablas
        private void Borrar_Click(object sender, EventArgs e)
        {
            if (orc != null)
            {
                try
                {
                    string Nombre_idEliminar = comboBoxColumnaID.SelectedItem.ToString();
                    string id_eliminar = comboBoxIDEliminar.SelectedItem.ToString();
                    //int id_eliminar_numero = int.Parse(id_eliminar); // Convierte el string de un textBox a int en este caso el id de las tablas
                    string delete = "DELETE " + ComboEliminar.SelectedItem.ToString() + " WHERE " + Nombre_idEliminar + " " + "=" + " " + id_eliminar;
                    OleDbCommand cmd = new OleDbCommand(delete, orc.myConnection);
                    MessageBox.Show(delete);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Los datos se han borrado correctamente");
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al borrar los datos de la tabla, intentelo de nuevo");
                }
            }
            if (server != null)
            {
                try
                {
                    string Nombre_idEliminar = comboBoxColumnaID.SelectedItem.ToString();
                    string id_eliminar = comboBoxIDEliminar.SelectedItem.ToString();
                    string delete = "DELETE " + ComboEliminar.SelectedItem.ToString() + " WHERE " + Nombre_idEliminar + " = " + id_eliminar;
                    SqlCommand cmd = new SqlCommand(delete, server.conexion);
                    MessageBox.Show(delete);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Los datos se han borrado correctamente");
                }
                catch
                {
                    MessageBox.Show("Error al borrar los datos de la tabla, intentelo de nuevo");
                }
            }
        }

        private void comboEliminar_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (orc != null)
            {
                //Llenar ComboEliminar con las tablas
                string tabla_escogida = ComboEliminar.SelectedItem.ToString();

                //Despliega la tabla de acuerdo a la que se seleccione en el combobox
                this.Nombre_tabla_eliminar.Text = ComboEliminar.SelectedItem.ToString();
                string extraer_tabla = "Select * from " + ComboEliminar.SelectedItem.ToString();

                OleDbCommand cmd = new OleDbCommand(extraer_tabla, orc.myConnection);
                DataTable datos = new DataTable(); // Guarda los datos en una tabla para poder mostrarlos
                OleDbDataAdapter adaptador = new OleDbDataAdapter(cmd);
                adaptador.Fill(datos); // Llena la tabla con los datos obtenidos del query
                GridEliminar.DataSource = datos; // Pone los datos del resultado de la consulta en el gridView

                //Llenar comboBoxColumnaID con las columnas
                this.comboBoxColumnaID.Items.Clear();
                orc.cmd.CommandText = "SELECT COLUMN_NAME FROM user_tab_cols WHERE table_name = '" + tabla_escogida + "'";
                orc.reader = orc.cmd.ExecuteReader();
                while (orc.reader.Read())
                {
                    comboBoxColumnaID.Items.Add(orc.reader.GetValue(0));
                }
                orc.reader.Close();
            }


            if (server != null)
            {
                //Llenar ComboEliminar con las tablas
                string tabla_escogida_server = ComboEliminar.SelectedItem.ToString();

                //Despliega la tabla de acuerdo a la que se seleccione en el combobox
                this.Nombre_tabla_eliminar.Text = ComboEliminar.SelectedItem.ToString();
                string extraer_tabla = "Select * from " + ComboEliminar.SelectedItem.ToString();

                SqlCommand cmd = new SqlCommand(extraer_tabla, server.conexion);
                DataTable datos = new DataTable(); // Guarda los datos en una tabla para poder mostrarlos
                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                adaptador.Fill(datos); // Llena la tabla con los datos obtenidos del query
                GridEliminar.DataSource = datos; // Pone los datos del resultado de la consulta en el gridView

                //Llenar comboBoxColumnaID con las columnas
                this.comboBoxColumnaID.Items.Clear();
                server.cmd = new SqlCommand("Select COLUMN_NAME from INFORMATION_SCHEMA.COLUMNS where Table_Name = '" + tabla_escogida_server + "'", server.conexion);
                server.reader = server.cmd.ExecuteReader();
                while (server.reader.Read())
                {
                    comboBoxColumnaID.Items.Add(server.reader.GetValue(0));
                }
                server.reader.Close();


            }




        }

        private void comboBoxIDEliminar_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (orc != null)
            {
                string tabla_escogida = ComboEliminar.SelectedItem.ToString();
                string columna_escogida = comboBoxColumnaID.SelectedItem.ToString();


                //Llenar comboBoxIDEliminar con los IDs
                this.comboBoxIDEliminar.Items.Clear();
                orc.cmd.CommandText = "SELECT " + columna_escogida + " FROM " + tabla_escogida;
                orc.reader = orc.cmd.ExecuteReader();
                while (orc.reader.Read())
                {
                    comboBoxIDEliminar.Items.Add(orc.reader.GetValue(0));
                }
                orc.reader.Close();

            }

            if (server != null)
            {
                string tabla_escogida = ComboEliminar.SelectedItem.ToString();
                string columna_escogida = comboBoxColumnaID.SelectedItem.ToString();


                //Llenar comboBoxIDEliminar con los IDs
                this.comboBoxIDEliminar.Items.Clear();
                server.cmd = new SqlCommand("SELECT " + columna_escogida + " FROM " + tabla_escogida, server.conexion);
                server.reader = server.cmd.ExecuteReader();
                while (server.reader.Read())
                {
                    comboBoxIDEliminar.Items.Add(server.reader.GetValue(0));
                }
                server.reader.Close();

            }
        }



        //Funcion que muestra los datos actualizados después de eliminar algún dato
        private void MostrarDatosEliminar_Click(object sender, EventArgs e)
        {

            if (orc != null)
            {
                string mostrar_tabla_actualizada = "Select * from " + ComboEliminar.SelectedItem.ToString();
                OleDbCommand cmd = new OleDbCommand(mostrar_tabla_actualizada, orc.myConnection);
                DataTable datos = new DataTable();
                OleDbDataAdapter adaptador = new OleDbDataAdapter(cmd);
                adaptador.Fill(datos);
                GridEliminar.DataSource = datos;

            }
            if (server != null)
            {
                string mostrar_tabla_actualizada = "Select * from " + ComboEliminar.SelectedItem.ToString();
                SqlCommand cmd = new SqlCommand(mostrar_tabla_actualizada, server.conexion);
                DataTable datos = new DataTable();
                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                adaptador.Fill(datos);
                GridEliminar.DataSource = datos;

            }
        }
    }

}











