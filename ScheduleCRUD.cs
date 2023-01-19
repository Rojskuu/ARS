using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomatedRoomScheduling
{
    internal class ScheduleCRUD : ICRUD
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

        public static String ScheduleID { get; set; }
        

        public void Create()
        {

            try {

                con = new SqlConnection(server);
                con.Open();
                int x = rand.Next();
                ScheduleID = "" + FrmDash.Yr + "" + FrmDash.Mnth + "" + FrmDash.Day + ""
                    + FrmDash.Hr + "" + FrmDash.Min + "" + FrmDash.Sec + "" + FrmDash.MilliSec + "" + FrmDash.Nanosec + "" + x;

                query = "insert into SCHED(SchedID, ClassID, RoomID, SYSem ,araw, Timeframe, Username,  Archive) " +
                        " values( '" + ScheduleID + "' , '" + Algo.ClassID + "' , '" + Algo.RoomID + "' , '" + FrmDash.SYSem + "' , '" + Algo.Day + "', " +
                        " '" + Algo.TimeFrame + "', '" + AdminChecker.Admin + "' , " + 0;

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();

            } catch (Exception ex) { MessageBox.Show(ex + ""); }




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
