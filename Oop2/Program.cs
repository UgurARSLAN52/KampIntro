// See https://aka.ms/new-console-template for more information

using Oop2;

GercekMusteri musteri1 = new GercekMusteri();
musteri1.Id = 1;
musteri1.MusteriNo="12345";
musteri1.Adi = "Uğur";
musteri1.Soyadi = "ARSLAN";
musteri1.Tcno = "1234565444";

TuzelMusteri musteri2 = new TuzelMusteri();
musteri2.Id = 2;
musteri2 .MusteriNo = "12345555";
musteri2.SirketAdi = "Arlan endüstriyel";
musteri2.VergiNo = "78892588";

MusteriManager musteriManager1 = new MusteriManager();

Musteri musteri3 = new TuzelMusteri ();
Musteri musteri4 = new GercekMusteri ();

musteriManager1.Ekle(musteri1);

