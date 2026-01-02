// See https://aka.ms/new-console-template for more information


using OOP3;

IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
ihtiyacKrediManager.Hesapla();

TasitKrediManager tasitKrediManager = new TasitKrediManager();
tasitKrediManager.Hesapla();

KonutKrediManager konutKrediManager = new KonutKrediManager();
konutKrediManager.Hesapla();

Console.WriteLine("------------------------");

IKrediManager ihtiyacKrediManager1 = new IhtiyacKrediManager();
ihtiyacKrediManager1.Hesapla();

Console.WriteLine("-------------------------");

BasvuruManager basvuruManager = new BasvuruManager();
basvuruManager.BasvuruYap(new KonutKrediManager(), new DataBaseLoggerService());
Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");
List<IKrediManager> krediler = new List<IKrediManager>() 
{
    new IhtiyacKrediManager(), 
    new TasitKrediManager(),  
    new KonutKrediManager() 
};

basvuruManager.KrediOnBilgilendirmesiYap(krediler);
