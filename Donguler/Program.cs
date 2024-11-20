// See https://aka.ms/new-console-template for more information




for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}

string[] kurslar = new string[] {"Yazılım geliştirme kampı", "Programlamanın temelleri", "java", "C#"};

foreach (var kurs in kurslar)
{
    Console.WriteLine(kurs);
}

Console.WriteLine("---------------------");

for (int i = 0; i < kurslar.Length; i++)
{
    Console.WriteLine(kurslar[i]);
}