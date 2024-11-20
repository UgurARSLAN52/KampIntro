// See https://aka.ms/new-console-template for more information

Kurs kurs1 = new Kurs();
kurs1.KursAdi = "Java";
kurs1.Egitmen = "Engin demirog";
kurs1.IzlenmeOrani = 85;

Kurs kurs2 = new Kurs();
kurs2.KursAdi = "C#";
kurs2.Egitmen = "Engin demirog";
kurs2.IzlenmeOrani = 60;

Kurs kurs3 = new Kurs();
kurs3.KursAdi = "Python";
kurs3.Egitmen = "Engin demirog";
kurs3.IzlenmeOrani = 75;

Kurs[] kurs = new Kurs[] {kurs1 , kurs2, kurs3};
foreach (var kurslar in kurs)
{
    Console.WriteLine(kurslar.KursAdi + " ---------- " + kurslar.Egitmen);
}

Console.WriteLine("---------------");

for (int i = 0; i < kurs.Length; i++)
{
    Console.WriteLine(kurs[i].KursAdi);
}

class Kurs
{
    public string KursAdi { get; set; }
    public string Egitmen { get; set; }
    public int IzlenmeOrani { get; set; }

}