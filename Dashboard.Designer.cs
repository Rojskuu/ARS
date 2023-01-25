namespace AutomatedRoomScheduling
{
    partial class FrmDash
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDash));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSched = new System.Windows.Forms.Button();
            this.btnRoom = new System.Windows.Forms.Button();
            this.btnClass = new System.Windows.Forms.Button();
            this.btnSubject = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSection = new System.Windows.Forms.Button();
            this.btnTeacher = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tcDash = new System.Windows.Forms.TabControl();
            this.tabTeach = new System.Windows.Forms.TabPage();
            this.txtTeach = new System.Windows.Forms.TextBox();
            this.dtgTeach = new System.Windows.Forms.DataGridView();
            this.tabSection = new System.Windows.Forms.TabPage();
            this.txtSection = new System.Windows.Forms.TextBox();
            this.dtgSec = new System.Windows.Forms.DataGridView();
            this.tabRoom = new System.Windows.Forms.TabPage();
            this.txtRoom = new System.Windows.Forms.TextBox();
            this.dtgRoom = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMini = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cmbSY = new System.Windows.Forms.ComboBox();
            this.btnSNT = new System.Windows.Forms.Button();
            this.GenID = new System.Windows.Forms.Timer(this.components);
            this.nanosec = new System.Windows.Forms.Timer(this.components);
            this.btnLogHis = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tcDash.SuspendLayout();
            this.tabTeach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTeach)).BeginInit();
            this.tabSection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSec)).BeginInit();
            this.tabRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRoom)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnSched);
            this.panel1.Controls.Add(this.btnRoom);
            this.panel1.Controls.Add(this.btnClass);
            this.panel1.Controls.Add(this.btnSubject);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnSection);
            this.panel1.Controls.Add(this.btnTeacher);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(92, 698);
            this.panel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(6, 619);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "SCHEDULE";
            // 
            // btnSched
            // 
            this.btnSched.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSched.BackgroundImage")));
            this.btnSched.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSched.Location = new System.Drawing.Point(13, 561);
            this.btnSched.Name = "btnSched";
            this.btnSched.Size = new System.Drawing.Size(66, 55);
            this.btnSched.TabIndex = 2;
            this.btnSched.UseVisualStyleBackColor = true;
            this.btnSched.Click += new System.EventHandler(this.btnSched_Click);
            // 
            // btnRoom
            // 
            this.btnRoom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRoom.BackgroundImage")));
            this.btnRoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRoom.Location = new System.Drawing.Point(13, 376);
            this.btnRoom.Name = "btnRoom";
            this.btnRoom.Size = new System.Drawing.Size(66, 55);
            this.btnRoom.TabIndex = 11;
            this.btnRoom.UseVisualStyleBackColor = true;
            this.btnRoom.Click += new System.EventHandler(this.btnRoom_Click);
            // 
            // btnClass
            // 
            this.btnClass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClass.BackgroundImage")));
            this.btnClass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClass.Location = new System.Drawing.Point(13, 470);
            this.btnClass.Name = "btnClass";
            this.btnClass.Size = new System.Drawing.Size(66, 55);
            this.btnClass.TabIndex = 10;
            this.btnClass.UseVisualStyleBackColor = true;
            this.btnClass.Click += new System.EventHandler(this.btnClass_Click);
            // 
            // btnSubject
            // 
            this.btnSubject.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSubject.BackgroundImage")));
            this.btnSubject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSubject.Location = new System.Drawing.Point(13, 285);
            this.btnSubject.Name = "btnSubject";
            this.btnSubject.Size = new System.Drawing.Size(66, 55);
            this.btnSubject.TabIndex = 9;
            this.btnSubject.UseVisualStyleBackColor = true;
            this.btnSubject.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(22, 434);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "ROOM";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnSection
            // 
            this.btnSection.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSection.BackgroundImage")));
            this.btnSection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSection.Location = new System.Drawing.Point(13, 193);
            this.btnSection.Name = "btnSection";
            this.btnSection.Size = new System.Drawing.Size(66, 55);
            this.btnSection.TabIndex = 8;
            this.btnSection.UseVisualStyleBackColor = true;
            this.btnSection.Click += new System.EventHandler(this.btnSection_Click);
            // 
            // btnTeacher
            // 
            this.btnTeacher.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTeacher.BackgroundImage")));
            this.btnTeacher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTeacher.Location = new System.Drawing.Point(13, 101);
            this.btnTeacher.Name = "btnTeacher";
            this.btnTeacher.Size = new System.Drawing.Size(66, 55);
            this.btnTeacher.TabIndex = 2;
            this.btnTeacher.UseVisualStyleBackColor = true;
            this.btnTeacher.Click += new System.EventHandler(this.btnTeacher_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(21, 528);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "CLASS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(15, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "SUBJECT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "SECTION";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(13, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "TEACHER";
            // 
            // tcDash
            // 
            this.tcDash.Controls.Add(this.tabTeach);
            this.tcDash.Controls.Add(this.tabSection);
            this.tcDash.Controls.Add(this.tabRoom);
            this.tcDash.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcDash.Location = new System.Drawing.Point(97, 87);
            this.tcDash.Name = "tcDash";
            this.tcDash.SelectedIndex = 0;
            this.tcDash.Size = new System.Drawing.Size(1112, 594);
            this.tcDash.TabIndex = 1;
            // 
            // tabTeach
            // 
            this.tabTeach.Controls.Add(this.txtTeach);
            this.tabTeach.Controls.Add(this.dtgTeach);
            this.tabTeach.Location = new System.Drawing.Point(4, 29);
            this.tabTeach.Name = "tabTeach";
            this.tabTeach.Padding = new System.Windows.Forms.Padding(3);
            this.tabTeach.Size = new System.Drawing.Size(1104, 561);
            this.tabTeach.TabIndex = 0;
            this.tabTeach.Text = "Teacher";
            this.tabTeach.UseVisualStyleBackColor = true;
            // 
            // txtTeach
            // 
            this.txtTeach.Location = new System.Drawing.Point(76, 34);
            this.txtTeach.Name = "txtTeach";
            this.txtTeach.Size = new System.Drawing.Size(227, 27);
            this.txtTeach.TabIndex = 1;
            this.txtTeach.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTeach_KeyUp);
            // 
            // dtgTeach
            // 
            this.dtgTeach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgTeach.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgTeach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgTeach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgTeach.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgTeach.GridColor = System.Drawing.Color.Black;
            this.dtgTeach.Location = new System.Drawing.Point(3, 67);
            this.dtgTeach.Name = "dtgTeach";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgTeach.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtgTeach.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgTeach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgTeach.Size = new System.Drawing.Size(743, 474);
            this.dtgTeach.TabIndex = 0;
            // 
            // tabSection
            // 
            this.tabSection.Controls.Add(this.txtSection);
            this.tabSection.Controls.Add(this.dtgSec);
            this.tabSection.Location = new System.Drawing.Point(4, 29);
            this.tabSection.Name = "tabSection";
            this.tabSection.Padding = new System.Windows.Forms.Padding(3);
            this.tabSection.Size = new System.Drawing.Size(1104, 561);
            this.tabSection.TabIndex = 1;
            this.tabSection.Text = "Section";
            this.tabSection.UseVisualStyleBackColor = true;
            // 
            // txtSection
            // 
            this.txtSection.Location = new System.Drawing.Point(76, 34);
            this.txtSection.Name = "txtSection";
            this.txtSection.Size = new System.Drawing.Size(227, 27);
            this.txtSection.TabIndex = 3;
            this.txtSection.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSection_KeyUp);
            // 
            // dtgSec
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtgSec.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgSec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgSec.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgSec.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgSec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgSec.DefaultCellStyle = dataGridViewCellStyle7;
            this.dtgSec.GridColor = System.Drawing.Color.White;
            this.dtgSec.Location = new System.Drawing.Point(4, 67);
            this.dtgSec.Name = "dtgSec";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgSec.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtgSec.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dtgSec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgSec.Size = new System.Drawing.Size(742, 474);
            this.dtgSec.TabIndex = 2;
            // 
            // tabRoom
            // 
            this.tabRoom.Controls.Add(this.txtRoom);
            this.tabRoom.Controls.Add(this.dtgRoom);
            this.tabRoom.Location = new System.Drawing.Point(4, 29);
            this.tabRoom.Name = "tabRoom";
            this.tabRoom.Size = new System.Drawing.Size(1104, 561);
            this.tabRoom.TabIndex = 4;
            this.tabRoom.Text = "Room";
            this.tabRoom.UseVisualStyleBackColor = true;
            this.tabRoom.Click += new System.EventHandler(this.tabRoom_Click);
            // 
            // txtRoom
            // 
            this.txtRoom.Location = new System.Drawing.Point(76, 34);
            this.txtRoom.Name = "txtRoom";
            this.txtRoom.Size = new System.Drawing.Size(227, 27);
            this.txtRoom.TabIndex = 3;
            this.txtRoom.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtRoom_KeyUp);
            // 
            // dtgRoom
            // 
            this.dtgRoom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgRoom.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgRoom.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dtgRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgRoom.DefaultCellStyle = dataGridViewCellStyle11;
            this.dtgRoom.Location = new System.Drawing.Point(3, 67);
            this.dtgRoom.Name = "dtgRoom";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgRoom.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtgRoom.RowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dtgRoom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgRoom.Size = new System.Drawing.Size(742, 474);
            this.dtgRoom.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(1, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 26);
            this.label6.TabIndex = 2;
            this.label6.Text = "DASHBOARD";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Yellow;
            this.panel2.Controls.Add(this.btnMini);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(91, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1131, 31);
            this.panel2.TabIndex = 0;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // btnMini
            // 
            this.btnMini.BackColor = System.Drawing.Color.White;
            this.btnMini.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMini.BackgroundImage")));
            this.btnMini.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMini.Location = new System.Drawing.Point(1066, 3);
            this.btnMini.Name = "btnMini";
            this.btnMini.Size = new System.Drawing.Size(28, 26);
            this.btnMini.TabIndex = 3;
            this.btnMini.UseVisualStyleBackColor = false;
            this.btnMini.Click += new System.EventHandler(this.btnMini_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Location = new System.Drawing.Point(1100, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(28, 26);
            this.btnExit.TabIndex = 2;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(1064, 51);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(0, 21);
            this.lblTimer.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cmbSY
            // 
            this.cmbSY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSY.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSY.FormattingEnabled = true;
            this.cmbSY.Location = new System.Drawing.Point(696, 56);
            this.cmbSY.Name = "cmbSY";
            this.cmbSY.Size = new System.Drawing.Size(151, 28);
            this.cmbSY.TabIndex = 2;
            this.cmbSY.SelectedIndexChanged += new System.EventHandler(this.cmbSY_SelectedIndexChanged);
            this.cmbSY.SelectionChangeCommitted += new System.EventHandler(this.cmbSY_SelectionChangeCommitted);
            // 
            // btnSNT
            // 
            this.btnSNT.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSNT.Location = new System.Drawing.Point(877, 46);
            this.btnSNT.Name = "btnSNT";
            this.btnSNT.Size = new System.Drawing.Size(129, 54);
            this.btnSNT.TabIndex = 3;
            this.btnSNT.Text = "     Add New       S.Y. / SEM ";
            this.btnSNT.UseVisualStyleBackColor = true;
            this.btnSNT.Click += new System.EventHandler(this.btnSNT_Click);
            // 
            // GenID
            // 
            this.GenID.Tick += new System.EventHandler(this.GenID_Tick);
            // 
            // nanosec
            // 
            this.nanosec.Interval = 1;
            this.nanosec.Tick += new System.EventHandler(this.nanosec_Tick);
            // 
            // btnLogHis
            // 
            this.btnLogHis.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogHis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogHis.BackgroundImage")));
            this.btnLogHis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogHis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogHis.Location = new System.Drawing.Point(104, 40);
            this.btnLogHis.Name = "btnLogHis";
            this.btnLogHis.Size = new System.Drawing.Size(36, 32);
            this.btnLogHis.TabIndex = 4;
            this.btnLogHis.UseVisualStyleBackColor = false;
            this.btnLogHis.Click += new System.EventHandler(this.btnLogHis_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(146, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 18);
            this.label8.TabIndex = 5;
            this.label8.Text = "Log History";
            // 
            // FrmDash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1221, 693);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnLogHis);
            this.Controls.Add(this.btnSNT);
            this.Controls.Add(this.cmbSY);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tcDash);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmDash_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tcDash.ResumeLayout(false);
            this.tabTeach.ResumeLayout(false);
            this.tabTeach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTeach)).EndInit();
            this.tabSection.ResumeLayout(false);
            this.tabSection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSec)).EndInit();
            this.tabRoom.ResumeLayout(false);
            this.tabRoom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRoom)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tcDash;
        private System.Windows.Forms.TabPage tabTeach;
        private System.Windows.Forms.TabPage tabSection;
        private System.Windows.Forms.Button btnTeacher;
        private System.Windows.Forms.Button btnRoom;
        private System.Windows.Forms.Button btnClass;
        private System.Windows.Forms.Button btnSubject;
        private System.Windows.Forms.Button btnSection;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtTeach;
        private System.Windows.Forms.DataGridView dtgTeach;
        private System.Windows.Forms.TabPage tabRoom;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMini;
        private System.Windows.Forms.TextBox txtSection;
        private System.Windows.Forms.DataGridView dtgSec;
        private System.Windows.Forms.TextBox txtRoom;
        private System.Windows.Forms.DataGridView dtgRoom;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSched;
        private System.Windows.Forms.ComboBox cmbSY;
        private System.Windows.Forms.Button btnSNT;
        private System.Windows.Forms.Timer GenID;
        private System.Windows.Forms.Timer nanosec;
        private System.Windows.Forms.Button btnLogHis;
        private System.Windows.Forms.Label label8;
    }
}