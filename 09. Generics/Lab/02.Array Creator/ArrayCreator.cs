﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericArrayCreator
{
    public class ArrayCreator
    {
        public static T[] Create<T>(int length, T item)
        {
            T[] current = new T[length];

            for (int i = 0; i < length; i++)
            {
                current[i] = item;
            }
            return current;
        }

    }
}
