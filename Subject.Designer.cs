namespace AutomatedRoomScheduling
{
    partial class FrmSubject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSubject));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMini = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbDept = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numMin = new System.Windows.Forms.NumericUpDown();
            this.numHrs = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbClassType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSubUnit = new System.Windows.Forms.ComboBox();
            this.txtSubDesc = new System.Windows.Forms.TextBox();
            this.txtSubCode = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHrs)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnMini);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 40);
            this.panel1.TabIndex = 2;
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
            this.btnMini.Location = new System.Drawing.Point(496, 7);
            this.btnMini.Name = "btnMini";
            this.btnMini.Size = new System.Drawing.Size(32, 26);
            this.btnMini.TabIndex = 4;
            this.btnMini.UseVisualStyleBackColor = false;
            this.btnMini.Click += new System.EventHandler(this.btnMini_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Location = new System.Drawing.Point(534, 7);
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
            this.label6.Size = new System.Drawing.Size(105, 26);
            this.label6.TabIndex = 3;
            this.label6.Text = "SUBJECT";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(247, 346);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.cmbDept);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.numMin);
            this.groupBox1.Controls.Add(this.numHrs);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmbClassType);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbSubUnit);
            this.groupBox1.Controls.Add(this.txtSubDesc);
            this.groupBox1.Controls.Add(this.txtSubCode);
            this.groupBox1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(37, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(492, 267);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Subject Information";
            // 
            // cmbDept
            // 
            this.cmbDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDept.FormattingEnabled = true;
            this.cmbDept.Items.AddRange(new object[] {
            "",
            "GENERAL",
            "BSIT",
            "BSHM",
            "BSTM",
            "BSCPE",
            "BMMA",
            "BACOMM"});
            this.cmbDept.Location = new System.Drawing.Point(217, 105);
            this.cmbDept.Name = "cmbDept";
            this.cmbDept.Size = new System.Drawing.Size(262, 28);
            this.cmbDept.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(40, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "Department:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(429, 215);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Min";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(296, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Hrs";
            // 
            // numMin
            // 
            this.numMin.Increment = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numMin.Location = new System.Drawing.Point(351, 208);
            this.numMin.Maximum = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.numMin.Name = "numMin";
            this.numMin.ReadOnly = true;
            this.numMin.Size = new System.Drawing.Size(72, 27);
            this.numMin.TabIndex = 13;
            // 
            // numHrs
            // 
            this.numHrs.Location = new System.Drawing.Point(218, 208);
            this.numHrs.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numHrs.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numHrs.Name = "numHrs";
            this.numHrs.ReadOnly = true;
            this.numHrs.Size = new System.Drawing.Size(72, 27);
            this.numHrs.TabIndex = 12;
            this.numHrs.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Class Type:";
            // 
            // cmbClassType
            // 
            this.cmbClassType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClassType.FormattingEnabled = true;
            this.cmbClassType.Items.AddRange(new object[] {
            "",
            "Lecture Room",
            "Computer Laboratory",
            "Kitchen Laboratory"});
            this.cmbClassType.Location = new System.Drawing.Point(217, 139);
            this.cmbClassType.Name = "cmbClassType";
            this.cmbClassType.Size = new System.Drawing.Size(262, 28);
            this.cmbClassType.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Hours needed:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Subject Unit:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Subject Description:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Subject Code:";
            // 
            // cmbSubUnit
            // 
            this.cmbSubUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubUnit.FormattingEnabled = true;
            this.cmbSubUnit.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbSubUnit.Location = new System.Drawing.Point(217, 173);
            this.cmbSubUnit.Name = "cmbSubUnit";
            this.cmbSubUnit.Size = new System.Drawing.Size(262, 28);
            this.cmbSubUnit.TabIndex = 3;
            // 
            // txtSubDesc
            // 
            this.txtSubDesc.Location = new System.Drawing.Point(216, 72);
            this.txtSubDesc.Name = "txtSubDesc";
            this.txtSubDesc.Size = new System.Drawing.Size(262, 27);
            this.txtSubDesc.TabIndex = 1;
            // 
            // txtSubCode
            // 
            this.txtSubCode.Location = new System.Drawing.Point(216, 39);
            this.txtSubCode.Name = "txtSubCode";
            this.txtSubCode.Size = new System.Drawing.Size(262, 27);
            this.txtSubCode.TabIndex = 0;
            this.txtSubCode.TextChanged += new System.EventHandler(this.txtSubCode_TextChanged);
            this.txtSubCode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSubCode_KeyUp);
            // 
            // FrmSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(570, 382);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSubject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmSubject_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHrs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnMini;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSubUnit;
        private System.Windows.Forms.TextBox txtSubDesc;
        private System.Windows.Forms.TextBox txtSubCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbClassType;
        private System.Windows.Forms.NumericUpDown numMin;
        private System.Windows.Forms.NumericUpDown numHrs;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbDept;
        private System.Windows.Forms.Label label10;
    }
}