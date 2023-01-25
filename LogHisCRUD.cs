using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedRoomScheduling
{
   
    internal class LogHisCRUD : ICRUD
    {
        SqlCommand cmd;
        SqlConnection con;
        String server = ConnectionString.ConString;
        SqlDataAdapter adapter;
        DataSet ds;
        DataTable dt;
        SqlDataReader reader;
        String query;

    Random rand = new Random();
        public static String LogID { get; set; }
        public static String Activity { get; set; }

        public void Create()
        {
            con = new SqlConnection(server);
            con.Open();
            int x = rand.Next(0,int.MaxValue);

            LogID = "" + FrmDash.Yr + "" + FrmDash.Mnth + "" + FrmDash.Day + "" + FrmDash.Hr + "" + FrmDash.Min + "" + FrmDash.Sec + ""+FrmDash.Nanosec+""+x;
            if (LogID.Equals("0000000")) 
            {
                LogID = FrmLogin.LogID;
            }
            query = "insert into LogHistory " +
            "(LogID, Username, Activity)" +
            "values('" +LogID+ "', '" + AdminChecker.Admin + "' , '"+Activity+"')";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Retrieve()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
