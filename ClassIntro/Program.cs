// See https://aka.ms/new-console-template for more information

Kurs kurs1 = new Kurs();
kurs1.KursAdi = "Java";
kurs1.Egitmen = "Engin demirog";
kurs1.IzlenmeOrani = 2500;

Kurs kurs2 = new Kurs();
kurs2.KursAdi = "python";
kurs2.Egitmen = "Engin demirog";
kurs2.IzlenmeOrani = 3500;

Kurs kurs3 = new Kurs();
kurs3.KursAdi = "C#";
kurs3.Egitmen = "Engin demirog";
kurs3.IzlenmeOrani = 7500;

Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3};

foreach (var kurs in kurslar)
{
    Console.WriteLine(kurs.KursAdi+ " : "+ kurs.Egitmen + " : "+ kurs.IzlenmeOrani);
   
}

class Kurs
{
    public string KursAdi { get; set; }
    public string Egitmen { get; set; }
    public int IzlenmeOrani { get; set; }

}
