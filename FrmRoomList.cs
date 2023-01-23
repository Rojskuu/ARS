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
    public partial class FrmRoomList : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        String server = ConnectionString.ConString;
        SqlDataAdapter adapter;
        DataSet ds;
        DataTable dt;
        SqlDataReader reader;
        String query, ID = "" , txt;
        LogHisCRUD log =  new LogHisCRUD();
        FrmRoom frmRoom;

        private RoomCRUD RC = new RoomCRUD();

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void btnMini_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Confirm", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LogHisCRUD.Activity = "Closed the Room form. ";
                log.Create();
                WindowChecker.IsRunning = false;
                this.Close();
            }
            //WindowChecker.IsRunning = false;
            //this.Close();
        }

        private void dtgRoom_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dtgRoom.SelectedRows)
                {

                    ID = dtgRoom.Rows[e.RowIndex].Cells[0].Value + "";

                }
            }
            catch (Exception) { }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FrmRoomList_Load(object sender, EventArgs e)
        {
            PopulatedtgRoom();
        }
        public void PopulatedtgRoom()
        {
            try
            {

                con = new SqlConnection(server);
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

        private void btnADD_Click(object sender, EventArgs e)
        {
            try
            {
                frmRoom = new FrmRoom();
                frmRoom.ShowDialog();
                
            }
            catch (Exception) { }
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



                    FrmRoom frmRoom = new FrmRoom(ID);
                    frmRoom.Show();
                   



                }
            }
            catch (Exception) { }
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
            catch (Exception ex) { MessageBox.Show(ex + ""); }
            finally { con.Close(); }
        }

        public FrmRoomList()
        {
            InitializeComponent();
        }
    }
}
