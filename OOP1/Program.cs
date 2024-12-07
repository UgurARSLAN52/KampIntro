// See https://aka.ms/new-console-template for more information

using OOP1;

Product product1 = new Product();
product1.Id = 1;
product1.CategoryId = 2;
product1.ProductName = "Masa";
product1.UnitPrice = 1500;
product1.UnitsInStock = 3;

ProductManager productManager1 = new ProductManager();

productManager1.Add(product1);
