﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._ArrayCreator
{
    static class ArrayCreator<T>
    {
        public static T[] Create(int length, T item)
        {
            T[] result = new T[length];

            for (int i = 0; i < length; i++)
            {
                result[i] = item;
            }

            return result;
        }
    }
}
