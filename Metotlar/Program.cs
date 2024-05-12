// See https://aka.ms/new-console-template for more information
using Metotlar;

SepetManager sepetManager = new SepetManager();

Urun urun1 = new Urun();
urun1.Id = 1;
urun1.Adi = "Elma";
urun1.Fiyati = 15;
urun1.Aciklama = "Amasya elması";

Urun urun2 = new Urun();
urun2.Id= 2;
urun2.Adi = "karpuz";
urun2.Fiyati = 35;
urun2.Aciklama = "Diyarbakır karpuzu";

Urun[] urunler = new Urun[] {urun1, urun2 };

foreach (var urun in urunler)
{
    Console.WriteLine(urun.Adi);
   
}

sepetManager.Ekle(urun1);

Console.ReadLine();
