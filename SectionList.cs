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
    public partial class FrmSectionList : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        String server = ConnectionString.ConString;
        SqlDataAdapter adapter;
        DataSet ds;
        DataTable dt;
        SqlDataReader reader;
        String query, ID = "" , txt, mess="";
        LogHisCRUD log;
        private SectionCRUD SC = new SectionCRUD();

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public FrmSectionList()
        {
            InitializeComponent();
        }
        public FrmSectionList(string mess)
        {
            InitializeComponent();
            btnUpdate.Enabled = false;
            this.mess = mess;
        }
        private void dtgTeach_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dtgSec.SelectedRows)
                {

                    ID = dtgSec.Rows[e.RowIndex].Cells[0].Value + "";

                }
            }
            catch (Exception) { }
        }

        public void PopulatedtgSec()
        {
            try
            {
                con = new SqlConnection(server);
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

            private void btnConfirm_Click(object sender, EventArgs e)
            {
                try
                {
                if (mess.Trim().Equals(""))
                {
                    FrmSection frmSection = new FrmSection();
                    frmSection.Show();
                    
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
                    ClassCRUD.SectionID = ID;
                        
                    }
                }
                }
                catch (Exception) { }
            }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
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
            if (MessageBox.Show("Are you sure you want to exit?", "Confirm", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LogHisCRUD.Activity = "Closed Section form" + ".";
                log.Create();
                WindowChecker.IsRunning = false;
                this.Close();
            }
            //WindowChecker.IsRunning = false;
            //this.Close();
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



                    FrmSection frmSec = new FrmSection(ID);
                    frmSec.ShowDialog();
                    this.Close();



                }
            }
            catch (Exception) { }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
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

        private void SectionList_Load(object sender, EventArgs e)
            {
              PopulatedtgSec();
            }
        }
    }

