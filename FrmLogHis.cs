using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomatedRoomScheduling
{
    public partial class FrmLogHis : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        String server = ConnectionString.ConString;
        SqlDataAdapter adapter;
        DataSet ds;
        DataTable dt;
        SqlDataReader reader;
        String query;
        LogHisCRUD log = new LogHisCRUD();

        public FrmLogHis()
        {
            InitializeComponent();
            con = new SqlConnection(server);
        }

        private void FrmLogHis_Load(object sender, EventArgs e)
        {
            PopdtgLogHis();
        }

        public void PopdtgLogHis() 
        {
            try
            {
                con.Open();

                query = "Select Username AS 'ADMIN', Activity , FORMAT(actTime, 'yyyy-MM-dd HH:mm:ss' ) AS 'Date & Time' from LogHistory ORDER BY actTime";

                adapter = new SqlDataAdapter(query, con);
                ds = new DataSet();
                ds.Clear();
                adapter.Fill(ds);
                dtgLogHis.DataSource = ds.Tables[0];

                con.Close();



            }
            catch (Exception e) { MessageBox.Show(e + ""); }
            finally { con.Close(); }



        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Confirm", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LogHisCRUD.Activity = "Closed Log History" + ".";
                log.Create();
                WindowChecker.IsRunning = false;
                this.Close();
            }
        }
    }
}
