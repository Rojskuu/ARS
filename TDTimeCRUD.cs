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
        Random rand = new Random();

        public static int Des { get; set; }
        public static int Asc { get; set; }
        public static String TDTID { get; set;}

        public TDTimeCRUD()
        {
            con = new SqlConnection(server);
        }

        public void Desc()
        {
            try 
            
            {
                con.Open();

                query = "Select TimeNo from TDTime where TDID = '"+TeacherDayCRUD.TDID+"'  Order by TimeNo Desc ";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Des = Convert.ToInt32(rdr.GetValue(0));
                    break;
                }

                con.Close();
            } catch (Exception ex) { MessageBox.Show(ex + ""); }
        
        }

        public void Ascend()
        {
            try
            {
               con.Open();

                query = "Select TimeNo from TDTime where TDID = '" + TeacherDayCRUD.TDID + "'  Order by TimeNo ASC ";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Asc= Convert.ToInt32(rdr.GetValue(0));
                    break;
                }

                con.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex + ""); }

        }

        public void Create()
        {
            try
            {
                int x = rand.Next();
                TDTID = "" + FrmDash.Yr + "" + FrmDash.Mnth + "" + FrmDash.Day + ""
                   + FrmDash.Hr + "" + FrmDash.Min + "" + FrmDash.Sec + "" + FrmDash.MilliSec + "" + FrmDash.Nanosec+""+x;

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
            catch (Exception ex ) { MessageBox.Show(ex + ""); }

        }

        public void Delete()
        {
            try 
            {
                con = new SqlConnection(server);
                con.Open();

                query = $"Delete from TDTime " +
                    "Where TDID = '" +TeacherDayCRUD.TDID+"'" ;

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();

            } catch (Exception ex) { MessageBox.Show(ex + ""); }


        }
        public void Retrieve()
        {
            
        }

        public void Update()
        {
            
        }
    }
}
