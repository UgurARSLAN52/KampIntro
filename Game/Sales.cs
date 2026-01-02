using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Sales
    {
        public void GameSales(GameItems gameItems,Gamer gamer)
        {
            Console.WriteLine(gameItems.ItemName + " ürünü " +gamer.GamerName + " sizlere satılmıştır.");
        }
    }
}
