using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;  // int tam sayı
            double faizOrani = 1.45;     // double ondalıklı sayı tipi
            bool sistemeGirisYapmisMi = true;  // bool doğru veya yanlış  - true , false

            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("eşit butonu");
            }

            // if şart bloğu 

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Sisteme giriş yaptınız");
            }
            else
            {
                Console.WriteLine("bilgilenizi yanlış girdinizs");
            }

            Console.WriteLine(kategoriEtiketi);
            // cw yazıp tab tab yaptığımızda otomatik Console.WriteLine();  geliyor.



            
        }
    }
}