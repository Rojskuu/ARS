using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace AutomatedRoomScheduling
{

    internal class TeachCRUD : ICRUD
    {
        SqlCommand cmd;
        SqlConnection con;
        String server = @"Data Source=DESKTOP-3LSCP0F\SQLEXPRESS;Initial Catalog = ARS; Integrated Security = True";
        SqlDataAdapter adapter;
        DataSet ds;
        DataTable dt;
        SqlDataReader reader;
        String query;




        public static String TeachDisplay = "Select TeacherID as 'Teacher ID', concat(FName, ' ', MName, '. ', LName) as Name," +
                    " Sex, Degree AS 'Highest form of Education', EmpType As 'Employee Type'" +
                       " FROM Teacher where Archive = 0";
        public static String TeacherID { get; set; }
        public static String FName { get; set; }
        public static String MName { get; set; }
        public static String LName { get; set; }
        public static String Sex { get; set; }
        public static String Religion { get; set; }
        public static String Bday { get; set; }
        public static String ConNum { get; set; }
        public static String Deg { get; set; }
        public static String CS { get; set; }
        public static String EmpType { get; set; }

        //For Bday Retrieve
        public static String year { get; set; }
        public static String month { get; set; }
        public static String day { get; set; }


        public static int Mon { get; set; }
        public static int Tue { get; set; }
        public static int Wed { get; set; }
        public static int Thu { get; set; }
        public static int Fri { get; set; }
        public static int Sat { get; set; }


        public void Create()
        {
            try
            {
                con = new SqlConnection(server);
                con.Open();

                query = $"insert into Teacher " +
                    "(TeacherID, Fname, Mname, Lname, Sex, Religion, Bday, Contact, Degree, CivilStat, EmpType, Username, Archive)" +
                    "values('" + TeacherID + "', '" + FName + "', '" + MName + "', '" + LName + "', '" + Sex + "', '" + Religion + "', " +
                    "'" + Bday + "', '" + ConNum + "','" + Deg + "', '" + CS + "', '" + EmpType + "', '" + AdminChecker.Admin + "', '" + 0 + "')";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();


            } catch (Exception) { }
        }

        public void PT()
        {
            try
            {
                con = new SqlConnection(server);
                con.Open();

                String ID = "" + FrmDash.Yr + "" + FrmDash.Mnth + "" + FrmDash.Day + "" + FrmDash.Hr + "" + FrmDash.Min + "" + FrmDash.Sec + "";

                query = $"insert into PartT " +
                    "(PartTID, TeacherID, Mon, Tue, Wed,Thu,Fri,Sat)" +
                    "values('" + ID + "', '" + TeacherID + "', '" + Mon + "', '" + Tue + "', '" + Wed + "', '" + Thu + "', '" + Fri + "', '" + Sat + "')";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();


            } catch (Exception) { }
        }

        public void FT()
        {
            try
            {
                con = new SqlConnection(server);
                con.Open();

                String ID = "" + FrmDash.Yr + "" + FrmDash.Mnth + "" + FrmDash.Day 
                    + "" + FrmDash.Hr + "" + FrmDash.Min + "" + FrmDash.Sec + "";

                query = $"insert into FullT " +
                    "(FullTID,TeacherID)" +
                    "values('" + ID + "', '" + TeacherID + "')";

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

                query = "select Fname, Mname, Lname, Sex, Religion," +
                    "  FORMAT(Bday,'yyyy') , FORMAT(Bday,'MM') , FORMAT(Bday,'dd'), " +
                    "Contact, Degree, CivilStat, EmpType " +
                    "from Teacher where TeacherID = '" + TeacherID + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    FName = rdr.GetString(0) + "";
                    MName = rdr.GetString(1) + "";
                    LName = rdr.GetString(2) + "";
                    Sex = rdr.GetString(3) + "";
                    Religion = rdr.GetString(4);
                    year = rdr.GetString(5) + "";
                    month = rdr.GetString(6) + "";
                    day = rdr.GetString(7) + "";
                    ConNum = rdr.GetString(8) + "";
                    Deg = rdr.GetString(9) + "";
                    CS = rdr.GetString(10) + "";
                    EmpType = rdr.GetString(11) + "";

                }

                con.Close();

            }
            catch (Exception) { }


        }

        public delegate void RetCallback();

        public RetCallback RCB;

        public void Update()
        {
            try 
            {
                con = new SqlConnection(server);
                con.Open();
               
                query = "update Teacher set " +
                         "Fname = '" + FName + "', " 
                       + "Mname = '" + MName + "', "
                       + "Lname = '" + LName + "', "
                       + "Sex = '" + Sex + "', "
                       + "Religion = '" + Religion + "', "
                       + "Bday = '" + Bday + "', "
                       + "Contact = '" + ConNum + "', "
                       + "Degree = '" + Deg + "'," 
                       + "CivilStat = '" + CS + "', "
                       + "EmpType = '" + EmpType + "' " 
                       + "where TeacherID = '"+TeacherID+"'";
            
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
             
                cmd.Dispose();
                con.Close();
                
               

            }
            catch (Exception ex) { MessageBox.Show(ex+""); }
        }
    }
}
