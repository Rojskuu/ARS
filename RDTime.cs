using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedRoomScheduling
{
    internal class RDTime : ICRUD
    {
        SqlCommand cmd;
        SqlConnection con;
        String server = ConnectionString.ConString;
        SqlDataAdapter adapter;
        DataSet ds;
        DataTable dt;
        SqlDataReader reader;
        String query;

        public static String RDTID {get; set;}



        public void Create()
        {
            try
            {
                 RDTID = "" + FrmDash.Yr + "" + FrmDash.Mnth + "" + FrmDash.Day + "" 
                    + FrmDash.Hr + "" + FrmDash.Min + "" + FrmDash.Sec + "" + FrmDash.MilliSec;

                con = new SqlConnection(server);
                con.Open();

                query = $"insert into RDTime " +
                    "(RDID,TimeNo, IsOccupied, RDTID)" +
                    "values('" + RoomDay.RDID + "', " + RoomCRUD.TimeNo + ", "+0+", '" + RDTID + "')";

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
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
