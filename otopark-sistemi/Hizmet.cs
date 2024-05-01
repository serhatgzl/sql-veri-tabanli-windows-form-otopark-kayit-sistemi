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
    public class Hizmet
    {
        int _id;
        string? isim;
        string? plaka;
        string? girissaat;
        string? cikissaat;
        string? aboneliktipi;

        public int Id { get => _id; set => _id = value; }
        public string? Isim { get => isim; set => isim = value; }
        public string? Plaka { get => plaka; set => plaka = value; }
        public string? Girissaat { get => girissaat; set => girissaat = value; }
        public string? Cikissaat { get => cikissaat; set => cikissaat = value; }
        public string? Aboneliktipi { get => aboneliktipi; set => aboneliktipi = value; }

        private static string myConn = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
        private const string Inserthizmet = "Insert Into Hizmet(sira_id, isim, plaka, girissaat, cikissaat, aboneliktipi) Values (@Sira_id, @Isim, @Plaka, @Girissaat, @Cikissaat, @Aboneliktipi)";
        public bool InsertHizmet(Hizmet hizmet)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(myConn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(Inserthizmet, con))
                {
                    com.Parameters.AddWithValue("@Sira_id", hizmet.Id);
                    com.Parameters.AddWithValue("@Isim", hizmet.Isim);
                    com.Parameters.AddWithValue("@Plaka", hizmet.Plaka);
                    com.Parameters.AddWithValue("@Girissaat", hizmet.Girissaat);
                    com.Parameters.AddWithValue("@Cikissaat", hizmet.Cikissaat);
                    com.Parameters.AddWithValue("@Aboneliktipi", hizmet.Aboneliktipi);
                    rows = com.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false;
        }

        private const string Updatehizmet = "Update Hizmet set isim=@Isim, plaka=@Plaka, girissaat=@Girissaat,cikissaat=@Cikissaat, aboneliktipi=@Aboneliktipi  where sira_id=@Sira_id";

        public bool UpdateHizmet(Hizmet hizmet)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(myConn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(Updatehizmet, con))
                {
                    com.Parameters.AddWithValue("@Sira_id", hizmet.Id);
                    com.Parameters.AddWithValue("@Isim", hizmet.Isim);
                    com.Parameters.AddWithValue("@Plaka", hizmet.Plaka);
                    com.Parameters.AddWithValue("@Girissaat", hizmet.Girissaat);
                    com.Parameters.AddWithValue("@Cikissaat", hizmet.Cikissaat);
                    com.Parameters.AddWithValue("@Aboneliktipi", hizmet.Aboneliktipi);
                    rows = com.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false;
        }

        private const string Deletehizmet = "Delete from Hizmet where sira_id=@Sira_id";

        public bool DeleteHizmet(Hizmet hizmet)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(myConn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(Deletehizmet, con))
                {
                    com.Parameters.AddWithValue("@Sira_id", hizmet.Id);
                    rows = com.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false;
        }

        private const string Selecthizmet = "Select * from Hizmet";

        public DataTable GetHizmet()
        {
            var datatable = new DataTable();
            using (SqlConnection con = new SqlConnection(myConn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(Selecthizmet, con))
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
