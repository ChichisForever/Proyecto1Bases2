﻿using System;
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
                try {
                    string Nombre_idActualizar = textBoxIDActualizar.Text;
                    string id_actualizar = textBoxNumIDActualizar.Text;
                    string valor_actualizar = TextBoxValorActualizar.Text;
                    string columna_actualizar = textBoxColumnaActualizar.Text;
                    string update = "UPDATE " + Combo_actualizar.SelectedItem.ToString() + "SET" + columna_actualizar + "=" + valor_actualizar + "WHERE" + Nombre_idActualizar.ToUpper() + "=" + id_actualizar + ";";
                    OleDbCommand cmd = new OleDbCommand(update, orc.myConnection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Los datos de la tabla se han actualizado correctamente");
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al actualizar los datos de la tabla, intentelo de nuevo");
                }
            }
            if(server != null)
            {

            }


        }
    }


    
}