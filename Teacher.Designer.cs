namespace AutomatedRoomScheduling
{
    partial class FrmTeach
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTeach));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMini = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grpPInfo = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbEmpType = new System.Windows.Forms.ComboBox();
            this.cmbCS = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbDegree = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtBday = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConNum = new System.Windows.Forms.TextBox();
            this.txtReligion = new System.Windows.Forms.TextBox();
            this.txtTeacherID = new System.Windows.Forms.TextBox();
            this.cmbSex = new System.Windows.Forms.ComboBox();
            this.txtMName = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbDept = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.grpPInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Controls.Add(this.btnMini);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(662, 40);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btnMini
            // 
            this.btnMini.BackColor = System.Drawing.Color.White;
            this.btnMini.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMini.BackgroundImage")));
            this.btnMini.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMini.Location = new System.Drawing.Point(588, 7);
            this.btnMini.Name = "btnMini";
            this.btnMini.Size = new System.Drawing.Size(28, 26);
            this.btnMini.TabIndex = 4;
            this.btnMini.UseVisualStyleBackColor = false;
            this.btnMini.Click += new System.EventHandler(this.btnMini_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Location = new System.Drawing.Point(622, 7);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(28, 26);
            this.btnExit.TabIndex = 3;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(3, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 26);
            this.label6.TabIndex = 3;
            this.label6.Text = "TEACHER";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(275, 536);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(116, 29);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grpPInfo
            // 
            this.grpPInfo.BackColor = System.Drawing.Color.White;
            this.grpPInfo.Controls.Add(this.label13);
            this.grpPInfo.Controls.Add(this.cmbDept);
            this.grpPInfo.Controls.Add(this.label12);
            this.grpPInfo.Controls.Add(this.cmbEmpType);
            this.grpPInfo.Controls.Add(this.cmbCS);
            this.grpPInfo.Controls.Add(this.label11);
            this.grpPInfo.Controls.Add(this.cmbDegree);
            this.grpPInfo.Controls.Add(this.label10);
            this.grpPInfo.Controls.Add(this.dtBday);
            this.grpPInfo.Controls.Add(this.label9);
            this.grpPInfo.Controls.Add(this.label8);
            this.grpPInfo.Controls.Add(this.label7);
            this.grpPInfo.Controls.Add(this.label5);
            this.grpPInfo.Controls.Add(this.label4);
            this.grpPInfo.Controls.Add(this.label3);
            this.grpPInfo.Controls.Add(this.label2);
            this.grpPInfo.Controls.Add(this.label1);
            this.grpPInfo.Controls.Add(this.txtConNum);
            this.grpPInfo.Controls.Add(this.txtReligion);
            this.grpPInfo.Controls.Add(this.txtTeacherID);
            this.grpPInfo.Controls.Add(this.cmbSex);
            this.grpPInfo.Controls.Add(this.txtMName);
            this.grpPInfo.Controls.Add(this.txtFName);
            this.grpPInfo.Controls.Add(this.txtLName);
            this.grpPInfo.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPInfo.Location = new System.Drawing.Point(21, 70);
            this.grpPInfo.Name = "grpPInfo";
            this.grpPInfo.Size = new System.Drawing.Size(618, 450);
            this.grpPInfo.TabIndex = 8;
            this.grpPInfo.TabStop = false;
            this.grpPInfo.Text = "PERSONAL INFORMATION";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(105, 367);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(147, 20);
            this.label12.TabIndex = 21;
            this.label12.Text = "Employment Type:";
            // 
            // cmbEmpType
            // 
            this.cmbEmpType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpType.FormattingEnabled = true;
            this.cmbEmpType.Items.AddRange(new object[] {
            "",
            "Part-Time",
            "Full-Time"});
            this.cmbEmpType.Location = new System.Drawing.Point(295, 359);
            this.cmbEmpType.Name = "cmbEmpType";
            this.cmbEmpType.Size = new System.Drawing.Size(279, 28);
            this.cmbEmpType.TabIndex = 20;
            this.cmbEmpType.Click += new System.EventHandler(this.cmbEmpType_Click);
            // 
            // cmbCS
            // 
            this.cmbCS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCS.FormattingEnabled = true;
            this.cmbCS.Items.AddRange(new object[] {
            "",
            "Single",
            "Married",
            "Widowed",
            "Divorced",
            "Separated"});
            this.cmbCS.Location = new System.Drawing.Point(295, 325);
            this.cmbCS.Name = "cmbCS";
            this.cmbCS.Size = new System.Drawing.Size(279, 28);
            this.cmbCS.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(105, 333);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 20);
            this.label11.TabIndex = 18;
            this.label11.Text = "Civil Status:";
            // 
            // cmbDegree
            // 
            this.cmbDegree.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDegree.FormattingEnabled = true;
            this.cmbDegree.Items.AddRange(new object[] {
            "",
            "Bachelor",
            "Master",
            "Doctor"});
            this.cmbDegree.Location = new System.Drawing.Point(295, 291);
            this.cmbDegree.Name = "cmbDegree";
            this.cmbDegree.Size = new System.Drawing.Size(279, 28);
            this.cmbDegree.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(105, 299);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "Degree:";
            // 
            // dtBday
            // 
            this.dtBday.Location = new System.Drawing.Point(295, 227);
            this.dtBday.Name = "dtBday";
            this.dtBday.Size = new System.Drawing.Size(279, 27);
            this.dtBday.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(105, 265);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Contact Number:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(105, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Birthday: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(105, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Religion:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Sex:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Middle Initial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "First Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Teacher ID:";
            // 
            // txtConNum
            // 
            this.txtConNum.Location = new System.Drawing.Point(295, 260);
            this.txtConNum.Name = "txtConNum";
            this.txtConNum.Size = new System.Drawing.Size(279, 27);
            this.txtConNum.TabIndex = 6;
            // 
            // txtReligion
            // 
            this.txtReligion.Location = new System.Drawing.Point(295, 192);
            this.txtReligion.Name = "txtReligion";
            this.txtReligion.Size = new System.Drawing.Size(279, 27);
            this.txtReligion.TabIndex = 5;
            // 
            // txtTeacherID
            // 
            this.txtTeacherID.Location = new System.Drawing.Point(295, 26);
            this.txtTeacherID.Name = "txtTeacherID";
            this.txtTeacherID.Size = new System.Drawing.Size(279, 27);
            this.txtTeacherID.TabIndex = 0;
            // 
            // cmbSex
            // 
            this.cmbSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSex.Items.AddRange(new object[] {
            "",
            "Male",
            "Female"});
            this.cmbSex.Location = new System.Drawing.Point(295, 158);
            this.cmbSex.Name = "cmbSex";
            this.cmbSex.Size = new System.Drawing.Size(279, 28);
            this.cmbSex.TabIndex = 4;
            // 
            // txtMName
            // 
            this.txtMName.Location = new System.Drawing.Point(295, 92);
            this.txtMName.Name = "txtMName";
            this.txtMName.Size = new System.Drawing.Size(279, 27);
            this.txtMName.TabIndex = 2;
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(295, 59);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(279, 27);
            this.txtFName.TabIndex = 1;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(295, 125);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(279, 27);
            this.txtLName.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(105, 401);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 20);
            this.label13.TabIndex = 23;
            this.label13.Text = "Department:";
            // 
            // cmbDept
            // 
            this.cmbDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDept.FormattingEnabled = true;
            this.cmbDept.Items.AddRange(new object[] {
            "",
            "General",
            "BSIT",
            "BSHM",
            "BSCPE"});
            this.cmbDept.Location = new System.Drawing.Point(295, 393);
            this.cmbDept.Name = "cmbDept";
            this.cmbDept.Size = new System.Drawing.Size(279, 28);
            this.cmbDept.TabIndex = 22;
            // 
            // FrmTeach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(662, 591);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grpPInfo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmTeach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmTeach_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpPInfo.ResumeLayout(false);
            this.grpPInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMini;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox grpPInfo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbEmpType;
        private System.Windows.Forms.ComboBox cmbCS;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbDegree;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtBday;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConNum;
        private System.Windows.Forms.TextBox txtReligion;
        private System.Windows.Forms.TextBox txtTeacherID;
        private System.Windows.Forms.ComboBox cmbSex;
        private System.Windows.Forms.TextBox txtMName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbDept;
    }
}