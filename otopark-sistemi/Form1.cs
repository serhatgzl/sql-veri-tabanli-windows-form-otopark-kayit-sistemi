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
    public partial class Form1 : Form
    {
        Musteri musteri = new Musteri();
        public Form1()
        {
            InitializeComponent();
            dgwMusteri.DataSource = musteri.GetMusteri();
        }
        private void ClearControls()
        {
            txtId.Text = "";
            txtAdSoyad.Text = "";
            txtYas.Text = "";
            txtTelefon.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e) { }
        private void dgwMusteri_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgwMusteri.CurrentRow.Cells[0].Value.ToString();
            txtAdSoyad.Text = dgwMusteri.CurrentRow.Cells[1].Value.ToString();
            txtYas.Text = dgwMusteri.CurrentRow.Cells[2].Value.ToString();
            txtTelefon.Text = dgwMusteri.CurrentRow.Cells[3].Value.ToString();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            musteri.Id = Convert.ToInt32(txtId.Text);
            musteri.AdSoyad = txtAdSoyad.Text;
            musteri.Yas = txtYas.Text;
            musteri.Telefon = txtTelefon.Text;

            var kontrol = musteri.InsertMusteri(musteri);
            dgwMusteri.DataSource = musteri.GetMusteri();
            if (kontrol)
            {
                ClearControls();
                MessageBox.Show("Müþteri baþarýyla eklendi.");
            }
            else
                MessageBox.Show("Hata!!!. Lütfen tekrar deneyin...");
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            musteri.Id = Convert.ToInt32(txtId.Text);
            musteri.AdSoyad = txtAdSoyad.Text;
            musteri.Yas = txtYas.Text;
            musteri.Telefon = txtTelefon.Text;

            var kontrol = musteri.UpdateMusteri(musteri);
            dgwMusteri.DataSource = musteri.GetMusteri();
            if (kontrol)
            {
                ClearControls();
                MessageBox.Show("Müþteri bilgileri baþarýyla güncellendi.");
            }
            else
                MessageBox.Show("Hata!!!. Lütfen tekrar deneyin...");
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            musteri.Id = Convert.ToInt32(txtId.Text);
            var kontrol = musteri.DeleteMusteri(musteri);
            dgwMusteri.DataSource = musteri.GetMusteri();
            if (kontrol)
            {
                ClearControls();
                MessageBox.Show("Müþteri baþarýyla silindi.");
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