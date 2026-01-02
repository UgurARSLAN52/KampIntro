using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class GamerManager
    {
        public void Add(Gamer gamer, GamerVerificationCheck check)
        {
            
            if (gamer.Ad == check.Ad && gamer.Soyad == check.Soyad && gamer.TcNo == check.TcNo && gamer.DogumYili == check.DogumYili)
            {
                Console.WriteLine(gamer.GamerName +" sisteme kaydınız başarılı olmuştur");
            }
            else
            {
                Console.WriteLine("Lütfen bilgilerinizi kontrol ediniz.");
            }
        }
        public void Remove(Gamer gamer) 
        {
            Console.WriteLine(gamer.GamerName + " oyundan kaydınız silinmiştir.");
        }
        public void UpDate(Gamer gamer)
        {
            Console.WriteLine(gamer.GamerName + " oyundaki bilgileriniz güncellenmiştir.");
        }
    }
}
