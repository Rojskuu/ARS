using System;
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
    public partial class FrmTeachList : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        String server = ConnectionString.ConString;
        SqlDataAdapter adapter;
        DataSet ds;
        DataTable dt;
        SqlDataReader reader;
        String query, ID = "", txt , mess="";
        private TeachCRUD TC = new TeachCRUD();
        LogHisCRUD log = new LogHisCRUD();
        FrmTeach frmTeach;

       [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public FrmTeachList()
        {

            InitializeComponent();
            
            con = new SqlConnection(server);
            PopulatedtgTeach();
        }
        public FrmTeachList(string mess)
        {

            InitializeComponent();
            con = new SqlConnection(server);
            btnUpdate.Enabled = false;
            this.mess = mess;
            PopulatedtgTeach();
        }



        private void FrmTeachList_Load(object sender, EventArgs e)
        {
            PopulatedtgTeach();

        }

        public void PopulatedtgTeach()
        {
            try
            {
                con.Open();

                query = "Select SUBSTRING(TeacherID,1,CHARINDEX('-', TeacherID)-1) AS 'Teacher ID', concat(FName, ' ', MName, '. ', LName) as Name," +
                    " Sex, Degree AS 'Highest form of Education', EmpType As 'Employee Type' ,Department" +
                       " FROM Teacher where Archive = 0 AND TeacherID LIKE '%" + FrmDash.SYSem + "%'";

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

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Confirm", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                WindowChecker.IsRunning = false;
                LogHisCRUD.Activity = " Closed Teacher form. " ;
                log.Create();
                dtgTeach.DataSource = null;
                dtgTeach.Rows.Clear();
                this.Close();
            }
            //WindowChecker.IsRunning = false;
            //this.Close();
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try 
            {
                if (mess.Trim().Equals(""))
                {
                    FrmTeach frmTeach = new FrmTeach();
                    
                    frmTeach.ShowDialog();
                    PopulatedtgTeach();
                }
                else 
                {
                    if (ID.Equals(""))
                    {
                        MessageBox.Show("Select a file!", "Warning!",
                                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else 
                    { 
                    ClassCRUD.TeacherID = ID;
                        
                    }
                }

            } catch (Exception) { }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtgTeach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (ID.Equals(""))
                {
                    MessageBox.Show("Select a file!", "Warning!",
                                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    frmTeach = new FrmTeach(ID);
                    frmTeach.ShowDialog();
                    PopulatedtgTeach();



                }
            }
            catch (Exception ex) { MessageBox.Show(ex + ""); }
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                txt = txtSearch.Text.Trim();

                if (txtSearch.Text.Trim().Equals(""))
                {
                    PopulatedtgTeach();
                }
                else
                {
                    con.Open();


                    query = "Select SUBSTRING(TeacherID,1,CHARINDEX('-', TeacherID)-1) AS 'Teacher ID', concat(FName, ' ', MName, '. ', LName) as Name," +
                            " Sex, Degree AS 'Highest form of Education', EmpType As 'Employee Type' , Department" +
                            " FROM Teacher where Archive = 0 " +
                            "AND TeacherID LIKE '%" + txt.Replace("'", "''") + "%' AND TeacherID LIKE '%" + FrmDash.SYSem + "%' " +
                            "or FName LIKE '%" + txt.Replace("'", "''") + "%' and TeacherID LIKE '%" + FrmDash.SYSem + "%' " +
                            "or MName LIKE '%" + txt.Replace("'", "''") + "%' and TeacherID LIKE '%" + FrmDash.SYSem + "%'"  +
                            "or LName LIKE '%" + txt.Replace("'", "''") + "%' and TeacherID LIKE '%" + FrmDash.SYSem + "%'"  +
                            "or Sex LIKE '" + txt.Replace("'", "''") + "%' and TeacherID LIKE '%" + FrmDash.SYSem + "%'" +
                            "or Degree LIKE '%" + txt.Replace("'", "''") + "%' and TeacherID LIKE '%" + FrmDash.SYSem + "%'" +
                            "or EmpType LIKE '%" + txt.Replace("'", "''") + "%' and TeacherID LIKE '%" + FrmDash.SYSem + "%'"
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

        private void dtgTeach_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dtgTeach.SelectedRows)
                {
                    
                    ID = dtgTeach.Rows[e.RowIndex].Cells[0].Value + "-" + FrmDash.SYSem ;
                    
                }
            }catch (Exception) { }
        }
    
    }
    
}
