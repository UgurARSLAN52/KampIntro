using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class SepetManager
    {
        public void Ekle(Product product)
        {
            Console.WriteLine("Sepete eklendi");
        }

        public void Güncelle()
        {
            Console.WriteLine("bilgiler güncellendi");
        }

        public void Silme()
        {
            Console.WriteLine("ürün silindi");
        }
    }
}
