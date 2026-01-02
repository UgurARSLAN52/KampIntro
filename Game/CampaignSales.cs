using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class CampaignSales
    {
        public void Add(GameItems gameItems) 
        {
            Console.WriteLine(gameItems.ItemName + " üründe %10 indirim eklendi");
        }

        public void Delete(GameItems gameItems)
        {
            Console.WriteLine(gameItems.ItemName + " üründeki indirim kaldırılmıştır.");
        }
        public void Update(GameItems gameItems)
        {
            Console.WriteLine(gameItems.ItemName + " üründe %10 indirim % 15 olarak güncellenmiştir.");
        }
    }
}
