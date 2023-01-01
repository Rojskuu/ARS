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
    public partial class FrmLogin : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        FrmDash dash;
        int attempt = 3;

        SqlConnection con;
        SqlDataReader reader;
        SqlDataAdapter adapter;
        String server = @"Data Source=DESKTOP-3LSCP0F\SQLEXPRESS;Initial Catalog = ARS; Integrated Security = True";
        DataSet ds;
        DataTable dt;
        SqlCommand cmd;
        String query;

        public FrmLogin()
        {
            InitializeComponent();
            con = new SqlConnection(server);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            

        }

        private void txtUsername_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtUsername.Text.Equals("Username"))
            {
                txtUsername.Clear();
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtPassword.Text.Equals("Password"))
            {
                txtPassword.Clear();
                
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                
                
                if (txtUsername.Text.Trim().Equals("") || txtUsername.Text.Trim().Equals("Username"))
                {

                    MessageBox.Show("Please input your Username.", "Username field is Empty.",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtPassword.Text.Trim().Equals("") || txtPassword.Text.Trim().Equals("Password"))
                {

                    MessageBox.Show("Please input your Password.", "Password field is Empty.",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    con.Open();

                    query = "SELECT * FROM ADMIN WHERE Username = '" + txtUsername.Text.Trim() +
                        "' AND Pass = '" + txtPassword.Text.Trim() + "'";
                    cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@Pass", txtPassword.Text);
                    dt = new DataTable();

                    adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);

                    if (dt.Rows.Count == 1)
                    {
                        con.Close();
                        dash = new FrmDash();
                        AdminChecker.Admin = txtUsername.Text.Trim();
                        this.Hide();
                        dash.Show();

                    }
                    else
                    {
                        con.Close();
                        MessageBox.Show("Invalid username or password. \n" + " Attempts left "+ attempt, "Invalid!",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                       
                        
                        txtPassword.Text = "";
                        txtUsername.Text = "";

                        if (attempt == 0) 
                        { 
                            btnLogin.Enabled = false;
                            txtUsername.Enabled = false;
                            txtPassword.Enabled = false;
                            MessageBox.Show("You have exceeded the number of login attempts." +
                                "\nPlease try again later.", "Log in failed!",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        attempt--;
                    }



                }



            }
            catch (Exception) { }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmLogin login = new FrmLogin();
            login.Close();
        }
    }
}
