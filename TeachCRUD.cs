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
        String server = ConnectionString.ConString;
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
        public static String Department { get; set; }

        //For Bday Retrieve
        public static String year { get; set; }
        public static String month { get; set; }
        public static String day { get; set; }

        public static int DayNo { get; set; }
        public static int TimeNo { get; set; }

        public static int Mon { get; set; }
        public static String MonIn { get; set; }
        public static String MonOut { get; set; }
        public static int Tue { get; set; }
        public static String TueIn { get; set; }
        public static String TueOut { get; set; }
        public static int Wed { get; set; }
        public static String WedIn { get; set; }
        public static String WedOut { get; set; }
        public static int Thu { get; set; }
        public static String ThuIn { get; set; }
        public static String ThuOut { get; set; }
        public static int Fri { get; set; }
        public static String FriIn { get; set; }
        public static String FriOut { get; set; }
        public static int Sat { get; set; }
        public static String SatIn { get; set; }
        public static String SatOut { get; set; }

        TeacherDayCRUD TeacherDayCRUD = new TeacherDayCRUD();
        TDTimeCRUD TDTime = new TDTimeCRUD();

        public void Create()
        {
            try
            {
                con = new SqlConnection(server);
                con.Open();

                query = $"insert into Teacher " +
                    "(TeacherID, Fname, Mname, Lname, Sex, Religion, Bday, Contact, Degree, CivilStat, EmpType, Department , Username, Archive)" +
                    "values('" + TeacherID + "', '" + FName + "', '" + MName + "', '" + LName + "', '" + Sex + "', '" + Religion + "', " +
                    "'" + Bday + "', '" + ConNum + "','" + Deg + "', '" + CS + "', '" + EmpType + "', '"+Department +"', '" + AdminChecker.Admin + "', '" + 0 + "')";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();

                if (EmpType.Equals("Full-Time"))
                {
                    TeacherDayPopulate();
                }
                else
                {
                    
                }

            } catch (Exception) { }
        }

        public void TeacherDayPopulate()
        {
            try
            {
                for (DayNo = 1; DayNo <= 6; DayNo++)
                {
                    FrmDash.Nanosec++;
                    TeacherDayCRUD.Create();

                    for (TimeNo = 1; TimeNo <= 48; TimeNo++)
                    {
                        FrmDash.Nanosec++;
                        TDTime.Create();
                    }

                }

            }
            catch (Exception ex) { MessageBox.Show(ex + ""); }
        }

        public void PT()
        {
            try
            {
                con = new SqlConnection(server);
                con.Open();

                String ID = "" + FrmDash.Yr + "" + FrmDash.Mnth + "" + FrmDash.Day + "" + FrmDash.Hr + "" + FrmDash.Min + "" + FrmDash.Sec + "";

                query = "insert into PartT " +
                    "(PartTID, TeacherID, Mon, MonIn, MonOut, Tue, TueIn, TueOut, " +
                    " Wed, WedIn, WedOut, Thu, ThuIn, ThuOut, Fri, FriIn, FriOut, Sat, SatIn, SatOut)" +
                    "values('" + ID + "', '" + TeacherID + "', " 
                    + Mon + ", '" +MonIn + "', '" +MonOut+"', "
                    + Tue + ", '" +TueIn + "', '" +TueOut+"', " 
                    + Wed + ", '" +WedIn + "', '" +WedOut+"', "
                    + Thu + ", '" +ThuIn + "', '" +ThuOut+"', "
                    + Fri + ", '" +FriIn + "', '" +FriOut+"', "
                    + Sat + ", '" +SatIn + "', '" +SatOut+"')";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();

                

            } catch (Exception ex) { MessageBox.Show(ex + ""); }
        }

        public void FT()
        {
            try
            {
                con = new SqlConnection(server);
                con.Open();

                String ID = "" + FrmDash.Yr + "" + FrmDash.Mnth + "" + FrmDash.Day 
                    + "" + FrmDash.Hr + "" + FrmDash.Min + "" + FrmDash.Sec + "";

                query = "insert into FullT " +
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

        public void CheckIDifExist(String txt)
        {
            try 
            {
                con = new SqlConnection(server);
                con.Open();

                query = "SELECT * FROM Teacher WHERE TeacherID = '" + txt + "'";
                    
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@TeacherID", txt);
                
                dt = new DataTable();

                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    MessageBox.Show("Teacher ID already exist. "
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

                query = "select Fname, Mname, Lname, Sex, Religion," +
                    "  FORMAT(Bday,'yyyy') , FORMAT(Bday,'MM') , FORMAT(Bday,'dd'), " +
                    "Contact, Degree, CivilStat, EmpType, Department " +
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
                    Department = rdr.GetString(12) + "";
                }
                con.Close();

                if (EmpType.Trim().Equals("Part-Time")) 
                {
                    RetrievePT();
                }
            }
            catch (Exception) { }

        }

        public void UpdatePT() 
        {
            try
            {
                con = new SqlConnection(server);
                con.Open();

                query = "update PartT set "   +
                        "Mon = "+Mon + ", "   +
                        "MonIn = '"  + MonIn  + "', " +
                        "MonOut= '"  + MonOut + "', " +
                        "Tue = "+Tue + ", "   +
                        "TueIn = '"  + TueIn  + "', " +
                        "TueOut= '"  + TueOut + "', " +
                        "Wed = "+Wed + ", "   +
                        "WedIn = '"  + WedIn  + "', " +
                        "WedOut= '"  + WedOut + "', " +
                        "Thu = "+Thu + ", "   +
                        "ThuIn = '"  + ThuIn  + "', " +
                        "ThuOut= '"  + ThuOut + "', " +
                        "Fri = "+Fri + ", "   +
                        "FriIn = '"  + FriIn  + "', " +
                        "FriOut= '"  + FriOut + "', " +
                        "Sat = "+Sat + ", "   +
                        "SatIn = '"  + SatIn  + "', " +
                        "SatOut= '"  + SatOut + "' " +
                        "where TeacherID = '" + TeacherID + "'";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();

                cmd.Dispose();
                con.Close();

                

            }
            catch (Exception ex) { MessageBox.Show(ex + ""); }
        }
        public void RetrievePT()
        {
            try 
            {
                con = new SqlConnection(server);
                con.Open();

                query = "select Mon, MonIn, MonOut, Tue, TueIn, TueOut," +
                    " Wed, WedIn, WedOut, Thu, ThuIn, ThuOut, Fri, FriIn, FriOut, Sat, SatIn, SatOut " +
                     "FROM PartT where TeacherID = '" + TeacherID + "'";

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Mon   = Convert.ToInt32(rdr.GetValue(0));
                    MonIn = rdr.GetString(1);
                    MonOut= rdr.GetString(2);
                    Tue   = Convert.ToInt32(rdr.GetValue(3));
                    TueIn = rdr.GetString(4);
                    TueOut= rdr.GetString(5);
                    Wed   = Convert.ToInt32(rdr.GetValue(6));
                    WedIn = rdr.GetString(7);
                    WedOut= rdr.GetString(8);
                    Thu   = Convert.ToInt32(rdr.GetValue(9));
                    ThuIn = rdr.GetString(10);
                    ThuOut= rdr.GetString(11);
                    Fri   = Convert.ToInt32(rdr.GetValue(12));
                    FriIn = rdr.GetString(13);
                    FriOut= rdr.GetString(14);
                    Sat   = Convert.ToInt32(rdr.GetValue(15));
                    SatIn = rdr.GetString(16);
                    SatOut= rdr.GetString(17);
                }
                con.Close();
                
                } catch (Exception ex) { }
        
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
                       + "EmpType = '" + EmpType + "', " 
                       + "Department = '"+Department+"' " 
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
