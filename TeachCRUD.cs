using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Collections;

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




        public static String TeachDisplay = "Select SUBSTRING(TeacherID,1,CHARINDEX('-', TeacherID)-1) AS 'Teacher ID', concat(FName, ' ', MName, '. ', LName) as Name," +
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

        public static ArrayList Days { get; set; } = new ArrayList();
        TDTimeCRUD TDTimeCRUD = new TDTimeCRUD();
        public static int Mon { get; set; }
        public static int MonIn { get; set; }
        public static int MonOut { get; set; }
        public static int Tue { get; set; }
        public static int TueIn { get; set; }
        public static int TueOut { get; set; }
        public static int Wed { get; set; }
        public static int WedIn { get; set; }
        public static int WedOut { get; set; }
        public static int Thu { get; set; }
        public static int ThuIn { get; set; }
        public static int ThuOut { get; set; }
        public static int Fri { get; set; }
        public static int FriIn { get; set; }
        public static int FriOut { get; set; }
        public static int Sat { get; set; }
        public static int SatIn { get; set; }
        public static int SatOut { get; set; }

        TeacherDayCRUD TeacherDayCRUD = new TeacherDayCRUD();
        TDTimeCRUD TDTime = new TDTimeCRUD();

        public void Create()
        {
            try
            {
                con = new SqlConnection(server);
                con.Open();

                TeacherID += "-" + FrmDash.SYSem; 

                query = $"insert into Teacher " +
                    "(TeacherID, Fname, Mname, Lname, Sex, Religion, Bday, Contact, Degree, CivilStat, EmpType, Department , Username, Archive)" +
                    "values('" + TeacherID.Replace("'", "''")+ "', '" + FName.Replace("'","''") + "', '" + MName.Replace("'", "''") + "', '" + LName.Replace("'", "''") + "', '" + Sex + "', '" + Religion.Replace("'", "''") + "', " +
                    "'" + Bday + "', '" + ConNum.Replace("'", "''") + "','" + Deg + "', '" + CS + "', '" + EmpType + "', '"+Department +"', '" + AdminChecker.Admin + "', '" + 0 + "')";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();

                if (EmpType.Equals("Full-Time"))
                {
                    TeacherDayPopulate();
                }
               

            } catch (Exception ex) { MessageBox.Show(ex + ""); }
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
                    "(PartTID, TeacherID)" +
                    "values('" + ID + "', '" + TeacherID + "')";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();

                TeacherDayTime();
                

            } catch (Exception ex) { MessageBox.Show(ex + ""); }
        }

        public void TeacherDayTime()
        {
            try
            {
                for (int i = 0; i < TeachCRUD.Days.Count; i++)
                {
                    TeachCRUD.DayNo = Convert.ToInt32(TeachCRUD.Days[i]);
                    TeacherDayCRUD.Create();

                    if (TeachCRUD.DayNo == 1)
                    {
                        for (int j = TeachCRUD.MonIn; j <= TeachCRUD.MonOut; j++)
                        {
                            TeachCRUD.TimeNo = j;
                            TDTimeCRUD.Create();
                        }
                    }
                    else if (TeachCRUD.DayNo == 2)
                    {
                        for (int j = TeachCRUD.TueIn; j <= TeachCRUD.TueOut; j++)
                        {
                            TeachCRUD.TimeNo = j;
                            TDTimeCRUD.Create();
                        }
                    }
                    else if (TeachCRUD.DayNo == 3)
                    {
                        for (int j = TeachCRUD.WedIn; j <= TeachCRUD.WedOut; j++)
                        {
                            TeachCRUD.TimeNo = j;
                            TDTimeCRUD.Create();
                        }
                    }
                    else if (TeachCRUD.DayNo == 4)
                    {
                        for (int j = TeachCRUD.ThuIn; j <= TeachCRUD.ThuOut; j++)
                        {
                            TeachCRUD.TimeNo = j;
                            TDTimeCRUD.Create();
                        }
                    }
                    else if (TeachCRUD.DayNo == 5)
                    {
                        for (int j = TeachCRUD.FriIn; j <= TeachCRUD.FriOut; j++)
                        {
                            TeachCRUD.TimeNo = j;
                            TDTimeCRUD.Create();
                        }
                    }
                    else if (TeachCRUD.DayNo == 6)
                    {
                        for (int j = TeachCRUD.SatIn; j <= TeachCRUD.SatOut; j++)
                        {
                            TeachCRUD.TimeNo = j;
                            TDTimeCRUD.Create();
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex + ""); }

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
            catch (Exception ex) { MessageBox.Show(ex + ""); }
        }

        public void Delete()
        {
            try 
            { 

             

            } catch (Exception ex) { MessageBox.Show(ex + ""); }


        }

        public void GetTDID() 
        {
            try
            {
                con = new SqlConnection(server);
                con.Open();

                
                query = "Select TDID from TeacherDay " +
                    " WHERE TeacherID = '" + TeacherID +"-"+FrmDash.SYSem+"'";

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    TeacherDayCRUD.TDID = rdr.GetString(rdr.GetOrdinal("TDID"));
                    TDTime.Delete();
                    TeacherDayCRUD.Delete();
                }
                con.Close();

                TeacherDayTime();
            }
            catch (Exception ex) { MessageBox.Show(ex + ""); }


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
                GetTDID();

            }
            catch (Exception ex) { MessageBox.Show(ex + ""); }
        }


        
        public void RetrievePT()
        {
            try 
            {
                con = new SqlConnection(server);
                con.Open();

                query = "Select TDID , DayNo from TeacherDay " +
                   " where TeacherID = '" + TeacherID +"-"+FrmDash.SYSem+ "'";

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader rdr = cmd.ExecuteReader();

               // int temp = 0;
                while (rdr.Read())
                {
                    TeacherDayCRUD.TDID = rdr.GetString(rdr.GetOrdinal("TDID")) + "";
                   // temp++;
                    TeachCRUD.DayNo = Convert.ToInt32(rdr.GetValue(rdr.GetOrdinal("DayNo")));
                   // temp++;

                    if (DayNo == 1) 
                    {
                        TDTime.Desc();
                        TDTime.Ascend();
                        TeachCRUD.Mon = 1;
                        TeachCRUD.MonIn = TDTimeCRUD.Asc;
                        TeachCRUD.MonOut = TDTimeCRUD.Des;
                    }
                    if (DayNo == 2)
                    {
                        TDTime.Desc();
                        TDTime.Ascend();
                        TeachCRUD.Tue = 1;
                        TeachCRUD.TueIn = TDTimeCRUD.Asc;
                        TeachCRUD.TueOut = TDTimeCRUD.Des;
                    }
                    if(DayNo == 3)
                    {
                        TDTime.Desc();
                        TDTime.Ascend();
                        TeachCRUD.Wed = 1;
                        TeachCRUD.WedIn = TDTimeCRUD.Asc;
                        TeachCRUD.WedOut = TDTimeCRUD.Des;
                    }
                    if (DayNo == 4)
                    {
                        TDTime.Desc();
                        TDTime.Ascend();
                        TeachCRUD.Thu = 1;
                        TeachCRUD.ThuIn = TDTimeCRUD.Asc;
                        TeachCRUD.ThuOut = TDTimeCRUD.Des;
                    }
                    if (DayNo == 5)
                    {
                        TDTime.Desc();
                        TDTime.Ascend();
                        TeachCRUD.Fri = 1;
                        TeachCRUD.FriIn = TDTimeCRUD.Asc;
                        TeachCRUD.FriOut = TDTimeCRUD.Des;
                    }
                    if(DayNo == 6)
                    {
                        TDTime.Desc();
                        TDTime.Ascend();
                        TeachCRUD.Sat = 1;
                        TeachCRUD.SatIn = TDTimeCRUD.Asc;
                        TeachCRUD.SatOut = TDTimeCRUD.Des;
                    }
                   



                }
                con.Close();
                
                } catch (Exception ex) { MessageBox.Show(ex + ""); }
        
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
                       + "where TeacherID = '"+TeacherID+"-"+FrmDash.SYSem+"'";
            
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
             
                cmd.Dispose();
                con.Close();
                
               

            }
            catch (Exception ex) { MessageBox.Show(ex+""); }
        }
    }
}
