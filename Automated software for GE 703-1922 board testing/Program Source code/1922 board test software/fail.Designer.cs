namespace _1922_board_test_software
{
    partial class fail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fail));
            this.FAIL_LOGIC = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // FAIL_LOGIC
            // 
            this.FAIL_LOGIC.BackColor = System.Drawing.Color.Lime;
            this.FAIL_LOGIC.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FAIL_LOGIC.ForeColor = System.Drawing.Color.Black;
            this.FAIL_LOGIC.Location = new System.Drawing.Point(390, 308);
            this.FAIL_LOGIC.Name = "FAIL_LOGIC";
            this.FAIL_LOGIC.Size = new System.Drawing.Size(87, 43);
            this.FAIL_LOGIC.TabIndex = 5;
            this.FAIL_LOGIC.Text = "OK";
            this.FAIL_LOGIC.UseVisualStyleBackColor = false;
            this.FAIL_LOGIC.Click += new System.EventHandler(this.FAIL_LOGIC_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(489, 369);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // fail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 357);
            this.Controls.Add(this.FAIL_LOGIC);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fail";
            this.Text = "fail";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button FAIL_LOGIC;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}