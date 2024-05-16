using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class EsnafKradisiManager : IKrediManager
    {
        public void Hesapla()
        {
            Console.WriteLine("Esnaf kredisi hesaplandı");
        }

        public void OnayVer()
        {
            throw new NotImplementedException();
        }
    }
}
