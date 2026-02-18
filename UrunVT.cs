using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace StokTakip
{
    internal class UrunVT
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-JKNOO9P\SQLEXPRESS;Initial Catalog=StokTakip;Integrated Security=True;");

        public List<Urun> Liste()
        {
            List<Urun> urn = new List<Urun>();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from Urunler", baglanti);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                Urun u = new Urun();
                u.ID = Convert.ToInt32(reader[0].ToString());
                u.URUNAD = reader[1].ToString();
                u.KATEGORI = reader[2].ToString();
                u.STOKADET = Convert.ToInt32(reader[3].ToString());
                u.FIYAT = Convert.ToDecimal(reader[4].ToString()); ;
                urn.Add(u);
            }
            baglanti.Close();
            return urn;
        }

        public void UrunEkle(Urun un)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Insert into Urunler (URUNAD,KATEGORI,STOKADET,FIYAT) values (@p1,@p2,@p3,@p4)",baglanti);
            komut.Parameters.AddWithValue("@p1",un.URUNAD);
            komut.Parameters.AddWithValue("@p2", un.KATEGORI);
            komut.Parameters.AddWithValue("@p3", un.STOKADET);
            komut.Parameters.AddWithValue("@p4",un.FIYAT);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ekleme Yapıldı."); 
        }

        public void UrunGuncelle(Urun un)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("UPDATE Urunler SET URUNAD=@p1,KATEGORI=@p2,STOKADET=@p3,FIYAT=@p4 where ID=@p5",baglanti);
            komut.Parameters.AddWithValue("@p1", un.URUNAD);
            komut.Parameters.AddWithValue("@p2", un.KATEGORI);
            komut.Parameters.AddWithValue("@p3", un.STOKADET);
            komut.Parameters.AddWithValue("@p4", un.FIYAT);
            komut.Parameters.AddWithValue("@p5", un.ID);
            komut.ExecuteNonQuery();
            baglanti.Close() ;
            MessageBox.Show("Güncelleme Yapıldı.");
        }

        public void UrunSil(int id)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("DELETE Urunler where ID=@p1",baglanti);
            komut.Parameters.AddWithValue("@p1",id);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Silme Yapıldı");
        }
        public List<Urun> UrunAra(string aranan)
        {
            List<Urun> aramaSonucu = new List<Urun>();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM Urunler WHERE URUNAD LIKE @p1", baglanti);
            komut.Parameters.AddWithValue("@p1", "%" + aranan + "%");
            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                Urun u = new Urun();
                u.ID = Convert.ToInt32(dr[0]);
                u.URUNAD = dr[1].ToString();
                u.KATEGORI = dr[2].ToString();
                u.STOKADET = Convert.ToInt32(dr[3]);
                u.FIYAT = Convert.ToDecimal(dr[4]);
                aramaSonucu.Add(u);
            }
            baglanti.Close();
            return aramaSonucu;
        }
    }
}
