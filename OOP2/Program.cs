// See https://aka.ms/new-console-template for more information
using OOP2;

Console.WriteLine("Hello, World!");

GercekMusteri gercekMusteri1 = new GercekMusteri();
gercekMusteri1.Id = 1;
gercekMusteri1.MusteriNo = "1234";
gercekMusteri1.Adi = "uğur";
gercekMusteri1.Soyadi = "Arslan";
gercekMusteri1.TcNo = "12154545";

TuzelMusteri tuzelMusteri1= new TuzelMusteri();
tuzelMusteri1 .Id = 2;
tuzelMusteri1.MusteriNo = "1235550";
tuzelMusteri1.SirketAdi = "asdfv";
tuzelMusteri1.VergiNo = "547878";

Musteri musteri3 = new TuzelMusteri();
Musteri musteri4 = new GercekMusteri();

MusteriManager musteriManager = new MusteriManager();
musteriManager.Add(gercekMusteri1);
musteriManager.Add(tuzelMusteri1);
musteriManager.Add(musteri4);
musteriManager.Add(musteri3);