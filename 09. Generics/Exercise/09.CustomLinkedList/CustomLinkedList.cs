using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.CustomLinkedList
{
    public class CustomLinkedList
    {
        public class CustomDoublyLinkedList<T>
        {
            private class ListNode
            {
                public ListNode(T value)
                {
                    Value = value;
                }

                public ListNode NextNode { get; set; }

                public ListNode PreviousNode { get; set; }

                public T Value { get; set; }
            }

            private ListNode head;
            private ListNode tail;

            public int Count { get; private set; }

            public void AddFirst(T element)
            {
                ListNode newHead = new(element);
            }
}
