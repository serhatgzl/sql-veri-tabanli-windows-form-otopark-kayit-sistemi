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
    public class Arac
    {
        int _id;
        string? aracplaka;
        string? renk;
        string? model;
        string? yil;

        public int Id { get => _id; set => _id = value; }
        public string? Aracplaka { get => aracplaka; set => aracplaka = value; }
        public string? Renk { get => renk; set => renk = value; }
        public string? Model { get => model; set => model = value; }
        public string? Yil { get => yil; set => yil = value; }

        private static string myConn = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
        private const string Insertarac = "Insert Into Arac(arac_id, arac_plaka, renk, model, yil) Values (@AracId, @AracPlaka, @AracRenk, @AracModel, @AracYil)";
        public bool InsertArac(Arac arac)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(myConn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(Insertarac, con))
                {
                    com.Parameters.AddWithValue("@AracId", arac.Id);
                    com.Parameters.AddWithValue("@AracPlaka", arac.Aracplaka);
                    com.Parameters.AddWithValue("@AracRenk", arac.Renk);
                    com.Parameters.AddWithValue("@AracModel", arac.Model);
                    com.Parameters.AddWithValue("@AracYil", arac.Yil);
                    rows = com.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false;
        }

        private const string Updatearac = "Update Arac set arac_plaka=@AracPlaka, renk=@AracRenk, model=@AracModel, yil=@AracYil where arac_id=@AracId";

        public bool UpdateArac(Arac arac)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(myConn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(Updatearac, con))
                {
                    com.Parameters.AddWithValue("@AracId", arac.Id);
                    com.Parameters.AddWithValue("@AracPlaka", arac.Aracplaka);
                    com.Parameters.AddWithValue("@AracRenk", arac.Renk);
                    com.Parameters.AddWithValue("@AracModel", arac.Model);
                    com.Parameters.AddWithValue("@AracYil", arac.Yil);
                    rows = com.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false;
        }

        private const string Deletearac = "Delete from Arac where arac_id=@AracId";

        public bool DeleteArac(Arac arac)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(myConn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(Deletearac, con))
                {
                    com.Parameters.AddWithValue("@AracId", arac.Id);
                    rows = com.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false;
        }

        private const string SelectArac = "Select * from Arac";
        public DataTable GetArac()
        {
            var datatable = new DataTable();
            using (SqlConnection con = new SqlConnection(myConn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(SelectArac, con))
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
