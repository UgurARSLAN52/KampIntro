using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
     class SepetManager
    {
        // operasyon isimleri büyük harfle başlıyor
        public void Ekle(Product product)
        {
            Console.WriteLine(product.ProductNane + " Sepete eklendi");
        }
    }
}
