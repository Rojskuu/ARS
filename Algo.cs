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
        String server = @"Data Source=DESKTOP-3LSCP0F\SQLEXPRESS;Initial Catalog = ARS; Integrated Security = True";
        SqlDataAdapter adapter;
        DataSet ds;
        DataTable dt;
        SqlDataReader reader;
        String query;

        ArrayList ClassList , RoomList;
        
        static int ctrClass = 0;



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
                int i = 0;
                while (rdr.Read())
                {
                    RoomList.Add(rdr.GetString(i) + "");
                    i++;
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
