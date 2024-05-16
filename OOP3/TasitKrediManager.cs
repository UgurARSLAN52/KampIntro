using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class TasitKrediManager : IKrediManager
    {
        public void Hesapla()
        {
            Console.WriteLine("Taşık kredisi ödeme planı hesaplandı.");
        }

        public void OnayVer()
        {
            throw new NotImplementedException();
        }
    }
}
