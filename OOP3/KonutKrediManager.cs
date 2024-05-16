using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class KonutKrediManager : IKrediManager
    {
        public void Hesapla()
        {
            Console.WriteLine("konut kredisi ödeme planı hesaplandı.");
        }

        public void OnayVer()
        {
            throw new NotImplementedException();
        }
    }
}
