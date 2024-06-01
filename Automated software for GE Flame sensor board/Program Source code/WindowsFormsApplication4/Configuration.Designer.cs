namespace WindowsFormsApplication4
{
    partial class Configuration
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
            this.usl_txtbx = new System.Windows.Forms.TextBox();
            this.lsl_txtbx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.heading_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usl_txtbx
            // 
            this.usl_txtbx.Location = new System.Drawing.Point(250, 63);
            this.usl_txtbx.Name = "usl_txtbx";
            this.usl_txtbx.Size = new System.Drawing.Size(100, 20);
            this.usl_txtbx.TabIndex = 20;
            // 
            // lsl_txtbx
            // 
            this.lsl_txtbx.Location = new System.Drawing.Point(122, 63);
            this.lsl_txtbx.Name = "lsl_txtbx";
            this.lsl_txtbx.Size = new System.Drawing.Size(100, 20);
            this.lsl_txtbx.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "USL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "LSL";
            // 
            // heading_lbl
            // 
            this.heading_lbl.AutoSize = true;
            this.heading_lbl.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heading_lbl.ForeColor = System.Drawing.Color.Crimson;
            this.heading_lbl.Location = new System.Drawing.Point(73, 9);
            this.heading_lbl.Name = "heading_lbl";
            this.heading_lbl.Size = new System.Drawing.Size(301, 25);
            this.heading_lbl.TabIndex = 16;
            this.heading_lbl.Text = "Flame Sensor Configuration";
            // 
            // Configuration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 111);
            this.Controls.Add(this.usl_txtbx);
            this.Controls.Add(this.lsl_txtbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.heading_lbl);
            this.Name = "Configuration";
            this.Text = "e";
            this.Load += new System.EventHandler(this.Configuration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usl_txtbx;
        private System.Windows.Forms.TextBox lsl_txtbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label heading_lbl;
    }
}