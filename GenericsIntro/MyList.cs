﻿using System;
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
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] TempArray = items;
            items = new T[items.Length + 1];

            for (int i = 0; i < TempArray.Length; i++)
            {
                items[i] = TempArray[i];
            }

            items[items.Length - 1] = item;
        }
    }
}
