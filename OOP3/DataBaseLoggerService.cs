using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    public class DataBaseLoggerService : ILoggerServis
    {
        public void Log()
        {
            Console.WriteLine("Veri Tabanina loglandi");
        }
    }
}
