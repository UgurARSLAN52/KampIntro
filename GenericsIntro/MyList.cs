using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    // ListeTip yerine sadece T yazabiliriz
    internal class MyList<ListeTip>
    {
        ListeTip[] items;
        public MyList()
        {
            items = new ListeTip[0];
        }
        // item eleman anlamında kullanılır
        public void Add(ListeTip item) 
        {
            //tempArray geçici dizi yazını new lediğimizde referans numarası kaybolmasın diye "" ListeTip[] tempArray = items; "" bu kod bloğuna tutturuyoruz.
            ListeTip[] tempArray = items;
            items = new ListeTip[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length-1]= item;
            
            
        }

        public int Length
        {
            get { return items.Length; }
        }
        public ListeTip[] Items
        { 
        get {return items; }
                }
    }
}
