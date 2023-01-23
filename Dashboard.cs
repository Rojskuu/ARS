using System;
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
        LogHisCRUD log = new LogHisCRUD();
        FrmLogHis LogHis;

        SYCRUD SYCRUD = new SYCRUD();

        ArrayList FrmCollection, WeekDay, Time;

        public static ArrayList SY;

        SqlCommand cmd;
        SqlConnection con;
        String server = ConnectionString.ConString;
        SqlDataAdapter adapter;
        DataSet ds;
        DataTable dt;
        SqlDataReader reader;
        String query, ID, txt;

        public static String SYSem { get; set; } = "";



       

        public static int Yr { get; set; }
        public static int Mnth { get; set; }
        public static int Day { get; set; }
        public static int Hr { get; set; }
        public static int Min { get; set; }
        public static int Sec { get; set; }
        public static int MilliSec { get; set; }
        public static int Nanosec { get; set; }





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
            MilliSec = dtime.Millisecond;
            Nanosec = 0;


            Timer timer = new Timer();
            PopulatedtgTeach();
            //PopulateDayTime();
            PopulatedtgRoom();
            PopulatedtgSec();
            PopSY();
        }

        public void PopSY()
        {
            try 
            {
                SYCRUD.Retrieve();

                for (int i = 0; i < SYCRUD.SYList.Count; i++)
                {
                    cmbSY.Items.Add(SYCRUD.SYList[i]);
                }

            } catch (Exception ex) { MessageBox.Show(ex+""); }

        }


        public void PopulatedtgTeach()
        {
            try
            {
                con.Open();

                query = "Select * from SCHED";

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
            if (MessageBox.Show("Are you sure you want to logout?", "Confirm", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LogHisCRUD.Activity = " Logout "+AdminChecker.Admin;
                log.Create();
                this.Close();
                
            }
            //this.Close();
        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            if (SYSem.Equals(""))
            {

                MessageBox.Show("Please select a SY / Sem before proceeding.",
                       "Select a SY / Sem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
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
                    LogHisCRUD.Activity = " Opened the Teacher form. ";
                    log.Create();
                    Teach.ShowDialog();

                }
            }
        }

        private void btnSection_Click(object sender, EventArgs e)
        {
            if (SYSem.Equals(""))
            {

                MessageBox.Show("Please select a SY / Sem before proceeding.",
                       "Select a SY / Sem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
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
                    LogHisCRUD.Activity = " Opened Section form. ";
                    log.Create();
                    Section.ShowDialog();
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (SYSem.Equals(""))
            {

                MessageBox.Show("Please select a SY / Sem before proceeding.",
                       "Select a SY / Sem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
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
                    LogHisCRUD.Activity = " Opened Subject form. ";
                    log.Create();
                    Subject.ShowDialog();
                }
            }
            

        }

        private void btnClass_Click(object sender, EventArgs e)
        {
            if (SYSem.Equals(""))
            {

                MessageBox.Show("Please select a SY / Sem before proceeding.",
                       "Select a SY / Sem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
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
                    LogHisCRUD.Activity = " Opened Class form. ";
                    log.Create();
                    Class.ShowDialog();
                }
            }
            
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            if (SYSem.Equals(""))
            {

                MessageBox.Show("Please select a SY / Sem before proceeding.",
                       "Select a SY / Sem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                if (WindowChecker.IsRunning == true)
                {
                    MessageBox.Show("A Form is already open. Please close the other forms before proceeding.",
                        "Close other form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    WindowChecker.IsRunning = true;
                    Room = new FrmRoomList();
                    LogHisCRUD.Activity = " Opened Room form. ";
                    log.Create();
                    Room.ShowDialog();
                }
            }
            
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

        private void btnSNT_Click(object sender, EventArgs e)
        {
            try 
            { 
                FrmSY frmSY = new FrmSY();
                LogHisCRUD.Activity = " Opened SY / Sem form.";
                log.Create();
                frmSY.ShowDialog();

            } catch (Exception ex) { MessageBox.Show(ex+""); }
        }

        private void GenID_Tick(object sender, EventArgs e)
        {
            
            
            MilliSec++;
            if (MilliSec == 99) 
            {
                MilliSec = 0;
                Sec++;
            }
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
        }

        private void nanosec_Tick(object sender, EventArgs e)
        {
            Nanosec++;
            if (Nanosec == 10000) { Nanosec = 0; }

        }

        private void cmbSY_SelectedIndexChanged(object sender, EventArgs e)
        {
            try 
            {

                SYSem = cmbSY.SelectedItem+"";

                LogHisCRUD.Activity =  " Selected "+SYSem+" in the Dashboard.";
                log.Create();

            } catch (Exception ex) { MessageBox.Show(ex+ ""); }
        }

        private void btnLogHis_Click(object sender, EventArgs e)
        {
            try 
            {
                if (WindowChecker.IsRunning == true)
                {
                    MessageBox.Show("A Form is open. Please close the other forms before proceeding.",
                        "Close other form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    WindowChecker.IsRunning = true;
                    LogHis = new FrmLogHis();
                    LogHisCRUD.Activity = " Opened the Log History. ";
                    log.Create();
                    LogHis.Show();

                }


            } catch (Exception ex) { MessageBox.Show(ex + ""); }
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
                            "or Yearlvl LIKE '%" + txt + "%' and Archive = 0 ";

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

       

       
        private void btnSched_Click(object sender, EventArgs e)
        {
            if (SYSem.Equals(""))
            {

                MessageBox.Show("Please select a SY / Sem before proceeding.",
                       "Select a SY / Sem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                Algo algo = new Algo();
            }
            
            //if (WindowChecker.IsRunning == true)
            //{
            //    MessageBox.Show("A Form is already open. Please close the other forms before proceeding.",
            //       "Close other form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
            //else
            //{
            //    WindowChecker.IsRunning = true;
            //    Sched = new FrmSchedule();
            //    Sched.Show();
            //}
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
