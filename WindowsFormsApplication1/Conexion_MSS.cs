using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    class Conexion_MSS
    {
        String user;
        String pass;
        String nbase;
       public  SqlConnection conexion;

        public Conexion_MSS(String u,String pass,String bd,int tipo)
        {
            user = u;
            this.pass = pass;
            nbase = bd;
            if (tipo == 0)
            {
                conexion = new SqlConnection("Data Source=.;Initial Catalog=" + nbase + ";Integrated Security=True");
            }
            if (tipo == 1)
            {
                conexion = new SqlConnection("Data Source=.;Initial Catalog=" + nbase + ";user id=" + user + ";password=" + pass);
            }
        }
    }
}
