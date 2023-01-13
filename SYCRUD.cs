using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomatedRoomScheduling
{
    
    internal class SYCRUD : ICRUD
    {
        SqlCommand cmd;
        SqlConnection con;
        String server = ConnectionString.ConString;
        SqlDataAdapter adapter;
        DataSet ds;
        DataTable dt;
        SqlDataReader reader;
        String query;

        public static ArrayList SYList = new ArrayList();
        public static String SYSem { get; set; }
        public static String SY { get; set; }
        public static String Sem { get; set; }




        public void Create()
        {
            try 
            {
                con = new SqlConnection(server);
                con.Open();

                query = $"insert into SYSem " +
                    "(SYSem, SY, Semester) " +
                    "values('" + SYSem+ "', '" + SY + "', '" + Sem + "')";
                    

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
            try
            {
                con = new SqlConnection(server);
                con.Open();

                query = $"Select SYSem from SYSem"
                    ;

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader rdr = cmd.ExecuteReader();
                int temp = 0;
                while (rdr.Read())
                {
                    SYList.Add(rdr.GetValue(rdr.GetOrdinal("SYSem")));
                    temp++;
                }
                    con.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex + "");
                                   }


        }

        public void Update()
        {
            
        }
    }
}
