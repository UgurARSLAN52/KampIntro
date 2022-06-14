using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] kurslar = new string[] {"yazılım geliştirme kursu", "programlamaya başlangıç", "java" , "C#"};

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("------------------");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu");

            
        }
    }
}
