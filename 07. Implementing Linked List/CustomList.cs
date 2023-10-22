using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop
{
    public class CustomList
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }

        public int Count { get; set; }

        public void AddLast(int value)
        {
            Node node = new Node(value);
            if (Tail == null)
            {
                Head = node;
                Tail = node;
                return;
            }
            Tail.Next = node;
            node.Previous = Tail;
            Tail = node;
        }

        public void AddFirst(int value)
        {
            Node node = new Node(value);
            if (Tail == null)
            {
                Head = node;
                Tail = node;
                return;
            }

            Head.Previous = node;
            node.Next = Head;
            Head = node;
        }

        public void ForEach(Action<Node> action)
        {
            Node node = Head;

            while (node != null)
            {
                action(node);
                node = node.Next;
            }
        }

        public int[] ToArray()
        {
            int[] array = new int[Count];
            int index = 0;
            ForEach(n => array[index++] = n.Value);
            return array;
        }

        public Node RemoveFirst()
        {
            Node oldHead = Head;
            Node newHead = Head.Next;
            newHead.Previous = null;
            Head = newHead;

            return oldHead;
        }

        public Node RemoveLast()
        {
            Node oldTail = Tail;
            Node newTail = Tail.Previous;
            newTail.Next = null;
            //Tail.Previous = null;
            Tail = newTail;

            return oldTail;
        }
    }
}
