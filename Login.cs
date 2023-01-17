﻿using System;
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
        FrmSuperAdmin superAdmin;
        int attempt = 1, Status;

        SqlConnection con;
        SqlDataReader reader;
        SqlDataAdapter adapter;
        String server = ConnectionString.ConString;
        DataSet ds;
        DataTable dt;
        SqlCommand cmd;
        String query, Role;



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
        public void GetRole() 
        {
            try 
            {
                con = new SqlConnection(server);
                con.Open();

                query = "select Role, BlockAcc " +
                     "FROM Admin where Username = '" + txtUsername.Text.Trim() + "'";

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                  Role = rdr.GetString(0);
                  Status = Convert.ToInt32(rdr.GetValue(1));
                }
                con.Close();
            } 
            catch (Exception ex) { MessageBox.Show(ex + ""); }
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
                        GetRole();

                        if (Status == 0)
                        {
                            if (Role.Equals("Admin"))
                            {

                                dash = new FrmDash();
                                AdminChecker.Admin = txtUsername.Text.Trim();
                                this.Hide();
                                dash.ShowDialog();
                                txtUsername.Text = "";
                                txtPassword.Text = "";
                                Show();
                            }
                            else
                            {
                                superAdmin = new FrmSuperAdmin();
                                this.Hide();
                                superAdmin.ShowDialog();
                                txtUsername.Text = "";
                                txtPassword.Text = "";
                                Show();
                            }
                        }
                        else 
                        {
                            MessageBox.Show("Your account has been blocked. \n" + "Please contact the super Admin.", "Account Blocked!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        con.Close();
                        MessageBox.Show("Invalid username or password. \n" + " Attempts left "+ attempt, "Invalid!",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                       
                        
                        

                        if (attempt == 0) 
                        { 
                            
                            MessageBox.Show("You have exceeded the number of login attempts." +
                                "\nPlease contact the Super Admin to activate your account.", "Log in failed!",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            BlockAcc();
                        }
                        attempt--;
                        txtPassword.Text = "";
                        txtUsername.Text = "";
                    }



                }



            }
            catch (Exception) { }
        }
        public void BlockAcc() 
        {
            try 
            {
                con = new SqlConnection(server);
                con.Open();

                query = "update Admin set " +
                         "BlockAcc = " + 1 +
                         " Where Username = '"
                         + txtUsername.Text.Trim() + "'";
                
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();

                cmd.Dispose();
                con.Close();

                txtUsername.Text = "";
                txtPassword.Text = "";
            } catch (Exception ex) 
            { MessageBox.Show(ex+""); }
        
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
            if (MessageBox.Show("Are you sure you want to exit?", "Confirm", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                FrmLogin login = new FrmLogin();
                login.Close();
            }
            //this.Close();
            //FrmLogin login = new FrmLogin();
            //login.Close();
        }
    }
}
