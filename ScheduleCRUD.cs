using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public static String ScheduleID { get; set; }
        public static String ClassID { get; set; }
        public static String RoomID { get; set; }
        public static String Day { get; set; }
         public static String Time { get; set; }

        public void Create()
        {
            
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
