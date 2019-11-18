using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REHBERİM
{
    class rehber
    {
        List<KİŞİ> Kişiler = new List<KİŞİ>();
        //private KİŞİ[] kişiler;
        //private int kişisayısı;
        private string Dosyaismi;

        public rehber(List<KİŞİ> kişiler)
        {
            Kişiler= kişiler;
            Dosyaismi = "rehber.txt";
        }
        public rehber(string dosyaismi)
        {
            Dosyaismi = dosyaismi;          
            Hepsinidosyadanyükle();

        }
        /*public rehber(KİŞİ[]kişiler,int kişisayısı,string dosyaismi)
        {
            this.kişiler = kişiler;
            this.kişisayısı = kişisayısı;
            this.Dosyaismi = dosyaismi;
        }
        */
        
        public void Kişiekle(string ad,string soyad,string tel)
        {
                      
                KİŞİ yenikişi = new KİŞİ(ad, soyad, tel);
                Kişiler.Add(yenikişi);
                kişikaydet();
                
            /*if (kişisayısı >=kişiler.Length)
            {
                Console.WriteLine("Rehber taşma hatası. Kişi eklenemedi.");
                return false;
            }
            else
            {
                kişiler[kişisayısı] = new KİŞİ(ad, Soyad, tel);
                kişisayısı++;
                kişikaydet();
                return true;
            }
            */
        }      
        public int Ara(string aramametni)
        {
                       
            for (int i = 0; i < Kişiler.Count; i++)
            {
                if (Kişiler[i].GetAd().ToLower() == aramametni.ToLower() || Kişiler[i].GetSoyad().ToLower() == aramametni.ToLower() || Kişiler[i].GetTel().ToLower() == aramametni.ToLower())
                return i;
            }
            return -1;        
        }
        public void sil(string aramametni)
        {
            int sil = Ara(aramametni);
            Kişiler.RemoveAt(sil);

        }
        public bool güncelle(int index)
        {
            string yeniAd, yeniSoyad, yeniTel;

            if (index < 0 || index > (Kişiler.Count - 1))
            {
                Console.WriteLine("Güncelleme - Hatalı indeks!  0<=indeks<=" + (Kişiler.Count));
                return false;
            }
            else
            {
                Console.Write("Adı=");
                yeniAd = Console.ReadLine();
                if (yeniAd.Length > 0)
                    Kişiler[index].SetAd(yeniAd);

                Console.Write("Soyadı=");
                yeniSoyad = Console.ReadLine();
                if (yeniSoyad.Length > 0)
                    Kişiler[index].SetSoyad(yeniSoyad);

                Console.Write("Telefon Numarası=");
                yeniTel = Console.ReadLine();
                if (yeniTel.Length > 0)
                    Kişiler[index].SetTel(yeniTel);
                hepsinikaydet();
                return true;
               
            } 
           
        }        
        public void kişilistele()
        {
            Console.WriteLine("no".PadRight(18) + "ad".PadRight(19) + "soyad".PadRight(20) + "tel".PadRight(20));
            Arayüz.Çizgiçiz(50);
            for(int i = 0; i < Kişiler.Count; i++)
            {
                Console.WriteLine((i + 1).ToString().PadRight(18) + Kişiler[i].GetAd().PadRight(15) + Kişiler[i].GetSoyad().PadRight(15) + Kişiler[i].GetTel().PadRight(15));
            }
        }
        public void sırala()
        {
           
            Kişiler.Sort();
            kişilistele();


        }
        public void hepsinikaydet()
        {
            StreamWriter dosya = new StreamWriter(Dosyaismi);
           
            for(int i = 0; i <Kişiler.Count; i++)
            {
                dosya.WriteLine("{0};{1};{2};", Kişiler[i].GetAd(), Kişiler[i].GetSoyad(), Kişiler[i].GetTel());
            }
            dosya.Close();
            
        }
        public void kişikaydet()
        {
            StreamWriter dosya = new StreamWriter(Dosyaismi,true);

            dosya.WriteLine(Kişiler[Kişiler.Count - 1].GetAd(),Kişiler[Kişiler.Count-1].GetSoyad(),Kişiler[Kişiler.Count-1].GetTel());
            dosya.Flush();
            dosya.Close();
            
        }
        private int Hepsinidosyadanyükle()
        {
            
            if (File.Exists(Dosyaismi))
            {
                int i = 0;
                StreamReader dosya = new StreamReader(Dosyaismi,true);
                string kayıt = dosya.ReadLine();
                string[] alanlar;
                string ad, soyad, tel;
                //int no;
                
                
                while (kayıt != null)
                {
                    alanlar = kayıt.Split(';');
                   
                    //dosya.Read("{0};{1};{2}", Kisiler[0].getAd(), Kisiler[2].getSoyad(), Kisiler[2].getTel());
                    ad = alanlar[0];
                    soyad = alanlar[1];
                    tel = alanlar[2];

                    Kişiler.Add(new KİŞİ(ad, soyad, tel));



                    /* ad = alanlar[0];
                    soyad = alanlar[1];
                     tel = alanlar[2];
                     Kisiler[i] = new Kisi(ad, soyad, tel);
                     i++;
                     KişiSayısı++;*/

                    kayıt = dosya.ReadLine();
                }
                dosya.Close();
            }
            return Kişiler.Count;
        }          
        
        public void yazdır(int index)
        {
            if(index<0||index > (Kişiler.Count - 1))
            {
                Console.WriteLine("hatalı index! 0<=" + (Kişiler.Count));
            }
            else
            {
                Arayüz.Çizgiçiz(50);
                Console.WriteLine("-Adı      :" +Kişiler[index].GetAd());
                Console.WriteLine("-Soyad    :" +Kişiler[index].GetSoyad());
                Console.WriteLine("-Telefon  :" +Kişiler[index].GetTel());
                Arayüz.Çizgiçiz(50);
            }
        }
        public void yazdır()
        {
            Console.WriteLine("REHBERİM");
            Arayüz.Çizgiçiz(50);
            Console.WriteLine("   AD                  SOYAD          TEL");
            Arayüz.Çizgiçiz(50);

            for(int i = 0; i <Kişiler.Count; i++)
            {
                Console.WriteLine($"{(i + 1),-4}{Kişiler[i].GetAd(),-20}{Kişiler[i].GetSoyad(),-18}{Kişiler[i].GetTel(),-17}");
            }
            Arayüz.Çizgiçiz(50);

        }

        

       
    }
}
