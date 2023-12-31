﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.GenericBoxofString
{
    public class Box<T>
    {
        public Box(T item)
        {
            Item = item;
        }
        public T Item { get; set; }

        public override string ToString()
        {
            return $"{typeof(T)}: {Item}";
        }
    }
}
