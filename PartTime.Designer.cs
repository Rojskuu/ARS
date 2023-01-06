namespace AutomatedRoomScheduling
{
    partial class FrmPT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPT));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMini = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbSatOut = new System.Windows.Forms.ComboBox();
            this.cmbSatIn = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbFriOut = new System.Windows.Forms.ComboBox();
            this.cmbFriIn = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbThuOut = new System.Windows.Forms.ComboBox();
            this.cmbThuIn = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbWedOut = new System.Windows.Forms.ComboBox();
            this.cmbWedIn = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbTueOut = new System.Windows.Forms.ComboBox();
            this.cmbTueIn = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbMonOut = new System.Windows.Forms.ComboBox();
            this.cmbMonIn = new System.Windows.Forms.ComboBox();
            this.cbSat = new System.Windows.Forms.CheckBox();
            this.cbFri = new System.Windows.Forms.CheckBox();
            this.cbThu = new System.Windows.Forms.CheckBox();
            this.cbWed = new System.Windows.Forms.CheckBox();
            this.cbTue = new System.Windows.Forms.CheckBox();
            this.cbMon = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Controls.Add(this.btnMini);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 40);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btnMini
            // 
            this.btnMini.BackColor = System.Drawing.Color.White;
            this.btnMini.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMini.BackgroundImage")));
            this.btnMini.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMini.Location = new System.Drawing.Point(408, 7);
            this.btnMini.Name = "btnMini";
            this.btnMini.Size = new System.Drawing.Size(28, 26);
            this.btnMini.TabIndex = 4;
            this.btnMini.UseVisualStyleBackColor = false;
            this.btnMini.Click += new System.EventHandler(this.btnMini_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(3, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 26);
            this.label6.TabIndex = 3;
            this.label6.Text = "PART - TIME";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.cmbSatOut);
            this.groupBox1.Controls.Add(this.cmbSatIn);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cmbFriOut);
            this.groupBox1.Controls.Add(this.cmbFriIn);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cmbThuOut);
            this.groupBox1.Controls.Add(this.cmbThuIn);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cmbWedOut);
            this.groupBox1.Controls.Add(this.cmbWedIn);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cmbTueOut);
            this.groupBox1.Controls.Add(this.cmbTueIn);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cmbMonOut);
            this.groupBox1.Controls.Add(this.cmbMonIn);
            this.groupBox1.Controls.Add(this.cbSat);
            this.groupBox1.Controls.Add(this.cbFri);
            this.groupBox1.Controls.Add(this.cbThu);
            this.groupBox1.Controls.Add(this.cbWed);
            this.groupBox1.Controls.Add(this.cbTue);
            this.groupBox1.Controls.Add(this.cbMon);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 282);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Days of Work";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(334, 23);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 21);
            this.label15.TabIndex = 31;
            this.label15.Text = "OUT";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(206, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 21);
            this.label14.TabIndex = 30;
            this.label14.Text = "IN";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(275, 221);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(24, 21);
            this.label13.TabIndex = 29;
            this.label13.Text = "to";
            // 
            // cmbSatOut
            // 
            this.cmbSatOut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSatOut.Enabled = false;
            this.cmbSatOut.FormattingEnabled = true;
            this.cmbSatOut.Items.AddRange(new object[] {
            "",
            "7:00",
            "7:15",
            "7:30",
            "8:00",
            "8:15",
            "8:30",
            "9:00",
            "9:15",
            "9:30",
            "10:00",
            "10:15",
            "10:30",
            "11:00",
            "11:15",
            "11:30",
            "12:00",
            "12:15",
            "12:30",
            "13:00",
            "13:15",
            "13:30",
            "14:00",
            "14:15",
            "14:30",
            "15:00",
            "15:15",
            "15:30",
            "16:00",
            "16:15",
            "16:30",
            "17:00",
            "17:15",
            "17:30",
            "18:00",
            "18:15",
            "18:30",
            "19:00"});
            this.cmbSatOut.Location = new System.Drawing.Point(316, 216);
            this.cmbSatOut.Name = "cmbSatOut";
            this.cmbSatOut.Size = new System.Drawing.Size(80, 29);
            this.cmbSatOut.TabIndex = 28;
            this.cmbSatOut.SelectedIndexChanged += new System.EventHandler(this.cmbSatOut_SelectedIndexChanged);
            // 
            // cmbSatIn
            // 
            this.cmbSatIn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSatIn.Enabled = false;
            this.cmbSatIn.FormattingEnabled = true;
            this.cmbSatIn.Items.AddRange(new object[] {
            "",
            "7:00",
            "7:15",
            "7:30",
            "8:00",
            "8:15",
            "8:30",
            "9:00",
            "9:15",
            "9:30",
            "10:00",
            "10:15",
            "10:30",
            "11:00",
            "11:15",
            "11:30",
            "12:00",
            "12:15",
            "12:30",
            "13:00",
            "13:15",
            "13:30",
            "14:00",
            "14:15",
            "14:30",
            "15:00",
            "15:15",
            "15:30",
            "16:00",
            "16:15",
            "16:30",
            "17:00",
            "17:15",
            "17:30",
            "18:00",
            "18:15",
            "18:30",
            "19:00"});
            this.cmbSatIn.Location = new System.Drawing.Point(176, 216);
            this.cmbSatIn.Name = "cmbSatIn";
            this.cmbSatIn.Size = new System.Drawing.Size(80, 29);
            this.cmbSatIn.TabIndex = 27;
            this.cmbSatIn.SelectedIndexChanged += new System.EventHandler(this.cmbSatIn_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(275, 187);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 21);
            this.label12.TabIndex = 26;
            this.label12.Text = "to";
            // 
            // cmbFriOut
            // 
            this.cmbFriOut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFriOut.Enabled = false;
            this.cmbFriOut.FormattingEnabled = true;
            this.cmbFriOut.Items.AddRange(new object[] {
            "",
            "7:00",
            "7:15",
            "7:30",
            "8:00",
            "8:15",
            "8:30",
            "9:00",
            "9:15",
            "9:30",
            "10:00",
            "10:15",
            "10:30",
            "11:00",
            "11:15",
            "11:30",
            "12:00",
            "12:15",
            "12:30",
            "13:00",
            "13:15",
            "13:30",
            "14:00",
            "14:15",
            "14:30",
            "15:00",
            "15:15",
            "15:30",
            "16:00",
            "16:15",
            "16:30",
            "17:00",
            "17:15",
            "17:30",
            "18:00",
            "18:15",
            "18:30",
            "19:00"});
            this.cmbFriOut.Location = new System.Drawing.Point(316, 182);
            this.cmbFriOut.Name = "cmbFriOut";
            this.cmbFriOut.Size = new System.Drawing.Size(80, 29);
            this.cmbFriOut.TabIndex = 25;
            this.cmbFriOut.SelectedIndexChanged += new System.EventHandler(this.cmbFriOut_SelectedIndexChanged);
            // 
            // cmbFriIn
            // 
            this.cmbFriIn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFriIn.Enabled = false;
            this.cmbFriIn.FormattingEnabled = true;
            this.cmbFriIn.Items.AddRange(new object[] {
            "",
            "7:00",
            "7:15",
            "7:30",
            "8:00",
            "8:15",
            "8:30",
            "9:00",
            "9:15",
            "9:30",
            "10:00",
            "10:15",
            "10:30",
            "11:00",
            "11:15",
            "11:30",
            "12:00",
            "12:15",
            "12:30",
            "13:00",
            "13:15",
            "13:30",
            "14:00",
            "14:15",
            "14:30",
            "15:00",
            "15:15",
            "15:30",
            "16:00",
            "16:15",
            "16:30",
            "17:00",
            "17:15",
            "17:30",
            "18:00",
            "18:15",
            "18:30",
            "19:00"});
            this.cmbFriIn.Location = new System.Drawing.Point(176, 182);
            this.cmbFriIn.Name = "cmbFriIn";
            this.cmbFriIn.Size = new System.Drawing.Size(80, 29);
            this.cmbFriIn.TabIndex = 24;
            this.cmbFriIn.SelectedIndexChanged += new System.EventHandler(this.cmbFriIn_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(275, 152);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 21);
            this.label11.TabIndex = 23;
            this.label11.Text = "to";
            // 
            // cmbThuOut
            // 
            this.cmbThuOut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbThuOut.Enabled = false;
            this.cmbThuOut.FormattingEnabled = true;
            this.cmbThuOut.Items.AddRange(new object[] {
            "",
            "7:00",
            "7:15",
            "7:30",
            "8:00",
            "8:15",
            "8:30",
            "9:00",
            "9:15",
            "9:30",
            "10:00",
            "10:15",
            "10:30",
            "11:00",
            "11:15",
            "11:30",
            "12:00",
            "12:15",
            "12:30",
            "13:00",
            "13:15",
            "13:30",
            "14:00",
            "14:15",
            "14:30",
            "15:00",
            "15:15",
            "15:30",
            "16:00",
            "16:15",
            "16:30",
            "17:00",
            "17:15",
            "17:30",
            "18:00",
            "18:15",
            "18:30",
            "19:00"});
            this.cmbThuOut.Location = new System.Drawing.Point(316, 147);
            this.cmbThuOut.Name = "cmbThuOut";
            this.cmbThuOut.Size = new System.Drawing.Size(80, 29);
            this.cmbThuOut.TabIndex = 22;
            this.cmbThuOut.SelectedIndexChanged += new System.EventHandler(this.cmbThuOut_SelectedIndexChanged);
            // 
            // cmbThuIn
            // 
            this.cmbThuIn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbThuIn.Enabled = false;
            this.cmbThuIn.FormattingEnabled = true;
            this.cmbThuIn.Items.AddRange(new object[] {
            "",
            "7:00",
            "7:15",
            "7:30",
            "8:00",
            "8:15",
            "8:30",
            "9:00",
            "9:15",
            "9:30",
            "10:00",
            "10:15",
            "10:30",
            "11:00",
            "11:15",
            "11:30",
            "12:00",
            "12:15",
            "12:30",
            "13:00",
            "13:15",
            "13:30",
            "14:00",
            "14:15",
            "14:30",
            "15:00",
            "15:15",
            "15:30",
            "16:00",
            "16:15",
            "16:30",
            "17:00",
            "17:15",
            "17:30",
            "18:00",
            "18:15",
            "18:30",
            "19:00"});
            this.cmbThuIn.Location = new System.Drawing.Point(176, 147);
            this.cmbThuIn.Name = "cmbThuIn";
            this.cmbThuIn.Size = new System.Drawing.Size(80, 29);
            this.cmbThuIn.TabIndex = 21;
            this.cmbThuIn.SelectedIndexChanged += new System.EventHandler(this.cmbThuIn_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(275, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 21);
            this.label10.TabIndex = 20;
            this.label10.Text = "to";
            // 
            // cmbWedOut
            // 
            this.cmbWedOut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWedOut.Enabled = false;
            this.cmbWedOut.FormattingEnabled = true;
            this.cmbWedOut.Items.AddRange(new object[] {
            "",
            "7:00",
            "7:15",
            "7:30",
            "8:00",
            "8:15",
            "8:30",
            "9:00",
            "9:15",
            "9:30",
            "10:00",
            "10:15",
            "10:30",
            "11:00",
            "11:15",
            "11:30",
            "12:00",
            "12:15",
            "12:30",
            "13:00",
            "13:15",
            "13:30",
            "14:00",
            "14:15",
            "14:30",
            "15:00",
            "15:15",
            "15:30",
            "16:00",
            "16:15",
            "16:30",
            "17:00",
            "17:15",
            "17:30",
            "18:00",
            "18:15",
            "18:30",
            "19:00"});
            this.cmbWedOut.Location = new System.Drawing.Point(316, 114);
            this.cmbWedOut.Name = "cmbWedOut";
            this.cmbWedOut.Size = new System.Drawing.Size(80, 29);
            this.cmbWedOut.TabIndex = 19;
            this.cmbWedOut.SelectedIndexChanged += new System.EventHandler(this.cmbWedOut_SelectedIndexChanged);
            // 
            // cmbWedIn
            // 
            this.cmbWedIn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWedIn.Enabled = false;
            this.cmbWedIn.FormattingEnabled = true;
            this.cmbWedIn.Items.AddRange(new object[] {
            "",
            "7:00",
            "7:15",
            "7:30",
            "8:00",
            "8:15",
            "8:30",
            "9:00",
            "9:15",
            "9:30",
            "10:00",
            "10:15",
            "10:30",
            "11:00",
            "11:15",
            "11:30",
            "12:00",
            "12:15",
            "12:30",
            "13:00",
            "13:15",
            "13:30",
            "14:00",
            "14:15",
            "14:30",
            "15:00",
            "15:15",
            "15:30",
            "16:00",
            "16:15",
            "16:30",
            "17:00",
            "17:15",
            "17:30",
            "18:00",
            "18:15",
            "18:30",
            "19:00"});
            this.cmbWedIn.Location = new System.Drawing.Point(176, 114);
            this.cmbWedIn.Name = "cmbWedIn";
            this.cmbWedIn.Size = new System.Drawing.Size(80, 29);
            this.cmbWedIn.TabIndex = 18;
            this.cmbWedIn.SelectedIndexChanged += new System.EventHandler(this.cmbWedIn_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(275, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 21);
            this.label9.TabIndex = 17;
            this.label9.Text = "to";
            // 
            // cmbTueOut
            // 
            this.cmbTueOut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTueOut.Enabled = false;
            this.cmbTueOut.FormattingEnabled = true;
            this.cmbTueOut.Items.AddRange(new object[] {
            "",
            "7:00",
            "7:15",
            "7:30",
            "8:00",
            "8:15",
            "8:30",
            "9:00",
            "9:15",
            "9:30",
            "10:00",
            "10:15",
            "10:30",
            "11:00",
            "11:15",
            "11:30",
            "12:00",
            "12:15",
            "12:30",
            "13:00",
            "13:15",
            "13:30",
            "14:00",
            "14:15",
            "14:30",
            "15:00",
            "15:15",
            "15:30",
            "16:00",
            "16:15",
            "16:30",
            "17:00",
            "17:15",
            "17:30",
            "18:00",
            "18:15",
            "18:30",
            "19:00"});
            this.cmbTueOut.Location = new System.Drawing.Point(316, 80);
            this.cmbTueOut.Name = "cmbTueOut";
            this.cmbTueOut.Size = new System.Drawing.Size(80, 29);
            this.cmbTueOut.TabIndex = 16;
            this.cmbTueOut.SelectedIndexChanged += new System.EventHandler(this.cmbTueOut_SelectedIndexChanged);
            // 
            // cmbTueIn
            // 
            this.cmbTueIn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTueIn.Enabled = false;
            this.cmbTueIn.FormattingEnabled = true;
            this.cmbTueIn.Items.AddRange(new object[] {
            "",
            "7:00",
            "7:15",
            "7:30",
            "8:00",
            "8:15",
            "8:30",
            "9:00",
            "9:15",
            "9:30",
            "10:00",
            "10:15",
            "10:30",
            "11:00",
            "11:15",
            "11:30",
            "12:00",
            "12:15",
            "12:30",
            "13:00",
            "13:15",
            "13:30",
            "14:00",
            "14:15",
            "14:30",
            "15:00",
            "15:15",
            "15:30",
            "16:00",
            "16:15",
            "16:30",
            "17:00",
            "17:15",
            "17:30",
            "18:00",
            "18:15",
            "18:30",
            "19:00"});
            this.cmbTueIn.Location = new System.Drawing.Point(176, 80);
            this.cmbTueIn.Name = "cmbTueIn";
            this.cmbTueIn.Size = new System.Drawing.Size(80, 29);
            this.cmbTueIn.TabIndex = 15;
            this.cmbTueIn.SelectedIndexChanged += new System.EventHandler(this.cmbTueIn_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(275, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 21);
            this.label8.TabIndex = 14;
            this.label8.Text = "to";
            // 
            // cmbMonOut
            // 
            this.cmbMonOut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonOut.Enabled = false;
            this.cmbMonOut.FormattingEnabled = true;
            this.cmbMonOut.Items.AddRange(new object[] {
            "",
            "7:00",
            "7:15",
            "7:30",
            "8:00",
            "8:15",
            "8:30",
            "9:00",
            "9:15",
            "9:30",
            "10:00",
            "10:15",
            "10:30",
            "11:00",
            "11:15",
            "11:30",
            "12:00",
            "12:15",
            "12:30",
            "13:00",
            "13:15",
            "13:30",
            "14:00",
            "14:15",
            "14:30",
            "15:00",
            "15:15",
            "15:30",
            "16:00",
            "16:15",
            "16:30",
            "17:00",
            "17:15",
            "17:30",
            "18:00",
            "18:15",
            "18:30",
            "19:00"});
            this.cmbMonOut.Location = new System.Drawing.Point(316, 47);
            this.cmbMonOut.Name = "cmbMonOut";
            this.cmbMonOut.Size = new System.Drawing.Size(80, 29);
            this.cmbMonOut.TabIndex = 13;
            this.cmbMonOut.SelectedIndexChanged += new System.EventHandler(this.cmbMonOut_SelectedIndexChanged);
            // 
            // cmbMonIn
            // 
            this.cmbMonIn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonIn.Enabled = false;
            this.cmbMonIn.FormattingEnabled = true;
            this.cmbMonIn.Items.AddRange(new object[] {
            "",
            "7:00",
            "7:15",
            "7:30",
            "8:00",
            "8:15",
            "8:30",
            "9:00",
            "9:15",
            "9:30",
            "10:00",
            "10:15",
            "10:30",
            "11:00",
            "11:15",
            "11:30",
            "12:00",
            "12:15",
            "12:30",
            "13:00",
            "13:15",
            "13:30",
            "14:00",
            "14:15",
            "14:30",
            "15:00",
            "15:15",
            "15:30",
            "16:00",
            "16:15",
            "16:30",
            "17:00",
            "17:15",
            "17:30",
            "18:00",
            "18:15",
            "18:30",
            "19:00"});
            this.cmbMonIn.Location = new System.Drawing.Point(176, 47);
            this.cmbMonIn.Name = "cmbMonIn";
            this.cmbMonIn.Size = new System.Drawing.Size(80, 29);
            this.cmbMonIn.TabIndex = 12;
            this.cmbMonIn.SelectedIndexChanged += new System.EventHandler(this.cmbMonIn_SelectedIndexChanged);
            // 
            // cbSat
            // 
            this.cbSat.AutoSize = true;
            this.cbSat.Location = new System.Drawing.Point(141, 223);
            this.cbSat.Name = "cbSat";
            this.cbSat.Size = new System.Drawing.Size(15, 14);
            this.cbSat.TabIndex = 11;
            this.cbSat.UseVisualStyleBackColor = true;
            this.cbSat.CheckedChanged += new System.EventHandler(this.cbSat_CheckedChanged);
            // 
            // cbFri
            // 
            this.cbFri.AutoSize = true;
            this.cbFri.Location = new System.Drawing.Point(141, 189);
            this.cbFri.Name = "cbFri";
            this.cbFri.Size = new System.Drawing.Size(15, 14);
            this.cbFri.TabIndex = 10;
            this.cbFri.UseVisualStyleBackColor = true;
            this.cbFri.CheckedChanged += new System.EventHandler(this.cbFri_CheckedChanged);
            // 
            // cbThu
            // 
            this.cbThu.AutoSize = true;
            this.cbThu.Location = new System.Drawing.Point(141, 156);
            this.cbThu.Name = "cbThu";
            this.cbThu.Size = new System.Drawing.Size(15, 14);
            this.cbThu.TabIndex = 9;
            this.cbThu.UseVisualStyleBackColor = true;
            this.cbThu.CheckedChanged += new System.EventHandler(this.cbThu_CheckedChanged);
            // 
            // cbWed
            // 
            this.cbWed.AutoSize = true;
            this.cbWed.Location = new System.Drawing.Point(141, 123);
            this.cbWed.Name = "cbWed";
            this.cbWed.Size = new System.Drawing.Size(15, 14);
            this.cbWed.TabIndex = 8;
            this.cbWed.UseVisualStyleBackColor = true;
            this.cbWed.CheckedChanged += new System.EventHandler(this.cbWed_CheckedChanged);
            // 
            // cbTue
            // 
            this.cbTue.AutoSize = true;
            this.cbTue.Location = new System.Drawing.Point(141, 89);
            this.cbTue.Name = "cbTue";
            this.cbTue.Size = new System.Drawing.Size(15, 14);
            this.cbTue.TabIndex = 7;
            this.cbTue.UseVisualStyleBackColor = true;
            this.cbTue.CheckedChanged += new System.EventHandler(this.cbTue_CheckedChanged);
            // 
            // cbMon
            // 
            this.cbMon.AutoSize = true;
            this.cbMon.Location = new System.Drawing.Point(141, 58);
            this.cbMon.Name = "cbMon";
            this.cbMon.Size = new System.Drawing.Size(15, 14);
            this.cbMon.TabIndex = 6;
            this.cbMon.UseVisualStyleBackColor = true;
            this.cbMon.CheckedChanged += new System.EventHandler(this.cbMon_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 21);
            this.label7.TabIndex = 5;
            this.label7.Text = "Sat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Thu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Wed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tue";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mon";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(184, 333);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(83, 32);
            this.btnConfirm.TabIndex = 3;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // FrmPT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(448, 377);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMini;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.CheckBox cbSat;
        private System.Windows.Forms.CheckBox cbFri;
        private System.Windows.Forms.CheckBox cbThu;
        private System.Windows.Forms.CheckBox cbWed;
        private System.Windows.Forms.CheckBox cbTue;
        private System.Windows.Forms.CheckBox cbMon;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbSatOut;
        private System.Windows.Forms.ComboBox cmbSatIn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbFriOut;
        private System.Windows.Forms.ComboBox cmbFriIn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbThuOut;
        private System.Windows.Forms.ComboBox cmbThuIn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbWedOut;
        private System.Windows.Forms.ComboBox cmbWedIn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbTueOut;
        private System.Windows.Forms.ComboBox cmbTueIn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbMonOut;
        private System.Windows.Forms.ComboBox cmbMonIn;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
    }
}