using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SQL_Odev_4
{
    public partial class Form4 : Form
    {

        Hizmet hizmet = new Hizmet();
        private static string myConn = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
        SqlConnection con = new SqlConnection(myConn);
        public Form4()
        {
            InitializeComponent();
            dgwHizmet.DataSource = hizmet.GetHizmet();
        }
        private void ClearControls()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
        }
        private void dgwMusteri_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dgwHizmet.CurrentRow.Cells[0].Value.ToString();
            comboBox1.Text = dgwHizmet.CurrentRow.Cells[1].Value.ToString();
            comboBox2.Text = dgwHizmet.CurrentRow.Cells[2].Value.ToString();
            textBox2.Text = dgwHizmet.CurrentRow.Cells[3].Value.ToString();
            textBox3.Text = dgwHizmet.CurrentRow.Cells[4].Value.ToString();
            comboBox3.Text = dgwHizmet.CurrentRow.Cells[5].Value.ToString();

        }
        private void Form4_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Musteri", con);
            SqlDataReader dr;
            con.Open();
            dr = komut.ExecuteReader();
            while(dr.Read())
            {
                comboBox1.Items.Add(dr["AdSoyad"]);
            }
            con.Close();

            SqlCommand komut2 = new SqlCommand("Select * From Arac", con);
            con.Open();
            dr = komut2.ExecuteReader();
            while (dr.Read())
            {
                comboBox2.Items.Add(dr["arac_plaka"]);
            }
            con.Close();

            SqlCommand komut3 = new SqlCommand("Select * From Abonelik", con);
            con.Open();
            dr = komut3.ExecuteReader();
            while (dr.Read())
            {
                comboBox3.Items.Add(dr["aboneliktip"]);
            }
            con.Close();

        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            hizmet.Id = Convert.ToInt32(textBox1.Text);
            hizmet.Isim = comboBox1.Text;
            hizmet.Plaka = comboBox2.Text;
            hizmet.Girissaat = textBox2.Text;
            hizmet.Cikissaat = textBox3.Text;
            hizmet.Aboneliktipi = comboBox3.Text;

            var kontrol = hizmet.InsertHizmet(hizmet);
            dgwHizmet.DataSource = hizmet.GetHizmet();
            if (kontrol)
            {
                ClearControls();
                MessageBox.Show("Park kayıt işlemi başarıyla eklendi.");
            }
            else
                MessageBox.Show("Hata!!!. Lütfen tekrar deneyin...");
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            hizmet.Id = Convert.ToInt32(textBox1.Text);
            hizmet.Isim = comboBox1.Text;
            hizmet.Plaka = comboBox2.Text;
            hizmet.Girissaat = textBox2.Text;
            hizmet.Cikissaat = textBox3.Text;
            hizmet.Aboneliktipi = comboBox3.Text;

            var kontrol = hizmet.UpdateHizmet(hizmet);
            dgwHizmet.DataSource = hizmet.GetHizmet();
            if (kontrol)
            {
                ClearControls();
                MessageBox.Show("Park kayıt işlemi başarıyla eklendi.");
            }
            else
                MessageBox.Show("Hata!!!. Lütfen tekrar deneyin...");
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            hizmet.Id = Convert.ToInt32(textBox1.Text);
            var kontrol = hizmet.DeleteHizmet(hizmet);
            dgwHizmet.DataSource = hizmet.GetHizmet();
            if (kontrol)
            {
                ClearControls();
                MessageBox.Show("Park kayıt işlemi başarıyla eklendi.");
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
