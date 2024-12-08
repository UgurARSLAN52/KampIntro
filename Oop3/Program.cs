// See https://aka.ms/new-console-template for more information

using System.Collections.Generic;
using Oop3;

IKrediManager tasitKrediManager = new TasitKrediManager();
IKrediManager konutKrediManager = new KonutKrediManager();
IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();

ILoggerService dataBaseLoggerService = new DataBaseLoggerService();
ILoggerService fileLoggerService = new FileLoggerService();


BasvuruManager basvuruManager = new BasvuruManager();
basvuruManager.BasvuruYap(tasitKrediManager, fileLoggerService);

List<IKrediManager> krediler = new List<IKrediManager> { konutKrediManager, tasitKrediManager };

//basvuruManager.KrediOnBilgilendirmesiYap(krediler);
