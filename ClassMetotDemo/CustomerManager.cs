using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class CustomerManager
    {
        public void Ekle(Customer customer)
        {
            Console.WriteLine("SAyın " + customer.CustomerName + " sisteme eklendiniz.");
        }

        public void Sil(Customer customer)
        {
            Console.WriteLine("SAyın " + customer.CustomerName + " sistemden silindiniz.");
        }
        public void Listeleme(Customer customer)
        {

            Console.WriteLine(customer.CustomerName+ " listedesiniz");
        }
    }
}
