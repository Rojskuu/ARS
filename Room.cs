using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomatedRoomScheduling
{
    public partial class FrmRoom : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        LogHisCRUD log;

        RoomCRUD RoomCRUD;

        public FrmRoom()
        {
            InitializeComponent();
            RoomCRUD = new RoomCRUD();
        }
        public FrmRoom(String ID) 
        {
            InitializeComponent();
            RoomCRUD = new RoomCRUD();
            RoomCRUD.RoomID = ID;
            RoomCRUD.Retrieve();
            Poptxt();

        }

        private void Room_Load(object sender, EventArgs e)
        {
           
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

       

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit? Any unsaved data will be lost.", "Confirm", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning) == DialogResult.OK)
            {
                FrmRoomList roomList = new FrmRoomList();
                roomList.Show();
                this.Close();
            }
            //FrmRoomList roomList = new FrmRoomList();
            //roomList.Show();
            //this.Close();
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        public void Clear() 
        {
            txtRoomID.Text = "";
            txtCap.Text = "";
            
            cmbRoomType.SelectedIndex = 0;

            btnADD.Text = "ADD";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtRoomID.Text.Equals("") || txtCap.Text.Equals("")
                    || cmbRoomType.SelectedIndex.Equals(0))
                {
                    MessageBox.Show("Please fill up all the fields. "
                          , "Field cannot be empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {

                    RoomCRUD.RoomID = txtRoomID.Text;
                    RoomCRUD.RoomCap = Convert.ToInt32(txtCap.Text);
                    RoomCRUD.RoomType = cmbRoomType.Text;
                   

                    if (btnADD.Text.Equals("ADD"))
                    {
                        LogHisCRUD.Activity = "Added Room " + RoomCRUD.RoomID + ".";
                        log.Create();
                        RoomCRUD.Create();
                        Clear();
                    }
                    else if (btnADD.Text.Equals("UPDATE"))
                    {
                        LogHisCRUD.Activity = "Updated Room " + RoomCRUD.RoomID + ".";
                        log.Create();
                        RoomCRUD.Update();
                        Clear();
                    }

                }
            }
            catch (Exception ex) { }
            finally 
            { 
                FrmRoomList roomList = new FrmRoomList();
                roomList.Show();
                this.Close();
            }
        }

        public void Poptxt() 
        {
            txtRoomID.Text = RoomCRUD.RoomID;
            txtCap.Text = RoomCRUD.RoomCap+"";
            cmbRoomType.Text = RoomCRUD.RoomType;
            

            btnADD.Text = "UPDATE";
        }

        private void txtRoomID_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                String txt = txtRoomID.Text;
                RoomCRUD.CheckRoomIDifExist(txt);

            }
            catch (Exception ex) { MessageBox.Show(ex + ""); }
        }
    }
}
