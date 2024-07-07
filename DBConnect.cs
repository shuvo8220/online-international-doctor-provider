using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace KnockDoc
{
    internal class DBConnect
    {
        private SqlConnection con = new SqlConnection(@"Data Source=DARKPHANTOM\SQLEXPRESS;Initial Catalog=knock_doc;Integrated Security=True;");
        public SqlConnection GetCon()
        {
            return con; 
        } 
        public void OpenCon()
        {
            if(con.State==ConnectionState.Closed)
            {
                con.Open();
            }
        }
        public void CloseCon()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
