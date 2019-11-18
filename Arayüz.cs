using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REHBERİM
{
    enum Anamenü { Ekle=1,ara,sil,güncelle,listele,sırala,çıkış}
    enum mesajtürü { Normal,Hata,Uyarı}
    class Arayüz
    {
        static public Anamenü anamenüseçim()
        {
            Console.WriteLine("\n********MENÜ********");
            for(int i = 01; i <= (int)Anamenü.çıkış; i++)
            {
                Console.WriteLine(i + "." + (Anamenü)i);
            }
            Console.Write("seçim:");
            return (Anamenü)Convert.ToInt32(Console.ReadLine());
        }
        static public bool eminmisiniz(string msj)
        {
            Console.Write(msj + "[e/h]");
            if (Console.ReadKey().Key == ConsoleKey.E)
                return true;
            else
                return false;
        }
        static public void mesaj(string msj, mesajtürü msjtür)
        {
            Console.WriteLine();
            switch (msjtür)
            {
                case mesajtürü.Normal:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case mesajtürü.Hata:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("hata!");
                    break;
                case mesajtürü.Uyarı:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("uyarı!");
                    break;
            }
            Console.WriteLine(msj);
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
        }
        static public void mesaj(string msj)
        {
            mesaj(msj, mesajtürü.Normal);
        }
        static public string stringoku()
        {
            string str;
            do
            {
                str = Console.ReadLine().Trim();

            } while (str == "");
            return str;
        }
        static public void stringoku(out string str)
        {
            do
            {
                str = Console.ReadLine().Trim();
            } while (str == "");
        }
        static public void Çizgiçiz(int çizgisayısı)
        {
            Console.WriteLine(new string('-', çizgisayısı));
        }
    }
}
