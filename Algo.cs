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
    internal class Algo
    {
        TeachCRUD TeachCRUD;

        ScheduleCRUD ScheduleCRUD = new ScheduleCRUD();

        
        SqlCommand cmd;
        SqlConnection con;
        String server = ConnectionString.ConString;
        SqlDataAdapter adapter;
        DataSet ds;
        DataTable dt;
        SqlDataReader reader;
        String query;
        Random random = new Random();


        public static  ArrayList ClassList { get; set; } = new ArrayList();
        public static ArrayList RoomLecList { get; set; } = new ArrayList();
       
        public static ArrayList RoomComList { get; set; } = new ArrayList();
        public static ArrayList RoomKitList { get; set; } = new ArrayList();

        public static ArrayList RDID { get; set; } = new ArrayList();
        public static ArrayList RDTID { get; set; } = new ArrayList();
        
        public static ArrayList TDID { get; set; } = new ArrayList();
        public static ArrayList TDay { get; set; } = new ArrayList();

        public static ArrayList RoomTimeNo { get; set; } = new ArrayList(); 

        public static ArrayList TeachTimeNo { get; set; } = new ArrayList();

        public static String Day { get; set; }
        public static String ClassType { get; set; }
        public static String ClassID { get; set; }
        public static String RoomID { get; set; }
        public static String RoomType { get; set; }
        public static String RoomD { get; set; }
        public static String RoomDT { get; set; }
        public static String TeacherID { get; set; }
        public static String TeacherD { get; set; }
        public static String TeacherDT { get; set; }
        public static String TimeFrame { get; set; }
        public static String SubjectHr { get; set; }
        public static String SubjectMin{ get; set; }
        public static String startClass { get; set; }
        public static String endClass { get; set; }
        public static int getStartRoom { get; set; } = 0;
        public static int getEndRoom { get; set; } = 0;

        public static int getStartTeach { get; set; } = 0;
        public static int getEndTeach { get; set; } = 0;




        public static int TotalTimeNo { get; set; }



        public static int TDayNo { get; set; }
        public static int RDayNo { get; set; }

        public static int ClassRandom { get; set; }
        public static int RoomRandom { get; set; }

        public static int RDIDRandom { get; set; }

        //subject >> Teacher that will teach >> Day&Time of partTime >>
        //department ---- 3rd 5-7 4th & 1st 7-7
        //use genetic algo instead


        public Algo()
        {
            PopClassList();
            
            MainAlgo();

        }

        
      

        public void GetRDID() 
        {
            try
            {
                con = new SqlConnection(server);
                con.Open();

                query = "Select RDID from RoomDay Where Archive = 0 AND RoomID = '"+RoomID+"'";

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader rdr = cmd.ExecuteReader();



                while (rdr.Read())
                {
                    RDID.Add(rdr.GetString(rdr.GetOrdinal("RDID")));

                }

                con.Close();

                
            }
            catch (Exception ex) { MessageBox.Show(ex + ""); }

        }

        public void GetRDTID()
        {
            try
            {
                con = new SqlConnection(server);
                con.Open();

                query = "Select TimeNo from RDTime Where isOccupied = 0 AND RDID = '" + RoomD + "' Order by TimeNo";

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    RoomTimeNo.Add(rdr.GetString(rdr.GetOrdinal("RDTID")));

                }

                con.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex + ""); }
        }

        public void PopClassList() 
        {
            try
            {
                con = new SqlConnection(server);
                con.Open();

                query = "Select ClassID from CLASS Where Archive = 0 OR isSched = 0";

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader rdr = cmd.ExecuteReader();
                
                while (rdr.Read())
                {
                   ClassList.Add(rdr.GetString(rdr.GetOrdinal("ClassID")));
                }

                con.Close();
                
            }
            catch (Exception ex) { MessageBox.Show(ex + ""); }

        }


        public void PopIDs() 
        {
            try
            {
                con = new SqlConnection(server);
                con.Open();

                query = "Select SubCode, SectionID, TeacherID from CLASS Where Archive = 0 AND CLASSID = '"+ClassID+"'";

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader rdr = cmd.ExecuteReader();
                
                while (rdr.Read())
                {
                    SubjectCRUD.SubjectCode = rdr.GetString(0);
                    SectionCRUD.SectionID = rdr.GetString(1);
                    TeachCRUD.TeacherID = rdr.GetString(2);
                }

                con.Close();
                
            }
            catch (Exception ex) { MessageBox.Show(ex + ""); }

        }

        public void MainAlgo() 
        {
            try 
            {
                /*
                Pili class
                getID
                SubTime, SubType
                FindSlot on teach
                Find similar slot on room
                Generate Sched
                 */
                if (ClassList.Count != 0)
                {
                    while (ClassList.Count != 0)
                    {
                        PickClass();
                        PopIDs();
                        GetSubjectTime();
                        RetriveTD();

                        if (TDID.Count != 0)
                        {
                            for (int i = 0; i <= TDID.Count; i++)
                            {
                                TeacherD = TDID[i] + "";
                                TDayNo = Convert.ToInt32(TDay[i]);

                                RetrieveTDT();

                                isTeachConsec();

                                if (getEndTeach != 0)
                                {

                                    if (ClassType.Equals("Computer Laboratory"))
                                    {
                                        RoomType = "Computer Laboratory";
                                    }
                                    else if (ClassType.Equals("Kitchen Laboratory"))
                                    {
                                        RoomType = "Kitchen Laboratory";
                                    }
                                    else if (ClassType.Equals("Lecture Room"))
                                    {
                                        RoomType = "Lecture Room";
                                    }
                                    getSimilarTime();
                                    PickRDID();
                                    getRoomID();
                                   
                                    getTimeFrame();

                                    getDay();

                                    ScheduleCRUD.Create();

                                    UpdateRoomTime();
                                    UpdateTeachTime();
                                    UpdateClass();

                                    ClassList.Remove(ClassID);




                                }

                            }
                        }


                    }
                }
                else 
                {

                    MessageBox.Show("Schedule Generated Successfully", "Schedule", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            } catch (Exception ex) 
            { MessageBox.Show(ex + ""); }
        
        }

        public void getDay() 
        {
            try
            {
                con = new SqlConnection(server);
                con.Open();

                query =
                        "Select DayName from Day where DayNo =" + TDayNo;

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                   Day = rdr.GetString(0);
                }

                con.Close();

            }
            catch (Exception ex) { MessageBox.Show(ex + ""); }

        }

        public void getRoomID() 
        {
            try
            {
                con = new SqlConnection(server);
                con.Open();

                query =
                        "Select R.RoomID from Room R " +
                        "INNER JOIN RoomDay RD " +
                        "ON R.RoomID = RD.RoomID " +
                        "where RDID = '" + RoomD+"'";

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    RoomID = rdr.GetString(0)+"";
                }

                con.Close();

            }
            catch (Exception ex) { MessageBox.Show(ex + ""); }

        }

        public void getTimeFrame()
        {
            try 
            {
                string start, end;
                con = new SqlConnection(server);
                con.Open();

                //query = "Select TimeFrame from Time where TimeNo IN (" + getStartTeach + ", "  + getEndTeach +" ) Order by TimeNo";
                query = "Select TimeFrame from Time where TimeNo  =" + getStartTeach;

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    
                    start = rdr.GetString(0);


                    startClass = start.Substring(0, start.ToString().IndexOf("-"));


                }
                con.Close();

                con.Open();

                query = "Select TimeFrame from Time where TimeNo  =" + getEndTeach;

                SqlCommand cmd1 = new SqlCommand(query, con);
                SqlDataReader rdr1 = cmd1.ExecuteReader();

                while (rdr1 .Read())
                {

                    end = rdr1.GetString(0);


                    endClass = end.Substring(end.ToString().IndexOf("-"));


                }


                TimeFrame = startClass + endClass;

                con.Close();

            } catch (Exception ex) { MessageBox.Show(ex + ""); }
        
        }

        public void UpdateClass() 
        {
            try
            {
                con = new SqlConnection(server);

                    con.Open();

                    query = "update Class set " +
                        "isSched = 1 " +
                         "where ClassID = '" + ClassID + "'";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();

                    cmd.Dispose();
                    con.Close();

                

            }
            catch (Exception ex) { MessageBox.Show(ex + ""); }

        }
        public void UpdateTeachTime()
        {
            try 
            {
                con = new SqlConnection(server);


                for (int i = getStartTeach; i <= getEndTeach; i++)
                {
                    con.Open();

                    query = "update TDTime set " +
                        "isOccupied = 1 "+
                         "where TDID = '" + TeacherD + "' AND TimeNo = "  + i ;

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();

                    cmd.Dispose();
                    con.Close();

                }

            } catch (Exception ex) { MessageBox.Show(ex + ""); }
        
        }


        public void UpdateRoomTime()
        {
            try
            {
                con = new SqlConnection(server);


                for (int i = getStartTeach; i <= getEndTeach; i++)
                {
                    con.Open();

                    query = "update RDTime set " +
                        "isOccupied = 1 " +
                         "where RDID = '" +RoomD + "' AND TimeNo = " + i;

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();

                    cmd.Dispose();
                    con.Close();

                }

            }
            catch (Exception ex) { MessageBox.Show(ex + ""); }

        }

        public void getSimilarTime()
        {
            try
            {
                con = new SqlConnection(server);
                con.Open();

                query = "SELECT RDT.RDID FROM  RDTime RDT " +
                        "INNER JOIN RoomDay RD " +
                        "ON RDT.RDID = RD.RDID " +
                        "INNER JOIN Room R " +
                        "ON R.RoomID = RD.RoomID " +
                        "WHERE RDT.TimeNo BETWEEN " + getStartTeach + 
                        " AND " + getEndTeach + 
                        "AND RDT.IsOccupied = 0 AND R.RoomType = '" + RoomType + "' AND RD.DayNo = " +TDayNo+
                        "GROUP BY RDT.RDID " +
                        "HAVING COUNT(DISTINCT RDT.TimeNo) = " + TotalTimeNo;

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    RDID.Add(rdr.GetString(rdr.GetOrdinal("RDID"))); ;
                }

                con.Close();

            }
            catch (Exception ex) { MessageBox.Show(ex + ""); }

        }


        public void GetSubjectTime() 
        {
            try
            {
                con = new SqlConnection(server);
                con.Open();

                query = "Select Hrs , ClassType from Subj Where Archive = 0 AND SubCode = '" + SubjectCRUD.SubjectCode + "'";

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    String temp = rdr.GetString(0);
                    SubjectHr = temp.Substring(0, temp.IndexOf(":"));
                    SubjectMin = temp.Substring(temp.IndexOf(":")+1);
                    ClassType = rdr.GetString(1);
                    TotalTimeNo = (Convert.ToInt32(SubjectHr) * 4) + (Convert.ToInt32(SubjectMin) / 15);
                }

                con.Close();
                
            }
            catch (Exception ex) { MessageBox.Show(ex + ""); }

        }





        //public void CheckTeacher()
        //{
        //    try
        //    {
        //        con = new SqlConnection(server);

        //        con.Open();

        //        query = "Select EmpType from Teacher Where Archive = 0 AND TeacherID = '" + TeachCRUD.TeacherID + "'";

        //        SqlCommand cmd = new SqlCommand(query, con);
        //        SqlDataReader rdr = cmd.ExecuteReader(); 

        //        while (rdr.Read())
        //        {
        //            TeachCRUD.EmpType = rdr.GetString(0);
        //        }

        //        con.Close();

               
                   
              

        //    }
        //    catch (Exception ex) { MessageBox.Show(ex + ""); }
        
        //}


       

        public void RetriveTD() 
        {
            
                try
                {
                    con = new SqlConnection(server);
                    con.Open();

                    query = "Select TDID , DayNo from TeacherDay " +
                       " where TeacherID = '" + TeachCRUD.TeacherID + "'";

                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader rdr = cmd.ExecuteReader();

                    
                    while (rdr.Read())
                    {
                        
                        TDID.Add(rdr.GetString(rdr.GetOrdinal("TDID")));
                        
                        TDay.Add(rdr.GetValue(rdr.GetOrdinal("DayNo")));
                        

                    }
                    con.Close();

                }
                catch (Exception ex) { MessageBox.Show(ex + ""); }

           
        }

        public void RetrieveTDT() 
        {
            try
            {
                con = new SqlConnection(server);
                con.Open();

                query = "Select TimeNo from TDTime " +
                   " where TDID = '" + TeacherD + "'" +" AND isOccupied = 0  Order by TimeNo";

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader rdr = cmd.ExecuteReader();


                while (rdr.Read())
                {

                     TeachTimeNo.Add(rdr.GetValue(rdr.GetOrdinal("TimeNo")));

              
                }
                con.Close();

            }
            catch (Exception ex) { MessageBox.Show(ex + ""); }

        }

        public void PickClass()
        {
            try 
            {
                while (ClassList.Count != 0) 
                {
                    ClassRandom = random.Next(0, ClassList.Count);
                    ClassID = ClassList[ClassRandom].ToString();
                    break;
                }
   
            } catch (Exception ex) { MessageBox.Show(ex + ""); }
        
        }

        public void PickRDID()
        {
            try
            {
                while (RDID.Count != 0)
                {
                   int RoomDayRandom = random.Next(0, RDID.Count);
                    RoomD = RDID[RoomDayRandom].ToString();
                    break;
                }

            }
            catch (Exception ex) { MessageBox.Show(ex + ""); }

        }


        public void PickLecRoom()
        {
            try 
            {
                RoomRandom = random.Next(0, RoomLecList.Count);
                RoomID = RoomLecList[RoomRandom].ToString();
               
            } catch (Exception ex) { MessageBox.Show(ex + ""); }
        }

        public void PickComRoom()
        {
            try
            {
                RoomRandom = random.Next(0, RoomLecList.Count);
                RoomID = RoomLecList[RoomRandom].ToString();

            }
            catch (Exception ex) { MessageBox.Show(ex + ""); }
        }
        public void PickKitRoom()
        {
            try
            {
                RoomRandom = random.Next(0, RoomLecList.Count);
                RoomID = RoomLecList[RoomRandom].ToString();

            }
            catch (Exception ex) { MessageBox.Show(ex + ""); }
        }

       


        public void isRoomConsec()
        {
            int temp = 0;
            for (int i = 1; i < RoomTimeNo.Count; i++)
            {

                if (getStartRoom == 0)
                {
                    getStartRoom = Convert.ToInt32(RoomTimeNo[i]);
                }

                if (Convert.ToInt32(RoomTimeNo[i]) != (Convert.ToInt32(RoomTimeNo[i - 1]) + 1))
                {
                    
                    getStartRoom = 0;
                    temp = 0;
                }
                else
                {
                    temp++;
                }

                if (temp == TotalTimeNo)
                {

                    getEndRoom = Convert.ToInt32(RoomTimeNo[i]);

                    break;

                }
            }

        }

        public void isTeachConsec()
        {
            int temp = 0;
            for (int i = 1; i < TeachTimeNo.Count; i++)
            {

                if (getStartTeach == 0)
                {
                    getStartTeach = Convert.ToInt32(TeachTimeNo[i]);
                }

                if (Convert.ToInt32(TeachTimeNo[i]) != (Convert.ToInt32(TeachTimeNo[i - 1]) + 1))
                {
                    getStartTeach = 0;
                    temp = 0;
                }
                else
                {
                    temp++;
                }

                if (temp == TotalTimeNo)
                {
                     getEndTeach = Convert.ToInt32(TeachTimeNo[i]);
                     break;

                }


            }

        }







    }










         




}

