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
    public partial class FrmClassList : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        String server = ConnectionString.ConString;
        SqlDataAdapter adapter;
        DataSet ds;
        DataTable dt;
        SqlDataReader reader;
        String query , ID = "", txt;
        ClassCRUD ClassCRUD;
        LogHisCRUD log = new LogHisCRUD();
        FrmClass FrmClass;
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public FrmClassList()
        {
            InitializeComponent();
            con = new SqlConnection(server);
            ClassCRUD = new ClassCRUD();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void FrmClassList_Load(object sender, EventArgs e)
        {
            PopdtgClass();
        }
        public void PopdtgClass() 
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

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                FrmClass = new FrmClass();
                FrmClass.Show();
                this.Close();
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
                LogHisCRUD.Activity = "Closed Class form" + ".";
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

                    
                    
                    FrmClass frmClass = new FrmClass(ID);
                    frmClass.Show();

                    this.Close();

                }
            }
            catch (Exception) { }
        }

        private void txtClass_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                txt = txtClass.Text.Trim();

                if (txtClass.Text.Trim().Equals(""))
                {
                    PopdtgClass();
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

        private void dtgClass_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dtgClass.SelectedRows)
                {
                    
                    ID = dtgClass.Rows[e.RowIndex].Cells[0].Value + "";
                    
                }
            }
            catch (Exception) { }
        }
    }
}
