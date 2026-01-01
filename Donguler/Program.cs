// See https://aka.ms/new-console-template for more information

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}


string kurs1 = "C#";
string kurs2 = "Java";
string kurs3 = "Python";

string[] kurslar = new string[] {kurs1, kurs2, kurs3 };

for (int i = 0; i <kurslar.Length ;i++)
{
    Console.WriteLine(kurslar[i]);
}

Console.WriteLine("-------------------------");

foreach (string kurs in kurslar)
{
    Console.WriteLine(kurs);
}

Console.ReadLine();
