using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Odev_4
{
    public class Abonelik
    {
        int _id;
        string? aboneliktip;
        string? sure;
        string? baslangic;
        string? bitis;
        string? ucret;

        public int Id { get => _id; set => _id = value; }
        public string? Aboneliktip { get => aboneliktip; set => aboneliktip = value; }
        public string? Sure { get => sure; set => sure = value; }
        public string? Baslangic { get => baslangic; set => baslangic = value; }
        public string? Bitis { get => bitis; set => bitis = value; }
        public string? Ucret { get => ucret; set => ucret = value; }

        private static string myConn = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
        private const string Insertabonelik = "Insert Into Abonelik(abonelikid, aboneliktip, sure, baslangic, bitis, ucret) Values (@Abonelikid, @Aboneliktip, @Sure, @Baslangic, @Bitis, @Ucret)";
        public bool InsertAbonelik(Abonelik abonelik)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(myConn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(Insertabonelik, con))
                {
                    com.Parameters.AddWithValue("@Abonelikid", abonelik.Id);
                    com.Parameters.AddWithValue("@Aboneliktip", abonelik.Aboneliktip);
                    com.Parameters.AddWithValue("@Sure", abonelik.Sure);
                    com.Parameters.AddWithValue("@Baslangic", abonelik.Baslangic);
                    com.Parameters.AddWithValue("@Bitis", abonelik.Bitis);
                    com.Parameters.AddWithValue("@Ucret", abonelik.Ucret);
                    rows = com.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false;
        }

        private const string Updateabonelik = "Update Abonelik set aboneliktip=@Aboneliktip, sure=@Sure, baslangic=@Baslangic,bitis=@Bitis, ucret=@Ucret  where abonelikid=@Abonelikid";

        public bool UpdateAbonelik(Abonelik abonelik)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(myConn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(Updateabonelik, con))
                {
                    com.Parameters.AddWithValue("@Abonelikid", abonelik.Id);
                    com.Parameters.AddWithValue("@Aboneliktip", abonelik.Aboneliktip);
                    com.Parameters.AddWithValue("@Sure", abonelik.Sure);
                    com.Parameters.AddWithValue("@Baslangic", abonelik.Baslangic);
                    com.Parameters.AddWithValue("@Bitis", abonelik.Bitis);
                    com.Parameters.AddWithValue("@Ucret", abonelik.Ucret);
                    rows = com.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false;
        }

        private const string Deleteabonelik = "Delete from Abonelik where abonelikid=@Abonelikid";

        public bool DeleteAbonelik(Abonelik abonelik)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(myConn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(Deleteabonelik, con))
                {
                    com.Parameters.AddWithValue("@Abonelikid", abonelik.Id);
                    rows = com.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false;
        }

        private const string Selectabonelik = "Select * from Abonelik";

        public DataTable GetAbonelik()
        {
            var datatable = new DataTable();
            using (SqlConnection con = new SqlConnection(myConn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(Selectabonelik, con))
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
