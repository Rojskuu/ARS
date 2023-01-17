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
    public partial class FrmSubjectList : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        String server = ConnectionString.ConString;
        SqlDataAdapter adapter;
        DataSet ds;
        DataTable dt;
        SqlDataReader reader;
        String query, ID = "" , txt , mess = "";

        FrmSubject FrmSub;

        private SubjectCRUD SC = new SubjectCRUD();

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
       
        public FrmSubjectList()
        {
            InitializeComponent();
        }
        public FrmSubjectList(string mess)
        {
            InitializeComponent();
            btnUpdate.Enabled = false;
            this.mess = mess;
        }

        private void FrmSubjectList_Load(object sender, EventArgs e)
        {
            PopulatedtgSub();
        }

        private void dtgSub_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dtgSub.SelectedRows)
                {

                    ID = dtgSub.Rows[e.RowIndex].Cells[0].Value + "";

                }
            }
            catch (Exception) { }

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (mess.Trim().Equals(""))
                {
                    FrmSub = new FrmSubject();
                    FrmSub.Show();
                    this.Close();
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
                      ClassCRUD.SubjectCode = ID;
                        this.Close();
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Confirm", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                WindowChecker.IsRunning = false;
                this.Close();
            }
            //WindowChecker.IsRunning = false;
            //this.Close();
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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



                    FrmSubject frmSub = new FrmSubject(ID);
                    frmSub.Show();

                    this.Close();

                }
            }
            catch (Exception) { }
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

        public void PopulatedtgSub() 
        {
            try
            {
                con = new SqlConnection(server);
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
    }
}
