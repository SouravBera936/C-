namespace LITHIUM_BATTERY
{
    partial class LOGIN_LOGIC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LOGIN_LOGIC));
            this.EXIT_LOGIC = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Version_lbl = new System.Windows.Forms.Label();
            this.heading_lbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PASSWORD = new System.Windows.Forms.TextBox();
            this.USERNAME = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // EXIT_LOGIC
            // 
            this.EXIT_LOGIC.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.EXIT_LOGIC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EXIT_LOGIC.Location = new System.Drawing.Point(440, 87);
            this.EXIT_LOGIC.Name = "EXIT_LOGIC";
            this.EXIT_LOGIC.Size = new System.Drawing.Size(75, 41);
            this.EXIT_LOGIC.TabIndex = 17;
            this.EXIT_LOGIC.Text = "E&XIT";
            this.EXIT_LOGIC.UseVisualStyleBackColor = false;
            this.EXIT_LOGIC.Click += new System.EventHandler(this.EXIT_LOGIC_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(369, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(174, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // Version_lbl
            // 
            this.Version_lbl.AutoSize = true;
            this.Version_lbl.Location = new System.Drawing.Point(306, 50);
            this.Version_lbl.Name = "Version_lbl";
            this.Version_lbl.Size = new System.Drawing.Size(60, 13);
            this.Version_lbl.TabIndex = 15;
            this.Version_lbl.Text = "Version 1.0";
            // 
            // heading_lbl
            // 
            this.heading_lbl.AutoSize = true;
            this.heading_lbl.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heading_lbl.ForeColor = System.Drawing.Color.Crimson;
            this.heading_lbl.Location = new System.Drawing.Point(65, 25);
            this.heading_lbl.Name = "heading_lbl";
            this.heading_lbl.Size = new System.Drawing.Size(298, 23);
            this.heading_lbl.TabIndex = 14;
            this.heading_lbl.Text = "Lithium Battery Test Software";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(440, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 12;
            this.button1.Text = "LOGIN";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 165);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "PASSWORD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "USERNAME";
            // 
            // PASSWORD
            // 
            this.PASSWORD.Location = new System.Drawing.Point(180, 165);
            this.PASSWORD.Name = "PASSWORD";
            this.PASSWORD.PasswordChar = '●';
            this.PASSWORD.Size = new System.Drawing.Size(208, 20);
            this.PASSWORD.TabIndex = 11;
            // 
            // USERNAME
            // 
            this.USERNAME.Location = new System.Drawing.Point(180, 97);
            this.USERNAME.Name = "USERNAME";
            this.USERNAME.Size = new System.Drawing.Size(208, 20);
            this.USERNAME.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // LOGIN_LOGIC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 196);
            this.Controls.Add(this.EXIT_LOGIC);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Version_lbl);
            this.Controls.Add(this.heading_lbl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PASSWORD);
            this.Controls.Add(this.USERNAME);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LOGIN_LOGIC";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EXIT_LOGIC;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Version_lbl;
        private System.Windows.Forms.Label heading_lbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PASSWORD;
        private System.Windows.Forms.TextBox USERNAME;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

