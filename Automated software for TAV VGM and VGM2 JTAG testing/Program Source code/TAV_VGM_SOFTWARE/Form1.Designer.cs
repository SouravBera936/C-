namespace TAV_VGM_SOFTWARE
{
    partial class Board_selection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Board_selection));
            this.USERNAME = new System.Windows.Forms.Button();
            this.SELECTION1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.PART_NUMBER = new System.Windows.Forms.ComboBox();
            this.SUMIT = new System.Windows.Forms.Button();
            this.STOP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // USERNAME
            // 
            this.USERNAME.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.USERNAME.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.USERNAME.Font = new System.Drawing.Font("Viner Hand ITC", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.USERNAME.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.USERNAME.Location = new System.Drawing.Point(63, 58);
            this.USERNAME.Name = "USERNAME";
            this.USERNAME.Size = new System.Drawing.Size(217, 34);
            this.USERNAME.TabIndex = 49;
            this.USERNAME.Text = "BOARD SELECTION:";
            this.USERNAME.UseVisualStyleBackColor = false;
            // 
            // SELECTION1
            // 
            this.SELECTION1.AutoCompleteCustomSource.AddRange(new string[] {
            "FS-9001-29",
            "FS-9001-60"});
            this.SELECTION1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.SELECTION1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SELECTION1.Items.AddRange(new object[] {
            "VGM",
            "VGM2",
            "VGM PGM ERRASE"});
            this.SELECTION1.Location = new System.Drawing.Point(325, 61);
            this.SELECTION1.Name = "SELECTION1";
            this.SELECTION1.Size = new System.Drawing.Size(163, 25);
            this.SELECTION1.TabIndex = 47;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(551, 263);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Viner Hand ITC", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(63, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 34);
            this.button1.TabIndex = 50;
            this.button1.Text = "PART NUMBER SELECTION:";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // PART_NUMBER
            // 
            this.PART_NUMBER.AutoCompleteCustomSource.AddRange(new string[] {
            "FS-9001-29",
            "FS-9001-60"});
            this.PART_NUMBER.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.PART_NUMBER.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PART_NUMBER.Items.AddRange(new object[] {
            "E30770DA01",
            "E30770CB03",
            "VGM PGM ERRASE"});
            this.PART_NUMBER.Location = new System.Drawing.Point(325, 135);
            this.PART_NUMBER.Name = "PART_NUMBER";
            this.PART_NUMBER.Size = new System.Drawing.Size(163, 25);
            this.PART_NUMBER.TabIndex = 51;
            this.PART_NUMBER.SelectedIndexChanged += new System.EventHandler(this.PART_NUMBER_SelectedIndexChanged);
            // 
            // SUMIT
            // 
            this.SUMIT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SUMIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SUMIT.ForeColor = System.Drawing.Color.White;
            this.SUMIT.Location = new System.Drawing.Point(409, 195);
            this.SUMIT.Name = "SUMIT";
            this.SUMIT.Size = new System.Drawing.Size(102, 37);
            this.SUMIT.TabIndex = 52;
            this.SUMIT.Text = "START";
            this.SUMIT.UseVisualStyleBackColor = false;
            this.SUMIT.Click += new System.EventHandler(this.SUMIT_Click);
            // 
            // STOP
            // 
            this.STOP.BackColor = System.Drawing.Color.LightBlue;
            this.STOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STOP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.STOP.Location = new System.Drawing.Point(23, 195);
            this.STOP.Name = "STOP";
            this.STOP.Size = new System.Drawing.Size(97, 37);
            this.STOP.TabIndex = 53;
            this.STOP.Text = "STOP";
            this.STOP.UseVisualStyleBackColor = false;
            this.STOP.Click += new System.EventHandler(this.STOP_Click);
            // 
            // Board_selection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 261);
            this.Controls.Add(this.STOP);
            this.Controls.Add(this.SUMIT);
            this.Controls.Add(this.PART_NUMBER);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.USERNAME);
            this.Controls.Add(this.SELECTION1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Board_selection";
            this.Text = "Board_Selection";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button USERNAME;
        private System.Windows.Forms.ComboBox SELECTION1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox PART_NUMBER;
        private System.Windows.Forms.Button SUMIT;
        private System.Windows.Forms.Button STOP;
    }
}

