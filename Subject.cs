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
    public partial class FrmSubject : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        FrmDash dash;
        SubjectCRUD SubjectCRUD;
        String Hrs;
        LogHisCRUD log = new LogHisCRUD();


        public FrmSubject()
        {
            InitializeComponent();
             SubjectCRUD = new SubjectCRUD();
            
            
        }
        public FrmSubject(String ID)
        {
            InitializeComponent();
            SubjectCRUD = new SubjectCRUD();
            SubjectCRUD.SubjectCode = ID;
            txtSubCode.Enabled = false;
            SubjectCRUD.Retrieve();
            Poptxt();

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
                FrmSubjectList frmSubject = new FrmSubjectList();
              
                this.Close();
            }
            //FrmSubjectList frmSubject = new FrmSubjectList();
            //frmSubject.Show();
            //this.Close();
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void FrmSubject_Load(object sender, EventArgs e)
        {
            
        }
        public void Poptxt() 
        {
            txtSubCode.Text = SubjectCRUD.SubjectCode;
            txtSubDesc.Text = SubjectCRUD.SubjectDesc;
            cmbSubUnit.Text = SubjectCRUD.SubjectUnit+"";
            cmbClassType.Text = SubjectCRUD.ClassType;
            numHrs.Value = SubjectCRUD.Hrs;
            numMin.Value = SubjectCRUD.Min;
            cmbDept.Text = SubjectCRUD.Department;
           
            Hrs = SubjectCRUD.SubjectHrsndd+"";

            btnAdd.Text = "UPDATE";
        }

        public void Clear() 
        {
            txtSubCode.Text = "";
            txtSubDesc.Text = "";
            cmbSubUnit.Text = "";
            
            numHrs.Value = 0;
            numMin.Value = 0;
            cmbClassType.Text = "";
            btnAdd.Text = "ADD";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSubCode.Text.Trim().Equals("") || txtSubDesc.Text.Trim().Equals("") ||
                    cmbSubUnit.Text.Trim().Equals("") || numHrs.Value.Equals(0) ||
                    cmbClassType.Text.Trim().Equals("") || cmbDept.Text.Equals(""))
                {
                    MessageBox.Show("Please fill up all the fields. "
                        , "Field cannot be empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    SubjectCRUD.SubjectCode = txtSubCode.Text;
                    SubjectCRUD.SubjectDesc = txtSubDesc.Text;
                    SubjectCRUD.SubjectUnit = Convert.ToInt32(cmbSubUnit.Text);
                    Hrs = numHrs.Value + ":" + numMin.Value;
                    SubjectCRUD.SubjectHrsndd = Hrs;
                    SubjectCRUD.ClassType = cmbClassType.Text;
                    SubjectCRUD.Department = cmbDept.Text;

                    if (btnAdd.Text.Equals("ADD"))
                    {
                        LogHisCRUD.Activity = "Added Subject " + SubjectCRUD.SubjectCode + ".";
                        log.Create();
                        SubjectCRUD.Create();
                        Clear();
                    }
                    else
                    {
                        LogHisCRUD.Activity = "Updated Subject " + SubjectCRUD.SubjectCode + ".";
                        log.Create();
                        SubjectCRUD.Update();
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

        private void txtSubCode_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                String txt = txtSubCode.Text;
                SubjectCRUD.CheckSubjectIDifExist(txt);

            }
            catch (Exception ex) { MessageBox.Show(ex + ""); }
        }

        private void txtSubCode_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
