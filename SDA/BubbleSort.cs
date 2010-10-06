using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SDA
{
    class BubbleSort
    {
        private double[] a;
        private int nElems;

        public void Sort()
        {
            int outIndex, inIndex;

            for(outIndex = nElems-1; outIndex > 1; outIndex--)
            {
                for(inIndex = 0; inIndex < outIndex; inIndex++)
                {
                    if (a[inIndex] > a[inIndex + 1])
                    {
                        swap(inIndex, inIndex + 1);
                    }
                }
            }
        }

        private void swap(int inIndex, int p)
        {
            double temp = a[p];
            a[p] = a[inIndex];
            a[inIndex] = temp;
        }
    }
}
