// See https://aka.ms/new-console-template for more information


using OOP1;

ProductManager productManager = new ProductManager();

Product product1 = new Product();
product1.Id = 1;
product1.CategoryId = 2;
product1.ProductName = "Masa";
product1.UnitPrice = 500;
product1.UnitsInStock = 3;

Product product2 = new Product {Id=2, CategoryId=2, ProductName="sandalye", UnitPrice=150, UnitsInStock=18 };

productManager.Add(product1);


int toplamaSonucu = productManager.Topla(3, 6);

Console.WriteLine(toplamaSonucu*2);