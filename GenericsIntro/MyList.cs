using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
     class MyList<T>
    {

        T[] items;
        public MyList()
        { 
            // bu bloğa constructor denir.
            items = new T[0];
        }

        public void Add(T item) 
        {
            T[] tempArray = items;
            items = new T[items.Length + 1];
        }
    }
}
