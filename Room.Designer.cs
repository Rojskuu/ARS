namespace AutomatedRoomScheduling
{
    partial class FrmRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRoom));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMini = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbRoomType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCap = new System.Windows.Forms.TextBox();
            this.txtRoomID = new System.Windows.Forms.TextBox();
            this.btnADD = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnMini);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(624, 40);
            this.panel1.TabIndex = 4;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(901, 409);
            this.panel3.TabIndex = 4;
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
            this.btnMini.Location = new System.Drawing.Point(556, 7);
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
            this.btnExit.Location = new System.Drawing.Point(590, 7);
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
            this.label6.Size = new System.Drawing.Size(84, 26);
            this.label6.TabIndex = 3;
            this.label6.Text = "ROOM";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbRoomType);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCap);
            this.groupBox1.Controls.Add(this.txtRoomID);
            this.groupBox1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(54, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 147);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Room Information";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Room Type:";
            // 
            // cmbRoomType
            // 
            this.cmbRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoomType.FormattingEnabled = true;
            this.cmbRoomType.Items.AddRange(new object[] {
            "",
            "Lecture Room",
            "Computer Laboratory",
            "Kitchen Laboratory"});
            this.cmbRoomType.Location = new System.Drawing.Point(218, 59);
            this.cmbRoomType.Name = "cmbRoomType";
            this.cmbRoomType.Size = new System.Drawing.Size(241, 28);
            this.cmbRoomType.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Capacity:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Room ID:";
            // 
            // txtCap
            // 
            this.txtCap.Location = new System.Drawing.Point(218, 92);
            this.txtCap.Name = "txtCap";
            this.txtCap.Size = new System.Drawing.Size(241, 27);
            this.txtCap.TabIndex = 2;
            // 
            // txtRoomID
            // 
            this.txtRoomID.Location = new System.Drawing.Point(218, 26);
            this.txtRoomID.Name = "txtRoomID";
            this.txtRoomID.Size = new System.Drawing.Size(241, 27);
            this.txtRoomID.TabIndex = 0;
            this.txtRoomID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtRoomID_KeyUp);
            // 
            // btnADD
            // 
            this.btnADD.Location = new System.Drawing.Point(272, 252);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(75, 23);
            this.btnADD.TabIndex = 6;
            this.btnADD.Text = "ADD";
            this.btnADD.UseVisualStyleBackColor = true;
            this.btnADD.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(623, 292);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Room_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnMini;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCap;
        private System.Windows.Forms.TextBox txtRoomID;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbRoomType;
    }
}