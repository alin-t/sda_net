using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkedList
{
    class Link
    {
        public int Data { get; set; }
        public Link Next { get; set; }

        public void DisplayLink()
        {
            Console.WriteLine("{" + Data + "}");
        }
    }
}
