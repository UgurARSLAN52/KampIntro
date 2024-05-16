// See https://aka.ms/new-console-template for more information


using OOP3;
using System.Collections.Generic;

IKrediManager konutKrediManager = new KonutKrediManager();
konutKrediManager.Hesapla();

IKrediManager ihtiyacKredisi = new IhtiyacKrediManager();
ihtiyacKredisi.Hesapla();

IKrediManager tasitKrediManager = new TasitKrediManager();
tasitKrediManager.Hesapla();

ILoggerService dataBaseLoggerService = new DataBaseLoggerService();
ILoggerService fileLoggerService = new FileLoggerService();

BasvuruManager basvuruManager = new BasvuruManager();
basvuruManager.BasvuruYap(new EsnafKradisiManager(), new List<ILoggerService> { dataBaseLoggerService , new SmsLoggerService()});


Console.WriteLine("----------------------------------------------");
List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKredisi, tasitKrediManager };
basvuruManager.KrediOnBilgilendirmesiYap(krediler);   