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
        public static ArrayList RoomList { get; set; } = new ArrayList();
        public static ArrayList RDID { get; set; } = new ArrayList();
        public static ArrayList RDTID { get; set; } = new ArrayList();
        
        public static ArrayList TDID { get; set; } = new ArrayList();
        public static ArrayList TDTID { get; set; } = new ArrayList(); 

        static int ctrClass = 0;

        public static String Room { get; set; }
        public static String RoomD { get; set; }
        public static String RoomDT { get; set; }
        public static String TeacherID { get; set; }
        public static String TeacherD { get; set; }
        public static String TeacherDT { get; set; }

        //subject >> Teacher that will teach >> Day&Time of partTime >>
        //department ---- 3rd 5-7 4th & 1st 7-7
        //use genetic algo instead


        public Algo()
        {
            PopClassList();
            PopRoomList();
        }

        public void PopRoomList() 
        {
            try
            {
                con = new SqlConnection(server);
                con.Open();

                query = "Select RoomID from Room Where Archive = 0";

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader rdr = cmd.ExecuteReader();
               
                
                
                while (rdr.Read())
                {
                    RoomList.Add(rdr.GetString(rdr.GetOrdinal("RoomID")));
                   
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

                query = "Select RDID from RoomDay Where Archive = 0 AND RoomID = '"+Room+"'";

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

                query = "Select RDTID from RDTime Where isOccupied = 0 AND RDID = '" + RoomD + "'";

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    RDTID.Add(rdr.GetString(rdr.GetOrdinal("RDTID")));

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

                query = "Select ClassID from CLASS Where Archive = 0";

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader rdr = cmd.ExecuteReader();
                
                while (rdr.Read())
                {
                    ClassList.Add(rdr.GetString(ctrClass)+"");
                    PopIDs();
                    ctrClass++;
                    
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

                query = "Select SubCode, SectionID, TeacherID from CLASS Where Archive = 0 AND CLASSID = '"+ClassList.IndexOf(ctrClass)+"'";

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader rdr = cmd.ExecuteReader();
                
                while (rdr.Read())
                {
                    SubjectCRUD.SubjectCode = rdr.GetString(0);
                    SectionCRUD.SectionID = rdr.GetString(1);
                    TeachCRUD.TeacherID = rdr.GetString(2);
                }

                con.Close();
                CheckTeacher();
            }
            catch (Exception ex) { MessageBox.Show(ex + ""); }

        }

        public void CheckTeacher()
        {
            try
            {
                con = new SqlConnection(server);
                con.Open();

                query = "Select EmpType from Teacher Where Archive = 0 AND TeacherID = '" + TeachCRUD.TeacherID + "'";

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    TeachCRUD.EmpType = rdr.GetString(0);
                }

                con.Close();

                if (TeachCRUD.EmpType.Equals("Part-Time"))
                {
                    CheckPTTeach();
                }
                else 
                { 
                
                }

            }
            catch (Exception ex) { MessageBox.Show(ex + ""); }
        
        }

        public void CheckPTTeach() 
        {
            try
            {
                TeachCRUD.RetrievePT();

            }
            catch (Exception ex) { MessageBox.Show(ex + ""); }
        }




         




    }
}
