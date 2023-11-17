namespace iconnet
{
    partial class FBeranda
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
            this.components = new System.ComponentModel.Container();
            this.lblname = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.btnlog = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnpelanggan = new System.Windows.Forms.Button();
            this.btnview = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(130, 34);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(76, 22);
            this.lblname.TabIndex = 1;
            this.lblname.Text = "<<name";
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.Location = new System.Drawing.Point(133, 68);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(56, 22);
            this.lbldate.TabIndex = 2;
            this.lbldate.Text = "<date";
            // 
            // btnlog
            // 
            this.btnlog.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnlog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlog.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnlog.Location = new System.Drawing.Point(324, 337);
            this.btnlog.Name = "btnlog";
            this.btnlog.Size = new System.Drawing.Size(342, 41);
            this.btnlog.TabIndex = 3;
            this.btnlog.Text = "Logout";
            this.btnlog.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(430, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 37);
            this.label4.TabIndex = 6;
            this.label4.Text = "Iconnet";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnpelanggan
            // 
            this.btnpelanggan.Location = new System.Drawing.Point(324, 199);
            this.btnpelanggan.Name = "btnpelanggan";
            this.btnpelanggan.Size = new System.Drawing.Size(342, 40);
            this.btnpelanggan.TabIndex = 7;
            this.btnpelanggan.Text = "Customer";
            this.btnpelanggan.UseVisualStyleBackColor = true;
            // 
            // btnview
            // 
            this.btnview.Location = new System.Drawing.Point(324, 273);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(342, 40);
            this.btnview.TabIndex = 8;
            this.btnview.Text = "View Data";
            this.btnview.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::iconnet.Properties.Resources.icon1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FBeranda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 524);
            this.Controls.Add(this.btnview);
            this.Controls.Add(this.btnpelanggan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnlog);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FBeranda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FBeranda";
            this.Load += new System.EventHandler(this.FBeranda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Button btnlog;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnpelanggan;
        private System.Windows.Forms.Button btnview;
    }
}