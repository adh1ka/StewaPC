namespace StewaPC
{
    partial class productForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRfs = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cbxUser = new System.Windows.Forms.ComboBox();
            this.dgvPrd = new System.Windows.Forms.DataGridView();
            this.btnIns = new System.Windows.Forms.Button();
            this.btnUpd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPwd = new System.Windows.Forms.TextBox();
            this.tbUsn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPrd = new System.Windows.Forms.Button();
            this.btnCtgr = new System.Windows.Forms.Button();
            this.btnSell = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrd)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Controls.Add(this.btnRfs);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.cbxUser);
            this.panel1.Controls.Add(this.dgvPrd);
            this.panel1.Controls.Add(this.btnIns);
            this.panel1.Controls.Add(this.btnUpd);
            this.panel1.Controls.Add(this.btnDel);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbPwd);
            this.panel1.Controls.Add(this.tbUsn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(219, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1568, 660);
            this.panel1.TabIndex = 0;
            // 
            // btnRfs
            // 
            this.btnRfs.BackColor = System.Drawing.SystemColors.Control;
            this.btnRfs.FlatAppearance.BorderSize = 0;
            this.btnRfs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRfs.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRfs.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnRfs.Location = new System.Drawing.Point(1368, 62);
            this.btnRfs.Name = "btnRfs";
            this.btnRfs.Size = new System.Drawing.Size(132, 64);
            this.btnRfs.TabIndex = 24;
            this.btnRfs.Text = "Refresh";
            this.btnRfs.UseVisualStyleBackColor = false;
            this.btnRfs.Click += new System.EventHandler(this.button5_Click);
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
            this.comboBox1.Location = new System.Drawing.Point(1154, 102);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 24);
            this.comboBox1.TabIndex = 24;
            this.comboBox1.Text = "SELECT CATEGORY";
            // 
            // cbxUser
            // 
            this.cbxUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxUser.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxUser.ForeColor = System.Drawing.Color.DarkBlue;
            this.cbxUser.FormattingEnabled = true;
            this.cbxUser.Items.AddRange(new object[] {
            "ADMIN",
            "SELLER"});
            this.cbxUser.Location = new System.Drawing.Point(230, 445);
            this.cbxUser.Name = "cbxUser";
            this.cbxUser.Size = new System.Drawing.Size(157, 24);
            this.cbxUser.TabIndex = 23;
            this.cbxUser.Text = "Pilih Jabatan";
            // 
            // dgvPrd
            // 
            this.dgvPrd.AllowUserToAddRows = false;
            this.dgvPrd.AllowUserToDeleteRows = false;
            this.dgvPrd.AllowUserToResizeColumns = false;
            this.dgvPrd.AllowUserToResizeRows = false;
            this.dgvPrd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrd.Location = new System.Drawing.Point(655, 152);
            this.dgvPrd.Name = "dgvPrd";
            this.dgvPrd.RowHeadersWidth = 51;
            this.dgvPrd.Size = new System.Drawing.Size(887, 471);
            this.dgvPrd.TabIndex = 22;
            // 
            // btnIns
            // 
            this.btnIns.BackColor = System.Drawing.SystemColors.Control;
            this.btnIns.FlatAppearance.BorderSize = 0;
            this.btnIns.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIns.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIns.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnIns.Location = new System.Drawing.Point(186, 513);
            this.btnIns.Name = "btnIns";
            this.btnIns.Size = new System.Drawing.Size(103, 84);
            this.btnIns.TabIndex = 21;
            this.btnIns.Text = "ADD";
            this.btnIns.UseVisualStyleBackColor = false;
            // 
            // btnUpd
            // 
            this.btnUpd.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpd.FlatAppearance.BorderSize = 0;
            this.btnUpd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpd.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnUpd.Location = new System.Drawing.Point(321, 513);
            this.btnUpd.Name = "btnUpd";
            this.btnUpd.Size = new System.Drawing.Size(99, 84);
            this.btnUpd.TabIndex = 20;
            this.btnUpd.Text = "EDIT";
            this.btnUpd.UseVisualStyleBackColor = false;
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.SystemColors.Control;
            this.btnDel.FlatAppearance.BorderSize = 0;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnDel.Location = new System.Drawing.Point(449, 513);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(98, 84);
            this.btnDel.TabIndex = 19;
            this.btnDel.Text = "DELETE";
            this.btnDel.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(230, 398);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(317, 25);
            this.textBox3.TabIndex = 18;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(230, 200);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(317, 32);
            this.textBox4.TabIndex = 17;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(129, 401);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "Password";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(129, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "Username";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(230, 249);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(317, 32);
            this.textBox2.TabIndex = 13;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(129, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Password";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(129, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Username";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // tbPwd
            // 
            this.tbPwd.BackColor = System.Drawing.Color.White;
            this.tbPwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPwd.Location = new System.Drawing.Point(230, 353);
            this.tbPwd.Name = "tbPwd";
            this.tbPwd.Size = new System.Drawing.Size(317, 25);
            this.tbPwd.TabIndex = 10;
            this.tbPwd.TextChanged += new System.EventHandler(this.tbPwd_TextChanged);
            // 
            // tbUsn
            // 
            this.tbUsn.Location = new System.Drawing.Point(230, 301);
            this.tbUsn.Name = "tbUsn";
            this.tbUsn.Size = new System.Drawing.Size(317, 32);
            this.tbUsn.TabIndex = 9;
            this.tbUsn.TextChanged += new System.EventHandler(this.tbUsn_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(129, 445);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(133, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Username";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(687, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(310, 37);
            this.label3.TabIndex = 6;
            this.label3.Text = "MANAGE PRODUCTS";
            // 
            // btnPrd
            // 
            this.btnPrd.BackColor = System.Drawing.SystemColors.Control;
            this.btnPrd.FlatAppearance.BorderSize = 0;
            this.btnPrd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrd.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnPrd.Location = new System.Drawing.Point(29, 146);
            this.btnPrd.Name = "btnPrd";
            this.btnPrd.Size = new System.Drawing.Size(164, 84);
            this.btnPrd.TabIndex = 1;
            this.btnPrd.Text = "Product";
            this.btnPrd.UseVisualStyleBackColor = false;
            this.btnPrd.Click += new System.EventHandler(this.btnPrd_Click);
            // 
            // btnCtgr
            // 
            this.btnCtgr.BackColor = System.Drawing.SystemColors.Control;
            this.btnCtgr.FlatAppearance.BorderSize = 0;
            this.btnCtgr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCtgr.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCtgr.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnCtgr.Location = new System.Drawing.Point(29, 251);
            this.btnCtgr.Name = "btnCtgr";
            this.btnCtgr.Size = new System.Drawing.Size(164, 84);
            this.btnCtgr.TabIndex = 2;
            this.btnCtgr.Text = "Categories";
            this.btnCtgr.UseVisualStyleBackColor = false;
            // 
            // btnSell
            // 
            this.btnSell.BackColor = System.Drawing.SystemColors.Control;
            this.btnSell.FlatAppearance.BorderSize = 0;
            this.btnSell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSell.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSell.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnSell.Location = new System.Drawing.Point(29, 355);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(164, 84);
            this.btnSell.TabIndex = 3;
            this.btnSell.Text = "Seller";
            this.btnSell.UseVisualStyleBackColor = false;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Control;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnExit.Location = new System.Drawing.Point(1707, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 74);
            this.btnExit.TabIndex = 23;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // productForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1799, 764);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSell);
            this.Controls.Add(this.btnCtgr);
            this.Controls.Add(this.btnPrd);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "productForm";
            this.Text = "productForm";
            this.Load += new System.EventHandler(this.productForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPrd;
        private System.Windows.Forms.Button btnCtgr;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPwd;
        private System.Windows.Forms.TextBox tbUsn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPrd;
        private System.Windows.Forms.Button btnIns;
        private System.Windows.Forms.Button btnUpd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRfs;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox cbxUser;
    }
}