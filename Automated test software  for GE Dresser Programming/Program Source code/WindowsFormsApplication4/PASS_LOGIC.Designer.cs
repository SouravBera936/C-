namespace WindowsFormsApplication4
{
    partial class PASS_LOGIC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PASS_LOGIC));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Version_lbl = new System.Windows.Forms.Label();
            this.heading_lbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PASSLOGIC = new System.Windows.Forms.Button();
            this.FAILLOGIC = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.Location = new System.Drawing.Point(10, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(699, 225);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Voltage cutoff";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(599, 11);
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
            this.textBox2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textBox2.Location = new System.Drawing.Point(337, 31);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(349, 150);
            this.textBox2.TabIndex = 49;
            this.textBox2.Text = "1. CLICK ON THE MMA_FIRMWAREDOWNLOAD ICON FOR PROGRAMMING.\r\n\r\n2. CHECK WHETHER TH" +
    "E \"MMA_FirmwareDownloaded Success\" CAME ON OUTPUT WINDOW\r\n\r\n3. CLEAR \"Clear Log\"" +
    " WINDOW.";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 31);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(320, 150);
            this.pictureBox3.TabIndex = 48;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApplication4.Properties.Resources.Centum_logo;
            this.pictureBox2.Location = new System.Drawing.Point(535, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(174, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 50;
            this.pictureBox2.TabStop = false;
            // 
            // Version_lbl
            // 
            this.Version_lbl.AutoSize = true;
            this.Version_lbl.Location = new System.Drawing.Point(416, 34);
            this.Version_lbl.Name = "Version_lbl";
            this.Version_lbl.Size = new System.Drawing.Size(60, 13);
            this.Version_lbl.TabIndex = 49;
            this.Version_lbl.Text = "Version 1.0";
            // 
            // heading_lbl
            // 
            this.heading_lbl.AutoSize = true;
            this.heading_lbl.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heading_lbl.ForeColor = System.Drawing.Color.Crimson;
            this.heading_lbl.Location = new System.Drawing.Point(109, 9);
            this.heading_lbl.Name = "heading_lbl";
            this.heading_lbl.Size = new System.Drawing.Size(308, 25);
            this.heading_lbl.TabIndex = 48;
            this.heading_lbl.Text = " GE DRESSER PROGRAMING";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = global::WindowsFormsApplication4.Properties.Resources.ge_monogram_primary_blue_RGB1;
            this.pictureBox1.Location = new System.Drawing.Point(10, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // PASSLOGIC
            // 
            this.PASSLOGIC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.PASSLOGIC.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PASSLOGIC.ForeColor = System.Drawing.Color.White;
            this.PASSLOGIC.Location = new System.Drawing.Point(148, 315);
            this.PASSLOGIC.Name = "PASSLOGIC";
            this.PASSLOGIC.Size = new System.Drawing.Size(75, 51);
            this.PASSLOGIC.TabIndex = 51;
            this.PASSLOGIC.Text = "PASS";
            this.PASSLOGIC.UseVisualStyleBackColor = false;
            this.PASSLOGIC.Click += new System.EventHandler(this.PASSLOGIC_Click);
            // 
            // FAILLOGIC
            // 
            this.FAILLOGIC.BackColor = System.Drawing.Color.Red;
            this.FAILLOGIC.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FAILLOGIC.ForeColor = System.Drawing.Color.White;
            this.FAILLOGIC.Location = new System.Drawing.Point(506, 315);
            this.FAILLOGIC.Name = "FAILLOGIC";
            this.FAILLOGIC.Size = new System.Drawing.Size(75, 51);
            this.FAILLOGIC.TabIndex = 51;
            this.FAILLOGIC.Text = "FAIL";
            this.FAILLOGIC.UseVisualStyleBackColor = false;
            this.FAILLOGIC.Click += new System.EventHandler(this.FAILLOGIC_Click);
            // 
            // PASS_LOGIC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 378);
            this.Controls.Add(this.FAILLOGIC);
            this.Controls.Add(this.PASSLOGIC);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Version_lbl);
            this.Controls.Add(this.heading_lbl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PASS_LOGIC";
            this.Text = "PASS_LOGIC";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Version_lbl;
        private System.Windows.Forms.Label heading_lbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button PASSLOGIC;
        private System.Windows.Forms.Button FAILLOGIC;
    }
}