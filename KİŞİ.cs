using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REHBERİM
{
    class KİŞİ:IComparable
    {
        static int no;
        private string Ad;
        private string Soyad;
        private string Tel;

        public KİŞİ()
        {
            no++;
        }
        public KİŞİ(string ad, string soyad, string tel)
        {
            
            Ad = ad;
            Soyad = soyad;
            Tel = tel;
        }

        public int CompareTo(object obj)
        {
            KİŞİ k = (KİŞİ)obj;
                int sonuç = Ad.CompareTo(k.Ad);
            if (sonuç == 0)
            {
                sonuç = Soyad.CompareTo(k.Soyad);
            }
            return sonuç;

        }
        public override string ToString()
        {
            return Ad + " " + Soyad+" "+Tel;
        }

        public string GetAd()
        {
            return Ad;
        }
        public string GetSoyad()
        {
            return Soyad;
        }
        public string GetTel()
        {
            return Tel;
        }
        public void SetAd(string Ad)
        {
            this.Ad = Ad;
        }
        public void SetSoyad(string Soyad)
        {
            this.Soyad = Soyad;
        }
        public void SetTel(string Tel)
        {
            this.Tel = Tel;
        }

    }
}
