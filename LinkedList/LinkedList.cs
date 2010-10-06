using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkedList
{
    class LinkedList
    {
        private Link first;

        public LinkedList()
        {
            first = null;
        }

        public bool IsEmpty()
        {
            return first == null;
        }

        public void InsertFirst(int data)
        {
            var newLink = new Link {Data = data, Next = first};
            first = newLink;
        }

        public Link DeleteFirst()
        {
            Link temp = first;
            first = first.Next;

            return temp;
        }

        public Link Find(int key)
        {
            Link current = first;
            while (current.Data != key)
            {
                if (current.Next == null)
                {
                    return null;
                }
                current = current.Next;
            }
            return current;
        }

        public Link Delete(int key)
        {
            Link current = first;
            Link previous = first;

            while (current.Data != key)
            {
                if (current.Next == null)
                {
                    return null;
                }
                previous = current;
                current = current.Next;
            }

            if (current == first)
            {
                first = first.Next;
            }
            else
            {
                previous.Next = current.Next;
            }

            return current;
        }

        public void DisplayList()
        {
            Link current = first;

            while (current != null)
            {
                current.DisplayLink();
                current = current.Next;
            }
        }
    }
}
