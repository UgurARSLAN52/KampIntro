// See https://aka.ms/new-console-template for more information

using System.Collections.Generic;

string[] names = new string[] { "Ali", "Ayşe", "Fatma", "Mehmet" };
Console.WriteLine(names[0]);
Console.WriteLine(names[1]);
Console.WriteLine(names[2]);
Console.WriteLine(names[3]);

names = new string[5];  // burada new dediğimizde yeniden refens alan oluşturduk ve önceki veriler kayboldu
names[4] = "Uğur";
Console.WriteLine(names[4]);
Console.WriteLine(names[0]);

// burada array kullanımı pratik değil çünkü boyutunu önceden bilmemiz gerekiyor ve yeniden boyutlandırma yapamıyoruz
// bu yüzden koleksiyonlar kullanılır

List<string> names2 = new List<string> {"Ali","Veli","Hasan","Hüseyin" };
Console.WriteLine(names2[0]);
Console.WriteLine(names2[1]);
Console.WriteLine(names2[2]);
Console.WriteLine(names2[3]);
names2.Add("Ayşe"); // listeye eleman ekleme
Console.WriteLine(names2[4]);
Console.WriteLine(names2[0]);