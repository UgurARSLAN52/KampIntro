using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Product product1 = new Product();
            
            product1.Adi = "kalem";
            product1.Fiyat = 10;
            product1.Aciklama = "Siyah yazan kalem";

            Product product2 = new Product();

            product2.Adi = "defter";
            product2.Fiyat = 30;
            product2.Aciklama = "kareli defter";

            Product product3 = new Product();

            product3.Adi = "silgi";
            product3.Fiyat = 5;
            product3.Aciklama = "yumaşak silgi";

            Product[] products = new Product[] {product1, product2 , product3 };

            foreach (var item in products)
            {
                Console.WriteLine(item.Adi);
                Console.WriteLine(item.Fiyat);
                Console.WriteLine(item.Aciklama);
                Console.WriteLine("----------------------");

            }
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);


        }
    }
    }

