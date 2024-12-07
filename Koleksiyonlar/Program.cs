// See https://aka.ms/new-console-template for more information

using System.Collections.Generic;

//string[] isimler = new string[] {"uğur", "engin","ali","veli"};
//foreach (var isim in isimler)
//{
//    Console.WriteLine(isim);
//}


List<string> isimler2 = new List<string>() { "uğur", "engin", "ali", "veli" };
Console.WriteLine(isimler2[0]);
Console.WriteLine(isimler2[1]);
Console.WriteLine(isimler2[2]);
Console.WriteLine(isimler2[3]);
isimler2.Add("ilker");
Console.WriteLine(isimler2[4]);
Console.WriteLine(isimler2[0]);