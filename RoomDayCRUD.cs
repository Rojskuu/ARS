using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedRoomScheduling
{
    internal class RoomDayCRUD : ICRUD
    {
        SqlCommand cmd;
        SqlConnection con;
        String server = ConnectionString.ConString;
        SqlDataAdapter adapter;
        DataSet ds;
        DataTable dt;
        SqlDataReader reader;
        String query;

        RDTimeCRUD RDTime = new RDTimeCRUD();

        public static String RDID { get; set; }
        

        public void Create()
        {
            try
            {
                RDID = "" + FrmDash.Yr + "" + FrmDash.Mnth + "" + FrmDash.Day + ""
                    + FrmDash.Hr + "" + FrmDash.Min + "" + FrmDash.Sec + "" + FrmDash.MilliSec+""+FrmDash.Nanosec;

                con = new SqlConnection(server);
                con.Open();

                query = $"insert into RoomDay " +
                    "(RoomID,DayNo,RDID)" +
                    "values('"+RoomCRUD.RoomID+"', "+RoomCRUD.DayNo+", '"+RDID+"')";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();

                

            }
            catch (Exception) { }
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Retrieve()
        {
            
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
