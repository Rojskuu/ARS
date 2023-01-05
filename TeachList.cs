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
        String server = @"Data Source=DESKTOP-3LSCP0F\SQLEXPRESS;Initial Catalog = ARS; Integrated Security = True";
        SqlDataAdapter adapter;
        DataSet ds;
        DataTable dt;
        SqlDataReader reader;
        String query, ID = "", txt , mess="";
        private TeachCRUD TC = new TeachCRUD();

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public FrmTeachList()
        {

            InitializeComponent();
           
            con = new SqlConnection(server);
        }
        public FrmTeachList(string mess)
        {

            InitializeComponent();
            con = new SqlConnection(server);
            btnUpdate.Enabled = false;
            this.mess = mess;
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

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            WindowChecker.IsRunning = false;
            this.Close();
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
                    frmTeach.Show();
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
                    ClassCRUD.TeacherID = ID;
                        this.Close();
                    }
                }

            } catch (Exception) { }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
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



                    FrmTeach frmTeach = new FrmTeach(ID);
                    frmTeach.ShowDialog();
                    this.Close();



                }
            }
            catch (Exception) { }
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

        private void dtgTeach_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dtgTeach.SelectedRows)
                {
                    
                    ID = dtgTeach.Rows[e.RowIndex].Cells[0].Value + "";
                    
                }
            }catch (Exception) { }
        }
    
    }
    
}
