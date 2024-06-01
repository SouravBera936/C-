namespace TAV_PSU_CP_Programming
{
    partial class Programming
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Programming));
            this.FAIL_LOGIC = new System.Windows.Forms.Button();
            this.PASS_LOGIC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FAIL_LOGIC
            // 
            this.FAIL_LOGIC.BackColor = System.Drawing.SystemColors.Control;
            this.FAIL_LOGIC.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FAIL_LOGIC.ForeColor = System.Drawing.Color.Red;
            this.FAIL_LOGIC.Location = new System.Drawing.Point(864, 12);
            this.FAIL_LOGIC.Name = "FAIL_LOGIC";
            this.FAIL_LOGIC.Size = new System.Drawing.Size(108, 34);
            this.FAIL_LOGIC.TabIndex = 59;
            this.FAIL_LOGIC.Text = "FAIL";
            this.FAIL_LOGIC.UseVisualStyleBackColor = false;
            this.FAIL_LOGIC.Click += new System.EventHandler(this.button1_Click);
            // 
            // PASS_LOGIC
            // 
            this.PASS_LOGIC.BackColor = System.Drawing.SystemColors.Control;
            this.PASS_LOGIC.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PASS_LOGIC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.PASS_LOGIC.Location = new System.Drawing.Point(3, 12);
            this.PASS_LOGIC.Name = "PASS_LOGIC";
            this.PASS_LOGIC.Size = new System.Drawing.Size(110, 34);
            this.PASS_LOGIC.TabIndex = 58;
            this.PASS_LOGIC.Text = "PASS";
            this.PASS_LOGIC.UseVisualStyleBackColor = false;
            this.PASS_LOGIC.Click += new System.EventHandler(this.button2_Click);
            // 
            // Programming
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 741);
            this.Controls.Add(this.FAIL_LOGIC);
            this.Controls.Add(this.PASS_LOGIC);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Programming";
            this.Opacity = 0.3D;
            this.Text = "Programming";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button FAIL_LOGIC;
        private System.Windows.Forms.Button PASS_LOGIC;
    }
}