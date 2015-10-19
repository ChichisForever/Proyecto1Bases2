﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace WindowsFormsApplication1
{
    public partial class ModificarTamañoColumna : Form
    {
        public Conexion_Oracle orc;
        private Conexion_MSS server;

        public ModificarTamañoColumna(Conexion_Oracle o, Conexion_MSS m)
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

        private void Datos_oracle()
        {

            //Llenar ComboEliminar con las tablas
            orc.cmd.CommandText = "Select Table_Name from user_tables";
            orc.reader = orc.cmd.ExecuteReader();
            while (orc.reader.Read())
            {
                ComboModificarTamaño.Items.Add(orc.reader.GetString(0));
            }
            orc.reader.Close();
        }

        private void Datos_sqlserver()
        {
            server.cmd = new SqlCommand("SELECT table_name FROM information_schema.tables", server.conexion);
            server.reader = server.cmd.ExecuteReader();
            while (server.reader.Read())
            {
                this.ComboModificarTamaño.Items.Add(server.reader[0]);
            }
            server.reader.Close();
        }

        private void ModificarColumna_Click(object sender, EventArgs e)
        {
            if (orc != null)
            {
                try
                {
                    string Nombre_ColumnaModificar = comboColumnaModificar.SelectedItem.ToString();
                    string tipo_Modificar = textBoxTipoModificar.Text;

                    string tamanio_Modificar = textBoxTipoModificar.Text;
                    int tamanio_numero = int.Parse(tamanio_Modificar);

                    //int id_eliminar_numero = int.Parse(id_eliminar); // Convierte el string de un textBox a int en este caso el id de las tablas
                    string delete = "ALTER TABLE " + "'" + ComboModificarTamaño.SelectedItem.ToString() + "'" + "'" + "MODIFY " + Nombre_ColumnaModificar + " " + tipo_Modificar + "(" + tamanio_numero + ")";
                    OleDbCommand cmd = new OleDbCommand(delete, orc.myConnection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("La columna se ha modificado correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificar la columna, intentelo de nuevo" + ex);
                }
            }
            if (server != null)
            {
                try
                {

                string Nombre_ColumnaModificar = comboColumnaModificar.SelectedItem.ToString();
                string tipo_Modificar = textBoxTipoModificar.Text;

                string tamanio_Modificar = textBoxTipoModificar.Text;
                int tamanio_numero = int.Parse(tamanio_Modificar);

                //int id_eliminar_numero = int.Parse(id_eliminar); // Convierte el string de un textBox a int en este caso el id de las tablas
                string delete = "ALTER TABLE " + ComboModificarTamaño.SelectedItem.ToString()   + "MODIFY " + Nombre_ColumnaModificar + " " + tipo_Modificar + "(" + tamanio_numero + ")";
                OleDbCommand cmd = new OleDbCommand(delete, orc.myConnection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("La columna se ha modificado correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificar la columna, intentelo de nuevo" + ex);
                }

            }
        }

        private void comboModificarTamanio_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (orc != null)
            {
                //Llenar  ComboModificarTamaño con las tablas
                string tabla_escogida = ComboModificarTamaño.SelectedItem.ToString();
                /*orc.cmd.CommandText = "Select Table_Name from user_tables";
                orc.reader = orc.cmd.ExecuteReader();
                while (orc.reader.Read())
                {
                    ComboModificarTamaño.Items.Add(orc.reader.GetString(0));
                }
                orc.reader.Close();*/

                //Despliega la tabla de acuerdo a la que se seleccione en el combobox
                this.Tabla_ModificarTamaño.Text = ComboModificarTamaño.SelectedItem.ToString();
                string extraer_tabla = "Select * from " + ComboModificarTamaño.SelectedItem.ToString();

                OleDbCommand cmd = new OleDbCommand(extraer_tabla, orc.myConnection);
                DataTable datos = new DataTable(); // Guarda los datos en una tabla para poder mostrarlos
                OleDbDataAdapter adaptador = new OleDbDataAdapter(cmd);
                adaptador.Fill(datos); // Llena la tabla con los datos obtenidos del query
                GridModificarColumna.DataSource = datos; // Pone los datos del resultado de la consulta en el gridView

                //Llenar comboColumnaModificar con las columnas

                orc.cmd.CommandText = "SELECT COLUMN_NAME FROM user_tab_cols WHERE table_name = '" + tabla_escogida + "'";
                orc.reader = orc.cmd.ExecuteReader();
                while (orc.reader.Read())
                {
                    comboColumnaModificar.Items.Add(orc.reader.GetValue(0));
                }
                orc.reader.Close();


            }
            if (server != null)
            {
                //Llenar  ComboModificarTamaño con las tablas
                string tabla_escogida = ComboModificarTamaño.SelectedItem.ToString();
                /*server.cmd = new SqlCommand("SELECT table_name FROM information_schema.tables", server.conexion);
                server.reader = server.cmd.ExecuteReader();
                while (server.reader.Read())
                {
                    this.ComboModificarTamaño.Items.Add(server.reader.GetValue(0));
                }
                server.reader.Close();*/

                //Despliega la tabla de acuerdo a la que se seleccione en el combobox
                this.Tabla_ModificarTamaño.Text = ComboModificarTamaño.SelectedItem.ToString();
                string extraer_tabla = "Select * from " + ComboModificarTamaño.SelectedItem.ToString();

                SqlCommand cmd = new SqlCommand(extraer_tabla, server.conexion);
                DataTable datos = new DataTable(); // Guarda los datos en una tabla para poder mostrarlos
                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                adaptador.Fill(datos); // Llena la tabla con los datos obtenidos del query
                GridModificarColumna.DataSource = datos; // Pone los datos del resultado de la consulta en el gridView

                //Llenar comboColumnaModificar con las columnas

                server.cmd=  new SqlCommand("Select COLUMN_NAME from INFORMATION_SCHEMA.COLUMNS where Table_Name = '" + tabla_escogida + "'", server.conexion);
                server.reader = server.cmd.ExecuteReader();
                while (server.reader.Read())
                {
                    comboColumnaModificar.Items.Add(server.reader.GetValue(0));
                }
                server.reader.Close();

            }

        }

        //Funcion que muestra los datos actualizados después de eliminar algún dato
        private void MostrarDatosModificar_Click(object sender, EventArgs e)
        {
            if (orc != null)
            {
                string mostrar_tabla_actualizada = "Select * from " + ComboModificarTamaño.SelectedItem.ToString();
                OleDbCommand cmd = new OleDbCommand(mostrar_tabla_actualizada, orc.myConnection);
                DataTable datos = new DataTable();
                OleDbDataAdapter adaptador = new OleDbDataAdapter(cmd);
                adaptador.Fill(datos);
                GridModificarColumna.DataSource = datos;
            }
            if(server != null)
            {
                string mostrar_tabla_actualizada = "Select * from " + ComboModificarTamaño.SelectedItem.ToString();
                SqlCommand cmd = new SqlCommand(mostrar_tabla_actualizada, server.conexion);
                DataTable datos = new DataTable();
                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                adaptador.Fill(datos);
                GridModificarColumna.DataSource = datos;
            }

        }




    }
}
