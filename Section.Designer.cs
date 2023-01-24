namespace AutomatedRoomScheduling
{
    partial class FrmSection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSection));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMini = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbYrlvl = new System.Windows.Forms.ComboBox();
            this.cmbCourse = new System.Windows.Forms.ComboBox();
            this.txtSectionCnt = new System.Windows.Forms.TextBox();
            this.txtSectionID = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnMini);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 40);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(803, 412);
            this.panel2.TabIndex = 2;
            // 
            // btnMini
            // 
            this.btnMini.BackColor = System.Drawing.Color.White;
            this.btnMini.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMini.BackgroundImage")));
            this.btnMini.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMini.Location = new System.Drawing.Point(416, 7);
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
            this.btnExit.Location = new System.Drawing.Point(450, 7);
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
            this.label6.Size = new System.Drawing.Size(111, 26);
            this.label6.TabIndex = 3;
            this.label6.Text = "SECTION";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbYrlvl);
            this.groupBox1.Controls.Add(this.cmbCourse);
            this.groupBox1.Controls.Add(this.txtSectionCnt);
            this.groupBox1.Controls.Add(this.txtSectionID);
            this.groupBox1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(6, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 201);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Section Information";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Year level:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Course:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Student Count:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Section ID:";
            // 
            // cmbYrlvl
            // 
            this.cmbYrlvl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYrlvl.FormattingEnabled = true;
            this.cmbYrlvl.Items.AddRange(new object[] {
            "",
            "Grade 11",
            "Grade 12",
            "Freshmen",
            "Sophomore",
            "Junior",
            "Senior"});
            this.cmbYrlvl.Location = new System.Drawing.Point(168, 79);
            this.cmbYrlvl.Name = "cmbYrlvl";
            this.cmbYrlvl.Size = new System.Drawing.Size(291, 28);
            this.cmbYrlvl.TabIndex = 3;
            // 
            // cmbCourse
            // 
            this.cmbCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCourse.FormattingEnabled = true;
            this.cmbCourse.Items.AddRange(new object[] {
            "",
            "BS in Information Technology (BSIT)",
            "BS in Hospitality Management (BSHM)",
            "BS in Tourism Management (BSTM)",
            "BS in Computer Engineering (BSCpE)",
            "Bachelor of Multimedia Arts (BMMA)",
            "BA in Communication (BACOMM)"});
            this.cmbCourse.Location = new System.Drawing.Point(168, 45);
            this.cmbCourse.Name = "cmbCourse";
            this.cmbCourse.Size = new System.Drawing.Size(291, 28);
            this.cmbCourse.TabIndex = 2;
            // 
            // txtSectionCnt
            // 
            this.txtSectionCnt.Location = new System.Drawing.Point(168, 146);
            this.txtSectionCnt.Name = "txtSectionCnt";
            this.txtSectionCnt.Size = new System.Drawing.Size(291, 27);
            this.txtSectionCnt.TabIndex = 1;
            // 
            // txtSectionID
            // 
            this.txtSectionID.Location = new System.Drawing.Point(168, 113);
            this.txtSectionID.Name = "txtSectionID";
            this.txtSectionID.Size = new System.Drawing.Size(291, 27);
            this.txtSectionID.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(197, 314);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(124, 24);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FrmSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(483, 435);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmSection_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMini;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbYrlvl;
        private System.Windows.Forms.ComboBox cmbCourse;
        private System.Windows.Forms.TextBox txtSectionCnt;
        private System.Windows.Forms.TextBox txtSectionID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
    }
}