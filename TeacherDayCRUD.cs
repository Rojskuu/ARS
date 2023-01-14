using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomatedRoomScheduling
{
    internal class TeacherDayCRUD : ICRUD
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
        public static string TDID { get; set; }

        public TeacherDayCRUD()
        {
            con = new SqlConnection(server);
            
        }

        public void Create()
        {
            try
            {
                int x = rand.Next();
                TDID = "" + FrmDash.Yr + "" + FrmDash.Mnth + "" + FrmDash.Day + ""
                   + FrmDash.Hr + "" + FrmDash.Min + "" + FrmDash.Sec + "" + FrmDash.MilliSec + "" + FrmDash.Nanosec+""+x;

                con = new SqlConnection(server);
                con.Open();

                query = $"insert into TeacherDay " +
                    "(TeacherID,DayNo, TDID)" +
                    "values('" + TeachCRUD.TeacherID + "', " + TeachCRUD.DayNo
                    + ", '" + TDID + "')";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();

            }
            catch (Exception ex ) { MessageBox.Show(ex + ""); }
        }

        public void Delete()
        {
            try
            {
                con = new SqlConnection(server);
                con.Open();

                query = $"Delete from TeacherDay " +
                    "Where TDID = '" + TeacherDayCRUD.TDID + "'";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();

            }
            catch (Exception ex) { MessageBox.Show(ex + ""); }
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
