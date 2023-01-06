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
    internal class SubjectCRUD : ICRUD
    {
        SqlCommand cmd;
        SqlConnection con;
        String server = @"Data Source=DESKTOP-3LSCP0F\SQLEXPRESS;Initial Catalog = ARS; Integrated Security = True";
        SqlDataAdapter adapter;
        DataSet ds;
        DataTable dt;
        SqlDataReader reader;
        String query;
        TimeSpan ts;

        public static String SubjectCode { get; set; }
        public static String SubjectDesc { get; set; }
        
        public static int SubjectUnit { get; set; }
        public static String SubjectHrsndd { get; set; }
        public static String ClassType { get; set; }
        public static String Department { get; set; }
        public static int Hrs { get; set; }
        public static int Min { get; set; }

        public static String SubDisplay = "Select SubCode AS 'Subject Code', SubDescript AS 'Subject Description'," +
            " unit AS 'Subject Unit' From Subj Where Archive = 0"; 
       
        public void Create()
        {
           try
           {
                 con = new SqlConnection(server);
                con.Open();

                query = $"insert into Subj " +
                    "(SubCode, SubDescript, ClassType, unit, Hrs,Department, Archive,Username)" +
                    "values('" + SubjectCode + "', '" + SubjectDesc + "', '"+ClassType+"', " + 
                    "'" + SubjectUnit + "', '" + SubjectHrsndd + "', '"+Department+"', " +
                    "'" +0+ "', '"+AdminChecker.Admin+"')";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
           }
           catch (Exception) { }

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

                query = "Select SubDescript, ClassType, unit, Hrs, Department " +
                        "from Subj where SubCode = '" + SubjectCode + "'";

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader rdr = cmd.ExecuteReader();
                
                while (rdr.Read())
                {
                    

                    SubjectDesc = rdr.GetString(0)+"";
                    ClassType = rdr.GetString(1);
                   
                    SubjectUnit = Convert.ToInt32(rdr.GetValue(2));

                    SubjectHrsndd = rdr.GetString(3);

                    if (TimeSpan.TryParse(SubjectHrsndd, out ts)) 
                    {
                        Hrs = ts.Hours;
                        Min = ts.Minutes;
                    }
                    Department = rdr.GetString(4);

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

                query = "UPDATE Subj set " +
                         "SubDescript = '" + SubjectDesc + "', "
                       + "ClassType = '" + ClassType + "', "
                       + "unit = '" + SubjectUnit + "', "
                       + "Hrs = '"+SubjectHrsndd+"' , " 
                       + "Department = '"+Department + "' "
                       + "WHERE SubCode = '"+SubjectCode+"'";


                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();

                cmd.Dispose();
                con.Close();



            }
            catch (Exception ex) { MessageBox.Show(ex + ""); }
        }
    }
}
