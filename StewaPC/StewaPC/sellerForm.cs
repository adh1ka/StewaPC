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
    public partial class sellerForm : Form
    {
        public sellerForm()
        {
            InitializeComponent();
        }

        public void employee()
        {
            string[] namaKolom = { "nama", "email", "role", "hp" };
            connection.tampil("employee", namaKolom, dgvSlr);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sellerForm_Load(object sender, EventArgs e)
        {
            string[] namaKolom = { "nama", "email", "role", "hp"};
            connection.tampil("employee", namaKolom, dgvSlr);
        }

        private void btnIns_Click(object sender, EventArgs e)
        {
            string[] namaKolom = { "nama", "email", "role", "hp" };
            string[] value = {tbNama.Text, tbEmail.Text, cbxSeller.Text, tbHP.Text};
            connection.insert("employee", namaKolom, value);
        }

        private void btnUpd_Click(object sender, EventArgs e)
        {
            string[] namaKolom = { "nama", "email", "role", "hp" };
            string[] value = {tbNama.Text, tbEmail.Text, cbxSeller.Text, tbHP.Text};
            connection.update("employee", namaKolom, value, id);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string[] namaKolom = { "nama", "email", "role", "hp" };
            string[] value = { tbNama.Text, tbEmail.Text, cbxSeller.Text, tbHP.Text };
            if (connection.getId("employee", namaKolom, value) == 0)
            {
                MessageBox.Show("Data Tidak Ditemukan");
            }
            else
            {
                try
                {
                    string[] nK = { "nama", "email", "role", "hp" };
                    connection.delete("employee", connection.getId("employee", namaKolom, value));
                    connection.tampil("employee", namaKolom, dgvSlr);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Delete Error");
                }
            }
            
        }
        public int id;

        private void dgvSlr_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = dgvSlr.Rows[e.RowIndex];
            tbNama.Text = row.Cells[0].Value.ToString();
            tbEmail.Text = row.Cells[1].Value.ToString();
            cbxSeller.Text = row.Cells[2].Value.ToString();
            tbHP.Text = row.Cells[3].Value.ToString();

            string[] namaKolom = { "nama", "email", "role", "hp" };
            string[] value = { tbNama.Text, tbEmail.Text, cbxSeller.Text, tbHP.Text };
            id = connection.getId("employee", namaKolom, value);

        }

        private void btnPrd_Click(object sender, EventArgs e)
        {
            this.Hide();
            productForm pdF = new productForm();
            pdF.ShowDialog();
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            this.Hide();
            sellerForm slF = new sellerForm();
            slF.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            connection.exit();
        }
    }
}
