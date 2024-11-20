// See https://aka.ms/new-console-template for more information

using Metotlar;



Product product1 = new Product();
product1.ProductNane = "Elma";
product1.Fiyati = 15;
product1.Aciklama = "amasya elması";

Product product2 = new Product();
product2.ProductNane = "Fındık";
product2.Fiyati = 250;
product2.Aciklama = "Ordu fındığı";

Product[] products = new Product[] { product1, product2 };
foreach (var product in products)
{
    Console.WriteLine(product.ProductNane);
}
Console.WriteLine("--------METOTLAR----------");

SepetManager sepetManager = new SepetManager();
sepetManager.Ekle(product1);