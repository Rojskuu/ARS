﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomatedRoomScheduling
{

    public partial class FrmDash : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        FrmTeachList Teach;
        FrmSectionList Section;
        FrmClassList Class;
        FrmRoomList Room;
        FrmSubjectList Subject;
        FrmSchedule Sched;

        ArrayList FrmCollection;


        SqlCommand cmd;
        SqlConnection con;
        String server = @"Data Source=DESKTOP-3LSCP0F\SQLEXPRESS;Initial Catalog = ARS; Integrated Security = True";
        SqlDataAdapter adapter;
        DataSet ds;
        DataTable dt;
        SqlDataReader reader;
        String query, ID, txt;

       

        public static int Yr { get; set; }
        public static int Mnth { get; set; }
        public static int Day { get; set; }
        public static int Hr { get; set; }
        public static int Min { get; set; }
        public static int Sec { get; set; }
        


        DateTime dtime = DateTime.Now;




        public FrmDash()
        {
            InitializeComponent();
            con = new SqlConnection(server);

        }

        private void FrmDash_Load(object sender, EventArgs e)
        {
            Populate_FrmCollection();

            Yr = dtime.Year;
            Mnth = dtime.Month;
            Day = dtime.Day;
            Hr = dtime.Hour;
            Min = dtime.Minute;
            Sec = dtime.Second;

            Timer timer = new Timer();
            PopulatedtgTeach();
            PopulatedtgClass();
            PopulatedtgRoom();
            PopulatedtgSec();
            PopulatedtgSub();

        }
        public void PopulatedtgTeach()
        {
            try
            {
                con.Open();

                query = TeachCRUD.TeachDisplay;

                adapter = new SqlDataAdapter(query, con);
                ds = new DataSet();
                ds.Clear();
                adapter.Fill(ds);
                dtgTeach.DataSource = ds.Tables[0];

                con.Close();



            }
            catch (Exception e) { MessageBox.Show(e + ""); }
            finally { con.Close(); }
        }
        public void PopulatedtgSec()
        {
            try
            {
                con.Open();

                query = SectionCRUD.SecDisplay;

                adapter = new SqlDataAdapter(query, con);
                ds = new DataSet();
                ds.Clear();
                adapter.Fill(ds);
                dtgSec.DataSource = ds.Tables[0];

                con.Close();

            }
            catch (Exception e) { MessageBox.Show(e + ""); }
            finally { con.Close(); }
        }

        public void PopulatedtgSub()
        {
            try
            {
                con.Open();

                query = SubjectCRUD.SubDisplay;

                adapter = new SqlDataAdapter(query, con);
                ds = new DataSet();
                ds.Clear();
                adapter.Fill(ds);
                dtgSub.DataSource = ds.Tables[0];

                con.Close();

            }
            catch (Exception e) { MessageBox.Show(e + ""); }
            finally { con.Close(); }

        }
        public void PopulatedtgRoom()
        {
            try
            {
                con.Open();

                query = RoomCRUD.RoomDisplay;

                adapter = new SqlDataAdapter(query, con);
                ds = new DataSet();
                ds.Clear();
                adapter.Fill(ds);
                dtgRoom.DataSource = ds.Tables[0];

                con.Close();



            }
            catch (Exception e) { MessageBox.Show(e + ""); }
            finally { con.Close(); }
        }
        public void PopulatedtgClass()
        {
            try
            {
                con.Open();

                query = ClassCRUD.ClassDisplay;

                adapter = new SqlDataAdapter(query, con);
                ds = new DataSet();
                ds.Clear();
                adapter.Fill(ds);
                dtgClass.DataSource = ds.Tables[0];

                con.Close();



            }
            catch (Exception e) { MessageBox.Show(e + ""); }
            finally { con.Close(); }
        }


        private void Populate_FrmCollection() 
        {
            FrmCollection = new ArrayList();
            FrmCollection.Add(Teach);
            FrmCollection.Add(Section);
            FrmCollection.Add(Class);
            FrmCollection.Add(Room);
            FrmCollection.Add(Subject);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            if (WindowChecker.IsRunning == true)
            {
                MessageBox.Show("A Form is already open. Please close the other forms before proceeding.",
                    "Close other form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                WindowChecker.IsRunning = true;
                Teach = new FrmTeachList();
                Teach.Show();
                
            }
        }

        private void btnSection_Click(object sender, EventArgs e)
        {
            if (WindowChecker.IsRunning == true)
            {
                MessageBox.Show("A Form is already open. Please close the other forms before proceeding.",
                   "Close other form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                WindowChecker.IsRunning = true;
                Section = new FrmSectionList();
                Section.Show();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (WindowChecker.IsRunning == true)
            {
                MessageBox.Show("A Form is already open. Please close the other forms before proceeding.",
                    "Close other form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                WindowChecker.IsRunning = true;
                Subject = new FrmSubjectList();
                Subject.Show();
            }
            

        }

        private void btnClass_Click(object sender, EventArgs e)
        {
            if (WindowChecker.IsRunning == true)
            {
                MessageBox.Show("A Form is already open. Please close the other forms before proceeding.",
                   "Close other form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                WindowChecker.IsRunning = true;
                Class = new FrmClassList();
                Class.Show();
            }
            
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            if (WindowChecker.IsRunning == true)
            {
                MessageBox.Show("A Form is already open. Please close the other forms before proceeding.",
                    "Close other form",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                WindowChecker.IsRunning = true;
                Room = new FrmRoomList();
                Room.Show();
            }
            
        }

        private void tabClass_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabRoom_Click(object sender, EventArgs e)
        {

        }

        private void txtRoom_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                txt = txtRoom.Text.Trim();

                if (txtRoom.Text.Equals(""))
                {
                    PopulatedtgRoom();
                }
                else
                {

                    con.Open();


                    query = "Select RoomID AS 'Room ID' , RoomType AS 'Room Type', " +
                            "Cap AS 'Capacity' , Flooor AS 'Floor' FROM ROOM WHERE Archive = 0 " +
                            "AND RoomID LIKE '%" + txt + "%' and Archive = 0 " +
                            "or RoomType LIKE '%" + txt + "%' and Archive = 0 " +
                            "or Cap LIKE '%" + txt + "%' and Archive = 0 " +
                            "or Flooor LIKE '%" + txt + "%' and Archive = 0 "
                        ;
                    adapter = new SqlDataAdapter(query, con);
                    ds = new DataSet();
                    ds.Clear();
                    adapter.Fill(ds);
                    dtgRoom.DataSource = ds.Tables[0];
                    con.Close();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex+""); }
            finally { con.Close(); }
        }

        private void txtSection_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                txt = txtSection.Text.Trim();

                if (txtSection.Text.Trim().Equals(""))
                {
                    PopulatedtgSec();
                }
                else
                {

                    con.Open();


                    query = "Select SectionID AS 'Section ID' , SecCnt AS 'Student Count' , Course AS 'Course' " +
                            ", Yearlvl AS 'Year level' from Section  where Archive = 0 " +
                            "AND SectionID LIKE '%" + txt + "%' and Archive = 0 " +
                            "or SecCnt LIKE '%" + txt + "%' and Archive = 0 " +
                            "or Course LIKE '%" + txt + "%' and Archive = 0 " +
                            "or Yearlvl LIKE '%" + txt + "%' and Archive = 0 "

                        ;
                    adapter = new SqlDataAdapter(query, con);
                    ds = new DataSet();
                    ds.Clear();
                    adapter.Fill(ds);
                    dtgSec.DataSource = ds.Tables[0];
                    con.Close();
                }
            }
            catch (Exception ex) { }
            finally { con.Close(); }
        }

        private void txtClass_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                txt = txtClass.Text.Trim();

                if (txtClass.Text.Trim().Equals(""))
                {
                    PopulatedtgClass();
                }
                else
                {

                    con.Open();


                    query = "SELECT ClassID AS 'Class ID', SubCode AS 'Subject Code', " +
                            "SectionID AS 'Section ID', TeacherID AS 'Teacher ID' FROM CLASS where Archive = 0 " +
                            "AND ClassID LIKE '%" + txt + "%' and Archive = 0 " +
                            "or SubCode LIKE '%" + txt + "%' and Archive = 0 " +
                            "or SectionID LIKE '%" + txt + "%' and Archive = 0 " +
                            "or TeacherID LIKE '%" + txt + "%' and Archive = 0 "
                        ;
                    adapter = new SqlDataAdapter(query, con);
                    ds = new DataSet();
                    ds.Clear();
                    adapter.Fill(ds);
                    dtgClass.DataSource = ds.Tables[0];
                    con.Close();
                }
            }
            catch (Exception ex) { }
            finally { con.Close(); }
        }

        private void txtSub_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                txt = txtSub.Text.Trim();

                if (txtSub.Text.Trim().Equals(""))
                {
                    PopulatedtgSub();
                }
                else
                {
                    con.Open();


                    query = "Select SubCode AS 'Subject Code', SubDescript AS 'Subject Description'," +
                            "SubType AS 'Subject Type', unit AS 'Subject Unit' , Hrs AS 'Hours Required' From Subj Where Archive = 0 " +
                            "AND SubCode LIKE '%" + txt + "%' and Archive = 0 " +
                            "or SubDescript LIKE '%" + txt + "%' and Archive = 0 " +
                            "or SubType LIKE '%" + txt + "%' and Archive = 0 " +
                            "or unit LIKE '%" + txt + "%' and Archive = 0 " +
                            "or Hrs LIKE '%" + txt + "%' and Archive = 0 "
                        ;
                    adapter = new SqlDataAdapter(query, con);
                    ds = new DataSet();
                    ds.Clear();
                    adapter.Fill(ds);
                    dtgSub.DataSource = ds.Tables[0];
                    con.Close();
                }
            }
            catch (Exception ex) { }
            finally { con.Close(); }
        }

        private void btnSched_Click(object sender, EventArgs e)
        {
            if (WindowChecker.IsRunning == true)
            {
                MessageBox.Show("A Form is already open. Please close the other forms before proceeding.",
                   "Close other form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                WindowChecker.IsRunning = true;
                Sched = new FrmSchedule();
                Sched.Show();
            }
        }

        private void txtTeach_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                txt = txtTeach.Text.Trim();

                if (txtTeach.Text.Trim().Equals(""))
                {
                    PopulatedtgTeach();
                }
                else
                {
                    con.Open();


                    query = "Select TeacherID as 'Teacher ID', concat(FName, ' ', MName, '. ', LName) as Name," +
                            " Sex, Degree AS 'Highest form of Education', EmpType As 'Employee Type'" +
                            " FROM Teacher where Archive = 0 " +
                            "AND TeacherID LIKE '%" + txt + "%' and Archive = 0 " +
                            "or FName LIKE '%" + txt + "%' and Archive = 0 " +
                            "or MName LIKE '%" + txt + "%' and Archive = 0 " +
                            "or LName LIKE '%" + txt + "%' and Archive = 0 " +
                            "or Sex LIKE '" + txt + "%' and Archive = 0 " +
                            "or Degree LIKE '%" + txt + "%' and Archive = 0 " +
                            "or EmpType LIKE '%" + txt + "%' and Archive = 0 "
                        ;
                    adapter = new SqlDataAdapter(query, con);
                    ds = new DataSet();
                    ds.Clear();
                    adapter.Fill(ds);
                    dtgTeach.DataSource = ds.Tables[0];
                    con.Close();
                }
            }
            catch (Exception ex) { }
            finally { con.Close(); }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Sec++;
            if (Sec == 60)
            {
                Sec = 0;
                Min++;
            }
            if (Min == 60)
            {
                Min = 0;
                Hr++;
            }

            lblTimer.Text = "Time:     " + Hr.ToString("00") + ":" + Min.ToString("00") +
                ":" + Sec.ToString("00") + "\nDate: " + Mnth.ToString("00") + "/" + Day.ToString("00") + "/" + Yr;
        }
    }
}
