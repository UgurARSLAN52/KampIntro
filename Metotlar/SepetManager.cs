using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    public class SepetManager
    {
        public void Ekle(Product product)
        {
            Console.WriteLine(product.ProductName + " ürünü eklendi.");
        }

        public void Delete(Product product)
        {
            Console.WriteLine(product.ProductName + " ürünü silindi.");
        }
    }
}
