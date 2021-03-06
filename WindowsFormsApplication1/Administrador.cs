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


//using Oracle.Web;
using System.Data.OleDb;


namespace WindowsFormsApplication1
{
    public partial class Administrador : Form
    {
        public Conexion_Oracle orc;
        private Conexion_MSS server;



        public Administrador(Conexion_Oracle o, Conexion_MSS m)
        {
            //Se inicializan las variables con el objeto creado anteriormente
            orc = o;
            server = m;
            InitializeComponent();

            if (orc != null)
            {
                mostrar_datos_oracle();
                //elim.Datos_oracle(orc);
            }
            if (this.server != null)
            {
                mostrar_datos_sqlserver();
                // elim.Datos_sqlserver(server);

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
            if (orc != null)
            {
                string query = entradaQuery.Text;
                try {
                    string nuevoquery = "EXPLAIN PLAN FOR " + query;
                    OleDbCommand resultado = new OleDbCommand(nuevoquery, orc.myConnection);
                    resultado.ExecuteNonQuery();
                    string ExcPlan = "select plan_table_output from table(dbms_xplan.display('plan_table', null, 'basic'))";
                    OleDbCommand plan = new OleDbCommand(ExcPlan, orc.myConnection);
                    DataTable datos = new DataTable();
                    OleDbDataAdapter adaptador = new OleDbDataAdapter(plan);
                    adaptador.Fill(datos);
                    GridExecPlan.DataSource = datos;

                    //DataTable datos = new DataTable();
                    //datos.Load(read);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ops.Parece que tenemos un problema" + ex);
                }


            }

            if (this.server != null)
            {
                try
                {
                    string query = entradaQuery.Text;
                    string nuevoquery = "With CTE AS( " + query + ") Select* from cte";
                    server.cmd = new SqlCommand("SET SHOWPLAN_ALL ON", server.conexion);
                    server.cmd.ExecuteNonQuery();
                    //server.cmd = new SqlCommand("GO", server.conexion);
                    //server.cmd.ExecuteNonQuery();
                    server.cmd = new SqlCommand(nuevoquery, server.conexion);
                    SqlDataAdapter adaptador = new SqlDataAdapter(server.cmd);
                    DataTable datos = new DataTable();
                    adaptador.Fill(datos);
                    GridExecPlan.DataSource = datos;
                }
                catch (Exception ex) {
                    MessageBox.Show("Ops.Parece que tenemos un problema" + ex);
                }
            }


        }




        private void eliminar_Click(object sender, EventArgs e)
        {
            Eliminar frm = new Eliminar(orc, server);
            frm.Show();
           

        }

        private void actualizar_Click(object sender, EventArgs e)
        {
            Actualizar frm = new Actualizar(orc, server);
            frm.Show();
           


        }

        private void Agregar_Columna_Click(object sender, EventArgs e)
        {
            AgregarColumna frm = new AgregarColumna(orc, server);
            frm.Show();
            


        }

        private void Eliminar_Columna_Click(object sender, EventArgs e)
        {
            EliminarColumna frm = new EliminarColumna(orc, server);
            frm.Show();
         

        }

        private void Modificar_Columna_Click(object sender, EventArgs e)
        {
            ModificarTamañoColumna frm = new ModificarTamañoColumna(orc, server);
            frm.Show();
           


        }


        //Función que ejecuta el query para crear tipos y tablas, insertar, eliminar y actualizar los objetos en oracle
        private void ejecutarObjeto_Click(object sender, EventArgs e)

        {
            string query_Objetos = queryObjetos.Text; //String que tiene el query para crear objetos ingresados por el usuario
            string comando = query_Objetos.Substring(0, 6); // Pasarle el string del select con la conexión a la base
            OleDbCommand cmd = new OleDbCommand(query_Objetos, orc.myConnection); //Se pasa el query y la conexion para que lo ejecute

            if (comando.ToUpper() == "INSERT" | comando.ToUpper() == "DELETE" | comando.ToUpper() == "CREATE" | comando.ToUpper() == "UPDATE")
            {
                try
                {

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("El query se ha realizado correctamente");

                }
                catch (Exception)
                {
                    MessageBox.Show("Error al ejecutar el query, vuelva a intentarlo");

                }
            }
            else
            {
                try
                {
                    DataTable datos = new DataTable(); // Guarda los datos en una tabla para poder mostrarlos
                    OleDbDataAdapter adaptador = new OleDbDataAdapter(cmd);
                    adaptador.Fill(datos); // Llena la tabla con los datos obtenidos del query
                    gridObjetos.DataSource = datos; // Pone los datos del resultado de la consulta en el gridView
                    MessageBox.Show("La consulta se ha realizado correctamente");


                }
                catch (Exception)
                {
                    MessageBox.Show("Error al ejecutar la consulta, vuelva a intentarlo");

                }


            }
        }
        //Función que realiza ma muestra de datos
        private void mostrar_datos_oracle()
        {
            this.dbname.Text = orc.database;
            this.label9.Text = "Informaciòn TableSpaces";
            this.listObjetos.View = View.Details;
            this.listObjetos.Columns.Add("Selecione uno", 100, HorizontalAlignment.Center);
            this.listObjetos.Items.Add("Procedimientos");
            this.listObjetos.Items.Add("Funciones");
            this.listObjetos.Items.Add("Sinonimos");
            this.listObjetos.Items.Add("Triggers");
            this.listObjetos.Items.Add("Paquetes");
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
            orc.reader.Close();
            //Indices
            orc.cmd = orc.myConnection.CreateCommand();
            orc.cmd.CommandText = "Select i.index_name,i.uniqueness,i.Table_name,col.column_name from user_indexes i inner join user_ind_columns col on i.Index_name = col.Index_name";
            orc.reader = orc.cmd.ExecuteReader();
            while (orc.reader.Read())
            {
                indices.Rows.Add(orc.reader.GetValue(0), orc.reader.GetValue(2), orc.reader.GetValue(3), orc.reader.GetValue(1));
            }
            orc.reader.Close();
            //Vistas
            orc.cmd = orc.myConnection.CreateCommand();
            orc.cmd.CommandText = "select view_name from user_views";
            orc.reader = orc.cmd.ExecuteReader();
            while (orc.reader.Read())
            {
                this.cboxvista.Items.Add(orc.reader.GetValue(0));
            }
            orc.reader.Close();

            try {
                orc.cmd = orc.myConnection.CreateCommand();
                orc.cmd.CommandText = "Select user_tablespaces.tablespace_name,sys.v_$datafile.bytes,(sys.v_$datafile.bytes-sys.dba_free_space.bytes),sys.dba_free_space.bytes from sys.dba_free_space  inner join sys.v_$tablespace on sys.dba_free_space.tablespace_name = sys.v_$tablespace.name inner join user_tablespaces on sys.v_$tablespace.name = user_tablespaces.tablespace_name inner join sys.v_$datafile on sys.v_$datafile.TS# = sys.v_$tablespace.TS#";
                orc.reader = orc.cmd.ExecuteReader();
                while (orc.reader.Read())
                {

                    this.infoTablespace.Rows.Add(orc.reader.GetValue(0), orc.reader.GetValue(1).ToString(), orc.reader.GetValue(2), orc.reader.GetValue(3));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Parece que no tenemos suficientes permisos para mostrar la información del tablespace");
            }

            orc.cmd = orc.myConnection.CreateCommand();
            orc.cmd.CommandText = "select DISTINCT SID, SERIAL#, STATUS, SYS.utl_inaddr.get_host_name, SCHEMA#, SQL_ID, USERNAME from V$SESSION, dual";
            orc.reader = orc.cmd.ExecuteReader();
            while (orc.reader.Read())
            {

                this.infoSesion.Rows.Add(orc.reader.GetValue(0), orc.reader.GetValue(1), orc.reader.GetValue(2).ToString(), orc.reader.GetValue(3).ToString(), orc.reader.GetValue(4), orc.reader.GetValue(5), orc.reader.GetValue(6).ToString());
            }

            this.comboBoxDDLTipo.Items.Add("INDEX");
            this.comboBoxDDLTipo.Items.Add("TABLE");
            this.comboBoxDDLTipo.Items.Add("VIEW");
        }

        private void mostrar_datos_sqlserver()
        {
            this.dbname.Text = this.server.nbase;
            this.label9.Text = "Informacion Archivos del Sistema";
            this.ventana.TabPages.Remove(objetos);
            this.listObjetos.View = View.Details;
            this.listObjetos.Columns.Add("Selecione uno", 100, HorizontalAlignment.Center);
            this.listObjetos.Items.Add("Procedimientos");
            this.listObjetos.Items.Add("Funciones");
            this.listObjetos.Items.Add("Sinonimos");
            this.listObjetos.Items.Add("Triggers");

            server.cmd = new SqlCommand("Select TABLE_NAME from INFORMATION_SCHEMA.TABLES where TABLE_CATALOG='" + server.nbase + "' and Table_Type='BASE TABLE'", server.conexion);
            server.reader = server.cmd.ExecuteReader();
            while (server.reader.Read()) {
                this.tablas.Items.Add(server.reader[0]);

            }
            server.reader.Close();
            server.cmd = new SqlCommand("Select sys.indexes.name,INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE.TABLE_NAME,INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE.COLUMN_NAME,sys.indexes.is_unique from sys.indexes  inner join INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE on sys.indexes.name = INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE.CONSTRAINT_NAME; ", server.conexion);
            server.reader = server.cmd.ExecuteReader();
            while (server.reader.Read())
            {
                this.indices.Rows.Add(server.reader[0], server.reader[1], server.reader[2], server.reader[3]);
            }
            server.reader.Close();
            server.cmd = new SqlCommand("Select TABLE_NAME from INFORMATION_SCHEMA.TABLES where TABLE_CATALOG='" + server.nbase + "' and Table_Type='VIEW'", server.conexion);
            server.reader = server.cmd.ExecuteReader();
            while (server.reader.Read())
            {
                this.cboxvista.Items.Add(server.reader[0]);
            }
            server.reader.Close();

            //Informacion de Archivos del sistema
            server.cmd = new SqlCommand("SELECT f.name,total_bytes,(total_bytes-available_bytes),available_bytes FROM sys.database_files AS f CROSS APPLY sys.dm_os_volume_stats(DB_ID(f.name), f.file_id); ", server.conexion);
            server.reader = server.cmd.ExecuteReader();
            while (server.reader.Read()) {
                this.infoTablespace.Rows.Add(server.reader[0], server.reader[1], server.reader[2], server.reader[3]);
            }
            server.reader.Close();

            server.cmd = new SqlCommand("select session_id, Serial = null, status, host_name, (select SCHEMA_NAME()) AS 'Schema', comando = null, nt_user_name from sys.dm_exec_sessions", server.conexion);
            server.reader = server.cmd.ExecuteReader();
            while (server.reader.Read())
            {
                this.infoSesion.Rows.Add(server.reader[0], server.reader[1].ToString(), server.reader[2].ToString(), server.reader[3].ToString(), server.reader[4].ToString(), server.reader[5].ToString(), server.reader[6].ToString());
            }
            server.reader.Close();

            this.comboBoxDDLTipo.Items.Add("USER_TABLE");
            this.comboBoxDDLTipo.Items.Add("VIEW");
            this.comboBoxDDLTipo.Items.Add("PRIMARY_KEY_CONSTRAINT");
            this.comboBoxDDLTipo.Items.Add("UNIQUE_CONSTRAINT");
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
                orc.reader.Close();

                orc.cmd = orc.myConnection.CreateCommand();
                orc.cmd.CommandText = "select partitioned from user_tables where table_name='" + tablas.SelectedItem.ToString() + "'";
                orc.reader = orc.cmd.ExecuteReader();

                while (orc.reader.Read())
                {
                    if (orc.reader.GetValue(0).ToString() == "YES")
                    {

                        this.lblparticion.Visible = true;
                        this.tableParticiones.Visible = true;
                        this.lbltipoparticiones.Visible = true;

                    }
                    else
                    {
                        this.lblparticion.Visible = false;
                        this.tableParticiones.Visible = false;
                        this.lbltipoparticiones.Visible = false;
                    }
                }
                orc.reader.Close();
                this.tableParticiones.Rows.Clear();
                orc.cmd = orc.myConnection.CreateCommand();
                orc.cmd.CommandText = "Select partition_name,composite from user_tab_partitions where table_name='" + tablas.SelectedItem.ToString() + "'";
                orc.reader = orc.cmd.ExecuteReader();
                while (orc.reader.Read())
                {
                    this.tableParticiones.Rows.Add(orc.reader.GetValue(0), orc.reader.GetValue(1));
                }

                orc.reader.Close();
                lbltipoparticiones.Text = "Esta tabla cuenta con las siguientes particiones:";
                orc.cmd = orc.myConnection.CreateCommand();
                orc.cmd.CommandText = "select partitioning_type from user_part_tables where table_name='" + tablas.SelectedItem.ToString() + "'";
                orc.reader = orc.cmd.ExecuteReader();
                while (orc.reader.Read())
                {
                    this.lbltipoparticiones.Text = lbltipoparticiones.Text + "   " + orc.reader.GetValue(0);
                }
                orc.reader.Close();



            }

            if (server != null)
            {
                server.cmd = new SqlCommand("Select COLUMN_NAME,DATA_TYPE,CHARACTER_MAXIMUM_LENGTH,IS_NULLABLE from INFORMATION_SCHEMA.COLUMNS where Table_Name = '" + tablas.SelectedItem.ToString() + "' and TABLE_CATALOG='" + server.nbase + "'", server.conexion);

                server.reader = server.cmd.ExecuteReader();
                while (server.reader.Read())
                {
                    tablaEscogida.Rows.Add(server.reader[0], server.reader[1], server.reader[2], server.reader[3]);
                }
                server.reader.Close();
            

            int contador = 0;
            server.cmd = new SqlCommand("SELECT *FROM sys.tables AS t JOIN sys.indexes AS i ON t.[object_id] = i.[object_id]  AND i.[type] IN (0,1) JOIN sys.partition_schemes ps ON i.data_space_id = ps.data_space_id  WHERE t.name ='" + tablas.SelectedItem.ToString() + "'", server.conexion);
            server.reader = server.cmd.ExecuteReader();
            while (server.reader.Read())
            {
                contador = contador + 1;
            }


            server.reader.Close();

                if (contador > 0)
                {
                    this.tableparticionesw.Visible = true;
                    this.lblparticion.Visible = true;
                    server.cmd = new SqlCommand("SELECT i.name AS IndexName, p.partition_number, f.name, f.type_desc  FROM sys.tables AS t JOIN sys.indexes AS i ON t.object_id = i.object_id JOIN sys.partitions AS p ON i.object_id = p.object_id AND i.index_id = p.index_id JOIN  sys.partition_schemes AS s ON i.data_space_id = s.data_space_id JOIN sys.partition_functions AS f  ON s.function_id = f.function_id WHERE t.name = '" + this.tablas.SelectedItem.ToString() + "'AND i.type <= 1 ORDER BY p.partition_number", server.conexion);
                    server.reader = server.cmd.ExecuteReader();
                    while (server.reader.Read())
                    {
                        this.tableparticionesw.Rows.Add(server.reader[0], server.reader[1], server.reader[2], server.reader[3]);
                    }
                    server.reader.Close();
                }
                else
                {
                    this.tableparticionesw.Visible = false;
                    this.lblparticion.Visible = false;

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
                orc.reader.Close();

            }
            if (server != null)
            {
                server.cmd = new SqlCommand("Select COLUMN_NAME,DATA_TYPE,CHARACTER_MAXIMUM_LENGTH,IS_NULLABLE from INFORMATION_SCHEMA.COLUMNS where Table_Name = '" + cboxvista.SelectedItem.ToString() + "' and TABLE_CATALOG='" + server.nbase + "'", server.conexion);
                server.reader = server.cmd.ExecuteReader();
                while (server.reader.Read())
                {
                    vista.Rows.Add(server.reader[0], server.reader[1], server.reader[2], server.reader[3]);
                }
                server.reader.Close();


            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String seleccion = "0";
            String comando = "";
            listResultado.Clear();
            listResultado.View = View.List;
            if (listObjetos.SelectedItems.Count > 0)
            {
                ListViewItem listItem = this.listObjetos.SelectedItems[0];
                seleccion = listItem.Text;

            }
            if (orc != null && seleccion != "0")
            {
                if (seleccion == "Procedimientos")
                {
                    comando = "select object_name from all_objects where object_type = 'PROCEDURE' AND owner='" + orc.user.ToUpper() + "'";

                }
                if (seleccion == "Funciones")
                {
                    comando = "select object_name from all_objects where object_type = 'FUNCTION' AND owner='" + orc.user.ToUpper() + "'";
                }
                if (seleccion == "Sinonimos")
                {
                    comando = "select object_name from all_objects where object_type = 'SYNONYM' AND owner='" + orc.user.ToUpper() + "'";
                }
                if (seleccion == "Triggers")
                {
                    comando = "select object_name from all_objects where object_type = 'TRIGGER' AND owner='" + orc.user.ToUpper() + "'";
                }
                if (seleccion == "Paquetes")
                {
                    comando = "select object_name from all_objects where object_type = 'PACKAGE' AND owner='" + orc.user.ToUpper() + "'";
                }



                orc.cmd = orc.myConnection.CreateCommand();
                orc.cmd.CommandText = comando;
                orc.reader = orc.cmd.ExecuteReader();

                while (orc.reader.Read())
                {
                    listResultado.Items.Add(orc.reader.GetValue(0).ToString());
                }
                orc.reader.Close();

            }
            if (server != null && seleccion != "0")
            {


                if (seleccion == "Procedimientos")
                {
                    comando = "Select name from " + server.nbase + ".dbo.sysobjects where xtype='P'";

                }
                if (seleccion == "Funciones")
                {
                    comando = "Select name from " + server.nbase + ".dbo.sysobjects where xtype='FN' ";
                }
                if (seleccion == "Sinonimos")
                {
                    comando = "Select name from " + server.nbase + ".dbo.sysobjects where xtype='SN' ";
                }
                if (seleccion == "Triggers")
                {
                    comando = "Select name from " + server.nbase + ".dbo.sysobjects where xtype='TR'";
                }
                try
                {
                    server.cmd = new SqlCommand(comando, server.conexion);
                    server.reader = server.cmd.ExecuteReader();

                    while (server.reader.Read())
                    {
                        listResultado.Items.Add(server.reader[0].ToString());
                    }
                    server.reader.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ops.Parece que tenemos un problema. ");
                }
            }

        }

        private void entradaQuery_TextChanged(object sender, EventArgs e)
        {

        }

        private void queryObjetos_TextChanged(object sender, EventArgs e)
        {

        }

        private void ejecutar_Click(object sender, EventArgs e)
        {

            if (orc != null)
            {
                string query = entradaQuery.Text;
                if (query[0].Equals('S') || query[0].Equals('s'))
                {
                    try
                    {
                        OleDbCommand resultado = new OleDbCommand(query, orc.myConnection);
                        //OleDbDataReader read = resultado.ExecuteReader();
                        DataTable datos = new DataTable();
                        //datos.Load(read);
                        OleDbDataAdapter adaptador = new OleDbDataAdapter(resultado);
                        adaptador.Fill(datos);
                        GridConsultas.DataSource = datos;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ops.Parece que tenemos un problema" + ex);
                    }

                }
                else
                {
                    try
                    {
                        OleDbCommand resultado = new OleDbCommand(query, orc.myConnection);
                        resultado.ExecuteNonQuery();
                        MessageBox.Show("Query Ejecutado");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ops.Parece que tenemos un problema" + ex);
                    }
                }


            }

            if (this.server != null) {
                string query = entradaQuery.Text;
                if (query[0].Equals('S') || query[0].Equals('s'))
                {
                    try
                    {
                        server.cmd = new SqlCommand(query, server.conexion);
                        SqlDataAdapter adaptador = new SqlDataAdapter(server.cmd);
                        DataTable datos = new DataTable();
                        adaptador.Fill(datos);
                        GridConsultas.DataSource = datos;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ops.Parece que tenemos un problema" + ex);
                    }
                }
                else {
                    try
                    {
                        server.cmd = new SqlCommand(query, server.conexion);
                        server.cmd.ExecuteNonQuery();
                        MessageBox.Show("El query fue ejecutado correctamente");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ops.Parece que tenemos un problema" + ex);
                    }
                }
            }

        }




       private void mostrarDDL_Click(object sender, EventArgs e)
        {
            if (orc != null)
            {
                try
                {
                    string tipo = comboBoxDDLTipo.SelectedItem.ToString();
                    EjecutarDLLOracle(tipo);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ocurrió un Problema, no se pudo ejecutar la consulta.");
                }
            }

            if (server != null)
            {
                try
                {
                    string tipo = comboBoxDDLTipo.SelectedItem.ToString();
                    EjecutarDDLMSS(tipo);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ocurrió un Problema, no se pudo ejecutar la consulta.");
                }
            }
        }
        
       private void EjecutarDLLOracle(String tipo)
        {
            string objeto = comboBoxDDL.SelectedItem.ToString();
            using (OracleConnection oraConn = new OracleConnection("data source=" + orc.database + ";user id=" + orc.user + ";password=" + orc.contrasennia))
            {
                oraConn.Open();

                using (OracleCommand cmd = new OracleCommand())
                {
                    cmd.Connection = oraConn;
                    cmd.CommandText = "dbms_metadata.get_ddl";
                    cmd.CommandType = CommandType.StoredProcedure;

                    OracleParameter clobparam = new OracleParameter();
                    clobparam.OracleDbType = OracleDbType.Clob;
                    clobparam.Direction = ParameterDirection.ReturnValue;
                    cmd.Parameters.Add(clobparam);

                    OracleParameter parmObjectType = new OracleParameter();
                    parmObjectType.OracleDbType = OracleDbType.Varchar2;
                    parmObjectType.ParameterName = "OBJECT_TYPE";
                    parmObjectType.Value = tipo;
                    cmd.Parameters.Add(parmObjectType);

                    OracleParameter parmObjectName = new OracleParameter();
                    parmObjectName.OracleDbType = OracleDbType.Varchar2;
                    parmObjectName.ParameterName = "NAME";
                    parmObjectName.Value = objeto;
                    cmd.Parameters.Add(parmObjectName);

                    OracleParameter parmObjectOwner = new OracleParameter();
                    parmObjectOwner.OracleDbType = OracleDbType.Varchar2;
                    parmObjectOwner.ParameterName = "SCHEMA";
                    parmObjectOwner.Value = orc.user.ToUpper();
                    cmd.Parameters.Add(parmObjectOwner);

                    cmd.ExecuteNonQuery();

                    this.cuadroMostrarDDL.Text = (((Oracle.DataAccess.Types.OracleClob)clobparam.Value).Value);

                    clobparam.Dispose();
                }
            }

        }

        private void EjecutarDDLMSS(String tipo)
        {
            string objeto = comboBoxDDL.SelectedItem.ToString();
            List<string> Columnas = new List<string>();
            List<string> FKS = new List<string>();
            List<string> PKS = new List<string>();
            List<string> Types = new List<string>();
            string command = "select * from " + objeto + ";";
            string connectionString = "Server=localhost;Database=Administrador_DB;Trusted_Connection=True;";
            string response = "CREATE TABLE " + objeto + " ( ";
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;
            SqlCommand myCommand;
            SqlDataReader myReader;
            connection.Open();
            myCommand = new SqlCommand(command, connection);
            myReader = myCommand.ExecuteReader();
            if (myReader.HasRows)
            {
                for (int i = 0; i < myReader.FieldCount; i++)
                {
                    Columnas.Add(myReader.GetName(i).ToString());
                }
                connection.Close();
                for (int i = 0; i < Columnas.Count; i++)
                {
                    connection.Open();
                    myCommand = new SqlCommand("select * from INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE as s where s.CONSTRAINT_NAME like '%FK_%' and s.TABLE_NAME = '" + objeto + "' and s.COLUMN_NAME = '" + Columnas[i] + "';", connection);
                    myReader = myCommand.ExecuteReader();
                    while (myReader.Read())
                    {
                        if (myReader["COLUMN_NAME"].ToString() != "")
                        {
                            FKS.Add(myReader["COLUMN_NAME"].ToString());
                        }
                    }
                    connection.Close();
                }
                for (int i = 0; i < Columnas.Count; i++)
                {
                    connection.Open();
                    myCommand = new SqlCommand("select * from INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE as s where s.CONSTRAINT_NAME like '%PK_%' and s.TABLE_NAME = '" + objeto + "' and s.COLUMN_NAME = '" + Columnas[i] + "';", connection);
                    myReader = myCommand.ExecuteReader();
                    while (myReader.Read())
                    {
                        if (myReader["COLUMN_NAME"].ToString() != "")
                        {
                            PKS.Add(myReader["COLUMN_NAME"].ToString());
                        }
                    }
                    connection.Close();
                }
                connection.Open();
                myCommand = new SqlCommand("select '  ['+column_name+'] ' + data_type + coalesce('('+cast(character_maximum_length as varchar)+')','') + ' ' + case when exists ( select id from syscolumns where object_name(id)='" + objeto + "' and name=column_name and columnproperty(id,name,'IsIdentity') = 1 ) then 'IDENTITY(' + cast(ident_seed('" + objeto + "') as varchar) + ',' + cast(ident_incr('" + objeto + "') as varchar) + ')' else '' end  + ' ' + ( case when IS_NULLABLE = 'No' then 'NOT ' else '' end ) + 'NULL ' + coalesce('DEFAULT '+COLUMN_DEFAULT,'') + ',' as col from information_schema.columns where table_name = '" + objeto + "' order by ordinal_position;", connection);
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    if (myReader["col"].ToString() != "")
                    {
                        Types.Add(myReader["col"].ToString());
                    }
                }
                connection.Close();
                for (int i = 0; i < Types.Count; i++)
                {
                    response += Types[i].ToString() + " ";
                }
                for (int i = 0; i < PKS.Count; i++)
                {
                    response += "PRIMARY KEY (" + PKS[i].ToString() + ") ";
                }
                for (int i = 0; i < FKS.Count; i++)
                {
                    connection.Open();
                    myCommand = new SqlCommand("select 'CONSTRAINT ['+ c1.CONSTRAINT_NAME +'] FOREING KEY (['+c1.COLUMN_NAME+']) REFERENCES ['+ c2.TABLE_SCHEMA+'].['+c2.TABLE_NAME+'] (['+c2.COLUMN_NAME+'])' as Cons from INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE as c1,INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE as c2, INFORMATION_SCHEMA.REFERENTIAL_CONSTRAINTS as r where c1.CONSTRAINT_NAME = r.CONSTRAINT_NAME and r.UNIQUE_CONSTRAINT_NAME = c2.CONSTRAINT_NAME and c1.COLUMN_NAME = '" + FKS[i].ToString() + "';", connection);
                    myReader = myCommand.ExecuteReader();
                    while (myReader.Read())
                    {
                        if (myReader["Cons"].ToString() != "")
                        {
                            response += (myReader["Cons"].ToString()) + "";
                        }
                    }
                    connection.Close();
                }
            }
            try
            {
                this.cuadroMostrarDDL.Text = response;
            }

            catch
            {
                MessageBox.Show("Ocurrió un Problema, no se pudo ejecutar la consulta.");
            }
        }


        private void comboBoxDDL_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label3_Click_2(object sender, EventArgs e)
        {

        }

        private void comboBoxDDLTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.comboBoxDDL.Items.Clear();
            string tipo = comboBoxDDLTipo.SelectedItem.ToString();
            
            if (orc != null)
            {
                if (tipo == "TABLE")
                {
                    try
                    {
                        orc.cmd = orc.myConnection.CreateCommand();
                        orc.cmd.CommandText = "select object_name from user_objects where object_type = 'TABLE'";
                        orc.reader = orc.cmd.ExecuteReader();
                        while (orc.reader.Read())
                        {
                            this.comboBoxDDL.Items.Add(orc.reader.GetValue(0));
                        }
                        orc.reader.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ocurrió un Problema, no se pudo conectar con la base de datos.");
                    }
                }

                if (tipo == "VIEW")
                {
                    try
                    {
                        orc.cmd = orc.myConnection.CreateCommand();
                        orc.cmd.CommandText = "select object_name from user_objects where object_type = 'VIEW'";
                        orc.reader = orc.cmd.ExecuteReader();
                        while (orc.reader.Read())
                        {
                            this.comboBoxDDL.Items.Add(orc.reader.GetValue(0));
                        }
                        orc.reader.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ocurrió un Problema, no se pudo conectar con la base de datos.");
                    }
                }

                if (tipo == "INDEX")
                {
                    try
                    {
                        orc.cmd = orc.myConnection.CreateCommand();
                        orc.cmd.CommandText = "select object_name from user_objects where object_type = 'INDEX'";
                        orc.reader = orc.cmd.ExecuteReader();
                        while (orc.reader.Read())
                        {
                            this.comboBoxDDL.Items.Add(orc.reader.GetValue(0));
                        }
                        orc.reader.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ocurrió un Problema, no se pudo conectar con la base de datos.");
                    }
                }
            }

            if (server != null)
            {
                if (tipo == "USER_TABLE")
                {
                    try
                    {
                        server.cmd = new SqlCommand("select name from sys.objects where type_desc = 'USER_TABLE'", server.conexion);
                        server.reader = server.cmd.ExecuteReader();
                        while (server.reader.Read())
                        {
                            this.comboBoxDDL.Items.Add(server.reader[0]);
                        }
                        server.reader.Close();
                    }

                    catch (Exception)
                    {
                        MessageBox.Show("Ocurrió un Problema, no se pudo conectar con la base de datos.");
                    }
                }

                if (tipo == "VIEW")
                {
                    try
                    {
                        server.cmd = new SqlCommand("select name from sys.objects where type_desc = 'VIEW'", server.conexion);
                        server.reader = server.cmd.ExecuteReader();
                        while (server.reader.Read())
                        {
                            this.comboBoxDDL.Items.Add(server.reader[0]);
                        }
                        server.reader.Close();
                    }

                    catch (Exception)
                    {
                        MessageBox.Show("Ocurrió un Problema, no se pudo conectar con la base de datos.");
                    }
                }

                if (tipo == "PRIMARY_KEY_CONSTRAINT")
                {
                    try
                    {
                        server.cmd = new SqlCommand("select name from sys.objects where type_desc = 'PRIMARY_KEY_CONSTRAINT'", server.conexion);
                        server.reader = server.cmd.ExecuteReader();
                        while (server.reader.Read())
                        {
                            this.comboBoxDDL.Items.Add(server.reader[0]);
                        }
                        server.reader.Close();
                    }

                    catch (Exception)
                    {
                        MessageBox.Show("Ocurrió un Problema, no se pudo conectar con la base de datos.");
                    }
                }

                if (tipo == "UNIQUE_CONSTRAINT")
                {
                    try
                    {
                        server.cmd = new SqlCommand("select name from sys.objects where type_desc = 'UNIQUE_CONSTRAINT'", server.conexion);
                        server.reader = server.cmd.ExecuteReader();
                        while (server.reader.Read())
                        {
                            this.comboBoxDDL.Items.Add(server.reader[0]);
                        }
                        server.reader.Close();
                    }

                    catch (Exception)
                    {
                        MessageBox.Show("Ocurrió un Problema, no se pudo conectar con la base de datos.");
                    }
                }
            }

        }

        private void planEjecution_Click(object sender, EventArgs e)
        {

        }

        private void DdlObject_Click(object sender, EventArgs e)
        {

        }

        private void info3_Click(object sender, EventArgs e)
        {

        }

        private void info4_Click(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void infoTablespace_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}