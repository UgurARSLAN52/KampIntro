// See https://aka.ms/new-console-template for more information
using ClassMetotDemo;

CustomerManager customerManager = new CustomerManager();

Customer customer1 = new Customer();
customer1.Id = 1;
customer1.Name = "Uğur";
customer1.LastName = "ARSLAN";
customer1.Tc = "1234560";

Customer customer2 = new Customer();
customer2.Id = 2;
customer2.Name = "Ali";
customer2.LastName = "Veli";
customer2.Tc = "545454545";

Customer customer3 = new Customer();
customer3.Id = 3;
customer3.Name = "Aysima";
customer3.LastName = "ARSLAN";
customer3.Tc = "12365478911";

customerManager.Add(customer1);
customerManager.Delete(customer2);
customerManager.Update(customer3);