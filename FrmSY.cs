using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomatedRoomScheduling
{
    public partial class FrmSY : Form
    {
        SYCRUD SY = new SYCRUD();
        FrmDash dash = new FrmDash();
        LogHisCRUD log =  new LogHisCRUD();

        public FrmSY()
        {
            InitializeComponent();
        }

        private void UDBeginYear_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                UDEndYear.Value = UDBeginYear.Value + 1;

            }
            catch (Exception ex) { MessageBox.Show(ex + ""); }
        }

      

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                SYCRUD.SYSem = UDBeginYear.Value + "-" + UDEndYear.Value + " " + cmbSem.Text;
                SYCRUD.SY = UDBeginYear.Value + "-" + UDEndYear.Value;
                SYCRUD.Sem = cmbSem.Text;

                SY.Create();
                LogHisCRUD.Activity =   " Added new SY / Sem. ";
                log.Create();
                dash.PopSY();

            }
            catch (Exception ex) { MessageBox.Show(ex + ""); }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit? Any unsaved data will be lost.", "Confirm", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning) == DialogResult.OK)
            {
                LogHisCRUD.Activity = " Closed SY / Sem form. ";
                log.Create();
                this.Close();
            }
            //this.Close();
        }
    }
}
