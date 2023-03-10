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
    public partial class FrmSection : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        FrmDash dash;
        SectionCRUD SectionCRUD;
        LogHisCRUD log = new LogHisCRUD();
        String course = "" , yr= "";
        public FrmSection()
        {
            InitializeComponent();
            SectionCRUD = new SectionCRUD();
        }

        public FrmSection(String ID) 
        {

            
                
            
            InitializeComponent();

            txtSectionID.Enabled = false;
            cmbCourse.Enabled = false;
            cmbYrlvl.Enabled = false;

            SectionCRUD = new SectionCRUD();
            SectionCRUD.SectionID = ID;
            SectionCRUD.Retrieve();
            SectionCRUD.SectionID = ID.Substring(0,ID.IndexOf('-'));

            

            Poptxt();

        }
        private void FrmSection_Load(object sender, EventArgs e)
        {
            
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            dash = new FrmDash();
            dash.Show();    
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit? Any unsaved data will be lost.", "Confirm", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning) == DialogResult.OK)
            {
                LogHisCRUD.Activity = " Closed Section form.";
                log.Create();
                this.Close();

                FrmSectionList frmSection = new FrmSectionList();
                
                
            }
            //FrmSectionList frmSection = new FrmSectionList();
            //frmSection.Show();
            //this.Close();
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public void Clear() 
        {
            txtSectionID.Text = "";
            txtSectionID.Enabled = true;
            txtSectionCnt.Text = "";
            txtSectionCnt.Enabled = true;
            cmbCourse.SelectedIndex = 0;
            cmbCourse.Enabled = true;
            cmbYrlvl.SelectedIndex = 0;
            cmbYrlvl.Enabled = true;
            btnAdd.Text = "ADD";
        }
        public void Poptxt() 
        {
            
            txtSectionID.Text = SectionCRUD.SectionID;
            txtSectionCnt.Text = SectionCRUD.SectionCount+"";
            cmbCourse.Text = SectionCRUD.Course;
            cmbYrlvl.Text = SectionCRUD.Yrlvl;

            txtSectionID.Enabled = false;
            btnAdd.Text = "UPDATE";

            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSectionID.Text.Equals("") || txtSectionCnt.Text.Equals("")
                    || cmbCourse.SelectedIndex.Equals(0) || cmbYrlvl.SelectedIndex.Equals(0))
                {
                    MessageBox.Show("Please fill up all the fields. "
                          , "Field cannot be empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {

                    SectionCRUD.SectionID = txtSectionID.Text;
                    SectionCRUD.SectionCount = Convert.ToInt32(txtSectionCnt.Text);
                    SectionCRUD.Course = cmbCourse.Text;
                    SectionCRUD.Yrlvl = cmbYrlvl.Text;

                    if (btnAdd.Text.Equals("ADD"))
                    {
                        LogHisCRUD.Activity = "Added Section " + SectionCRUD.SectionID + ".";
                        log.Create();
                        SectionCRUD.Create();
                       

                        Clear();
                    }
                    else if (btnAdd.Text.Equals("UPDATE"))
                    {
                        LogHisCRUD.Activity = "Updated Section " + SectionCRUD.SectionID + ".";
                        log.Create();
                        SectionCRUD.Update();


                        Clear();
                    }

                }
            }
            catch (Exception ex) { }
            finally 
            { 
                
                this.Close();
            }
        }

        private void cmbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //if (SectionCRUD.SectionID.Equals(""))
                //{
                //     cmbCourse.SelectedIndexChanged -= cmbCourse_SelectedIndexChanged;
            
                //}
                //int start = cmbCourse.Text.IndexOf('(')+1;
                //int end = cmbCourse.Text.IndexOf(')') - start;
                //course = cmbCourse.Text.Substring(start, end);

            //txtSectionID.Text = course + " " + yr;


        } catch (Exception ex) { MessageBox.Show(""); }
        }

        private void cmbYrlvl_SelectedIndexChanged(object sender, EventArgs e)
        {
            try 
            {
                //if (SectionCRUD.SectionID.Equals(""))
                //{
                //    cmbYrlvl.SelectedIndexChanged -= cmbYrlvl_SelectedIndexChanged;
                //}
                //yr = cmbYrlvl.SelectedIndex+"";

                //txtSectionID.Text = course +" "+ yr;
            } catch (Exception ex) { MessageBox.Show(ex + ""); }
        }

        private void txtSectionCnt_KeyUp(object sender, KeyEventArgs e)
        {
            if (!char.IsControl(((char)e.KeyCode)) && !char.IsDigit(((char)e.KeyCode)))
            {
                MessageBox.Show("Please input number only in this text field.", "Error!",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
               txtSectionCnt.Text = "";
                e.Handled = true;
            }
        }

        private void btnElipsis_Click(object sender, EventArgs e)
        {

        }
    }
}
