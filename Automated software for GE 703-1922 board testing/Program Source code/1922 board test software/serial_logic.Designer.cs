namespace _1922_board_test_software
{
    partial class serial_logic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(serial_logic));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Version_lbl = new System.Windows.Forms.Label();
            this.heading_lbl = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.start_logic = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sl_no_txtbx = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(434, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(174, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            // 
            // Version_lbl
            // 
            this.Version_lbl.AutoSize = true;
            this.Version_lbl.Location = new System.Drawing.Point(327, 38);
            this.Version_lbl.Name = "Version_lbl";
            this.Version_lbl.Size = new System.Drawing.Size(60, 13);
            this.Version_lbl.TabIndex = 33;
            this.Version_lbl.Text = "Version 1.0";
            // 
            // heading_lbl
            // 
            this.heading_lbl.AutoSize = true;
            this.heading_lbl.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heading_lbl.ForeColor = System.Drawing.Color.Crimson;
            this.heading_lbl.Location = new System.Drawing.Point(63, 9);
            this.heading_lbl.Name = "heading_lbl";
            this.heading_lbl.Size = new System.Drawing.Size(361, 25);
            this.heading_lbl.TabIndex = 32;
            this.heading_lbl.Text = "Aurora Main Board Test Software";
            // 
            // pictureBox3
            // 
            this.pictureBox3.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.ErrorImage")));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(-2, 1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(59, 59);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 31;
            this.pictureBox3.TabStop = false;
            // 
            // start_logic
            // 
            this.start_logic.BackColor = System.Drawing.Color.Lime;
            this.start_logic.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_logic.ForeColor = System.Drawing.Color.Black;
            this.start_logic.Location = new System.Drawing.Point(450, 186);
            this.start_logic.Name = "start_logic";
            this.start_logic.Size = new System.Drawing.Size(111, 38);
            this.start_logic.TabIndex = 30;
            this.start_logic.Text = "START";
            this.start_logic.UseVisualStyleBackColor = false;
            this.start_logic.Click += new System.EventHandler(this.start_logic_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 15);
            this.label1.TabIndex = 29;
            this.label1.Text = "BOARD SERIAL NO :";
            // 
            // sl_no_txtbx
            // 
            this.sl_no_txtbx.Location = new System.Drawing.Point(432, 125);
            this.sl_no_txtbx.Name = "sl_no_txtbx";
            this.sl_no_txtbx.Size = new System.Drawing.Size(164, 20);
            this.sl_no_txtbx.TabIndex = 28;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(279, 140);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // serial_logic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 256);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Version_lbl);
            this.Controls.Add(this.heading_lbl);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.start_logic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sl_no_txtbx);
            this.Controls.Add(this.pictureBox1);
            this.Name = "serial_logic";
            this.Text = "serial_logic";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Version_lbl;
        private System.Windows.Forms.Label heading_lbl;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button start_logic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sl_no_txtbx;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}