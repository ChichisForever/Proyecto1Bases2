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
    public partial class EliminarColumna : Form
    {
        public Conexion_Oracle orc;
        private Conexion_MSS server;
        public EliminarColumna(Conexion_Oracle o, Conexion_MSS m)

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

        private void Datos_oracle()
        {
            //Llenar ComboEliminar con las tablas
            this.ComboEliminarColumna.Items.Clear();

            orc.cmd.CommandText = "Select Table_Name from user_tables";
            orc.reader = orc.cmd.ExecuteReader();
            while (orc.reader.Read())
            {
                ComboEliminarColumna.Items.Add(orc.reader.GetString(0));
            }
            orc.reader.Close();

        }

        private void Datos_sqlserver()
        {
            this.ComboEliminarColumna.Items.Clear();
            server.cmd = new SqlCommand("SELECT table_name FROM information_schema.tables", server.conexion);
            server.reader = server.cmd.ExecuteReader();
            while (server.reader.Read())
            {
                this.ComboEliminarColumna.Items.Add(server.reader[0]);
            }
            server.reader.Close();

        }

        private void EliminarColumna_Click(object sender, EventArgs e)
        {
            if (orc != null)
            {
                try
                {

                    string eliminar_Columna = "ALTER TABLE " + ComboEliminarColumna.SelectedItem.ToString() + " DROP COLUMN " + comboColumnaEliminar.SelectedItem.ToString();
                    OleDbCommand cmd = new OleDbCommand(eliminar_Columna, orc.myConnection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("La columna  se ha borrado correctamente");
                }
                catch (Exception)
                {
                    MessageBox.Show("Error no se pudo borrar la columna de la tabla, intentelo de nuevo");
                }
            }
            if (server != null)
            {
                try
                {
                string eliminar_Columna = "ALTER TABLE "  + ComboEliminarColumna.SelectedItem.ToString()  + " DROP COLUMN " + comboColumnaEliminar.SelectedItem.ToString();
                SqlCommand cmd = new SqlCommand(eliminar_Columna, server.conexion);
                cmd.ExecuteNonQuery();
                MessageBox.Show("La columna  se ha alterado correctamente");
                }
                catch (Exception)
                {
                    MessageBox.Show("Error no se pudo borrar la columna de la tabla, intentelo de nuevo");
                }

            }
        }

        private void comboEliminarColumna_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (orc != null)
            {
                string tabla_escogida = ComboEliminarColumna.SelectedItem.ToString();
                //Llenar ComboEliminarColumna con las tablas
               
                this.Tabla_EliminarColumna.Text = ComboEliminarColumna.SelectedItem.ToString();
                string extraer_tabla = "Select * from " + ComboEliminarColumna.SelectedItem.ToString();

                OleDbCommand cmd = new OleDbCommand(extraer_tabla, orc.myConnection);
                DataTable datos = new DataTable(); // Guarda los datos en una tabla para poder mostrarlos
                OleDbDataAdapter adaptador = new OleDbDataAdapter(cmd);
                adaptador.Fill(datos); // Llena la tabla con los datos obtenidos del query
                GridEliminarColumna.DataSource = datos; // Pone los datos del resultado de la consulta en el gridView

                //Llenar comboColumnaEliminar con las columnas
                this.comboColumnaEliminar.Items.Clear();
                orc.cmd.CommandText = "SELECT COLUMN_NAME FROM user_tab_cols WHERE table_name = '" + tabla_escogida + "'";
                orc.reader = orc.cmd.ExecuteReader();
                while (orc.reader.Read())
                {
                    comboColumnaEliminar.Items.Add(orc.reader.GetValue(0));
                }
                orc.reader.Close();


            }
            if (server != null)
            {
                //Llenar ComboEliminarColumna con las tablas
                string tabla_escogida = ComboEliminarColumna.SelectedItem.ToString();
            

                this.Tabla_EliminarColumna.Text = ComboEliminarColumna.SelectedItem.ToString();
                string extraer_tabla = "Select * from " + ComboEliminarColumna.SelectedItem.ToString();

                SqlCommand cmd = new SqlCommand(extraer_tabla, server.conexion);
                DataTable datos = new DataTable(); // Guarda los datos en una tabla para poder mostrarlos
                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                adaptador.Fill(datos); // Llena la tabla con los datos obtenidos del query
                GridEliminarColumna.DataSource = datos; // Pone los datos del resultado de la consulta en el gridView

                //Llenar comboColumnaEliminar con las columnas
                this.comboColumnaEliminar.Items.Clear();
                server.cmd= new SqlCommand("Select COLUMN_NAME from INFORMATION_SCHEMA.COLUMNS where Table_Name = '" + tabla_escogida + "'", server.conexion);
                server.reader = server.cmd.ExecuteReader();
                while (server.reader.Read())
                {
                    comboColumnaEliminar.Items.Add(server.reader.GetValue(0));
                }
                server.reader.Close();

            }

        }

        //Funcion que muestra los datos actualizados después de eliminar una columna
        private void MostrarDatosEliminarColumna_Click(object sender, EventArgs e)
        {

            if (orc != null)
            {
                string mostrar_tabla_actualizada = "Select * from " + ComboEliminarColumna.SelectedItem.ToString();
                OleDbCommand cmd = new OleDbCommand(mostrar_tabla_actualizada, orc.myConnection);
                DataTable datos = new DataTable();
                OleDbDataAdapter adaptador = new OleDbDataAdapter(cmd);
                adaptador.Fill(datos);
                GridEliminarColumna.DataSource = datos;
            }
            if(server != null)
            {
                string mostrar_tabla_actualizada = "Select * from " + ComboEliminarColumna.SelectedItem.ToString();
                SqlCommand cmd = new SqlCommand(mostrar_tabla_actualizada, server.conexion);
                DataTable datos = new DataTable();
                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                adaptador.Fill(datos);
                GridEliminarColumna.DataSource = datos;

            }

        }

















    }
}
