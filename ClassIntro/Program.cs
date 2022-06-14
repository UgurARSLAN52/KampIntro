using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs { };
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin hoca";
            kurs1.IzlenmeOrani = 1500;

            Kurs kurs2 = new Kurs { };
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Engin hoca";
            kurs2.IzlenmeOrani = 2500;

            Kurs kurs3 = new Kurs { };
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Engin hoca";
            kurs3.IzlenmeOrani = 50;

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (var dersler in kurslar)
            {
                Console.WriteLine(dersler.KursAdi);
                Console.WriteLine(dersler.Egitmen);
                Console.WriteLine(dersler.IzlenmeOrani);
                Console.WriteLine("-------------------");
            }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }

    }
}
