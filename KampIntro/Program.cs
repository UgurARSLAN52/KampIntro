// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//type safety = tip güvenliği
//Do not repeat yourself = kendini tekrarlama
string kategoriEtiketi = "Kategori1";
int ogrenciSayisi = 32000;
double ondalik = 10.5;
bool sistemeGirisYapmisMi = true;
Console.WriteLine(kategoriEtiketi);

if (sistemeGirisYapmisMi==true)
{
    Console.WriteLine("Sisteme giris Yapilmis");
}
else if (sistemeGirisYapmisMi==false)
{
    Console.WriteLine("Sisteme giris Yapilmamis");
}
else
{
    Console.WriteLine("islem yapılmadi");
}

double dolarDun = 7.35;
double dolarBugun = 7.45;

if (dolarDun>dolarBugun)
{
    Console.WriteLine("Azalis Butonu");
}
else if (dolarDun<dolarBugun)
{
    Console.WriteLine("Artis Butonu");
}
else
{
    Console.WriteLine("Esittir");
}











    Console.ReadLine();