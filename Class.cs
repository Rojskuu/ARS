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
    public partial class FrmClass : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        SqlCommand cmd;
        SqlConnection con;
        String server = ConnectionString.ConString;
        SqlDataAdapter adapter;
        DataSet ds;
        DataTable dt;
        SqlDataReader reader;
        LogHisCRUD log = new LogHisCRUD();
        String query;

        FrmDash dash;
        ClassCRUD ClassCRUD;
        bool Exist = false;
        public FrmClass()
        {
            InitializeComponent();
            con = new SqlConnection(server);
            ClassCRUD = new ClassCRUD();
        }

        public FrmClass(String ID) 
        {
            InitializeComponent();
            con = new SqlConnection(server);
            ClassCRUD = new ClassCRUD();

            ClassCRUD.ClassID = ID;
            ClassCRUD.Retrieve();
            btnADD.Text = "UPDATE";
            PoptxtSec();
            PoptxtSub();
            PoptxtTeach();
        }


        private void frmClass_Load(object sender, EventArgs e)
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
                FrmClassList frmClass = new FrmClassList();
                
                
                this.Close();
            }
            //FrmClassList frmClass = new FrmClassList();
            //frmClass.Show();
            //this.Close();
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            try
            {
                string mess = "This is Class";
                FrmTeachList TL = new FrmTeachList(mess);
                TL.ShowDialog();
                PoptxtTeach();
            }
            catch (Exception ex) { }
        }
        public void PoptxtTeach()
        {
            txtTeacherID.Text = ClassCRUD.TeacherID.Substring(0, ClassCRUD.TeacherID.IndexOf('-'));
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            try
            {
                string mess = "This is Class";
                FrmSectionList SC = new FrmSectionList(mess);
                SC.ShowDialog();
                PoptxtSec();
            }
            catch (Exception ex) { }
        }

        public void PoptxtSec() 
        {
            txtSectionID.Text = ClassCRUD.SectionID.Substring(0,ClassCRUD.SectionID.IndexOf('-')); 


        
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {

        }

        
        public void Clear() 
        {
            txtTeacherID.Text = "";
            txtSectionID.Text = "";
            txtSubCode.Text = "";

            btnADD.Text = "ADD";
        
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSubCode.Text.Trim().Equals("")
                    || txtSectionID.Text.Trim().Equals("") || txtTeacherID.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Please fill up all the fields. "
                        , "Field cannot be empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    ClassCRUD.TeacherID = txtTeacherID.Text.Trim();
                    ClassCRUD.SectionID = txtSectionID.Text.Trim();
                    ClassCRUD.SubjectCode = txtSubCode.Text.Trim();
                    CheckExist();

                    if (btnADD.Text.Equals("ADD"))
                    {

                        if (Exist == false)
                        {
                            ClassCRUD.Create();
                            LogHisCRUD.Activity = "Added Class " + ClassCRUD.ClassID + ".";
                            log.Create();
                            Clear();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("This combination is already existing "
                        , "Already Exist", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }
                    else if (btnADD.Text.Equals("UPDATE"))
                    {

                        ClassCRUD.Update();
                        LogHisCRUD.Activity = "Updated Class " + ClassCRUD.ClassID + ".";
                        log.Create();
                        btnADD.Text = "ADD";
                        Clear();
                        this.Close();
                    }

                }
            }
            catch (Exception ex) { }
            finally 
            {
                FrmClassList frmClass = new FrmClassList();
                frmClass.Show();
                this.Close();
            }
        


        }

        public void CheckExist() 
        {
            con.Open();

            query = "SELECT * FROM CLASS WHERE SubCode = '" + txtSubCode.Text.Trim() +
                "' AND SectionID = '" + txtSectionID.Text.Trim() + "'";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@SubCode", txtSubCode.Text);
            cmd.Parameters.AddWithValue("@SectionID", txtSectionID.Text);
            dt = new DataTable();

            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                con.Close();

                Exist = true;
            }
            else 
            {
                con.Close();

                Exist = false;
            }


        }

        private void btnSubCode_Click(object sender, EventArgs e)
        {
            try
            {
                string mess = "This is Class";
                FrmSubjectList SC = new FrmSubjectList(mess);
                SC.ShowDialog();

                PoptxtSub();
            }
            catch (Exception ex)
            {
            }
        }

        public void PoptxtSub() 
        {
            txtSubCode.Text = ClassCRUD.SubjectCode;
        }
        public void PoptxtAll() 
        {
            txtSectionID.Text = ClassCRUD.SectionID;
            txtSubCode.Text = ClassCRUD.SubjectCode;
            txtTeacherID.Text = ClassCRUD.TeacherID;

            btnADD.Text = "UPDATE";
        
        }
        private void btnClass_Click(object sender, EventArgs e)
        {
            
        }
    }
}
