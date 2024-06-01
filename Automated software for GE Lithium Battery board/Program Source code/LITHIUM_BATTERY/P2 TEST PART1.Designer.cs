namespace LITHIUM_BATTERY
{
    partial class P2_TEST_PART1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(P2_TEST_PART1));
            this.Votage_test = new System.Windows.Forms.Button();
            this.resistace_check = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RESULT_VALUE = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.heading_lbl = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.next_step = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trip_current = new System.Windows.Forms.TextBox();
            this.trip_voltage = new System.Windows.Forms.TextBox();
            this.Version_lbl = new System.Windows.Forms.Label();
            this.start_logic = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Votage_test
            // 
            this.Votage_test.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Votage_test.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Votage_test.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Votage_test.Location = new System.Drawing.Point(515, 63);
            this.Votage_test.Name = "Votage_test";
            this.Votage_test.Size = new System.Drawing.Size(75, 31);
            this.Votage_test.TabIndex = 2;
            this.Votage_test.Text = "START";
            this.Votage_test.UseVisualStyleBackColor = false;
            this.Votage_test.Click += new System.EventHandler(this.Votage_test_Click);
            // 
            // resistace_check
            // 
            this.resistace_check.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resistace_check.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.resistace_check.Location = new System.Drawing.Point(23, 31);
            this.resistace_check.Name = "resistace_check";
            this.resistace_check.Size = new System.Drawing.Size(295, 30);
            this.resistace_check.TabIndex = 0;
            this.resistace_check.Text = "Adjust the Rheostat  resistsnce > 5 OHM";
            this.resistace_check.UseVisualStyleBackColor = true;
            this.resistace_check.Click += new System.EventHandler(this.resistace_check_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Votage_test);
            this.groupBox1.Controls.Add(this.RESULT_VALUE);
            this.groupBox1.Controls.Add(this.resistace_check);
            this.groupBox1.Location = new System.Drawing.Point(0, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(601, 100);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reistance_adjust";
            // 
            // RESULT_VALUE
            // 
            this.RESULT_VALUE.Enabled = false;
            this.RESULT_VALUE.Location = new System.Drawing.Point(364, 38);
            this.RESULT_VALUE.Name = "RESULT_VALUE";
            this.RESULT_VALUE.ReadOnly = true;
            this.RESULT_VALUE.Size = new System.Drawing.Size(100, 20);
            this.RESULT_VALUE.TabIndex = 1;
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM2";
            // 
            // heading_lbl
            // 
            this.heading_lbl.AutoSize = true;
            this.heading_lbl.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heading_lbl.ForeColor = System.Drawing.Color.Crimson;
            this.heading_lbl.Location = new System.Drawing.Point(54, 12);
            this.heading_lbl.Name = "heading_lbl";
            this.heading_lbl.Size = new System.Drawing.Size(372, 29);
            this.heading_lbl.TabIndex = 49;
            this.heading_lbl.Text = "Lithium Battery Test Software";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(432, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(174, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 51;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.next_step);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.trip_current);
            this.groupBox3.Controls.Add(this.trip_voltage);
            this.groupBox3.Location = new System.Drawing.Point(2, 403);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(599, 117);
            this.groupBox3.TabIndex = 53;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Result";
            // 
            // next_step
            // 
            this.next_step.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.next_step.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next_step.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.next_step.Location = new System.Drawing.Point(265, 70);
            this.next_step.Name = "next_step";
            this.next_step.Size = new System.Drawing.Size(75, 41);
            this.next_step.TabIndex = 2;
            this.next_step.Text = "OK";
            this.next_step.UseVisualStyleBackColor = false;
            this.next_step.Click += new System.EventHandler(this.next_step_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(377, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "TRIP CURRENT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "TRIP VOLTAGE";
            // 
            // trip_current
            // 
            this.trip_current.Enabled = false;
            this.trip_current.Location = new System.Drawing.Point(490, 19);
            this.trip_current.Name = "trip_current";
            this.trip_current.Size = new System.Drawing.Size(100, 20);
            this.trip_current.TabIndex = 0;
            // 
            // trip_voltage
            // 
            this.trip_voltage.Enabled = false;
            this.trip_voltage.Location = new System.Drawing.Point(116, 19);
            this.trip_voltage.Name = "trip_voltage";
            this.trip_voltage.Size = new System.Drawing.Size(100, 20);
            this.trip_voltage.TabIndex = 0;
            // 
            // Version_lbl
            // 
            this.Version_lbl.AutoSize = true;
            this.Version_lbl.Location = new System.Drawing.Point(310, 43);
            this.Version_lbl.Name = "Version_lbl";
            this.Version_lbl.Size = new System.Drawing.Size(60, 13);
            this.Version_lbl.TabIndex = 50;
            this.Version_lbl.Text = "Version 1.0";
            // 
            // start_logic
            // 
            this.start_logic.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.start_logic.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_logic.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.start_logic.Location = new System.Drawing.Point(515, 187);
            this.start_logic.Name = "start_logic";
            this.start_logic.Size = new System.Drawing.Size(75, 31);
            this.start_logic.TabIndex = 52;
            this.start_logic.Text = "OK";
            this.start_logic.UseVisualStyleBackColor = false;
            this.start_logic.Click += new System.EventHandler(this.start_logic_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(512, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 51;
            this.label3.Text = "Instructions";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 50;
            this.label2.Text = "Pictures";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textBox2.Location = new System.Drawing.Point(252, 31);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(349, 150);
            this.textBox2.TabIndex = 49;
            this.textBox2.Text = "\r\n\r\n1. DECREASE THE RESISTANCE BY ROTATING THE WHEEL OF RHEOSTAT\r\n\r\n2. CHECK WHET" +
    "HER THE VOLTAGE & CURRENT  TRIPPED\r\n\r\n3. ADJUST THE LOAD TO JUST BEFORE VOLTAGE " +
    "& CURRENT CUTOFF CONDITION";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 31);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(246, 150);
            this.pictureBox3.TabIndex = 48;
            this.pictureBox3.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.start_logic);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.Location = new System.Drawing.Point(0, 172);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(601, 271);
            this.groupBox2.TabIndex = 52;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Voltage cutoff";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // P2_TEST_PART1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 525);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.heading_lbl);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Version_lbl);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "P2_TEST_PART1";
            this.Text = "P2_TEST_PART1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Votage_test;
        private System.Windows.Forms.Button resistace_check;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox RESULT_VALUE;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label heading_lbl;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button next_step;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox trip_current;
        private System.Windows.Forms.TextBox trip_voltage;
        private System.Windows.Forms.Label Version_lbl;
        private System.Windows.Forms.Button start_logic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}