using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.ManagedDataAccess;
//using Oracle.Web;
using System.Data.OleDb;

namespace WindowsFormsApplication1
{

    class Conexion_Oracle
    {
        public string conexion;
        string user;
        string contrasennia;
        string database;
       public OleDbConnection myConnection;



        public Conexion_Oracle(string u, string db, string p)
        {
            
            user = u;
            database = db;
            contrasennia = p;
            conexion = "Provider=MSDAORA; User ID=" + user + ";password=" + contrasennia + "; Data Source=" + database + ";Persist Security Info=True";

            myConnection= new OleDbConnection(conexion);

        }
    }
}
