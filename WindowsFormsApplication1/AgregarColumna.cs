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
    public partial class AgregarColumna : Form
    {
        public Conexion_Oracle orc;
        private Conexion_MSS server;

        public AgregarColumna(Conexion_Oracle o, Conexion_MSS m)
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
            orc.cmd.CommandText = "Select Table_Name from user_tables";
            orc.reader = orc.cmd.ExecuteReader();
            while (orc.reader.Read())
            {
                ComboAgregarColumna.Items.Add(orc.reader.GetString(0));
            }
            orc.reader.Close();
        }

        private void Datos_sqlserver()
        {
            server.cmd = new SqlCommand("SELECT table_name FROM information_schema.tables", server.conexion);
            server.reader = server.cmd.ExecuteReader();
            while (server.reader.Read())
            {
                this.ComboAgregarColumna.Items.Add(server.reader[0]);
            }
            server.reader.Close();
        }

        private void AgregarColumna_Click(object sender, EventArgs e)
        {
            if (orc != null)
            {
                try
                {
                    string Nombre_ColumnaAgregar = TextBoxColumnaAgregar.Text;
                    string tipo_Columna = TextBoxTipoColumnaAgregar.Text;
                    string delete = "ALTER TABLE " + "'" + ComboAgregarColumna.SelectedItem.ToString() + "'" + "ADD " + Nombre_ColumnaAgregar + " " + "=" + " " + tipo_Columna;
                    OleDbCommand cmd = new OleDbCommand(delete, orc.myConnection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("La columna se ha agregado correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar la columna, intentelo de nuevo" + ex);
                }
            }
            if (server != null)
            {

            }

        }
        private void comboAgregarColumna_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (orc != null)
            {
                this.Tabla_AgregarColumna.Text = ComboAgregarColumna.SelectedItem.ToString();
                string extraer_tabla = "Select * from " + ComboAgregarColumna.SelectedItem.ToString();

                OleDbCommand cmd = new OleDbCommand(extraer_tabla, orc.myConnection);
                DataTable datos = new DataTable(); // Guarda los datos en una tabla para poder mostrarlos
                OleDbDataAdapter adaptador = new OleDbDataAdapter(cmd);
                adaptador.Fill(datos); // Llena la tabla con los datos obtenidos del query
                GridAgregarColumna.DataSource = datos; // Pone los datos del resultado de la consulta en el gridView

            }
            if (server != null)
            {

            }

        }
        //Funcion que muestra los datos actualizados después de agregar algún dato
        private void MostrarDatosAgregarColumna_Click(object sender, EventArgs e)
        {
            string mostrar_tabla_actualizada = "Select * from " + ComboAgregarColumna.SelectedItem.ToString();
            OleDbCommand cmd = new OleDbCommand(mostrar_tabla_actualizada, orc.myConnection);
            DataTable datos = new DataTable();
            OleDbDataAdapter adaptador = new OleDbDataAdapter(cmd);
            adaptador.Fill(datos);
            GridAgregarColumna.DataSource = datos;

        }



















    }
}
