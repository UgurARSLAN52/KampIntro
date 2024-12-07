// See https://aka.ms/new-console-template for more information

using ClassMetotDemo;

Customer customer1 = new Customer();
customer1.CustomerName = "Uğur";
customer1.CustomerKimlikNumber = "12345678";
customer1.Aciklama = "Genç Müşteri";

Customer customer2 = new Customer();
customer2.CustomerName = "ARSLAN";
customer2.CustomerKimlikNumber = "12345678";
customer1.Aciklama = "Yaşlı Müşteri";

CustomerManager customerManager = new CustomerManager();

customerManager.Ekle(customer1);
customerManager.Sil(customer2);

customerManager.Listeleme(customer1);

Console.ReadLine();

  