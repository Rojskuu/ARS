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
    internal class ClassCRUD : ICRUD
    {
        SqlCommand cmd;
        SqlConnection con;
        String server = @"Data Source=DESKTOP-3LSCP0F\SQLEXPRESS;Initial Catalog = ARS; Integrated Security = True";
        SqlDataAdapter adapter;
        DataSet ds;
        DataTable dt;
        SqlDataReader reader;
        String query;

        public static String ClassDisplay = "SELECT ClassID AS 'Class ID', SubCode AS 'Subject Code', " +
            "SectionID AS 'Section ID', TeacherID AS 'Teacher ID' FROM CLASS";

        public static bool Exist { get; set; }

        public static String ClassID ;
        public static String RoomID {get;set;}
        public static String TeacherID {get;set;}
        public static String SectionID {get;set;}
        public static String SubjectCode { get; set; }





        public void Create()
        {
            try
            {
                ClassID = "" + FrmDash.Yr + "" + FrmDash.Mnth + "" + FrmDash.Day + "" + FrmDash.Hr + "" + FrmDash.Min + "" + FrmDash.Sec + "";

                con = new SqlConnection(server);
                con.Open();


                query = "insert into CLASS " +
                "(ClassID, SubCode, SectionID, TeacherID , Archive , Username ) " +
                "values('" + ClassID + "', '" + SubjectCode + "', '" + SectionID + "', '" + TeacherID + "' ," +
                "'" + 0 + "', '" + AdminChecker.Admin + "')";


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

        public void Retrieve()
        {
            try
            {
                con = new SqlConnection(server);
                con.Open();

                query = "Select SubCode, SectionID, TeacherID " +
                        "from CLASS where ClassID = '" + ClassID + "'";

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    SubjectCode = rdr.GetString(0);
                    SectionID = rdr.GetString(1);
                    TeacherID = rdr.GetString(2);

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

                query = "update Class set " +
                         "SubCode = '" + SubjectCode + "', "
                       + "SectionID = '" + SectionID + "', "
                       + "TeacherID = '" + TeacherID + "' WHERE ClassID = '" + ClassID + "'";


                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();

                cmd.Dispose();
                con.Close();



            }
            catch (Exception ex) { MessageBox.Show(ex + ""); }
        }
    }
}
