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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AutomatedRoomScheduling
{
    public partial class FrmTeach : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        
        FrmDash dash;

        Apos apos = new Apos();

        TeachCRUD TeachCRUD;

        TeacherDayCRUD TeacherDayCRUD = new TeacherDayCRUD();
        TDTimeCRUD TDTimeCRUD  = new TDTimeCRUD();

        public static String male = "";
        public static String female = "";
       
        public FrmTeach()
        {
            InitializeComponent();
            TeachCRUD = new TeachCRUD();
        }

        public FrmTeach(String ID)
        {
            InitializeComponent();
            TeachCRUD = new TeachCRUD();

            TeachCRUD.TeacherID = ID;
            TeachCRUD.Retrieve();
            Poptxt();
        }
        private void FrmTeach_Load(object sender, EventArgs e)
        {
            int currentYear = DateTime.Now.Year;
            int minAge = 22;
            int maxAge = 50;

            dtBday.MaxDate = new DateTime(currentYear - minAge, 1, 1);
            dtBday.MinDate = new DateTime(currentYear - maxAge, 12, 31);

            txtConNum.MaxLength = 10;
        }

        public void Poptxt() 
        {
            txtTeacherID.Text = TeachCRUD.TeacherID;
            txtFName.Text = TeachCRUD.FName;
            txtMName.Text = TeachCRUD.MName;
            txtLName.Text = TeachCRUD.LName;
            if (TeachCRUD.Sex.Equals("Male"))
            {
                rbtnMale.Checked = true;
                rbtnFemale.Checked = false;
            }
            else 
            {
                rbtnMale.Checked = false;
                rbtnFemale.Checked = true;
            }
            txtReligion.Text = TeachCRUD.Religion;
            dtBday.Value = new DateTime(Convert.ToInt32(TeachCRUD.year), 
            Convert.ToInt32(TeachCRUD.month), Convert.ToInt32(TeachCRUD.day));
            txtConNum.Text = TeachCRUD.ConNum;
            cmbDegree.Text = TeachCRUD.Deg;
            cmbCS.Text = TeachCRUD.CS;
            cmbEmpType.Text = TeachCRUD.EmpType;
            cmbDept.Text = TeachCRUD.Department;

            
            txtTeacherID.Enabled = false;
            btnAdd.Text = "UPDATE";
        }
        

        private void btnMini_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit? Any unsaved data will be lost.", "Confirm", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Clear();
                FrmTeachList frmTeachList = new FrmTeachList();
                frmTeachList.Show();

                this.Close();
            }
            //Clear();
            //FrmTeachList frmTeachList = new FrmTeachList();
            //frmTeachList.Show();

            //this.Close();
        }
        public void Clear() 
        {
            TeachCRUD.Mon = 0;
            TeachCRUD.MonIn = 0;
            TeachCRUD.MonOut = 0;
            TeachCRUD.Tue = 0;
            TeachCRUD.TueIn = 0;
            TeachCRUD.TueOut = 0;
            TeachCRUD.Wed = 0;
            TeachCRUD.WedIn = 0;
            TeachCRUD.WedOut = 0;
            TeachCRUD.Thu = 0;
            TeachCRUD.ThuIn = 0;
            TeachCRUD.ThuOut = 0;
            TeachCRUD.Fri = 0;
            TeachCRUD.FriIn = 0;
            TeachCRUD.FriOut = 0;
            TeachCRUD.Sat = 0;
            TeachCRUD.SatIn = 0;
            TeachCRUD.SatOut = 0;
            MessageBox.Show("Cleared");
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTeacherID.Text.Trim().Equals("") || txtFName.Text.Trim().Equals("")
                     || txtMName.Text.Trim().Equals("") || txtLName.Text.Trim().Equals("")
                     || txtReligion.Text.Trim().Equals("") 
                     || dtBday.Value.Equals(DateTime.Now) || txtConNum.Text.Trim().Equals("")
                     || cmbDegree.Text.Trim().Equals("") || cmbCS.Text.Trim().Equals("")
                     || cmbEmpType.Text.Trim().Equals("") || cmbDept.Text.Trim().Equals("") 
                     || (!rbtnMale.Checked && !rbtnFemale.Checked))
                {
                    MessageBox.Show("Please fill up all the fields. "
                        , "Field cannot be empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (txtConNum.Text.Length != txtConNum.MaxLength)
                {
                    MessageBox.Show("Please complete the contact # field. "
                        , "Input incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    TeachCRUD.TeacherID = txtTeacherID.Text.Trim();
                    TeachCRUD.FName = txtFName.Text.Trim();
                    TeachCRUD.MName = txtMName.Text.Trim();
                    TeachCRUD.LName = txtLName.Text.Trim();
                    TeachCRUD.Religion = txtReligion.Text.Trim();
                    TeachCRUD.Bday = dtBday.Value.ToString("yyyy-MM-dd");
                    TeachCRUD.ConNum = txtConNum.Text.Trim();
                    TeachCRUD.Deg = cmbDegree.Text.Trim();
                    TeachCRUD.CS = cmbCS.Text.Trim();
                    TeachCRUD.EmpType = cmbEmpType.Text.Trim();
                    TeachCRUD.Department = cmbDept.Text.Trim();

                    if (btnAdd.Text.Equals("ADD"))
                    {
                            TeachCRUD.Create();
                            TeachCRUD.PT();
                            TeachCRUD.FT();

                            MessageBox.Show("Teacher successfully added. "
                          , "Successfully added.", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            ClearValues();
                            Clear();
                        


                    }
                    else if (btnAdd.Text.Equals("UPDATE"))
                    {
                            TeachCRUD.Update();

                        if (cmbEmpType.Text.Trim().Equals("Part-Time"))
                        {
                            TeachCRUD.UpdatePT();

                        }

                        
                        MessageBox.Show("Teacher updated successfully. "
                      , "Updated Successfully.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnAdd.Text = "ADD";

                        ClearValues();
                        Clear();

                    }

                }
            }
            catch (Exception ex) { }
            //finally 
            //{ 
            //    FrmTeachList frmTeachList = new FrmTeachList();
            //    frmTeachList.Show();
            //    this.Close(); 
            //}
        }

       
        public void ClearValues() 
        {
            txtFName.Text = "";
            txtLName.Text = "";
            txtMName.Text = "";
            txtTeacherID.Text = "";
            txtReligion.Text = "";
            txtConNum.Text = "";
            rbtnMale.Checked = false;
            rbtnFemale.Checked = false;
            cmbDegree.SelectedIndex = 0;
            cmbEmpType.SelectedIndex = 0;
            cmbCS.SelectedIndex = 0;
            dtBday.Value = DateTime.Now;
  
        }


        private void txtTeacherID_KeyUp(object sender, KeyEventArgs e)
        {
            try 
            {
                String txt = txtTeacherID.Text;
                if (txt.Contains("'"))
                {
                    int loc = txt.LastIndexOf("'");

                    String apos = "'";

                    String temp = txt.Insert(loc, apos);

                    txt = temp;
                }
                TeachCRUD.CheckIDifExist(txt);
            
            } catch (Exception ex) { MessageBox.Show(ex + "");}
        }

        private void cmbEmpType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try 
            {
                if (cmbEmpType.SelectedIndex.Equals(1))
                {
                    btnPT.Enabled = true;
                    btnPT.Visible = true;
                }
                else 
                {
                    btnPT.Enabled = false;
                    btnPT.Visible = false;
                }
            } catch (Exception ex) { MessageBox.Show(ex + ""); }
        }

        private void btnPT_Click(object sender, EventArgs e)
        {
            try
            {
                
                    FrmPT pt = new FrmPT();

                    pt.ShowDialog();

                
            }
            catch (Exception ex) { MessageBox.Show(ex + ""); }
        }

        private void txtConNum_KeyUp(object sender, KeyEventArgs e)
        {
            // Allow only digits and the backspace key
            if (!char.IsControl(((char)e.KeyCode)) && !char.IsDigit(((char)e.KeyCode)))
            {
                MessageBox.Show("Please input number only in this text field.", "Error!",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConNum.Text = "";
                e.Handled = true;
            }
        }

        private void rbtnMale_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnMale.Checked)
            {
                TeachCRUD.Sex = "Male";
            }
            else
            {
                TeachCRUD.Sex = "Female";
            }
        }

        private void rbtnFemale_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
