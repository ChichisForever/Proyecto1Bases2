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

    public class Conexion_Oracle
    {
        public string conexion;
       public string user;
        public string contrasennia;
       public string database;
       public OleDbConnection myConnection;
  
        public OleDbCommand cmd;
        public OleDbDataReader reader;



        public Conexion_Oracle(string u, string db, string p)
        {
            
            user = u;
            database = db;
            contrasennia = p;
            conexion = "Provider=MSDAORA; User ID=" + user + ";password=" + contrasennia + "; Data Source=" + database + ";Persist Security Info=True";

            myConnection= new OleDbConnection(conexion);
            myConnection = new OleDbConnection(conexion);
            cmd = myConnection.CreateCommand();
            
        }
    }
}
