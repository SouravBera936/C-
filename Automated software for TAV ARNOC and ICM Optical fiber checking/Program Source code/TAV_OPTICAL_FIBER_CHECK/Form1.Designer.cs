namespace TAV_OPTICAL_FIBER_CHECK
{
    partial class BOARD_SELECTION
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BOARD_SELECTION));
            this.USERNAME = new System.Windows.Forms.Button();
            this.SELECTION = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // USERNAME
            // 
            this.USERNAME.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.USERNAME.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.USERNAME.Font = new System.Drawing.Font("Viner Hand ITC", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.USERNAME.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.USERNAME.Location = new System.Drawing.Point(107, 116);
            this.USERNAME.Name = "USERNAME";
            this.USERNAME.Size = new System.Drawing.Size(152, 34);
            this.USERNAME.TabIndex = 46;
            this.USERNAME.Text = "BOARD SELECTION:";
            this.USERNAME.UseVisualStyleBackColor = false;
            // 
            // SELECTION
            // 
            this.SELECTION.AutoCompleteCustomSource.AddRange(new string[] {
            "FS-9001-29",
            "FS-9001-60"});
            this.SELECTION.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.SELECTION.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SELECTION.Items.AddRange(new object[] {
            "CARTE-ARNIC",
            "CARTE-ICM"});
            this.SELECTION.Location = new System.Drawing.Point(302, 119);
            this.SELECTION.Name = "SELECTION";
            this.SELECTION.Size = new System.Drawing.Size(163, 25);
            this.SELECTION.TabIndex = 44;
            this.SELECTION.SelectedIndexChanged += new System.EventHandler(this.SELECTION_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(551, 263);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // BOARD_SELECTION
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 261);
            this.Controls.Add(this.USERNAME);
            this.Controls.Add(this.SELECTION);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BOARD_SELECTION";
            this.Text = "BOARD_SELECTION";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button USERNAME;
        private System.Windows.Forms.ComboBox SELECTION;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

