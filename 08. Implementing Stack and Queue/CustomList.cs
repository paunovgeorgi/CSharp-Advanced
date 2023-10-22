using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop
{
    public class CustomList
    {

        private const int InitialCapacity = 2;
        private int[] items;
        public CustomList()
        {
            items = new int[InitialCapacity];
        }

        public int Count { get; private set; }

        public int this[int index]
        {
            get
            {
                ThrowExeptionIfIndexOutOfRange(index);
                return items[index];
            }
            set
            {
                ThrowExeptionIfIndexOutOfRange(index);
                items[index] = value;
            }
        }


        public void Add(int item)
        {
            if (Count == items.Length)
            {
                Resize();
            }
            items[Count] = item;
            Count++;
        }

        public void AddRange(int[] items)
        {
            foreach (int item in items)
            {
                Add(item);
            }
        }

        public void InsertAt(int index, int item)
        {
            ThrowExeptionIfIndexOutOfRange(index);

            if (items.Length == Count)
            {
                Resize();
            }

            ShiftRight(index);

            items[index] = item;

            Count++;


        }

        public int RemoveAt(int index)
        {
            ThrowExeptionIfIndexOutOfRange(index);

            int removedItem = items[index];

            ShiftLeft(index);

            Count--;

            if (Count <= items.Length / 4)
            {
                Shrink();
            }

            return removedItem;
        }

        public bool Contains(int item)
        {
            foreach (int i in items)
            {
                if (i == item)
                {
                    return true;
                }
            }

            return false;
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            ThrowExeptionIfIndexOutOfRange(firstIndex);
            ThrowExeptionIfIndexOutOfRange(secondIndex);

            int temp = items[firstIndex];
            items[firstIndex] = items[secondIndex];
            items[secondIndex] = temp;
        }

        private void Resize()
        {
            int[] copy = new int[items.Length * 2];

            for (int i = 0; i < Count; i++)
            {
                copy[i] = items[i];
            }

            items = copy;
        }

        private void ThrowExeptionIfIndexOutOfRange(int index)
        {
            if (index <0 || index >= Count)
            {
                throw new IndexOutOfRangeException("Index is invalid");
            }
        }

        private void ShiftLeft(int index)
        {
            for (int i = index; i < Count - 1; i++)
            {
                items[i] = items[i + 1];
            }
        }

        private void ShiftRight(int index)
        {
            for (int i = Count - 1; i >= index; i--)
            {
                items[i + 1] = items[i];
            }
        }

        private void Shrink()
        {
            int[] copy = new int[items.Length / 2];

            for (int i = 0; i < Count; i++)
            {
                copy[i] = items[i];
            }

            items = copy;
        }

    }
}
