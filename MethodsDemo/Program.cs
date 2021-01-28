using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaslikGetir();

            double ortalama;

            if (GirisAlinacakMi())
            {
                double vize1 = GirisAl("1. vize");
                double vize2 = GirisAl("2.vize");
                double final = GirisAl("Final");
                ortalama = OrtalamaHesapla(vize1, vize2, final);
            }
            else
            {
                ortalama = OrtalamaHesapla();
            }
            

            
            GecmeDurumuGöster(ortalama);

           // OrtalamaHesaplaTest(Convert.ToInt32(vize1), Convert.ToInt32(vize2), Convert.ToInt32(final));

            Console.ReadLine();
        }
        static bool GirisAlinacakMi()
        {
            bool sonuc;
            Console.Write("Sınav notlarını girmek istiyor musunuz? (e: evet, h: hayır)");
            string giris = Console.ReadLine();
            //sonuc = giris == "e";
            if (giris == "e")
                sonuc = true;
            else
                sonuc = false;
            
            return sonuc;
            

            //static bool GirisAlinacakMi()
            //{
            //    Console.Write("Sınav notlarını girmek istiyor musunuz? (e: evet, h: hayır");
            //    string giris = Console.ReadLine();
            //    //    if (giris == "e")
            //    //        return true;
            //    //    else
            //    //        return false;
            //    if (giris == "e")
            //        return true;
            //    return false;
        }

        static void GecmeDurumuGöster(double ortalama)
        {
            Console.WriteLine("Ortalama: " + ortalama);
            if (ortalama < 60)
            {
                Console.WriteLine("Kaldı!");
            }
            else
            {
                Console.WriteLine("Geçti.");
            }
        }

        static double GirisAl(string sinav)
        {
            Console.Write(sinav + ": ");
            string giris = Console.ReadLine();
            //return double.Parse(giris);
            return Convert.ToDouble(giris);
        }
        static void BaslikGetir()
        {
            Console.WriteLine("***Öğrenci not ortalaması hesaplama***");
        }
        static double OrtalamaHesapla(double vize1 = 80, double vize2 = 80, double final = 70)
        {
            return (vize1 + vize2) * 20 / 100 + final * 60 / 100;
            //return (vize1 + vize2) * 0.2 + final * 0.6;
        }

        static void OrtalamaHesaplaTest(int vize1, int vize2, int final)
        {
            double ortalama = (vize1 + vize2) * 20 / 100 + final * 60 / 100;
            Console.WriteLine("Test:" + ortalama);
            //return (vize1 + vize2) * 0.2 + final * 0.6;
        }
    }
}
