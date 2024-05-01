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
    public partial class Form3 : Form
    {

        Abonelik abonelik = new Abonelik();
        public Form3()
        {
            InitializeComponent();
            dgwAbonelik.DataSource = abonelik.GetAbonelik();
        }
        private void ClearControls()
        {
            textBox1.Text = "";
            comboBox1.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }
        private void dgwAbonelik_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dgwAbonelik.CurrentRow.Cells[0].Value.ToString();
            comboBox1.Text = dgwAbonelik.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dgwAbonelik.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dgwAbonelik.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dgwAbonelik.CurrentRow.Cells[4].Value.ToString();
            textBox6.Text = dgwAbonelik.CurrentRow.Cells[5].Value.ToString();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            string[] aboneliktipi = {
                "Tek Kullanımlık","Haftalık Abonelik","Aylık Abonelik","Yıllık Abonelik"
            };
            comboBox1.Items.AddRange(aboneliktipi);

        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            abonelik.Id = Convert.ToInt32(textBox1.Text);
            abonelik.Aboneliktip = comboBox1.Text;
            abonelik.Sure = textBox3.Text;
            abonelik.Baslangic = textBox4.Text;
            abonelik.Bitis = textBox5.Text;
            abonelik.Ucret = textBox6.Text;

            var kontrol = abonelik.InsertAbonelik(abonelik);
            dgwAbonelik.DataSource = abonelik.GetAbonelik();
            if (kontrol)
            {
                ClearControls();
                MessageBox.Show("Abonelik tipi başarıyla eklendi.");
            }
            else
                MessageBox.Show("Hata!!!. Lütfen tekrar deneyin...");
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            abonelik.Id = Convert.ToInt32(textBox1.Text);
            abonelik.Aboneliktip = comboBox1.Text;
            abonelik.Sure = textBox3.Text;
            abonelik.Baslangic = textBox4.Text;
            abonelik.Bitis = textBox5.Text;
            abonelik.Ucret = textBox6.Text;

            var kontrol = abonelik.InsertAbonelik(abonelik);
            dgwAbonelik.DataSource = abonelik.GetAbonelik();
            if (kontrol)
            {
                ClearControls();
                MessageBox.Show("Abonelik tipi bilgileri başarıyla güncellendi.");
            }
            else
                MessageBox.Show("Hata!!!. Lütfen tekrar deneyin...");
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            abonelik.Id = Convert.ToInt32(textBox1.Text);
            var kontrol = abonelik.DeleteAbonelik(abonelik);
            dgwAbonelik.DataSource = abonelik.GetAbonelik();
            if (kontrol)
            {
                ClearControls();
                MessageBox.Show("Abonelik tipi başarıyla silindi.");
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
