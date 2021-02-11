using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyDictionary<T>
    {
        T[] items;

        public MyDictionary()
        {
            items =  new T[0];
        }

        public void Add(T item)
        {
            T[] tempArray = items;
            items = new T[items.Length + 1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                tempArray[i] = items[i];
            }
            items[items.Length - 1] = item;

        }
    }
}
