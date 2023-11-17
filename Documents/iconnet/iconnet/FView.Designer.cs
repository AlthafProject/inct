namespace iconnet
{
    partial class FView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idcollumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nikcollumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namecollumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nometerancollumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nohpcollumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailcollumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatcollumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kelurahancollumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kecamatancollumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kotacollumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lokasicollumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.layanancollumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prosescollumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.proccess = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcollumn,
            this.nikcollumn,
            this.namecollumn,
            this.nometerancollumn,
            this.nohpcollumn,
            this.emailcollumn,
            this.alamatcollumn,
            this.kelurahancollumn,
            this.kecamatancollumn,
            this.kotacollumn,
            this.lokasicollumn,
            this.layanancollumn,
            this.createdat,
            this.Prosescollumn,
            this.Action,
            this.proccess});
            this.dataGridView1.Location = new System.Drawing.Point(12, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1488, 328);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idcollumn
            // 
            this.idcollumn.DataPropertyName = "id";
            this.idcollumn.HeaderText = "ID";
            this.idcollumn.MinimumWidth = 6;
            this.idcollumn.Name = "idcollumn";
            this.idcollumn.Width = 125;
            // 
            // nikcollumn
            // 
            this.nikcollumn.DataPropertyName = "nik";
            this.nikcollumn.HeaderText = "NIK";
            this.nikcollumn.MinimumWidth = 6;
            this.nikcollumn.Name = "nikcollumn";
            this.nikcollumn.Width = 125;
            // 
            // namecollumn
            // 
            this.namecollumn.DataPropertyName = "name";
            this.namecollumn.HeaderText = "Name";
            this.namecollumn.MinimumWidth = 6;
            this.namecollumn.Name = "namecollumn";
            this.namecollumn.Width = 125;
            // 
            // nometerancollumn
            // 
            this.nometerancollumn.DataPropertyName = "nometeran";
            this.nometerancollumn.HeaderText = "Nomor Meteran";
            this.nometerancollumn.MinimumWidth = 6;
            this.nometerancollumn.Name = "nometerancollumn";
            this.nometerancollumn.Width = 125;
            // 
            // nohpcollumn
            // 
            this.nohpcollumn.DataPropertyName = "nohp";
            this.nohpcollumn.HeaderText = "Nomor Hp";
            this.nohpcollumn.MinimumWidth = 6;
            this.nohpcollumn.Name = "nohpcollumn";
            this.nohpcollumn.Width = 125;
            // 
            // emailcollumn
            // 
            this.emailcollumn.DataPropertyName = "email";
            this.emailcollumn.HeaderText = "Email";
            this.emailcollumn.MinimumWidth = 6;
            this.emailcollumn.Name = "emailcollumn";
            this.emailcollumn.Width = 125;
            // 
            // alamatcollumn
            // 
            this.alamatcollumn.DataPropertyName = "alamat";
            this.alamatcollumn.HeaderText = "Alamat";
            this.alamatcollumn.MinimumWidth = 6;
            this.alamatcollumn.Name = "alamatcollumn";
            this.alamatcollumn.Width = 125;
            // 
            // kelurahancollumn
            // 
            this.kelurahancollumn.DataPropertyName = "kelurahan";
            this.kelurahancollumn.HeaderText = "Kelurahan";
            this.kelurahancollumn.MinimumWidth = 6;
            this.kelurahancollumn.Name = "kelurahancollumn";
            this.kelurahancollumn.Width = 125;
            // 
            // kecamatancollumn
            // 
            this.kecamatancollumn.DataPropertyName = "kecamatan";
            this.kecamatancollumn.HeaderText = "Kecamatan";
            this.kecamatancollumn.MinimumWidth = 6;
            this.kecamatancollumn.Name = "kecamatancollumn";
            this.kecamatancollumn.Width = 125;
            // 
            // kotacollumn
            // 
            this.kotacollumn.DataPropertyName = "kabupaten";
            this.kotacollumn.HeaderText = "Kabupaten";
            this.kotacollumn.MinimumWidth = 6;
            this.kotacollumn.Name = "kotacollumn";
            this.kotacollumn.Width = 125;
            // 
            // lokasicollumn
            // 
            this.lokasicollumn.DataPropertyName = "titikkor";
            this.lokasicollumn.HeaderText = "Titik Kordinat";
            this.lokasicollumn.MinimumWidth = 6;
            this.lokasicollumn.Name = "lokasicollumn";
            this.lokasicollumn.Width = 125;
            // 
            // layanancollumn
            // 
            this.layanancollumn.DataPropertyName = "layanan";
            this.layanancollumn.HeaderText = "Layanan";
            this.layanancollumn.MinimumWidth = 6;
            this.layanancollumn.Name = "layanancollumn";
            this.layanancollumn.Width = 125;
            // 
            // createdat
            // 
            this.createdat.DataPropertyName = "created";
            this.createdat.HeaderText = "Created";
            this.createdat.MinimumWidth = 6;
            this.createdat.Name = "createdat";
            this.createdat.Width = 125;
            // 
            // Prosescollumn
            // 
            this.Prosescollumn.DataPropertyName = "proses";
            this.Prosescollumn.HeaderText = "proses";
            this.Prosescollumn.MinimumWidth = 6;
            this.Prosescollumn.Name = "Prosescollumn";
            this.Prosescollumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Prosescollumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Prosescollumn.Width = 125;
            // 
            // Action
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "Delete";
            this.Action.DefaultCellStyle = dataGridViewCellStyle1;
            this.Action.HeaderText = "Delete";
            this.Action.MinimumWidth = 6;
            this.Action.Name = "Action";
            this.Action.Width = 125;
            // 
            // proccess
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "Confirm";
            this.proccess.DefaultCellStyle = dataGridViewCellStyle2;
            this.proccess.HeaderText = "Proccess";
            this.proccess.MinimumWidth = 6;
            this.proccess.Name = "proccess";
            this.proccess.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(135, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(790, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1396, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(649, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 40);
            this.label2.TabIndex = 4;
            this.label2.Text = "View";
            // 
            // FView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1512, 464);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FView";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcollumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nikcollumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namecollumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nometerancollumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nohpcollumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailcollumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatcollumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kelurahancollumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kecamatancollumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kotacollumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lokasicollumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn layanancollumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prosescollumn;
        private System.Windows.Forms.DataGridViewButtonColumn Action;
        private System.Windows.Forms.DataGridViewButtonColumn proccess;
        private System.Windows.Forms.Label label2;
    }
}