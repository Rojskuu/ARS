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

        public FrmPT()
        {
            InitializeComponent();
            HoldValues();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            TeachCRUD.Mon = Mon;
            TeachCRUD.Tue = Tue;
            TeachCRUD.Wed = Wed;
            TeachCRUD.Thu = Thu;
            TeachCRUD.Fri = Fri;
            TeachCRUD.Sat = Sat;

            this.Close();
        }

        private void cbMon_CheckedChanged(object sender, EventArgs e)
        {
            if (Mon == 0) { Mon++; } else { Mon--; }
        }

        private void cbTue_CheckedChanged(object sender, EventArgs e)
        {
            if (Tue == 0) { Tue++; } else { Tue--; }
        }

        private void cbWed_CheckedChanged(object sender, EventArgs e)
        {
            if (Wed == 0) { Wed++; } else { Wed--; }
        }

        private void cbThu_CheckedChanged(object sender, EventArgs e)
        {
            if (Thu== 0) { Thu++; } else { Thu--; }
        }

        private void cbFri_CheckedChanged(object sender, EventArgs e)
        {
            if (Fri == 0) { Fri++; } else { Fri--; }
        }

        private void cbSat_CheckedChanged(object sender, EventArgs e)
        {
            if (Sat == 0) { Sat++; } else { Sat--; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HoldValues();


        }
        public void HoldValues() 
        {
            cbMon.Checked = Convert.ToBoolean(TeachCRUD.Mon);
            cbTue.Checked = Convert.ToBoolean(TeachCRUD.Tue);
            cbWed.Checked = Convert.ToBoolean(TeachCRUD.Wed);
            cbThu.Checked = Convert.ToBoolean(TeachCRUD.Thu);
            cbFri.Checked = Convert.ToBoolean(TeachCRUD.Fri);
            cbSat.Checked = Convert.ToBoolean(TeachCRUD.Sat);
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
    }
}
