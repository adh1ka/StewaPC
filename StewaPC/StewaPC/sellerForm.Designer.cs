namespace StewaPC
{
    partial class sellerForm
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRfs = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cbxSeller = new System.Windows.Forms.ComboBox();
            this.dgvSlr = new System.Windows.Forms.DataGridView();
            this.btnIns = new System.Windows.Forms.Button();
            this.btnUpd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.tbHP = new System.Windows.Forms.TextBox();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCtgr = new System.Windows.Forms.Button();
            this.btnPrd = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSell = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSlr)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Control;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnExit.Location = new System.Drawing.Point(1273, 26);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(60, 60);
            this.btnExit.TabIndex = 28;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRfs
            // 
            this.btnRfs.BackColor = System.Drawing.SystemColors.Control;
            this.btnRfs.FlatAppearance.BorderSize = 0;
            this.btnRfs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRfs.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRfs.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnRfs.Location = new System.Drawing.Point(1026, 50);
            this.btnRfs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRfs.Name = "btnRfs";
            this.btnRfs.Size = new System.Drawing.Size(99, 52);
            this.btnRfs.TabIndex = 24;
            this.btnRfs.Text = "Refresh";
            this.btnRfs.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.DarkBlue;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ADMIN",
            "SELLER"});
            this.comboBox1.Location = new System.Drawing.Point(866, 83);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(136, 22);
            this.comboBox1.TabIndex = 24;
            this.comboBox1.Text = "SELECT CATEGORY";
            // 
            // cbxSeller
            // 
            this.cbxSeller.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxSeller.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSeller.ForeColor = System.Drawing.Color.DarkBlue;
            this.cbxSeller.FormattingEnabled = true;
            this.cbxSeller.Items.AddRange(new object[] {
            "ADMIN",
            "SELLER"});
            this.cbxSeller.Location = new System.Drawing.Point(172, 347);
            this.cbxSeller.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxSeller.Name = "cbxSeller";
            this.cbxSeller.Size = new System.Drawing.Size(239, 22);
            this.cbxSeller.TabIndex = 23;
            this.cbxSeller.Text = "Pilih Jabatan";
            // 
            // dgvSlr
            // 
            this.dgvSlr.AllowUserToAddRows = false;
            this.dgvSlr.AllowUserToDeleteRows = false;
            this.dgvSlr.AllowUserToResizeColumns = false;
            this.dgvSlr.AllowUserToResizeRows = false;
            this.dgvSlr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSlr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSlr.Location = new System.Drawing.Point(495, 129);
            this.dgvSlr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvSlr.Name = "dgvSlr";
            this.dgvSlr.RowHeadersWidth = 51;
            this.dgvSlr.Size = new System.Drawing.Size(665, 383);
            this.dgvSlr.TabIndex = 22;
            this.dgvSlr.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSlr_CellMouseClick);
            // 
            // btnIns
            // 
            this.btnIns.BackColor = System.Drawing.SystemColors.Control;
            this.btnIns.FlatAppearance.BorderSize = 0;
            this.btnIns.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIns.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIns.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnIns.Location = new System.Drawing.Point(172, 417);
            this.btnIns.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIns.Name = "btnIns";
            this.btnIns.Size = new System.Drawing.Size(70, 55);
            this.btnIns.TabIndex = 21;
            this.btnIns.Text = "ADD";
            this.btnIns.UseVisualStyleBackColor = false;
            this.btnIns.Click += new System.EventHandler(this.btnIns_Click);
            // 
            // btnUpd
            // 
            this.btnUpd.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpd.FlatAppearance.BorderSize = 0;
            this.btnUpd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpd.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnUpd.Location = new System.Drawing.Point(258, 417);
            this.btnUpd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpd.Name = "btnUpd";
            this.btnUpd.Size = new System.Drawing.Size(65, 55);
            this.btnUpd.TabIndex = 20;
            this.btnUpd.Text = "EDIT";
            this.btnUpd.UseVisualStyleBackColor = false;
            this.btnUpd.Click += new System.EventHandler(this.btnUpd_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.SystemColors.Control;
            this.btnDel.FlatAppearance.BorderSize = 0;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnDel.Location = new System.Drawing.Point(337, 417);
            this.btnDel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(74, 55);
            this.btnDel.TabIndex = 19;
            this.btnDel.Text = "DELETE";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // tbHP
            // 
            this.tbHP.BackColor = System.Drawing.Color.White;
            this.tbHP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbHP.Location = new System.Drawing.Point(172, 284);
            this.tbHP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbHP.Name = "tbHP";
            this.tbHP.Size = new System.Drawing.Size(238, 20);
            this.tbHP.TabIndex = 18;
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(172, 162);
            this.tbNama.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(239, 27);
            this.tbNama.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(97, 287);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "HP";
            // 
            // btnCtgr
            // 
            this.btnCtgr.BackColor = System.Drawing.SystemColors.Control;
            this.btnCtgr.FlatAppearance.BorderSize = 0;
            this.btnCtgr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCtgr.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCtgr.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnCtgr.Location = new System.Drawing.Point(14, 220);
            this.btnCtgr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCtgr.Name = "btnCtgr";
            this.btnCtgr.Size = new System.Drawing.Size(123, 68);
            this.btnCtgr.TabIndex = 26;
            this.btnCtgr.Text = "Categories";
            this.btnCtgr.UseVisualStyleBackColor = false;
            // 
            // btnPrd
            // 
            this.btnPrd.BackColor = System.Drawing.SystemColors.Control;
            this.btnPrd.FlatAppearance.BorderSize = 0;
            this.btnPrd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrd.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnPrd.Location = new System.Drawing.Point(14, 135);
            this.btnPrd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPrd.Name = "btnPrd";
            this.btnPrd.Size = new System.Drawing.Size(123, 68);
            this.btnPrd.TabIndex = 25;
            this.btnPrd.Text = "Product";
            this.btnPrd.UseVisualStyleBackColor = false;
            this.btnPrd.Click += new System.EventHandler(this.btnPrd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(97, 167);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Nama";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(172, 221);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(239, 27);
            this.tbEmail.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(97, 226);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(97, 347);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Role";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(515, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "MANAGE SELLER";
            // 
            // btnSell
            // 
            this.btnSell.BackColor = System.Drawing.SystemColors.Control;
            this.btnSell.FlatAppearance.BorderSize = 0;
            this.btnSell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSell.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSell.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnSell.Location = new System.Drawing.Point(14, 305);
            this.btnSell.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(123, 68);
            this.btnSell.TabIndex = 27;
            this.btnSell.Text = "Seller";
            this.btnSell.UseVisualStyleBackColor = false;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Controls.Add(this.btnRfs);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.cbxSeller);
            this.panel1.Controls.Add(this.dgvSlr);
            this.panel1.Controls.Add(this.btnIns);
            this.panel1.Controls.Add(this.btnUpd);
            this.panel1.Controls.Add(this.btnDel);
            this.panel1.Controls.Add(this.tbHP);
            this.panel1.Controls.Add(this.tbNama);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tbEmail);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(157, 91);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1176, 536);
            this.panel1.TabIndex = 24;
            // 
            // sellerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 654);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCtgr);
            this.Controls.Add(this.btnPrd);
            this.Controls.Add(this.btnSell);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "sellerForm";
            this.Text = "sellerForm";
            this.Load += new System.EventHandler(this.sellerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSlr)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRfs;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox cbxSeller;
        private System.Windows.Forms.DataGridView dgvSlr;
        private System.Windows.Forms.Button btnIns;
        private System.Windows.Forms.Button btnUpd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.TextBox tbHP;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCtgr;
        private System.Windows.Forms.Button btnPrd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Panel panel1;
    }
}