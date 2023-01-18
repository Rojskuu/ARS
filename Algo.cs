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


        public static String ClassType { get; set; }
        public static String ClassID { get; set; }
        public static String RoomID { get; set; }
        public static String RoomD { get; set; }
        public static String RoomDT { get; set; }
        public static String TeacherID { get; set; }
        public static String TeacherD { get; set; }
        public static String TeacherDT { get; set; }

        public static String SubjectHr { get; set; }
        public static String SubjectMin{ get; set; }
        public static int getStartRoom { get; set; } = 0;
        public static int getEndRoom { get; set; } = 0;

        public static int getStartTeach { get; set; } = 0;
        public static int getEndTeach { get; set; } = 0;


        public static int TotalTimeNo { get; set; }



        public static int TDayNo { get; set; }
        public static int RDayNo { get; set; }

        public static int ClassRandom { get; set; }
        public static int RoomRandom { get; set; }

        //subject >> Teacher that will teach >> Day&Time of partTime >>
        //department ---- 3rd 5-7 4th & 1st 7-7
        //use genetic algo instead


        public Algo()
        {
            PopClassList();
            PopRoomList();
            MainAlgo();

        }

        public void PopRoomList()
        {
            try 
            { 
                PopRoomLecList();
                PopRoomKitList();
                PopRoomComList();
            } catch (Exception ex) { MessageBox.Show(ex + ""); }
        
        }
        public void PopRoomLecList() 
        {
            try
            {
                con = new SqlConnection(server);
                con.Open();

                query = "Select RoomID from Room Where Archive = 0 And RoomType = 'Lecture Room'";

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader rdr = cmd.ExecuteReader();
               
                while (rdr.Read())
                {

                    RoomLecList.Add(rdr.GetString(rdr.GetOrdinal("RoomID")));
                   
                }

                con.Close();

            }
            catch (Exception ex) { MessageBox.Show(ex + ""); }
        }

        public void PopRoomComList()
        {
            try
            {
                con = new SqlConnection(server);
                con.Open();

                query = "Select RoomID from Room Where Archive = 0 And RoomType = 'Computer Laboratory'";

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {

                    RoomComList.Add(rdr.GetString(rdr.GetOrdinal("RoomID")));

                }

                con.Close();

            }
            catch (Exception ex) { MessageBox.Show(ex + ""); }
        }

        public void PopRoomKitList()
        {
            try
            {
                con = new SqlConnection(server);
                con.Open();

                query = "Select RoomID from Room Where Archive = 0 And RoomType = 'Kitchen Laboratory'";

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {

                    RoomKitList.Add(rdr.GetString(rdr.GetOrdinal("RoomID")));

                }

                con.Close();

            }
            catch (Exception ex) { MessageBox.Show(ex + ""); }
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

                query = "Select ClassID from CLASS Where Archive = 0 AND isSched = 0";

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
                while (ClassList.Count != 0)
                {
                    PickClass();
                    PopIDs();
                    GetSubjectTime();
                    RetriveTD();

                    for (int i = 0; i <= TDID.Count; i++)
                    {
                        TeacherD = TDID[i]+"";
                        TDayNo = Convert.ToInt32(TDay[i]);

                        RetrieveTDT();

                        isTeachConsec();

                        if (getEndTeach != 0) 
                        {
                            
                            if (ClassType.Equals("Computer Laboratory"))
                            {

                                for (int j = 0; j < RoomComList.Count; j++)
                                {

                                    PickComRoom();
                                    GetRDID();


                                }
                            }
                            else if (ClassType.Equals("Kitchen Laboratory"))
                            { 
                               
                               
                            }
                            else if (ClassType.Equals("Lecture Room"))
                            {
                                
                                
                            }

                        }

                    }


                }




            } catch (Exception ex) 
            { MessageBox.Show(ex + ""); }
        
        }

        public void getSimilarTime()
        {
            try
            {
                con = new SqlConnection(server);
                con.Open();

                query = "SELECT RDID FROM RDTime "+
                        "WHERE TimeNo BETWEEN " + getStartTeach+  "AND"+ getEndTeach + " TotalTimeNo AND IsOccupied = 0 " +
                        "GROUP BY RDID " +
                       " HAVING COUNT(DISTINCT TimeNo) ="+ TotalTimeNo; 

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

                query = "Select Hrs , ClassType from Subj Where Archive = 0 AND SubejctCode = '" + SubjectCRUD.SubjectCode + "'";

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
                       " where TeacherID = '" + TeacherID + "'";

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

                     TeachTimeNo.Add(rdr.GetString(rdr.GetOrdinal("TimeNo")));

              
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
                    
                }
   
            } catch (Exception ex) { MessageBox.Show(ex + ""); }
        
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

        public void findFit() 
        {
            try
            {

               


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

