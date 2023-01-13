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
    public partial class FrmPT : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public static int Mon { get; set; }
        public static int Tue { get; set; }
        public static int Wed { get; set; }
        public static int Thu { get; set; }
        public static int Fri { get; set; }
        public static int Sat { get; set; }

        TeacherDayCRUD TeacherDayCRUD = new TeacherDayCRUD();
        TDTimeCRUD TDTimeCRUD = new TDTimeCRUD();

        public FrmPT()
        {
            InitializeComponent();
            HoldValues();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

            if (cbMon.Checked  && (cmbMonIn.SelectedIndex.Equals(0) || cmbMonOut.SelectedIndex.Equals(0)) ||
                cbTue.Checked  && (cmbTueIn.SelectedIndex.Equals(0) || cmbTueOut.SelectedIndex.Equals(0)) ||
                cbWed.Checked  && (cmbWedIn.SelectedIndex.Equals(0) || cmbWedOut.SelectedIndex.Equals(0)) ||
                cbThu.Checked  && (cmbThuIn.SelectedIndex.Equals(0) || cmbThuOut.SelectedIndex.Equals(0)) ||
                cbFri.Checked  && (cmbFriIn.SelectedIndex.Equals(0) || cmbFriOut.SelectedIndex.Equals(0)) ||
                cbSat.Checked  && (cmbSatIn.SelectedIndex.Equals(0) || cmbSatOut.SelectedIndex.Equals(0)))
            {
                MessageBox.Show("Please fill up all the fields. "
                              , "Field cannot be empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                if (cbMon.Checked)
                {
                    TeachCRUD.Days.Add(1);
                    TeachCRUD.MonIn = cmbMonIn.SelectedIndex;
                    TeachCRUD.MonOut = cmbMonOut.SelectedIndex;

                }
                else if (cbTue.Checked)
                {
                    TeachCRUD.Days.Add(2);
                    TeachCRUD.TueIn = cmbTueIn.SelectedIndex;
                    TeachCRUD.TueOut = cmbTueOut.SelectedIndex;
                }
                else if (cbWed.Checked)
                {
                    TeachCRUD.Days.Add(3);
                    TeachCRUD.WedIn = cmbWedIn.SelectedIndex;
                    TeachCRUD.WedOut = cmbWedOut.SelectedIndex;
                }
                else if (cbThu.Checked)
                {
                    TeachCRUD.Days.Add(4);
                    TeachCRUD.ThuIn = cmbThuIn.SelectedIndex;
                    TeachCRUD.ThuOut = cmbThuOut.SelectedIndex;
                }
                else if (cbFri.Checked)
                {
                    TeachCRUD.Days.Add(5);
                    TeachCRUD.FriIn = cmbFriIn.SelectedIndex;
                    TeachCRUD.FriOut = cmbFriOut.SelectedIndex;
                }
                else if (cbSat.Checked)
                {
                    TeachCRUD.Days.Add(6);
                    TeachCRUD.SatIn = cmbSatIn.SelectedIndex;
                    TeachCRUD.SatOut = cmbSatOut.SelectedIndex;
                }
                

                ClearCheck();
                this.Close();
            }
        }

       

        public void ClearCheck() 
        { 
            cbMon.Checked = false;
            cbTue.Checked = false;
            cbWed.Checked = false;
            cbThu.Checked = false;
            cbFri.Checked = false;
            cbSat.Checked = false;
        
        }

        private void cbMon_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMon.Checked) 
            {
                Mon = 1;

                cmbMonIn.Enabled = true;
            }
            else if (cbMon.Checked == false)
            {
                
                Mon = 0;
                

                cmbMonIn.Enabled = false;
                cmbMonIn.SelectedIndex = 0;
                cmbMonOut.SelectedIndex = 0;
            }
        }

        private void cbTue_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTue.Checked)
            {
                
                Tue = 1;
                

                cmbTueIn.Enabled = true;
            }
            else if (cbTue.Checked == false)
            {
                
                Tue = 0;
                

                cmbTueIn.Enabled = false;
                cmbTueIn.SelectedIndex = 0;
                cmbTueOut.SelectedIndex = 0;
            }
        }

        private void cbWed_CheckedChanged(object sender, EventArgs e)
        {
            if (cbWed.Checked)
            {
                
                Wed = 1;
                

                cmbWedIn.Enabled = true;
            }
            else if (cbWed.Checked == false)
            {
               
                Wed = 0;
                

                cmbWedIn.Enabled = false;
                cmbWedIn.SelectedIndex = 0;
                cmbWedOut.SelectedIndex = 0;
            }
        }

        private void cbThu_CheckedChanged(object sender, EventArgs e)
        {
            if (cbThu.Checked)
            {
                
                Thu = 1;
                

                cmbThuIn.Enabled = true;
            }
            else if (cbThu.Checked == false)
            {
                
                Thu = 0;
                

                cmbThuIn.Enabled = false;
                cmbThuIn.SelectedIndex = 0;
                cmbThuOut.SelectedIndex = 0;
            }
        }

        private void cbFri_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFri.Checked)
            {
                
                Fri = 1;
                

                cmbFriIn.Enabled = true;
            }
            else if (cbFri.Checked == false)
            {
               
                Fri = 0;
                

                cmbFriIn.Enabled = false;
                cmbFriIn.SelectedIndex = 0;
                cmbFriOut.SelectedIndex = 0;
            }
        }

        private void cbSat_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSat.Checked)
            {
                
                Sat = 1;
                

                cmbSatIn.Enabled = true;
            }
            else if (cbSat.Checked == false)
            {
                
                Sat = 0;
                

                cmbSatIn.Enabled = false;
                cmbSatIn.SelectedIndex = 0;
                cmbSatOut.SelectedIndex = 0;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HoldValues();
        }
        public void HoldValues() 
        {
            cbMon.Checked  = Convert.ToBoolean(TeachCRUD.Mon);
            cmbMonIn.SelectedIndex  = TeachCRUD.MonIn;
            cmbMonOut.SelectedIndex = TeachCRUD.MonOut;
            cbTue.Checked  = Convert.ToBoolean(TeachCRUD.Tue);
            cmbTueIn.SelectedIndex = TeachCRUD.TueIn;
            cmbTueOut.SelectedIndex = TeachCRUD.TueOut;
            cbWed.Checked  = Convert.ToBoolean(TeachCRUD.Wed);
            cmbWedIn.SelectedIndex = TeachCRUD.WedIn;
            cmbWedOut.SelectedIndex = TeachCRUD.WedOut;
            cbThu.Checked  = Convert.ToBoolean(TeachCRUD.Thu);
            cmbThuIn.SelectedIndex = TeachCRUD.ThuIn;
            cmbThuOut.SelectedIndex = TeachCRUD.ThuOut;
            cbFri.Checked  = Convert.ToBoolean(TeachCRUD.Fri);
            cmbFriIn.SelectedIndex = TeachCRUD.FriIn;
            cmbFriOut.SelectedIndex = TeachCRUD.FriOut;
            cbSat.Checked  = Convert.ToBoolean(TeachCRUD.Sat);
            cmbSatIn.SelectedIndex = TeachCRUD.SatIn;
            cmbSatOut.SelectedIndex = TeachCRUD.SatOut;
        }

        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            try 
            { 
                WindowState = FormWindowState.Minimized; 
            } catch (Exception ex) { MessageBox.Show(ex+""); }
            
        }

        private void cmbMonIn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMonIn.Text.Equals(""))
            {
                cmbMonOut.Text = "";
                cmbMonOut.Enabled = false;

            }
            else 
            {
                cmbMonOut.Enabled = true;

            }
        }

        private void cmbTueIn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTueIn.Text.Equals(""))
            {
                cmbTueOut.Text = "";
                cmbTueOut.Enabled = false;

            }
            else
            {
                cmbTueOut.Enabled = true;

            }
        }

        private void cmbWedIn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbWedIn.Text.Equals(""))
            {
                cmbWedOut.Text = "";
                cmbWedOut.Enabled = false;

            }
            else
            {
                cmbWedOut.Enabled = true;

            }
        }

        private void cmbThuIn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbThuIn.Text.Equals(""))
            {
                cmbThuOut.Text = "";
                cmbThuOut.Enabled = false;

            }
            else
            {
                cmbThuOut.Enabled = true;

            }
        }

        private void cmbFriIn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFriIn.Text.Equals(""))
            {
                cmbFriOut.Text = "";
                cmbFriOut.Enabled = false;

            }
            else
            {
                cmbFriOut.Enabled = true;

            }
        }

        private void cmbSatIn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSatIn.Text.Equals(""))
            {
                cmbSatOut.Text = "";
                cmbSatOut.Enabled = false;

            }
            else
            {
                cmbSatOut.Enabled = true;

            }
        }

        private void cmbMonOut_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMonIn.SelectedIndex >= cmbMonOut.SelectedIndex && cmbMonOut.SelectedIndex!=0) 
            {
                MessageBox.Show("Time out cannot be less than the time in."
                        , "Time Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbMonOut.SelectedIndex = 0;
            } 

        }

        private void cmbTueOut_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTueIn.SelectedIndex >= cmbTueOut.SelectedIndex && cmbTueOut.SelectedIndex != 0)
            {
                MessageBox.Show("Time out cannot be less than the time in."
                        , "Time Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbTueOut.SelectedIndex = 0;
            }
        }

        private void cmbWedOut_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbWedIn.SelectedIndex >= cmbWedOut.SelectedIndex && cmbWedOut.SelectedIndex != 0)
            {
                MessageBox.Show("Time out cannot be less than the time in."
                        , "Time Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbWedOut.SelectedIndex = 0;
            }
        }

        private void cmbThuOut_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbThuIn.SelectedIndex >= cmbThuOut.SelectedIndex && cmbThuOut.SelectedIndex != 0)
            {
                MessageBox.Show("Time out cannot be less than the time in."
                        , "Time Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbThuOut.SelectedIndex = 0;
            }
        }

        private void cmbFriOut_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFriIn.SelectedIndex >= cmbFriOut.SelectedIndex && cmbFriOut.SelectedIndex != 0)
            {
                MessageBox.Show("Time out cannot be less than the time in."
                        , "Time Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbFriOut.SelectedIndex = 0;
            }
        }

        private void cmbSatOut_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSatIn.SelectedIndex >= cmbSatOut.SelectedIndex && cmbSatOut.SelectedIndex != 0)
            {
                MessageBox.Show("Time out cannot be less than the time in."
                        , "Time Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbSatOut.SelectedIndex = 0;
            }
        }

      
    }
}
