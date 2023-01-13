using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedRoomScheduling
{
    internal class TDTimeCRUD : ICRUD
    {
        SqlCommand cmd;
        SqlConnection con;
        String server = ConnectionString.ConString;
        SqlDataAdapter adapter;
        DataSet ds;
        DataTable dt;
        SqlDataReader reader;
        String query;

        public static String TDTID { get; set;}
       
        public void Create()
        {
            try
            {
                TDTID = "" + FrmDash.Yr + "" + FrmDash.Mnth + "" + FrmDash.Day + ""
                   + FrmDash.Hr + "" + FrmDash.Min + "" + FrmDash.Sec + "" + FrmDash.MilliSec + "" + FrmDash.Nanosec;

                con = new SqlConnection(server);
                con.Open();

                query = $"insert into TDTime " +
                    "(TDID,TimeNo, IsOccupied, TDTID)" +
                    "values('" + TeacherDayCRUD.TDID + "', " + TeachCRUD.TimeNo + ", " + 0 + ", '" + TDTID + "')";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
            }
            catch (Exception) { }

        }

        public void Delete()
        {

        }
        public void Retrieve()
        {
            
        }

        public void Update()
        {
            
        }
    }
}
