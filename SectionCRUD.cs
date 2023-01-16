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
    internal class SectionCRUD : ICRUD
    {
        SqlCommand cmd;
        SqlConnection con;
        String server = ConnectionString.ConString;
        SqlDataAdapter adapter;
        DataSet ds;
        DataTable dt;
        SqlDataReader reader;
        String query;

        public static String SecDisplay = "Select SectionID AS 'Section ID' , SecCnt AS 'Student Count' , Course AS 'Course' " +
            ", Yearlvl AS 'Year level' from Section  where Archive = 0";

        public static String SectionID { get; set; }
        public static int SectionCount { get; set; }
        public static String Course { get; set; }
        public static String Yrlvl { get; set; }

        public void Create() 
        {
            try {

                con = new SqlConnection(server);
                con.Open();

            
                query = "insert into Section " +
                "(SectionID, SecCnt, Course, Yearlvl, Archive , Username)" +
                "values('" + SectionID +"-"+FrmDash.SYSem+ "', '" + SectionCount + "', '" + Course + "', " +
                "'" + Yrlvl + "', '" + 0 + "', '" + AdminChecker.Admin + "')";

            
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();


        } catch (Exception) { }

}
        public void Update() 
        {
            try
            {
                con = new SqlConnection(server);
                con.Open();

                query = "update Section set " +
                         "SecCnt = '" + SectionCount + "', "
                       + "Course = '" + Course + "', "
                       + "Yearlvl = '" + Yrlvl + "' WHERE SectionID = '" + SectionID+"'";
                      

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();

                cmd.Dispose();
                con.Close();



            }
            catch (Exception ex) { MessageBox.Show(ex + ""); }
        }
        public void Delete() 
        { 

        }

        public void CheckSectionIDifExist(String txt)
        {
            try
            {
                con = new SqlConnection(server);
                con.Open();

                query = "SELECT * FROM Section WHERE SectionID = '" + txt + "'";

                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@SectionID", txt);

                dt = new DataTable();

                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    MessageBox.Show("Section ID already exist. "
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

                query = "Select SecCnt, Course, Yearlvl " +
                        "from Section where SectionID = '"+SectionID +"'";
                
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader rdr = cmd.ExecuteReader();
               
                while (rdr.Read())
                {
                   //MessageBox.Show(rdr.GetString(0) + " " + rdr.GetString(1) + " " + rdr.GetString(2));
                   
                    SectionCount = Convert.ToInt32(rdr.GetValue(0));
                    Course = rdr.GetString(1) + "";
                    Yrlvl = rdr.GetString(2) + "";

                    
                   
                }

                con.Close();

            }
            catch (Exception ex) { MessageBox.Show(ex + ""); }
        }


    }


}
