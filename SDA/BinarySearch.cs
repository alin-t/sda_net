using System;

namespace SDA
{
    class BinarySearch
    {
        private const int Size = 10;
        private readonly double[] _elements = new double[Size];

        public BinarySearch()
        {
            Init();
        }

        private void Init()
        {
            for (int i = 0; i < Size; i++)
            {
                _elements[i] = new Random().Next(0, 30);
            }
        }

        public int Find(double searchKey)
        {
            int lowerBound = 0;
            int upperBound = Size - 1;

            while (true)
            {
                int curIn = (upperBound + lowerBound) / 2;

                if (lowerBound > upperBound) return -1;

                if (_elements[curIn] == searchKey)
                    return curIn;

                if (_elements[curIn] > searchKey)
                {
                    lowerBound = curIn + 1;
                }
                else
                {
                    upperBound = curIn - 1;
                }
            }
        }
    }
}
