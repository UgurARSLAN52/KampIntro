using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Sayın :" + customer.Name + " "+ customer.LastName + " bankamıza kaydınız oluşmuştur");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Sayın :" + customer.Name + " " + customer.LastName + " bankamızdan kaydınız silinmiştir.");
        }
        public void Update(Customer customer)
        {
            Console.WriteLine("Sayın :" + customer.Name + " " + customer.LastName + " bankamızdaki bilgileriniz güncellenmiştir.");
        }
    }
}
