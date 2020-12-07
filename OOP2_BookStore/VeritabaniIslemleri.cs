using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_BookStore
{
    public class VeritabaniIslemleri
    {
		private static SqlConnection baglanti;
        private static VeritabaniIslemleri nesne;
        private VeritabaniIslemleri()
        { }
        public static VeritabaniIslemleri bagOlustur(string veritabaniAdi)
        {
            baglanti = new SqlConnection("Data Source=.; Initial Catalog=" + veritabaniAdi + "; Integrated Security=true");
            if (nesne==null)
                nesne = new VeritabaniIslemleri();
            return nesne;
        }
        public DataTable veriCek(string kolonAdi,string tabloAdi)
        {
            baglanti.Open();
            DataTable tablo = new DataTable();
            string sorgu = "SELECT " + kolonAdi + " FROM " + tabloAdi;
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataAdapter adaptor = new SqlDataAdapter(komut);
            adaptor.Fill(tablo);
            baglanti.Close();
            return tablo;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sorgu"></param>
        /// <returns></returns>
        public DataTable veriCek(string sorgu)
        {
			baglanti.Open();
			DataTable tablo = new DataTable();
			SqlCommand komut = new SqlCommand(sorgu, baglanti);
			SqlDataAdapter adaptor = new SqlDataAdapter(komut);
            adaptor.Fill(tablo);
			baglanti.Close();
            return tablo;
        }
        public void dataUpdate(string column,string values, string tableName,string condition)
        {
            string queryPart = null;
            string[] columnsNames = column.Split(',');
            string[] columnsValues = values.Split('#');
            if (columnsNames.Length==columnsValues.Length)
            {
                baglanti.Open();
                int i = 0;
                foreach (string item in columnsNames)
                {
                    if (queryPart != null)
                        queryPart += ",";
                    queryPart += item + "=" + columnsValues[i++];
                }
                string query = "UPDATE " + tableName + " SET " + queryPart + " WHERE " + condition;
                SqlCommand komut = new SqlCommand(query, baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("counts of columns and values should have same parameter count");
            }
        }
        public void veriKaydet(string kolonAdlari,string degerler,string tabloAdi)
        {
            string sorgu = "INSERT INTO " + tabloAdi + "(" + kolonAdlari + ") VALUES (" + degerler + ")";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        public void veriKaydet(string sorgu)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        public void veriKaydet(string resimYolu,string tabloAdi,string resimKolonAdi,string idKolonAdi,int musteriId)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO "+tabloAdi+"("+idKolonAdi+","+resimKolonAdi+") SELECT " + musteriId+", BulkColumn FROM OpenrowSet(Bulk'" +resimYolu + "', SINGLE_BLOB) as image",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        public void deleteData(string condition, string tableName)
        {
            baglanti.Open();
            string query = "UPDATE " + tableName + " SET visibility=0 WHERE " + condition;
            SqlCommand command = new SqlCommand(query, baglanti);
            command.ExecuteNonQuery();
            baglanti.Close();
        }
    }
}
