using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;

namespace TestManagement
{
    public class clsSqlConnection
    {
        public static SqlConnection con()
        {
               //virtual database String
             // SqlConnection sqlcon = new SqlConnection("Data Source=SG2NWPLS19SQL-v04.mssql.shr.prod.sin2.secureserver.net;Integrated Security=False;User ID=GayasoftPsyTest;Password=aaditya$1811;Initial Catalog=PsychologicalTestMng;Encrypt=False;Packet Size=4096");
            //Local Database String
             SqlConnection sqlcon = new SqlConnection("Data Source=DESKTOP-RTCHIJF;Initial Catalog=TestManagement;Integrated Security=True");
            return sqlcon;
        }
       
    }
}
