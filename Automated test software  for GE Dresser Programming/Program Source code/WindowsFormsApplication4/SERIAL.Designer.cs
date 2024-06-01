namespace WindowsFormsApplication4
{
    partial class SERIAL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SERIAL));
            this.heading_lbl = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SERIAL_NUMBER = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SUBMIT_LOGIC = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Version_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // heading_lbl
            // 
            this.heading_lbl.AutoSize = true;
            this.heading_lbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heading_lbl.ForeColor = System.Drawing.Color.Crimson;
            this.heading_lbl.Location = new System.Drawing.Point(88, 9);
            this.heading_lbl.Name = "heading_lbl";
            this.heading_lbl.Size = new System.Drawing.Size(314, 24);
            this.heading_lbl.TabIndex = 12;
            this.heading_lbl.Text = "GE DRESSER PROGRAMMING";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApplication4.Properties.Resources.Centum_logo;
            this.pictureBox2.Location = new System.Drawing.Point(496, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(174, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = global::WindowsFormsApplication4.Properties.Resources.ge_monogram_primary_blue_RGB1;
            this.pictureBox1.Location = new System.Drawing.Point(2, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // SERIAL_NUMBER
            // 
            this.SERIAL_NUMBER.Location = new System.Drawing.Point(479, 124);
            this.SERIAL_NUMBER.Name = "SERIAL_NUMBER";
            this.SERIAL_NUMBER.Size = new System.Drawing.Size(191, 21);
            this.SERIAL_NUMBER.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(277, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "BOARD SERIAL NUMBER";
            // 
            // SUBMIT_LOGIC
            // 
            this.SUBMIT_LOGIC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.SUBMIT_LOGIC.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SUBMIT_LOGIC.ForeColor = System.Drawing.Color.White;
            this.SUBMIT_LOGIC.Location = new System.Drawing.Point(515, 209);
            this.SUBMIT_LOGIC.Name = "SUBMIT_LOGIC";
            this.SUBMIT_LOGIC.Size = new System.Drawing.Size(121, 44);
            this.SUBMIT_LOGIC.TabIndex = 17;
            this.SUBMIT_LOGIC.Text = "START";
            this.SUBMIT_LOGIC.UseVisualStyleBackColor = false;
            this.SUBMIT_LOGIC.Click += new System.EventHandler(this.SUBMIT_LOGIC_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(2, 74);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(265, 222);
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // Version_lbl
            // 
            this.Version_lbl.AutoSize = true;
            this.Version_lbl.Location = new System.Drawing.Point(408, 35);
            this.Version_lbl.Name = "Version_lbl";
            this.Version_lbl.Size = new System.Drawing.Size(65, 15);
            this.Version_lbl.TabIndex = 19;
            this.Version_lbl.Text = "Version 1.0";
            // 
            // SERIAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 301);
            this.Controls.Add(this.Version_lbl);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.SUBMIT_LOGIC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SERIAL_NUMBER);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.heading_lbl);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SERIAL";
            this.Text = "CONNECTOR_FORM";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label heading_lbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox SERIAL_NUMBER;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SUBMIT_LOGIC;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label Version_lbl;
    }
}