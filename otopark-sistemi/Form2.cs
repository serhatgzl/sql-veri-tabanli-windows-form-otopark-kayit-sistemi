using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_Odev_4
{
    public partial class Form2 : Form
    {
        Arac arac = new Arac();
        public Form2()
        {
            InitializeComponent();
            dgwArac.DataSource = arac.GetArac();
        }
        private void ClearControls()
        {
            txtId.Text = "";
            txtPlaka.Text = "";
            txtRenk.Text = "";
            txtModel.Text = "";
            txtYil.Text = "";
        }
        private void dgwMusteri_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgwArac.CurrentRow.Cells[0].Value.ToString();
            txtPlaka.Text = dgwArac.CurrentRow.Cells[1].Value.ToString();
            txtRenk.Text = dgwArac.CurrentRow.Cells[2].Value.ToString();
            txtModel.Text = dgwArac.CurrentRow.Cells[3].Value.ToString();
            txtYil.Text = dgwArac.CurrentRow.Cells[4].Value.ToString();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            arac.Id = Convert.ToInt32(txtId.Text);
            arac.Aracplaka = txtPlaka.Text;
            arac.Renk = txtRenk.Text;
            arac.Model = txtModel.Text;
            arac.Yil = txtYil.Text;

            var kontrol = arac.InsertArac(arac);
            dgwArac.DataSource = arac.GetArac();
            if (kontrol)
            {
                ClearControls();
                MessageBox.Show("Araç başarıyla eklendi.");
            }
            else
                MessageBox.Show("Hata!!!. Lütfen tekrar deneyin...");
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            arac.Id = Convert.ToInt32(txtId.Text);
            arac.Aracplaka = txtPlaka.Text;
            arac.Renk = txtRenk.Text;
            arac.Model = txtModel.Text;
            arac.Yil = txtYil.Text;

            var kontrol = arac.UpdateArac(arac);
            dgwArac.DataSource = arac.GetArac();
            if (kontrol)
            {
                ClearControls();
                MessageBox.Show("Araç bilgileri başarıyla güncellendi.");
            }
            else
                MessageBox.Show("Hata!!!. Lütfen tekrar deneyin...");
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            arac.Id = Convert.ToInt32(txtId.Text);
            var kontrol = arac.DeleteArac(arac);
            dgwArac.DataSource = arac.GetArac();
            if (kontrol)
            {
                ClearControls();
                MessageBox.Show("Araç başarıyla silindi.");
            }
            else
                MessageBox.Show("Hata!!!. Lütfen tekrar deneyin...");
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            ClearControls();
        }
    }
}
