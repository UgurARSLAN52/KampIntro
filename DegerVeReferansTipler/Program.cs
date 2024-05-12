// See https://aka.ms/new-console-template for more information


//Değer tip
int sayi1 = 10;
int sayi2 = 30;
sayi1 = sayi2;
sayi2 = 65;
Console.WriteLine(sayi1);

//Referans tip
int[] sayilar1 = new int[] {10, 20, 30};
int[] sayilar2 = new int[] { 100, 200, 200 };
sayilar1 = sayilar2;
sayilar2[0] = 999;
Console.WriteLine(sayilar1[0]);