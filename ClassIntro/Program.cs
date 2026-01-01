// See https://aka.ms/new-console-template for more information

Kurs kurs1 = new Kurs();
kurs1.KursAdi = "C#";
kurs1.Egitmen = "Engin Demirog";
kurs1.IzlenmeOrani = 5000;

Kurs kurs2 = new Kurs();
kurs2.KursAdi = "Java";
kurs2.Egitmen = "Uğur ARSLAN";
kurs2.IzlenmeOrani = 3500;

Kurs kurs3 = new Kurs();
kurs3.KursAdi = "Python";
kurs3.Egitmen = "Engin Demirog";
kurs3.IzlenmeOrani = 8000;


Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };
foreach (var kurs in kurslar)
{
    Console.WriteLine(kurs.KursAdi);
}

class Kurs
{
    public string KursAdi { get; set; }
    public string Egitmen { get; set; }
    public int IzlenmeOrani { get; set; }
}



