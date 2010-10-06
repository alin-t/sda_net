using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoubleLinkedList
{
    class DoubleLinkedList
    {
        public Link First { get; set; }
        public Link Last { get; set; }
        public DoubleLinkedList()
        {
            First = Last = null;
        }

        public bool IsEmpty()
        {
            return First == null;
        }

        public void InsertFirst(int data)
        {
            Link newLink = new Link() {Data = data};
            if (IsEmpty())
            {
                First = newLink;
            }
            else
            {
                newLink.Next = First;
                First.Previous = newLink;
            }

            First = newLink;
        }
    }
}
