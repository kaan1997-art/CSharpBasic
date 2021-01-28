using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            // logical operators (mantıksal operatörler) : && (and), || or, ! (not) 
            // realtions operators ( ilişkisel operatörler) : ==,!=,>=,<=,<,>
            // aritmetic operators (aritmetik operatörler) : +, - , * ,/ ,%
            // assigment operator (atama operatörü): =

            // 3 sayı karşılaştırma
            Console.Write("1.sayı: ");
            string Sayi1 = Console.ReadLine();
            Console.Write("2.sayı: ");
            string Sayi2 = Console.ReadLine();
            Console.Write("3.sayı: ");
            string Sayi3 = Console.ReadLine();
            int enBuyuk;
            if (Convert.ToInt32(Sayi1) == Convert.ToInt32(Sayi2) && Convert.ToInt32(Sayi2) == Convert.ToInt32(Sayi3))
            {
                Console.WriteLine("Tüm girilen sayılar eşit");
            }
            else
            {
                enBuyuk = Convert.ToInt32(Sayi1);
                if ((Convert.ToInt32(Sayi2) >= Convert.ToInt32(Sayi1)) && Convert.ToInt32(Sayi2) >= Convert.ToInt32(Sayi3))
                {
                    enBuyuk = Convert.ToInt32(Sayi2);
                }
                if ((Convert.ToInt32(Sayi3) >= Convert.ToInt32(Sayi1)) && Convert.ToInt32(Sayi3) >= Convert.ToInt32(Sayi2))
                {
                    enBuyuk = Convert.ToInt32(Sayi3);
                }
                Console.WriteLine("En büyük sayı " + enBuyuk);
            }
            Console.ReadLine();
               

            var number = 11;
            if (number == 10) // true, false
            {
                Console.WriteLine("Number is 10");
            }
            else // number != 10
            {
                Console.WriteLine("Number is not 10");
            }
            number = 20;
            if (number == 10)
            {
                Console.WriteLine("Number is 10");
            }
            else if (number == 20)
            {
                Console.WriteLine("Number is 20");
            }
            else
            {
                Console.WriteLine("Number is not 10 or 20");
            }

            switch (number)
            {
                case 10:
                    Console.WriteLine("Number is 10");
                    break;
                case 20:
                    Console.WriteLine("Number is 20");
                    break;
                default:
                    Console.WriteLine("Number is not 10 or 20");
                    break;
            }

            // ternary operator
            number = 11;
            string result = number == 10 ? "Number is 10" : "Number is not 10";
            Console.WriteLine(result);

            int sayi = 150;
            if (sayi >= 0)
            {
                if (sayi <= 100)
                {
                    Console.WriteLine("0-100");
                }
                else if (sayi > 100)
                {
                    if (sayi <= 200)
                    {
                        Console.WriteLine("100-200");
                    }
                    else
                    {
                        Console.WriteLine("Sınır dışı");
                    }
                }
            }
            else
            {
                Console.WriteLine("Sınır dışı");
            }

            if (sayi >= 0 && sayi <= 100)
            {
                Console.WriteLine("0-100");
            }
            else if (sayi > 100 && sayi <= 200)
            {
                Console.WriteLine("100-200");
            }
            else
            {
                Console.WriteLine("Sınır dışı");
            }

            Console.Write("Bir tam sayı giriniz:");
            string giris = Console.ReadLine();
            string cikis;
            int girisSayisi = Convert.ToInt32(giris);
            if (girisSayisi > 0)
                cikis = "Pozitif";
            else if (girisSayisi < 0)
                cikis = "Negatif";
            else
                cikis = "Sıfıra Eşit";
            Console.WriteLine(cikis);


            Console.Write("Yazı mı (y), tura mı (t)?");
            string inputText = Console.ReadLine();
            int inputNumber;
            //int moneyValue = 1; // 1:yazı, 0 : tura
            Random rastgele = new Random();
            int moneyValue = rastgele.Next(0, 2);
            if (inputText == "y" || inputText == "t")
            {
                //if (inputText == "y")
                //    inputNumber = 1;// yazı
                //else
                //    inputNumber = 0;// tura
                inputNumber = 0;
                if (inputText == "y")
                    inputNumber = 1;
                if (inputNumber == moneyValue)
                {
                    Console.WriteLine("Tebrikler bildiniz.");
                }
                else
                {
                    Console.WriteLine("Bilemediniz.");
                }


            }
            #region Koronavirüs
            else
            {
                Console.WriteLine("Lütfen yazı için \"y\" tura için de \"t\" girin!");
            }
            // Koronavirüs tespit:
            Console.WriteLine("***Koronavirüs Belirti Tespit");
            string soruEk = "Evet(e); Hayır (h)";
            string uyari = "Lütfen evet için \"e\", hayır için \"h\" girin...";
            Console.WriteLine("Ateş var mı?" + soruEk);
            string atesCevap = Console.ReadLine();
            if (!(atesCevap == "e" || atesCevap == "h"))
            {
                Console.WriteLine(uyari);
            }
            else
            {
                Console.Write("Öksürük var mı?" + soruEk);
                string oksurukCevap = Console.ReadLine();
                if (!(oksurukCevap == "e" || oksurukCevap == "h"))
                {
                    Console.WriteLine(uyari);
                }
                else
                {
                    Console.Write("Boğaz ağrısı var mı?" + soruEk);
                    string bogazagrısıcevap = Console.ReadLine();
                    if (!(bogazagrısıcevap == "e" || bogazagrısıcevap == "h"))
                        Console.WriteLine(uyari);
                    else
                    {
                        //if (atesCevap == "e" || oksurukCevap == "e" || bogazagrısıcevap == "e")
                        if (atesCevap == "e" || (oksurukCevap == "e" && bogazagrısıcevap == "e"))
                        {
                            Console.WriteLine("Koronovirüs olma ihtimaliniz vardır.");
                        }
                        else
                        {
                            Console.WriteLine("Koronavirüs olma ihtimaliniz yoktur.");
                        }

                    }


                }

                #endregion

                #region Kullanıc Girişi
                Console.WriteLine("***Kullanını Girişi***");
                Console.Write("Kullanıcı adı: ");
                string kullaniciAdi = Console.ReadLine();
                Console.Write("Şifre: ");
                string sifre = Console.ReadLine();
                string kayitliKullaniciAdi = "cagil";
                string kayitliSifre = "123";
                if (kullaniciAdi == kayitliKullaniciAdi && sifre == kayitliSifre)
                    Console.WriteLine("Hoşgeldiniz " + kullaniciAdi);
                else
                    Console.WriteLine("Geçersiz kullanıcı.");
                #endregion
                Console.Write("1.sayi");
                string sayi1 = Console.ReadLine();
                Console.Write("2.sayi");
                string sayi2 = Console.ReadLine();
                int sayi1deger = Convert.ToInt32(sayi1);
                int sayi2deger = int.Parse(sayi2);
                if (sayi1deger > sayi2deger)
                    Console.WriteLine(sayi1deger + " >" + sayi2deger);
                else if (sayi1deger < sayi2deger)
                    Console.WriteLine(sayi1deger + "<" + sayi2deger);
                else
                    Console.WriteLine(sayi1deger + "=" + sayi2deger);
               







                Console.ReadLine();
            }
        }
    }
}
