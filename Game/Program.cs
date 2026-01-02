// See https://aka.ms/new-console-template for more information

using Game;

GamerVerificationCheck check = new GamerVerificationCheck();
check.Ad = "Uğur";
check.Soyad = "ARSLAN";
check.TcNo = "12345678911";
check.DogumYili = "1993";

Gamer gamer = new Gamer();
gamer.Id = 1;
gamer.GamerName = "UgurARSLAN";
gamer.Ad = "Uğur";
gamer.Soyad = "ARSLAN";
gamer.Email = "ugurarslan@hotmail.com";
gamer.TcNo = "12345678911";
gamer.DogumYili = "1993";
gamer.Password = "1234";

GameItems gameItems = new GameItems();
gameItems.Id = 1;
gameItems.ItemName = "Zırh";
gameItems.ItemPrice= 100;

GamerManager gamerManager = new GamerManager();
gamerManager.Add(gamer, check);

Sales sales = new Sales();
sales.GameSales(gameItems, gamer);

CampaignSales campaignSales = new CampaignSales();
campaignSales.Update(gameItems);