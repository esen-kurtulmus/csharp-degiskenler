using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace birinciders
{
    internal class Program
    {
        static void Main(string[] args)
        {

        //değişkenler: verilerin bellekte tutulmasını sağlar.
        //değişkenin_türü değişken isim;
        //string Metinsel İfadeler için kullanılan değişken türüdür.
            string ad;
            ad = "esen";
            Console.Write(ad);
            string adi, soyad;
            adi = "esen";
            soyad = "kurt";
            Console.Write(adi + " " + soyad);
            //int tamsayı türünde işlem sağlayan değişken türü
            int sayi;
            sayi = 45;
            Console.WriteLine(sayi);
            int sayi1, sayi2, sonuc;
            sayi1 = 25;
            sayi2 = 2;
            sonuc = sayi1 + sayi2;
            Console.WriteLine(sonuc);
            //double ---ondalık sayı ile işlem yapar.
            double sayi3;
            sayi3 = 48.90;

            Console.WriteLine(sayi3);
            double sayi4, sayi5, sonuc1;
            sayi4 = 10.2;
            sayi5 = 2.1;
            sonuc1 = sayi4 / sayi5;
            Console.Write(sonuc1);
            
            Console.ReadLine();




        }
    }
}

