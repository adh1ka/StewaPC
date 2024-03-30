using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StewaPC
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }
        void clear()
        {
            tbUsn.Text = string.Empty;
            tbPwd.Text = string.Empty;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbUsn.Text == "" || tbPwd.Text == "" || cbxUser.Text == "")
            {
                MessageBox.Show("Masukkan Data Terlebih Dahulu", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string[] namaKolom = { "email", "pwd" };
                string[] value = { tbUsn.Text, tbPwd.Text };
                //if(connection.validate("employee", namaKolom, value))
                //{
                    MessageBox.Show("Selamat Datang Kembali " + tbUsn.Text + "", "Login Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                    sellerForm sf = new sellerForm();
                    this.Hide();
                    sf.Show();
                //}
                //else
                //{
                //    MessageBox.Show("Username atau Password yang Anda Masukkan Belum Tepat", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error );
                //}
                
                
            }
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            tbPwd.PasswordChar = '*';
        }

        private void label4_Click(object sender, EventArgs e)
        {
            connection.exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void cbxUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            string pilihan = cbxUser.SelectedItem.ToString();
        }

        private void cbxUser_MouseClick(object sender, MouseEventArgs e)
        {
            cbxUser.Text = string.Empty;
        }
    }
}
