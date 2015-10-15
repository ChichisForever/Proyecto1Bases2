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
            if (this.server != null)
            {
                mostrar_datos_sqlserver();
                
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

        }

        //Función que ejecuta el query para crear tipos y tablas en los objetos
        private void ejecutarObjeto_Click(object sender, EventArgs e)

        {
            string query_Objetos = queryObjetos.Text;
            string comando = query_Objetos.Substring(0, 6);
            OleDbCommand cmd = new OleDbCommand(query_Objetos, orc.myConnection);

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
                    // string query_Objetos = queryObjetos.Text; //String que tiene el query para crear objetos ingresados por el usuario
                    // OleDbCommand cmd = new OleDbCommand(query_Objetos, orc.myConnection); // Pasarle el string del select con la conexión a la base
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

            //Tipos de Objetos
            orc.cmd = orc.myConnection.CreateCommand();
            orc.cmd.CommandText = "select object_name from user_objects";
            orc.reader = orc.cmd.ExecuteReader();
            while (orc.reader.Read())
            {
                this.comboBoxDDL.Items.Add(orc.reader.GetValue(0));
            }

            //Nombres de los Objetos
            orc.cmd = orc.myConnection.CreateCommand();
            orc.cmd.CommandText = "select distinct object_type from user_objects";
            orc.reader = orc.cmd.ExecuteReader();
            while (orc.reader.Read())
            {
                this.comboBoxDDLTipo.Items.Add(orc.reader.GetValue(0));
            }

        }
        private void mostrar_datos_sqlserver()
        {
            this.dbname.Text = this.server.nbase;
            this.listObjetos.View = View.Details;
            this.listObjetos.Columns.Add("Selecione uno", 100,HorizontalAlignment.Center);
            this.listObjetos.Items.Add("Procedimientos");
            this.listObjetos.Items.Add("Funciones");
            this.listObjetos.Items.Add("Sinonimos");
            this.listObjetos.Items.Add("Triggers");

            server.cmd = new SqlCommand("Select TABLE_NAME from INFORMATION_SCHEMA.TABLES where TABLE_CATALOG='"+server.nbase+ "' and Table_Type='BASE TABLE'", server.conexion);
            server.reader = server.cmd.ExecuteReader();
            while (server.reader.Read()){
                this.tablas.Items.Add(server.reader[0]);

            }
            server.reader.Close();
            server.cmd = new SqlCommand("Select sys.indexes.name,INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE.TABLE_NAME,INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE.COLUMN_NAME,sys.indexes.is_unique from sys.indexes  inner join INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE on sys.indexes.name = INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE.CONSTRAINT_NAME; ",server.conexion);
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
            if (server != null)
            {
                server.cmd = new SqlCommand("Select COLUMN_NAME,DATA_TYPE,CHARACTER_MAXIMUM_LENGTH,IS_NULLABLE from INFORMATION_SCHEMA.COLUMNS where Table_Name = '"+tablas.SelectedItem.ToString() +"' and TABLE_CATALOG='"+server.nbase+"'", server.conexion);
                server.reader = server.cmd.ExecuteReader();
                while (server.reader.Read())
                {
                    tablaEscogida.Rows.Add(server.reader[0],server.reader[1], server.reader[2], server.reader[3]);
                }
                server.reader.Close();
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
            String seleccion="0";   
            if (listObjetos.SelectedItems.Count > 0)
            {
                ListViewItem listItem = this.listObjetos.SelectedItems[0];
                seleccion = listItem.Text;
                
            }
           
            if (server != null && seleccion!="0"){

                String comando = "";
                if (seleccion == "Procedimientos")
            {
                comando = "Select name from b2.dbo.sysobjects where xtype='P'";

            }
            if (seleccion == "Funciones")
            {
                comando = "Select name from b2.dbo.sysobjects where xtype='FN' ";
            }
            if (seleccion == "Sinonimos")
            {
                comando = "Select name from b2.dbo.sysobjects where xtype='SN' ";
            }

                listResultado.Clear();
                listResultado.View = View.List;

                try {
                    server.cmd = new SqlCommand(comando, server.conexion);
                    server.reader = server.cmd.ExecuteReader();


                    while (server.reader.Read()) {
                        listResultado.Items.Add(server.reader[0].ToString());
                    }
                    server.reader.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ops.Parece que tenemos un problema");
                }
            }

        }

<<<<<<< HEAD
        private void entradaQuery_TextChanged(object sender, EventArgs e)
        {

        }

        private void queryObjetos_TextChanged(object sender, EventArgs e)
        {

        }

        private void ejecutar_Click(object sender, EventArgs e) {

            if (orc != null) {
                string query = entradaQuery.Text;
                if (query[0].Equals('S') || query[0].Equals('s')) {
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
                    catch (Exception ex) {
                        MessageBox.Show("Ops.Parece que tenemos un problema" + ex);
                    }

                } else {
                    try {
                        OleDbCommand resultado = new OleDbCommand(query, orc.myConnection);
                        resultado.ExecuteNonQuery();
                        MessageBox.Show("Query Ejecutado");
                    } catch( Exception ex) {
                        MessageBox.Show("Ops.Parece que tenemos un problema"+ ex);
                    }
                }


            }
            
            if (orc == null)
            {

                MessageBox.Show("No conecta :((");
            }
            

            


=======
        private void mostrarDDL_Click(object sender, EventArgs e)
        {
            string objeto = comboBoxDDL.SelectedItem.ToString();
            string tipo = comboBoxDDLTipo.SelectedItem.ToString();

            if (tipo == "TABLE")
            {
                string query_Objetos = "SELECT DBMS_METADATA.GET_DDL('TABLE',u.table_name) FROM USER_TABLES u WHERE u.TABLE_NAME = " + objeto; //String que tiene el query para crear objetos ingresados por el usuario
                OleDbCommand cmd = new OleDbCommand(query_Objetos, orc.myConnection); // Pasarle el string del select con la conexión a la base
                DataSet datos = new DataSet(); // Guarda los datos en un set para poder mostrarlos
                OleDbDataAdapter adaptador = new OleDbDataAdapter(cmd);
                adaptador.Fill(datos); // Llena la tabla con los datos obtenidos del query
                cuadroMostrarDDL.DataSource = datos; // Pone los datos del resultado de la consulta en el gridView
            }


        }

        private void comboBoxDDL_SelectedIndexChanged(object sender, EventArgs e)
        {
            orc.cmd = orc.myConnection.CreateCommand();
            orc.cmd.CommandText = "select object_name from user_objects";
            orc.reader = orc.cmd.ExecuteReader();
            while (orc.reader.Read())
            {
              
                this.comboBoxDDL.Items.Add(orc.reader.GetValue(0));
            }

        }

        private void label3_Click_2(object sender, EventArgs e)
        {

        }

        private void comboBoxDDLTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            orc.cmd = orc.myConnection.CreateCommand();
            orc.cmd.CommandText = "select object_type from user_objects";
            orc.reader = orc.cmd.ExecuteReader();
            while (orc.reader.Read())
            {

                this.comboBoxDDLTipo.Items.Add(orc.reader.GetString(0));
            }
>>>>>>> origin/master
        }
    }

}