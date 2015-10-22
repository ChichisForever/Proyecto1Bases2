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
    public partial class Actualizar : Form
    {
        public Conexion_Oracle orc;
        private Conexion_MSS server;

        public Actualizar(Conexion_Oracle o, Conexion_MSS m)
        {
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

            //Llenar ComboEliminar con las tablas
            this.Combo_actualizar.Items.Clear();
            orc.cmd.CommandText = "Select Table_Name from user_tables";
            orc.reader = orc.cmd.ExecuteReader();
            while (orc.reader.Read())
            {
                Combo_actualizar.Items.Add(orc.reader.GetString(0));
            }
            orc.reader.Close();

        }

        public void Datos_sqlserver()
        {
            this.Combo_actualizar.Items.Clear();
            server.cmd = new SqlCommand("SELECT table_name FROM information_schema.tables", server.conexion);
            server.reader = server.cmd.ExecuteReader();
            while (server.reader.Read())
            {
                this.Combo_actualizar.Items.Add(server.reader[0]);
            }
            server.reader.Close();
        }

        //Funcion para actualizar los datos de las tablas
        private void Actualizar_Click(object sender, EventArgs e)
        {
            if (orc != null)
            {
                try
                {
                    string Nombre_idActualizar = comboBoxColumnaIDActualizar.SelectedItem.ToString();
                    string id_actualizar = comboBoxIDActualizar.SelectedItem.ToString();
                   
                    string valor_actualizar = TextBoxValorActualizar.Text;
                    string columna_actualizar = comboBoxColumnaActualizar.SelectedItem.ToString();
                    string update = "UPDATE " + Combo_actualizar.SelectedItem.ToString() + " SET " + columna_actualizar + "=" + "'" + valor_actualizar + "'" + " WHERE " + Nombre_idActualizar + "=" + id_actualizar;
                    OleDbCommand cmd = new OleDbCommand(update, orc.myConnection);
                    MessageBox.Show(update);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Los datos de la tabla se han actualizado correctamente");
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al actualizar los datos de la tabla, intentelo de nuevo");
                }
            }
            if (server != null)
            {
                try
                {
                    string Nombre_idActualizar = comboBoxColumnaIDActualizar.SelectedItem.ToString();
                    string id_actualizar = comboBoxIDActualizar.SelectedItem.ToString();
                    string valor_actualizar = TextBoxValorActualizar.Text;
                    string columna_actualizar = comboBoxColumnaActualizar.SelectedItem.ToString();
                    string update = "UPDATE " + Combo_actualizar.SelectedItem.ToString() + " SET " + columna_actualizar + "=" + "'" + valor_actualizar + "'" + " WHERE " + Nombre_idActualizar + "=" + id_actualizar;
                    SqlCommand cmd = new SqlCommand(update, server.conexion);
                    MessageBox.Show(update);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Los datos de la tabla se han actualizado correctamente");
                }
                catch
                {
                    MessageBox.Show("Error al actualizar los datos de la tabla, intentelo de nuevo");
                }

            }


        }

        private void comboActualizar_SelectedIndexChanged(object sender, EventArgs e)

        {

            if (orc != null)
            {
                string tabla_escogida = Combo_actualizar.SelectedItem.ToString();
                

                this.Tabla_actualizar.Text = Combo_actualizar.SelectedItem.ToString();
                string extraer_tabla = "Select * from " + Combo_actualizar.SelectedItem.ToString();

                OleDbCommand cmd = new OleDbCommand(extraer_tabla, orc.myConnection);
                DataTable datos = new DataTable(); // Guarda los datos en una tabla para poder mostrarlos
                OleDbDataAdapter adaptador = new OleDbDataAdapter(cmd);
                adaptador.Fill(datos); // Llena la tabla con los datos obtenidos del query
                GridActualizar.DataSource = datos; // Pone los datos del resultado de la consulta en el gridView

                //Llenar comboBoxColumnaID con las columnas
                this.comboBoxColumnaActualizar.Items.Clear();
                orc.cmd.CommandText = "SELECT COLUMN_NAME FROM user_tab_cols WHERE table_name = '" + tabla_escogida + "'";
                orc.reader = orc.cmd.ExecuteReader();
                while (orc.reader.Read())
                {
                    comboBoxColumnaActualizar.Items.Add(orc.reader.GetValue(0));
                }
                orc.reader.Close();

            }
            if (server != null)
            {
                //Llenar ComboEliminar con las tablas
                string tabla_escogida = Combo_actualizar.SelectedItem.ToString();
               
                this.Tabla_actualizar.Text = Combo_actualizar.SelectedItem.ToString();
                string extraer_tabla = "Select * from " + Combo_actualizar.SelectedItem.ToString();

                SqlCommand cmd = new SqlCommand(extraer_tabla, server.conexion);
                DataTable datos = new DataTable(); // Guarda los datos en una tabla para poder mostrarlos
                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                adaptador.Fill(datos); // Llena la tabla con los datos obtenidos del query
                GridActualizar.DataSource = datos; // Pone los datos del resultado de la consulta en el gridView


                //Llenar comboBoxColumnaID con las columnas
                this.comboBoxColumnaActualizar.Items.Clear();
                server.cmd = new SqlCommand("Select COLUMN_NAME from INFORMATION_SCHEMA.COLUMNS where Table_Name = '" + tabla_escogida + "'", server.conexion);
                server.reader = server.cmd.ExecuteReader();
                while (server.reader.Read())
                {
                    comboBoxColumnaActualizar.Items.Add(server.reader.GetValue(0));
                }
                server.reader.Close();

            }

        }
        private void comboBoxColumnaActualizar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (orc != null)
            {
                //Llenar comboBoxColumnaActualizar con columnas
                string tabla_escogida = Combo_actualizar.SelectedItem.ToString();


                //Llenar comboBoxColumnaIDActualizar con id's
                this.comboBoxColumnaIDActualizar.Items.Clear();
                orc.cmd.CommandText = "SELECT COLUMN_NAME FROM user_tab_cols WHERE table_name = '" + tabla_escogida + "'";
                orc.reader = orc.cmd.ExecuteReader();
                while (orc.reader.Read())
                {
                    comboBoxColumnaIDActualizar.Items.Add(orc.reader.GetValue(0));
                }
                orc.reader.Close();

            }
            if (server != null)
            {

                //Llenar comboBoxColumnaID con las columnas
                string tabla_escogida = Combo_actualizar.SelectedItem.ToString();


                //Llenar comboBoxColumnaIDActualizar con las columnas
                this.comboBoxColumnaIDActualizar.Items.Clear();
                server.cmd = new SqlCommand("Select COLUMN_NAME from INFORMATION_SCHEMA.COLUMNS where Table_Name = '" + tabla_escogida + "'", server.conexion);
                server.reader = server.cmd.ExecuteReader();
                while (server.reader.Read())
                {
                    comboBoxColumnaIDActualizar.Items.Add(server.reader.GetValue(0));
                }
                server.reader.Close();


            }
        }

        private void comboBoxColumnaIDActualizar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (orc != null)
            {
                //Llenar comboBoxColumnaIDActualizar con id's
                string tabla_escogida = Combo_actualizar.SelectedItem.ToString();
                string columna_escogida = comboBoxColumnaIDActualizar.SelectedItem.ToString();


                //Llenar comboBoxIDActualizar con id's
                this.comboBoxIDActualizar.Items.Clear();
                orc.cmd.CommandText = "SELECT " + columna_escogida + " FROM " + tabla_escogida;
                orc.reader = orc.cmd.ExecuteReader();
                while (orc.reader.Read())
                {
                    comboBoxIDActualizar.Items.Add(orc.reader.GetValue(0));
                }
                orc.reader.Close();
            }
            if (server != null)
            {
                //Llenar comboBoxColumnaIDActualizar con las columnas
                string tabla_escogida = Combo_actualizar.SelectedItem.ToString();
                string columna_escogida = comboBoxColumnaIDActualizar.SelectedItem.ToString();


                //Llenar comboBoxIDActualizar con id's
                this.comboBoxIDActualizar.Items.Clear();
                server.cmd = new SqlCommand("SELECT " + columna_escogida + " FROM " + tabla_escogida, server.conexion);
                server.reader = server.cmd.ExecuteReader();
                while (server.reader.Read())
                {
                    comboBoxIDActualizar.Items.Add(server.reader.GetValue(0));
                }
                server.reader.Close();
            }


        }


        //Funcion que muestra los datos de la tabla después de actualizarla
        private void MostrarDatosActualizar_Click(object sender, EventArgs e)
        {
            if (orc != null)
            {
                string mostrar_tabla_actualizada = "Select * from " + Combo_actualizar.SelectedItem.ToString();
                OleDbCommand cmd = new OleDbCommand(mostrar_tabla_actualizada, orc.myConnection);
                DataTable datos = new DataTable();
                OleDbDataAdapter adaptador = new OleDbDataAdapter(cmd);
                adaptador.Fill(datos);
                GridActualizar.DataSource = datos;
            }
            if (server != null)
            {
                string mostrar_tabla_actualizada = "Select * from " + Combo_actualizar.SelectedItem.ToString();
                SqlCommand cmd = new SqlCommand(mostrar_tabla_actualizada, server.conexion);
                DataTable datos = new DataTable();
                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                adaptador.Fill(datos);
                GridActualizar.DataSource = datos;

            }
        }
    }



}