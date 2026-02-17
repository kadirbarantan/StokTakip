using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip
{
    internal class Urun
    {
        int id;
        string UrunAd;
        string Kategori;
        int StokAdet;
        decimal Fiyat;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string URUNAD
        {
            get { return UrunAd; }
            set { UrunAd = value; }
        }
        public string KATEGORI
        {
            get { return Kategori; }
            set { Kategori = value; }
        }
        public int STOKADET
        {
            get { return StokAdet; }
            set { StokAdet = value; }
        }
        public decimal FIYAT
        {
            get { return Fiyat; }
            set{ Fiyat = value; }
        }
    }
}
