using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 100;
            double ondalik = 10.5;
            bool sistemeGirisYapmisMi = false;

            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(ogrenciSayisi);
            Console.WriteLine(ondalik);
            Console.WriteLine(sistemeGirisYapmisMi);

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("sisteme giriş yapmadı");
            }
            else
            {
                Console.WriteLine("sisteme giriş yapdınız");
            }

            if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış");
            }
            else if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Düşüş");
            }
            else
            {
                Console.WriteLine("eşit");
            }
            
        }
    }
}
