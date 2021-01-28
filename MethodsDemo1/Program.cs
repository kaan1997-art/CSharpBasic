using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            double ortalama;
            BaslikGetir();
            double vize1 = GirisAl("1. vize");
            double vize2 = GirisAl("2.vize");
            double final = GirisAl("Final");
            ortalama = OrtalamaHesapla(vize1, vize2, final);
            GecmeDurumuGöster(ortalama);
            Console.ReadLine();
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
        static double OrtalamaHesapla(double vize1 , double vize2, double final)
        {
            return (vize1 + vize2) * 20 / 100 + final * 60 / 100;
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
    }
}
