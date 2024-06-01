namespace WindowsFormsApplication4
{
    partial class MAIN_FORM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MAIN_FORM));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fILEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cONFIGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lOGOUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hELPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBOUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sl_no_txtbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BOARD_START = new System.Windows.Forms.Button();
            this.TEST_COMPLETED = new System.Windows.Forms.Button();
            this.OUT_PUT = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.USL_VALUE_txtbx = new System.Windows.Forms.TextBox();
            this.RESULT_VALUE = new System.Windows.Forms.TextBox();
            this.LSL_VALUE_txtbx = new System.Windows.Forms.TextBox();
            this.Version_lbl = new System.Windows.Forms.Label();
            this.heading_lbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.menuStrip1.SuspendLayout();
            this.OUT_PUT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fILEToolStripMenuItem,
            this.hELPToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(582, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fILEToolStripMenuItem
            // 
            this.fILEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cONFIGToolStripMenuItem,
            this.lOGOUTToolStripMenuItem});
            this.fILEToolStripMenuItem.Name = "fILEToolStripMenuItem";
            this.fILEToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.fILEToolStripMenuItem.Text = "FILE";
            // 
            // cONFIGToolStripMenuItem
            // 
            this.cONFIGToolStripMenuItem.Name = "cONFIGToolStripMenuItem";
            this.cONFIGToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.cONFIGToolStripMenuItem.Text = "CONFIGURATION";
            // 
            // lOGOUTToolStripMenuItem
            // 
            this.lOGOUTToolStripMenuItem.Name = "lOGOUTToolStripMenuItem";
            this.lOGOUTToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.lOGOUTToolStripMenuItem.Text = "LOGOUT";
            // 
            // hELPToolStripMenuItem
            // 
            this.hELPToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aBOUTToolStripMenuItem});
            this.hELPToolStripMenuItem.Name = "hELPToolStripMenuItem";
            this.hELPToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.hELPToolStripMenuItem.Text = "HELP";
            // 
            // aBOUTToolStripMenuItem
            // 
            this.aBOUTToolStripMenuItem.Name = "aBOUTToolStripMenuItem";
            this.aBOUTToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.aBOUTToolStripMenuItem.Text = "ABOUT";
            // 
            // sl_no_txtbx
            // 
            this.sl_no_txtbx.Location = new System.Drawing.Point(160, 119);
            this.sl_no_txtbx.Name = "sl_no_txtbx";
            this.sl_no_txtbx.Size = new System.Drawing.Size(186, 20);
            this.sl_no_txtbx.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "BOARD SERIAL NO :";
            // 
            // BOARD_START
            // 
            this.BOARD_START.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BOARD_START.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BOARD_START.Location = new System.Drawing.Point(445, 109);
            this.BOARD_START.Name = "BOARD_START";
            this.BOARD_START.Size = new System.Drawing.Size(111, 38);
            this.BOARD_START.TabIndex = 3;
            this.BOARD_START.Text = "START";
            this.BOARD_START.UseVisualStyleBackColor = true;
            this.BOARD_START.Click += new System.EventHandler(this.BOARD_START_Click);
            // 
            // TEST_COMPLETED
            // 
            this.TEST_COMPLETED.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TEST_COMPLETED.ForeColor = System.Drawing.SystemColors.Highlight;
            this.TEST_COMPLETED.Location = new System.Drawing.Point(430, 58);
            this.TEST_COMPLETED.Name = "TEST_COMPLETED";
            this.TEST_COMPLETED.Size = new System.Drawing.Size(100, 52);
            this.TEST_COMPLETED.TabIndex = 7;
            this.TEST_COMPLETED.Text = "TEST COMPLETED";
            this.TEST_COMPLETED.UseVisualStyleBackColor = true;
            this.TEST_COMPLETED.Click += new System.EventHandler(this.TEST_COMPLETED_Click);
            // 
            // OUT_PUT
            // 
            this.OUT_PUT.Controls.Add(this.label4);
            this.OUT_PUT.Controls.Add(this.TEST_COMPLETED);
            this.OUT_PUT.Controls.Add(this.label3);
            this.OUT_PUT.Controls.Add(this.label2);
            this.OUT_PUT.Controls.Add(this.USL_VALUE_txtbx);
            this.OUT_PUT.Controls.Add(this.RESULT_VALUE);
            this.OUT_PUT.Controls.Add(this.LSL_VALUE_txtbx);
            this.OUT_PUT.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OUT_PUT.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.OUT_PUT.Location = new System.Drawing.Point(15, 168);
            this.OUT_PUT.Name = "OUT_PUT";
            this.OUT_PUT.Size = new System.Drawing.Size(555, 137);
            this.OUT_PUT.TabIndex = 8;
            this.OUT_PUT.TabStop = false;
            this.OUT_PUT.Text = "OUTPUT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "USL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "RESULT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "LSL";
            // 
            // USL_VALUE_txtbx
            // 
            this.USL_VALUE_txtbx.Enabled = false;
            this.USL_VALUE_txtbx.Location = new System.Drawing.Point(84, 96);
            this.USL_VALUE_txtbx.Name = "USL_VALUE_txtbx";
            this.USL_VALUE_txtbx.Size = new System.Drawing.Size(100, 22);
            this.USL_VALUE_txtbx.TabIndex = 0;
            // 
            // RESULT_VALUE
            // 
            this.RESULT_VALUE.Enabled = false;
            this.RESULT_VALUE.Location = new System.Drawing.Point(282, 74);
            this.RESULT_VALUE.MaxLength = 3;
            this.RESULT_VALUE.Name = "RESULT_VALUE";
            this.RESULT_VALUE.Size = new System.Drawing.Size(100, 22);
            this.RESULT_VALUE.TabIndex = 0;
            // 
            // LSL_VALUE_txtbx
            // 
            this.LSL_VALUE_txtbx.Enabled = false;
            this.LSL_VALUE_txtbx.Location = new System.Drawing.Point(84, 44);
            this.LSL_VALUE_txtbx.Name = "LSL_VALUE_txtbx";
            this.LSL_VALUE_txtbx.Size = new System.Drawing.Size(100, 22);
            this.LSL_VALUE_txtbx.TabIndex = 0;
            // 
            // Version_lbl
            // 
            this.Version_lbl.AutoSize = true;
            this.Version_lbl.Location = new System.Drawing.Point(323, 55);
            this.Version_lbl.Name = "Version_lbl";
            this.Version_lbl.Size = new System.Drawing.Size(60, 13);
            this.Version_lbl.TabIndex = 11;
            this.Version_lbl.Text = "Version 1.0";
            // 
            // heading_lbl
            // 
            this.heading_lbl.AutoSize = true;
            this.heading_lbl.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heading_lbl.ForeColor = System.Drawing.Color.Crimson;
            this.heading_lbl.Location = new System.Drawing.Point(80, 27);
            this.heading_lbl.Name = "heading_lbl";
            this.heading_lbl.Size = new System.Drawing.Size(305, 25);
            this.heading_lbl.TabIndex = 10;
            this.heading_lbl.Text = "Flame Sensor Test Software";
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApplication4.Properties.Resources.Centum_logo;
            this.pictureBox2.Location = new System.Drawing.Point(396, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(174, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = global::WindowsFormsApplication4.Properties.Resources.ge_monogram_primary_blue_RGB2;
            this.pictureBox1.Location = new System.Drawing.Point(15, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM2";
            // 
            // MAIN_FORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 335);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Version_lbl);
            this.Controls.Add(this.heading_lbl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.OUT_PUT);
            this.Controls.Add(this.BOARD_START);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sl_no_txtbx);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MAIN_FORM";
            this.Text = "MAINFORM";
            this.Load += new System.EventHandler(this.MAIN_FORM_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.OUT_PUT.ResumeLayout(false);
            this.OUT_PUT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fILEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cONFIGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lOGOUTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hELPToolStripMenuItem;
        private System.Windows.Forms.TextBox sl_no_txtbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BOARD_START;
        private System.Windows.Forms.Button TEST_COMPLETED;
        private System.Windows.Forms.GroupBox OUT_PUT;
        private System.Windows.Forms.TextBox USL_VALUE_txtbx;
        private System.Windows.Forms.TextBox RESULT_VALUE;
        private System.Windows.Forms.TextBox LSL_VALUE_txtbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem aBOUTToolStripMenuItem;
        private System.Windows.Forms.Label Version_lbl;
        private System.Windows.Forms.Label heading_lbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
        private System.IO.Ports.SerialPort serialPort1;
    }
}