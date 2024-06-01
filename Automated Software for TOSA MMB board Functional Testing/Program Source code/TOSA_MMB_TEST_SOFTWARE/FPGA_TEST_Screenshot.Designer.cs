namespace TOSA_MMB_TEST_SOFTWARE
{
    partial class FPGA_TEST_Screenshot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FPGA_TEST_Screenshot));
            this.FAILLOGIC = new System.Windows.Forms.Button();
            this.PASSLOGIC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FAILLOGIC
            // 
            this.FAILLOGIC.BackColor = System.Drawing.SystemColors.Control;
            this.FAILLOGIC.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FAILLOGIC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.FAILLOGIC.Location = new System.Drawing.Point(869, 12);
            this.FAILLOGIC.Name = "FAILLOGIC";
            this.FAILLOGIC.Size = new System.Drawing.Size(103, 35);
            this.FAILLOGIC.TabIndex = 59;
            this.FAILLOGIC.Text = "FAIL";
            this.FAILLOGIC.UseVisualStyleBackColor = false;
            this.FAILLOGIC.Click += new System.EventHandler(this.FAILLOGIC_Click);
            // 
            // PASSLOGIC
            // 
            this.PASSLOGIC.BackColor = System.Drawing.SystemColors.Control;
            this.PASSLOGIC.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PASSLOGIC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.PASSLOGIC.Location = new System.Drawing.Point(316, 12);
            this.PASSLOGIC.Name = "PASSLOGIC";
            this.PASSLOGIC.Size = new System.Drawing.Size(107, 35);
            this.PASSLOGIC.TabIndex = 58;
            this.PASSLOGIC.Text = "PASS";
            this.PASSLOGIC.UseVisualStyleBackColor = false;
            this.PASSLOGIC.Click += new System.EventHandler(this.PASSLOGIC_Click);
            // 
            // FPGA_TEST_Screenshot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 741);
            this.Controls.Add(this.FAILLOGIC);
            this.Controls.Add(this.PASSLOGIC);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FPGA_TEST_Screenshot";
            this.Opacity = 0.3D;
            this.Text = "FPGA_TEST_Screenshot";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button FAILLOGIC;
        private System.Windows.Forms.Button PASSLOGIC;
    }
}