using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SDA
{
    class Queue : IQueue
    {
        private int queueSize;
        private int[] queueArray;
        private int front;
        private int rear;
        private int nItems;

        public Queue(int size)
        {
            this.queueSize = size;
            queueArray = new int[size];

            front = 0;
            rear = -1;
            nItems = 0;
        }

        public void Insert(int i)
        {
            if (rear == queueSize - 1)
                rear = -1;
            queueArray[++rear] = i;
            nItems++;
        }

        public int Remove()
        {
            int temp = queueArray[front++];
            if (front == queueSize)
                front = 0;
            nItems--;

            return temp;
        }

        public int PeekFront()
        {
            return queueArray[front];
        }

        public bool IsEmpty()
        {
            return nItems == 0;
        }

        public bool IsFull()
        {
            return nItems == queueSize;
        }

        public int Size()
        {
            return nItems;
        }
    }
}
