// See https://aka.ms/new-console-template for more information

string[] kurslar = new string[] {"C#", "java", "python" };

foreach (var Kurslar in kurslar)
{
    Console.WriteLine(Kurslar);
}
Console.WriteLine("--------------------------");


for (int i = 0; i <kurslar.Length; i++)
{
    Console.WriteLine(kurslar[i]);
}