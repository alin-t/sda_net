using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SDA
{
    interface IQueue
    {
        void Insert(int i);
        int Remove();
        int PeekFront();
        bool IsEmpty();
        bool IsFull();
        int Size();
    }
}
