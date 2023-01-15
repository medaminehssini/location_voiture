using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CONTROLLER
{
    public class Connection
    {
        SqlConnection conn = new SqlConnection("database=Faculté;server=LAPTOP-69V4GC7B;User ID=sa;pwd=pass");

        public  Connection()
        {
            conn.Open ();
        }

        public Boolean executeCommand(SqlCommand cmd)
        {
            cmd.Connection = conn;
        
            if (cmd.ExecuteNonQuery() >= 1)
                return true;
            else
                return false;

        }
        public SqlDataReader SDD(string cmdch)
        {
            SqlCommand command = new SqlCommand(cmdch);
            command.Connection = conn;
            return command.ExecuteReader();
        }
    }
}
