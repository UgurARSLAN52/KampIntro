// See https://aka.ms/new-console-template for more information

using Metotlar;

Product product1 = new Product();
product1.Id = 1;
product1.ProductName = "Hp Leptop";
product1.UnitsPrice = 25000;

Product product2 = new Product();
product2.Id = 2;
product2.ProductName = "Dell Leptop";
product2.UnitsPrice = 30000;


Product[] products = new Product[] { product1, product2 };
foreach (var product in products)
{
    Console.WriteLine(product.ProductName);
}

Console.WriteLine("----------------");

SepetManager sepetManager = new SepetManager();
sepetManager.Ekle(product1);

