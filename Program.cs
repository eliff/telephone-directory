using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REHBERİM
{
    class Program
    {
        static void Main(string[] args)
        {
             string ad,soyad,tel, metin;
             int indeks;

            rehber İkişiler = new rehber("rehberdosya.txt");


            Anamenü seçim;
            do
            {
              
                seçim = Arayüz.anamenüseçim();

                if (seçim == Anamenü.listele)
                {
                    İkişiler.yazdır();
                }
                else if (seçim == Anamenü.Ekle)
                {
                    Console.Write("Yeni Ad=");
                    ad = Arayüz.stringoku();
                    Console.Write("Yeni Soyad=");
                    soyad = Arayüz.stringoku();
                    Console.Write("Yeni Telefon Numarası=");
                    tel = Arayüz.stringoku();

                    İkişiler.Kişiekle( ad, soyad,tel);
                    
                }
                else if (seçim == Anamenü.güncelle)
                {
                    Console.Write("Güncellenecek kişi=");
                    metin = Arayüz.stringoku();
                    indeks = İkişiler.Ara(metin);
                    if (indeks == -1)
                    {
                        Arayüz.mesaj(metin + " listede bulunamadı...",mesajtürü.Hata);
                    }
                    else
                    {
                        
                        //Arayüz.StringOku(out isim);
                        if (İkişiler.güncelle(indeks))
                            Arayüz.mesaj(metin + " başarıyla güncellendi.");
                        else
                            Arayüz.mesaj(metin + " güncellenemedi.", mesajtürü.Uyarı);
                    }


                }
                else if (seçim == Anamenü.ara)
                {
                    Console.WriteLine("aramak istediğniz isim:");
                    string aramametni = Console.ReadLine();
                    int sonuç = İkişiler.Ara(aramametni);
                    İkişiler.yazdır();
                }
                else if (seçim == Anamenü.sırala)
                {
                    
                    İkişiler.sırala();
                    İkişiler.yazdır();
                    //İkişiler.kişilistele();
                    KİŞİ kis = new KİŞİ();
                    kis.CompareTo(kis);
                    
                }
                
                else if (seçim == Anamenü.sil)
                {
                    Console.WriteLine("silmek istediğiniz kişinin Adı / Soyadı");
                    string silinecek = Console.ReadLine();
                    İkişiler.sil(silinecek);

                    //Console.Write("Silinecek İsim=");
                    //metin = Arayüz.stringoku();
                    //indeks = İkişiler.Ara(metin);
                    //if (indeks == -1)
                    //{
                        //Arayüz.mesaj(metin + " listede bulunamadı...", mesajtürü.Hata);
                    //}
                    //else
                    //{
                        //bool eminMi = Arayüz.eminmisiniz("Silmek istediğinizden emin misiniz?...");
                        //if (eminMi)
                        //{
                           // if (İkişiler.sil(metin))
                                //Arayüz.mesaj(metin + " başarıyla silindi.");
                            //else
                               // Arayüz.mesaj(metin + " silinemedi.", mesajtürü.Uyarı);
                       // }

                    //}
                }
                
            } while (seçim != Anamenü.çıkış);


            Console.Read();



    }   }
}
