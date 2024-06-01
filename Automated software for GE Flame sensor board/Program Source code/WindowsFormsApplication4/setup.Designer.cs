namespace WindowsFormsApplication4
{
    partial class SETUP_CALIBRATION
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SETUP_CALIBRATION));
            this.Version_lbl = new System.Windows.Forms.Label();
            this.heading_lbl = new System.Windows.Forms.Label();
            this.CAL_POINT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OUT_PUT1 = new System.Windows.Forms.GroupBox();
            this.START_LOGIC1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.RESULT_VALUE = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.USL_VALUE = new System.Windows.Forms.TextBox();
            this.LSL_VALUE = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.START_LOGIC2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.RESULT_VALUE1 = new System.Windows.Forms.TextBox();
            this.TEST_COMPLETED = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.OUT_PUT1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Version_lbl
            // 
            this.Version_lbl.AutoSize = true;
            this.Version_lbl.Location = new System.Drawing.Point(304, 46);
            this.Version_lbl.Name = "Version_lbl";
            this.Version_lbl.Size = new System.Drawing.Size(60, 13);
            this.Version_lbl.TabIndex = 19;
            this.Version_lbl.Text = "Version 1.0";
            // 
            // heading_lbl
            // 
            this.heading_lbl.AutoSize = true;
            this.heading_lbl.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heading_lbl.ForeColor = System.Drawing.Color.Crimson;
            this.heading_lbl.Location = new System.Drawing.Point(66, 9);
            this.heading_lbl.Name = "heading_lbl";
            this.heading_lbl.Size = new System.Drawing.Size(305, 25);
            this.heading_lbl.TabIndex = 18;
            this.heading_lbl.Text = "Flame Sensor Test Software";
            // 
            // CAL_POINT
            // 
            this.CAL_POINT.Location = new System.Drawing.Point(469, 66);
            this.CAL_POINT.Name = "CAL_POINT";
            this.CAL_POINT.Size = new System.Drawing.Size(74, 20);
            this.CAL_POINT.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(203, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "GOLDEN BOARD CALIBRATION POINT";
            // 
            // OUT_PUT1
            // 
            this.OUT_PUT1.Controls.Add(this.START_LOGIC1);
            this.OUT_PUT1.Controls.Add(this.label3);
            this.OUT_PUT1.Controls.Add(this.RESULT_VALUE);
            this.OUT_PUT1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OUT_PUT1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.OUT_PUT1.Location = new System.Drawing.Point(12, 99);
            this.OUT_PUT1.Name = "OUT_PUT1";
            this.OUT_PUT1.Size = new System.Drawing.Size(516, 74);
            this.OUT_PUT1.TabIndex = 23;
            this.OUT_PUT1.TabStop = false;
            this.OUT_PUT1.Text = "CALIBRATION FOR NO LIGHT OUTPUT";
            // 
            // START_LOGIC1
            // 
            this.START_LOGIC1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.START_LOGIC1.Location = new System.Drawing.Point(6, 39);
            this.START_LOGIC1.Name = "START_LOGIC1";
            this.START_LOGIC1.Size = new System.Drawing.Size(93, 31);
            this.START_LOGIC1.TabIndex = 24;
            this.START_LOGIC1.Text = "START";
            this.START_LOGIC1.UseVisualStyleBackColor = true;
            this.START_LOGIC1.Click += new System.EventHandler(this.START_LOGIC1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "RESULT";
            // 
            // RESULT_VALUE
            // 
            this.RESULT_VALUE.Enabled = false;
            this.RESULT_VALUE.Location = new System.Drawing.Point(380, 39);
            this.RESULT_VALUE.MaxLength = 3;
            this.RESULT_VALUE.Name = "RESULT_VALUE";
            this.RESULT_VALUE.Size = new System.Drawing.Size(100, 22);
            this.RESULT_VALUE.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.USL_VALUE);
            this.groupBox1.Controls.Add(this.LSL_VALUE);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.START_LOGIC2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.RESULT_VALUE1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(18, 190);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(516, 113);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CALIBRATION FOR MINIMUM LIGHT OUTPUT";
            // 
            // USL_VALUE
            // 
            this.USL_VALUE.Enabled = false;
            this.USL_VALUE.Location = new System.Drawing.Point(216, 78);
            this.USL_VALUE.Name = "USL_VALUE";
            this.USL_VALUE.Size = new System.Drawing.Size(81, 22);
            this.USL_VALUE.TabIndex = 4;
            // 
            // LSL_VALUE
            // 
            this.LSL_VALUE.Enabled = false;
            this.LSL_VALUE.Location = new System.Drawing.Point(216, 27);
            this.LSL_VALUE.Name = "LSL_VALUE";
            this.LSL_VALUE.Size = new System.Drawing.Size(81, 22);
            this.LSL_VALUE.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(146, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "USL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "LSL";
            // 
            // START_LOGIC2
            // 
            this.START_LOGIC2.Location = new System.Drawing.Point(6, 39);
            this.START_LOGIC2.Name = "START_LOGIC2";
            this.START_LOGIC2.Size = new System.Drawing.Size(93, 28);
            this.START_LOGIC2.TabIndex = 2;
            this.START_LOGIC2.Text = "START";
            this.START_LOGIC2.UseVisualStyleBackColor = true;
            this.START_LOGIC2.Click += new System.EventHandler(this.START_LOGIC2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(314, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "RESULT";
            // 
            // RESULT_VALUE1
            // 
            this.RESULT_VALUE1.Enabled = false;
            this.RESULT_VALUE1.Location = new System.Drawing.Point(374, 55);
            this.RESULT_VALUE1.MaxLength = 3;
            this.RESULT_VALUE1.Name = "RESULT_VALUE1";
            this.RESULT_VALUE1.Size = new System.Drawing.Size(100, 22);
            this.RESULT_VALUE1.TabIndex = 0;
            // 
            // TEST_COMPLETED
            // 
            this.TEST_COMPLETED.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TEST_COMPLETED.Location = new System.Drawing.Point(349, 309);
            this.TEST_COMPLETED.Name = "TEST_COMPLETED";
            this.TEST_COMPLETED.Size = new System.Drawing.Size(104, 40);
            this.TEST_COMPLETED.TabIndex = 26;
            this.TEST_COMPLETED.Text = "TEST COMPLETED";
            this.TEST_COMPLETED.UseVisualStyleBackColor = true;
            this.TEST_COMPLETED.Click += new System.EventHandler(this.TEST_COMPLETED_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApplication4.Properties.Resources.Centum_logo;
            this.pictureBox2.Location = new System.Drawing.Point(379, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(174, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = global::WindowsFormsApplication4.Properties.Resources.ge_monogram_primary_blue_RGB2;
            this.pictureBox1.Location = new System.Drawing.Point(1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // SETUP_CALIBRATION
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 352);
            this.Controls.Add(this.TEST_COMPLETED);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.OUT_PUT1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CAL_POINT);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Version_lbl);
            this.Controls.Add(this.heading_lbl);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SETUP_CALIBRATION";
            this.Text = "setup";
            this.OUT_PUT1.ResumeLayout(false);
            this.OUT_PUT1.PerformLayout();
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
        private System.Windows.Forms.TextBox CAL_POINT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox OUT_PUT1;
        private System.Windows.Forms.TextBox RESULT_VALUE;
        private System.Windows.Forms.Button START_LOGIC1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button START_LOGIC2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox RESULT_VALUE1;
        private System.Windows.Forms.Button TEST_COMPLETED;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox USL_VALUE;
        private System.Windows.Forms.TextBox LSL_VALUE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}