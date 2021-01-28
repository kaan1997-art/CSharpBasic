﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Bu bir yorum satırıdır.

            /*
            Bu başka bir yorum
            satırıdır.
            */

            #region Value Types
            // 1 byte= 8 bits
            #region Integer
            // 32 bits
            int number1;
            number1 = 10;
            number1 = 20;
            //Console.WriteLine(30);
            Console.WriteLine("Number 1 is" + number1);
            Console.WriteLine("Number 1 is {0}.", number1);
            Console.WriteLine("int max value: " + int.MaxValue + ", int min value: " + int.MinValue);

            uint number2 = 30;
            Console.WriteLine("Number 2 is " + number2);



            #endregion
            #region Long
            // 64 bits
            long number3 = 2147483648;
            number3 = -10;
            Console.WriteLine("Number 3 is " + number3);
            ulong number4 = 542;
            Console.WriteLine("Number 4 is " + number4);
            #endregion

            #region Short
            // 16 bits
            short number5 = 32000;
            ushort number6 = 16000;
            Console.WriteLine("No 5 is {0}, No 6 is {1}", number5, number6);
            #endregion

            #region
            // 8 bits
            byte number7 = 255;
            Console.WriteLine("No 7: " + number7);
            sbyte number8 = -128;
            Console.WriteLine("No 8: " + number8);

            #endregion
            #region Boolean
            // 1 bits (1 byte C#)
            bool condition = true;
            condition = false;
            Console.WriteLine("Condition: " + condition);

            #endregion

            #region Char
            char character = 'A'; // ASCII: 8 bits (65), Unicode: 16 bits
            Console.WriteLine("Character: " + character + ", ASCII Code: " + (int)character);
            #endregion

            #region Double
            // 64 bits
            double number9 = 1.7;
            Console.WriteLine("No 9:" + number9 + ",max value: " + double.MaxValue);
            #endregion
            #region Float
            // 32 bits
            float number10 = -15.67f;
            Console.WriteLine("No 10:" + number10);
            #endregion

            #region Decimal
            // 24 * 8 bits
            decimal number11 = 11.77M;
            Console.WriteLine("No 11:" + number11);
            #endregion

            #region Enum
            Console.WriteLine(Days.Monday);
            #endregion




            #endregion

            #region Reference Types
            #region String
            // 4 byte address, uzunluğu 2 milyar byte
            string characters = "Ankara";
            characters = "Ankara İstanbul";
            characters = "Ankara İstanbul İzmir";
            Console.WriteLine(characters);
            #endregion

            #endregion

            #region Var
            var number12 = 13;
            var number12string = "No 12 is";
            Console.WriteLine(number12string + " " + number12);
            #endregion

            int n1 = 1, n2 =2, n3 = 3;
            Int32 n4 = 4;

            double d1;
            Double d2;

            string s1;
            String s2;

            bool deger1;
            Boolean deger2;

            string ad = "\"Çağıl\"";
            Console.WriteLine(ad);

            /* Özel karakterler: Escape characters, escape sequences:
             * \' - Tek Tırnak
             * \" - Çift Tırnak
             * \" - Tırnak
             * \n - new line (alt satır)
             * \r - carriage return (satır başı)
             * \\ - slash
             * \t - tab
             */

            char tekTırnak = '\'';

            string path = "C:\\BilgeAdam\\Console";
            Console.WriteLine(path);
            string sehir1 = "Ankara";
            string sehir2 = "İstanbul";
            Console.WriteLine(sehir1);
            Console.WriteLine(sehir2);

            string sehir = "Ankara\nİstanbul";
            sehir = sehir1 + "\n" + sehir2;
            Console.WriteLine(sehir);

            var adi = "Çağıl";
            var soyadi = "Alsaç";
            var tab = "\t";

            Console.WriteLine(adi + tab + soyadi);

            // Önermeler:
            bool p, q;
            bool r; // result
            p = true;
            q = true;

            r = p || q;
            Console.WriteLine("p: " + p + " || q: " + q + " = " + r);
            r = p && q; // ve (and)  
            Console.WriteLine("p: " + p + " && q: " + q + " = " + r);

            p = false;
            q = false;
            r = p || q;
            Console.WriteLine("p: " + p + " || q: " + q + " = " + r);
            r = p && q; // ve (and)  
            Console.WriteLine("p: " + p + " && q: " + q + " = " + r);

            p = true; // false
            q = false; // true
            r = p || q;
            Console.WriteLine("p: " + p + " || q: " + q + " = " + r);
            r = p && q; // ve (and)  
            Console.WriteLine("p: " + p + " && q: " + q + " = " + r);

            r = true; // false
            r = !r; //false

            Console.WriteLine("r= " + r);


            Console.ReadLine();
        }
    }

    #region Enum
    enum Days
    {
        Monday = 1,
        Tuesday = 2,
        Wednesday = 3,
        Thirsday = 4,
        Friday = 5,
        Saturday = 6,
        Sunday = 7
    }

    #endregion
}
