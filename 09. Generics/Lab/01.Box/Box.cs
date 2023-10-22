using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxOfT
{
    public class Box<T>
    {
        private List<T> boxes;

        public Box()
        {
            boxes = new List<T>();
        }
        public void Add(T element)
        {
            boxes.Add(element);
        }

        public int Count
        {
            get => boxes.Count;
        }
        public T Remove()
        {
            T current = boxes.Last();

            boxes.RemoveAt(boxes.Count - 1);

            return current;
        }

    }
}
