using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Odev_4
{
    public class Musteri
    {
        int id;
        string? adSoyad;
        string? yas;
        string? telefon;

        public int Id { get => id; set => id = value; }
        public string? AdSoyad { get => adSoyad; set => adSoyad = value; }
        public string? Yas { get => yas; set => yas = value; }
        public string? Telefon { get => telefon; set => telefon = value; }

        private static string myConn = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
        private const string Insertmusteri = "Insert Into Musteri(Id, AdSoyad, Yas, Telefon) Values (@MusteriId, @MusteriAd, @MusteriYas, @MusteriTelefon)";
        public bool InsertMusteri(Musteri musteri)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(myConn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(Insertmusteri, con))
                {
                    com.Parameters.AddWithValue("@MusteriId", musteri.Id);
                    com.Parameters.AddWithValue("@MusteriAd", musteri.AdSoyad);
                    com.Parameters.AddWithValue("@MusteriYas", musteri.Yas);
                    com.Parameters.AddWithValue("@MusteriTelefon", musteri.Telefon);
                    rows = com.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false;
        }

        private const string Updatemusteri = "Update Musteri set AdSoyad=@MusteriAd, Yas=@MusteriYas, Telefon=@MusteriTelefon where Id=@MusteriId";

        public bool UpdateMusteri(Musteri musteri)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(myConn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(Updatemusteri, con))
                {
                    com.Parameters.AddWithValue("@MusteriId", musteri.Id);
                    com.Parameters.AddWithValue("@MusteriAd", musteri.AdSoyad);
                    com.Parameters.AddWithValue("@MusteriYas", musteri.Yas);
                    com.Parameters.AddWithValue("@MusteriTelefon", musteri.Telefon);
                    rows = com.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false;
        }

        private const string Deletemusteri = "Delete from Musteri where Id=@MusteriId";

        public bool DeleteMusteri(Musteri musteri)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(myConn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(Deletemusteri, con))
                {
                    com.Parameters.AddWithValue("@MusteriId", musteri.Id);
                    rows = com.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false;
        }

        private const string SelectMusteri = "Select * from Musteri";

        public DataTable GetMusteri()
        {
            var datatable = new DataTable();
            using (SqlConnection con = new SqlConnection(myConn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(SelectMusteri, con))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(com))
                    {
                        adapter.Fill(datatable);
                    }
                }
            }
            return datatable;
        }

    }

}
