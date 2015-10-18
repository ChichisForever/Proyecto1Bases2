using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Eliminar : Form
    {
       
        public Eliminar()
        {
            InitializeComponent();

        }

        public void Datos_oracle(Conexion_Oracle orc)
        {
            
            //Llenar ComboEliminar con las tablas
            orc.cmd.CommandText = "Select Table_Name from user_tables";
            orc.reader = orc.cmd.ExecuteReader();
            while (orc.reader.Read())
            {
                ComboEliminar.Items.Add(orc.reader.GetString(0)); 
            }

            this.Nombre_tabla_eliminar.Text = this.ComboEliminar.SelectedItem.ToString();


        }

        public void Datos_sqlserver(Conexion_MSS server)
        {
            this.Nombre_tabla_eliminar.Text = this.ComboEliminar.SelectedItem.ToString();


        }

    }








}


