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
    public partial class FrmTeach : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        
        FrmDash dash;

        TeachCRUD TeachCRUD;
       
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
            dtBday.MaxDate = DateTime.Now;
        }

        public void Poptxt() 
        {
            txtTeacherID.Text = TeachCRUD.TeacherID;
            txtFName.Text = TeachCRUD.FName;
            txtMName.Text = TeachCRUD.MName;
            txtLName.Text = TeachCRUD.LName;
            cmbSex.Text = TeachCRUD.Sex;
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
            Clear();
            FrmTeachList frmTeachList = new FrmTeachList();
            frmTeachList.Show();

            this.Close();
        }
        public void Clear() 
        {
            TeachCRUD.Mon = 0;
            TeachCRUD.MonIn = "";
            TeachCRUD.MonOut = "";
            TeachCRUD.Tue = 0;
            TeachCRUD.TueIn = "";
            TeachCRUD.TueOut = "";
            TeachCRUD.Wed = 0;
            TeachCRUD.WedIn = "";
            TeachCRUD.WedOut = "";
            TeachCRUD.Thu = 0;
            TeachCRUD.ThuIn = "";
            TeachCRUD.ThuOut = "";
            TeachCRUD.Fri = 0;
            TeachCRUD.FriIn = "";
            TeachCRUD.FriOut = "";
            TeachCRUD.Sat = 0;
            TeachCRUD.SatIn = "";
            TeachCRUD.SatOut = "";
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
                     || cmbSex.Text.Trim().Equals("") || txtReligion.Text.Trim().Equals("")
                     || dtBday.Value.Equals(DateTime.Now) || txtConNum.Text.Trim().Equals("")
                     || cmbDegree.Text.Trim().Equals("") || cmbCS.Text.Trim().Equals("")
                     || cmbEmpType.Text.Trim().Equals("") || cmbDept.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Please fill up all the fields. "
                        , "Field cannot be empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    TeachCRUD.TeacherID = txtTeacherID.Text.Trim();
                    TeachCRUD.FName = txtFName.Text.Trim();
                    TeachCRUD.MName = txtMName.Text.Trim();
                    TeachCRUD.LName = txtLName.Text.Trim();
                    TeachCRUD.Sex = cmbSex.Text.Trim();
                    TeachCRUD.Religion = txtReligion.Text.Trim();
                    TeachCRUD.Bday = dtBday.Value.ToString("yyyy-MM-dd");
                    TeachCRUD.ConNum = txtConNum.Text.Trim();
                    TeachCRUD.Deg = cmbDegree.Text.Trim();
                    TeachCRUD.CS = cmbCS.Text.Trim();
                    TeachCRUD.EmpType = cmbEmpType.Text.Trim();
                    TeachCRUD.Department = cmbDept.Text.Trim();

                    if (btnAdd.Text.Equals("ADD"))
                    {


                        if (cmbEmpType.Text.Trim().Equals("Part-Time"))
                        {
                            TeachCRUD.Create();
                            TeachCRUD.PT();

                            MessageBox.Show("Part-Time Teacher successfully added. "
                          , "Successfully added.", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            ClearValues();
                            Clear();
                        }
                        else
                        {
                            TeachCRUD.Create();
                            TeachCRUD.FT();

                            MessageBox.Show("Full-Time Teacher successfully added. "
                          , "Successfully added.", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            ClearValues();
                            Clear();
                        }


                    }
                    else if (btnAdd.Text.Equals("UPDATE"))
                    {

                        TeachCRUD.Update();
                        TeachCRUD.UpdatePT();
                        
                        MessageBox.Show("Teacher updated successfully. "
                      , "Updated Successfully.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnAdd.Text = "ADD";

                        //ClearValues();
                        Clear();

                    }

                }
            }
            catch (Exception ex) { }
            finally 
            { 
                FrmTeachList frmTeachList = new FrmTeachList();
                frmTeachList.Show();
                this.Close(); 
            }
        }

        public void ClearValues() 
        {
            txtFName.Text = "";
            txtLName.Text = "";
            txtMName.Text = "";
            txtTeacherID.Text = "";
            txtReligion.Text = "";
            txtConNum.Text = "";
            cmbDegree.SelectedIndex = 0;
            cmbSex.SelectedIndex = 0;
            cmbEmpType.SelectedIndex = 0;
            cmbCS.SelectedIndex = 0;
            dtBday.Value = DateTime.Now;
  
        }


        private void cmbEmpType_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbEmpType.Text.Trim().Equals("Part-Time"))
                {
                    FrmPT pt = new FrmPT();


                    pt.ShowDialog();

                }
            }
            catch (Exception ex) { MessageBox.Show(ex + ""); }
        }
    }
}
