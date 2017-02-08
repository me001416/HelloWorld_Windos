using System;
using System.Collections.Generic;

namespace WindowsFormsApplication1
{
    public class BubbleSort
    {
        public BubbleSort(List<int> x, int count)
        {
            if (x.Count != 0)
            {
                for (int i = 1; i <= x.Count; i++)
                {
                    for (int j = 1; j <= x.Count; j++)
                    {
                        if (x[j] < x[j - 1])
                        {
                            int temp = x[j];
                            x[j] = x[j - 1];
                            x[j - 1] = temp;
                        }
                    }
                }
            }
        }
    }
}