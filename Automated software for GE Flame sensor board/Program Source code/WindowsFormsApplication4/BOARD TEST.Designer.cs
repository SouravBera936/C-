namespace WindowsFormsApplication4
{
    partial class BOARD_TEST
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BOARD_TEST));
            this.Version_lbl = new System.Windows.Forms.Label();
            this.heading_lbl = new System.Windows.Forms.Label();
            this.OUT_PUT = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TEST_COMPLETED1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.USL_VALUE_txtbx = new System.Windows.Forms.TextBox();
            this.RESULT_VALUE1 = new System.Windows.Forms.TextBox();
            this.LSL_VALUE_txtbx = new System.Windows.Forms.TextBox();
            this.BOARD_START = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sl_no_txtbx = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.START_LOGIC1 = new System.Windows.Forms.Button();
            this.SPEC_VALUE = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TEST_COMPLETED2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.RESULT_VALUE2 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.OUT_PUT.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Version_lbl
            // 
            this.Version_lbl.AutoSize = true;
            this.Version_lbl.Location = new System.Drawing.Point(301, 34);
            this.Version_lbl.Name = "Version_lbl";
            this.Version_lbl.Size = new System.Drawing.Size(60, 13);
            this.Version_lbl.TabIndex = 9;
            this.Version_lbl.Text = "Version 1.0";
            // 
            // heading_lbl
            // 
            this.heading_lbl.AutoSize = true;
            this.heading_lbl.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heading_lbl.ForeColor = System.Drawing.Color.Crimson;
            this.heading_lbl.Location = new System.Drawing.Point(60, 9);
            this.heading_lbl.Name = "heading_lbl";
            this.heading_lbl.Size = new System.Drawing.Size(305, 25);
            this.heading_lbl.TabIndex = 8;
            this.heading_lbl.Text = "Flame Sensor Test Software";
            // 
            // OUT_PUT
            // 
            this.OUT_PUT.Controls.Add(this.label4);
            this.OUT_PUT.Controls.Add(this.TEST_COMPLETED1);
            this.OUT_PUT.Controls.Add(this.label3);
            this.OUT_PUT.Controls.Add(this.label2);
            this.OUT_PUT.Controls.Add(this.USL_VALUE_txtbx);
            this.OUT_PUT.Controls.Add(this.RESULT_VALUE1);
            this.OUT_PUT.Controls.Add(this.LSL_VALUE_txtbx);
            this.OUT_PUT.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OUT_PUT.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.OUT_PUT.Location = new System.Drawing.Point(22, 89);
            this.OUT_PUT.Name = "OUT_PUT";
            this.OUT_PUT.Size = new System.Drawing.Size(555, 137);
            this.OUT_PUT.TabIndex = 14;
            this.OUT_PUT.TabStop = false;
            this.OUT_PUT.Text = "NO LIGHT OUTPUT";
            this.OUT_PUT.Enter += new System.EventHandler(this.OUT_PUT_Enter);
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
            // TEST_COMPLETED1
            // 
            this.TEST_COMPLETED1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TEST_COMPLETED1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.TEST_COMPLETED1.Location = new System.Drawing.Point(446, 58);
            this.TEST_COMPLETED1.Name = "TEST_COMPLETED1";
            this.TEST_COMPLETED1.Size = new System.Drawing.Size(109, 52);
            this.TEST_COMPLETED1.TabIndex = 7;
            this.TEST_COMPLETED1.Text = "TEST COMPLETED";
            this.TEST_COMPLETED1.UseVisualStyleBackColor = true;
            this.TEST_COMPLETED1.Click += new System.EventHandler(this.TEST_COMPLETED1_Click);
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
            // RESULT_VALUE1
            // 
            this.RESULT_VALUE1.Enabled = false;
            this.RESULT_VALUE1.Location = new System.Drawing.Point(282, 74);
            this.RESULT_VALUE1.MaxLength = 3;
            this.RESULT_VALUE1.Name = "RESULT_VALUE1";
            this.RESULT_VALUE1.Size = new System.Drawing.Size(100, 22);
            this.RESULT_VALUE1.TabIndex = 0;
            // 
            // LSL_VALUE_txtbx
            // 
            this.LSL_VALUE_txtbx.Enabled = false;
            this.LSL_VALUE_txtbx.Location = new System.Drawing.Point(84, 44);
            this.LSL_VALUE_txtbx.Name = "LSL_VALUE_txtbx";
            this.LSL_VALUE_txtbx.Size = new System.Drawing.Size(100, 22);
            this.LSL_VALUE_txtbx.TabIndex = 0;
            // 
            // BOARD_START
            // 
            this.BOARD_START.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BOARD_START.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BOARD_START.Location = new System.Drawing.Point(468, 45);
            this.BOARD_START.Name = "BOARD_START";
            this.BOARD_START.Size = new System.Drawing.Size(111, 38);
            this.BOARD_START.TabIndex = 13;
            this.BOARD_START.Text = "START";
            this.BOARD_START.UseVisualStyleBackColor = true;
            this.BOARD_START.Click += new System.EventHandler(this.BOARD_START_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "BOARD SERIAL NO :";
            // 
            // sl_no_txtbx
            // 
            this.sl_no_txtbx.Location = new System.Drawing.Point(203, 63);
            this.sl_no_txtbx.Name = "sl_no_txtbx";
            this.sl_no_txtbx.Size = new System.Drawing.Size(186, 20);
            this.sl_no_txtbx.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.START_LOGIC1);
            this.groupBox1.Controls.Add(this.SPEC_VALUE);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TEST_COMPLETED2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.RESULT_VALUE2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(22, 232);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(555, 108);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MINIMUM LIGHT OUTPUT";
            // 
            // START_LOGIC1
            // 
            this.START_LOGIC1.Location = new System.Drawing.Point(29, 40);
            this.START_LOGIC1.Name = "START_LOGIC1";
            this.START_LOGIC1.Size = new System.Drawing.Size(103, 37);
            this.START_LOGIC1.TabIndex = 10;
            this.START_LOGIC1.Text = "START";
            this.START_LOGIC1.UseVisualStyleBackColor = true;
            this.START_LOGIC1.Click += new System.EventHandler(this.START_LOGIC1_Click);
            // 
            // SPEC_VALUE
            // 
            this.SPEC_VALUE.Enabled = false;
            this.SPEC_VALUE.Location = new System.Drawing.Point(283, 21);
            this.SPEC_VALUE.Name = "SPEC_VALUE";
            this.SPEC_VALUE.Size = new System.Drawing.Size(100, 22);
            this.SPEC_VALUE.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(222, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "SPEC";
            // 
            // TEST_COMPLETED2
            // 
            this.TEST_COMPLETED2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TEST_COMPLETED2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.TEST_COMPLETED2.Location = new System.Drawing.Point(446, 38);
            this.TEST_COMPLETED2.Name = "TEST_COMPLETED2";
            this.TEST_COMPLETED2.Size = new System.Drawing.Size(109, 52);
            this.TEST_COMPLETED2.TabIndex = 7;
            this.TEST_COMPLETED2.Text = "TEST COMPLETED";
            this.TEST_COMPLETED2.UseVisualStyleBackColor = true;
            this.TEST_COMPLETED2.Click += new System.EventHandler(this.TEST_COMPLETED2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(222, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "RESULT";
            // 
            // RESULT_VALUE2
            // 
            this.RESULT_VALUE2.Enabled = false;
            this.RESULT_VALUE2.Location = new System.Drawing.Point(282, 74);
            this.RESULT_VALUE2.MaxLength = 3;
            this.RESULT_VALUE2.Name = "RESULT_VALUE2";
            this.RESULT_VALUE2.Size = new System.Drawing.Size(100, 22);
            this.RESULT_VALUE2.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApplication4.Properties.Resources.Centum_logo;
            this.pictureBox2.Location = new System.Drawing.Point(360, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(174, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = global::WindowsFormsApplication4.Properties.Resources.ge_monogram_primary_blue_RGB1;
            this.pictureBox1.Location = new System.Drawing.Point(2, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // BOARD_TEST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 345);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.OUT_PUT);
            this.Controls.Add(this.BOARD_START);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sl_no_txtbx);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Version_lbl);
            this.Controls.Add(this.heading_lbl);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BOARD_TEST";
            this.Text = "BOARD_TEST";
            this.Load += new System.EventHandler(this.BOARD_TEST_Load);
            this.OUT_PUT.ResumeLayout(false);
            this.OUT_PUT.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Version_lbl;
        private System.Windows.Forms.Label heading_lbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox OUT_PUT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button TEST_COMPLETED1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox USL_VALUE_txtbx;
        private System.Windows.Forms.TextBox RESULT_VALUE1;
        private System.Windows.Forms.TextBox LSL_VALUE_txtbx;
        private System.Windows.Forms.Button BOARD_START;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sl_no_txtbx;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button TEST_COMPLETED2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox RESULT_VALUE2;
        private System.Windows.Forms.TextBox SPEC_VALUE;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button START_LOGIC1;
    }
}