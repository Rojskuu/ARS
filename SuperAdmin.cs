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
    public partial class FrmSuperAdmin : Form
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
        String server = ConnectionString.ConString;
        DataTable dt;
        SqlCommand cmd;
        String query;
        FrmLogin Login;

        public FrmSuperAdmin()
        {
            InitializeComponent();
            con = new SqlConnection(server);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try 
            {
                if (txtUsername.Text.Trim().Equals("") || cmbStatus.SelectedIndex.Equals(0))
                {
                    MessageBox.Show("Please fill up all the fields. "
                                 , "Field cannot be empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else 
                {
                    CheckAdmin();
                }
            } 
            catch (Exception ex) { MessageBox.Show(ex + ""); }
        }

        public void CheckAdmin() 
        {
            try 
            {
                
                con.Open();

                query = "SELECT * FROM ADMIN WHERE Username = '" + txtUsername.Text.Trim() + "'";
                    
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                dt = new DataTable();
                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                con.Close();

                if (dt.Rows.Count == 1)
                {
                    UpdateAdmin();
                }
                else
                {
                    MessageBox.Show("User does not exist. ", "Invalid!",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            } catch (Exception ex) { MessageBox.Show(ex + ""); }
        }

        public void UpdateAdmin()
        {
            try 
            {
                int temp;
                if (cmbStatus.SelectedIndex.Equals(1))
                {
                    temp = 0;
                }
                else 
                {
                    temp = 1;
                }
                con = new SqlConnection(server);
                con.Open();

                query = "update Admin set " +
                         "BlockAcc = " + temp +
                         " Where Username = '" 
                         + txtUsername.Text.Trim() + "'";
                      

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();

                cmd.Dispose();
                con.Close();

                MessageBox.Show("Account status updated.", "Account status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
            catch (Exception ex) { MessageBox.Show(ex + ""); }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Confirm", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Login = new FrmLogin();
                this.Hide();
                Login.Show();
            }
            //Login = new FrmLogin();
            //this.Hide();
            //Login.Show();
        }
    }
}
