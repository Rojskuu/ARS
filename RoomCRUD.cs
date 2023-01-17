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
    internal class RoomCRUD : ICRUD
    {
        SqlCommand cmd;
        SqlConnection con;
        String server = ConnectionString.ConString;
        SqlDataAdapter adapter;
        DataSet ds;
        DataTable dt;
        SqlDataReader reader;
        String query;

        RoomDayCRUD RoomDay = new RoomDayCRUD();
        RDTimeCRUD RDTime = new RDTimeCRUD();

        public static String RoomID { get; set; }
        public static String RoomType { get; set; }
        public static int RoomCap { get; set; }

        public static int DayNo { get; set; }
        public static int TimeNo { get; set; }


        public static String RoomDisplay = "Select RoomID AS 'Room ID' , RoomType AS 'Room Type', " +
            "Cap AS 'Capacity'  FROM ROOM WHERE Archive = 0";

        public void Create()
        {
            try
            {

                con = new SqlConnection(server);
                con.Open();


                query = "insert into Room " +
                "(RoomID, RoomType, Cap , Archive , Username ) " +
                "values('" + RoomID + "', '" + RoomType + "', '" + RoomCap + "', " +
                 + 0 + ", '" + AdminChecker.Admin + "')";


                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();


                RoomDayPopulate();

            }
            catch (Exception ex) { MessageBox.Show(ex + ""); }
        }

        public void RoomDayPopulate() 
        {
            try 
            {
                for (DayNo = 1; DayNo <= 6; DayNo++)
                {
                    RoomDay.Create();
                    FrmDash.Nanosec++;

                    for (TimeNo = 1; TimeNo <= 48 ; TimeNo++)
                    {
                        
                        RDTime.Create();
                        FrmDash.Nanosec++;
                    }
                }

            } catch (Exception ex) { MessageBox.Show(ex + ""); }        
        }

        public void Delete()
        {
            
        }

        public void CheckRoomIDifExist(String txt)
        {
            try
            {
                con = new SqlConnection(server);
                con.Open();

                query = "SELECT * FROM Room WHERE RoomID = '" + txt + "'";

                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@RoomID", txt);

                dt = new DataTable();

                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    MessageBox.Show("Room ID already exist. "
                        , "Existing ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            catch (Exception ex) { MessageBox.Show(ex + ""); }

        }

        public void Retrieve()
        {
            try
            {
                con = new SqlConnection(server);
                con.Open();

                query = "Select RoomType, Cap " +
                        "from Room where RoomID = '" + RoomID + "'";

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader rdr = cmd.ExecuteReader();
                
                while (rdr.Read())
                {
                    RoomType = rdr.GetString(0);
                    RoomCap = Convert.ToInt32(rdr.GetValue(1));
                }

                con.Close();

            }
            catch (Exception ex) { MessageBox.Show(ex + ""); }
        }

        public void Update()
        {
            try
            {
                con = new SqlConnection(server);
                con.Open();

                query = "update Room set " +
                         "RoomType = '" + RoomType + "', "
                       + "Cap = '" + RoomCap + "' "
                       + "WHERE RoomID = '" + RoomID + "'";


                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();

                cmd.Dispose();
                con.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex + ""); }
        }
    }
}
