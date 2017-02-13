using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public class ThreeCombin
    {
        public int num1;
        public int num2;
        public int num3;

        public List<int> numList = new List<int>();

        public int count;

        public int mouth;
        public int day;
        public int year;

        public int hitCount;

        public ThreeCombin(List<int> sourceList, int c1, int m1, int d1, int y1)
        {
            numList = sourceList;

            if (numList.Count == 3)
            {
                num1 = numList[0];
                num2 = numList[1];
                num3 = numList[2];
            }

            count = c1;
            mouth = m1;
            day = d1;
            year = y1;
            hitCount = 0;
        }

        public ThreeCombin(int c1, int m1, int d1, int y1)
        {
            count = c1;
            mouth = m1;
            day = d1;
            year = y1;
        }

        public ThreeCombin(int x1, int x2, int x3, int c1, int m1, int d1, int y1)
        {
            num1 = x1;
            num2 = x2;
            num3 = x3;

            count = c1;

            mouth = m1;
            day = d1;
            year = y1;
        }

        public void update()
        {
            numList = new List<int>();

            numList.Add(num1);
            numList.Add(num2);
            numList.Add(num3);

            BubbleSort _BubbleSort = new BubbleSort(numList, numList.Count);

            num1 = numList[0];
            num2 = numList[1];
            num3 = numList[2];
        }

        public void NumToLIst(Boolean Active)
        {
            if (Active)
            {
                numList.Add(num1);
                numList.Add(num2);
                numList.Add(num3);
            }
            else
            {
                if (numList.Count == 3)
                {
                    num1 = numList[0];
                    num2 = numList[1];
                    num3 = numList[2];
                }
            }
        }
    }

    public class FourCombin : ThreeCombin
    {
        public int num4;

        public FourCombin(List<int> sourceList, int c1, int m1, int d1, int y1)
            : base(sourceList, c1, m1, d1, y1)
        {
            if (numList.Count == 4)
            {
                num1 = numList[0];
                num2 = numList[1];
                num3 = numList[2];
                num4 = numList[3];
            }
        }

        public FourCombin(int x1, int x2, int x3, int x4, int c1, int m1, int d1, int y1) : base(x1, x2, x3, c1, m1, d1, y1)
        {
            num4 = x4;
        }
    }

    public class FiveCombin : FourCombin
    {
        public int num5;

        public FiveCombin(List<int> sourceList, int c1, int m1, int d1, int y1)
            : base(sourceList, c1, m1, d1, y1)
        {
            if (numList.Count == 5)
            {
                num1 = numList[0];
                num2 = numList[1];
                num3 = numList[2];
                num4 = numList[3];
                num5 = numList[4];
            }
        }

        public FiveCombin(int x1, int x2, int x3, int x4, int x5, int c1, int m1, int d1, int y1) : base(x1, x2, x3, x4, c1, m1, d1, y1)
        {
            num5 = x5;
        }
    }

    public class SixCombin : FiveCombin
    {
        public int num6;

        public SixCombin(List<int> sourceList, int c1, int m1, int d1, int y1)
            : base(sourceList, c1, m1, d1, y1)
        {
            if (numList.Count == 6)
            {
                num1 = numList[0];
                num2 = numList[1];
                num3 = numList[2];
                num4 = numList[3];
                num5 = numList[4];
                num6 = numList[5];
            }
        }

        public SixCombin(int x1, int x2, int x3, int x4, int x5, int x6, int c1, int m1, int d1, int y1) : base(x1, x2, x3, x4, x5, c1, m1, d1, y1)
        {
            num6 = x6;
        }
    }
    
    public class Combinations
    {
        public List<List<int>> NewCombine(List<int> sourceList, int k)
        {
            List<List<int>> resultList = new List<List<int>>();

            if (sourceList.Count != 0 && k != 0 && sourceList.Count >= k )
            {
                List<int> tCombinList = new List<int>();
                doCombin(0, sourceList.Count, k, resultList, tCombinList, sourceList);
            }

            return resultList;
        }

        public void doCombin(int start, int end, int deep, List<List<int>> resultList, List<int> tCombinList, List<int> sourceList)
        {
            for (int i = start; i < end; i++)
            {
                if (end - i + 1 < deep)
                {
                    return;
                }

                tCombinList.Add(sourceList[i]);

                if (deep - 1 == 0)
                {
                    resultList.Add(new List<int> (tCombinList));
                    tCombinList.RemoveAt(tCombinList.Count - 1);
                }
                else
                {
                    doCombin(i + 1, end, deep - 1, resultList, tCombinList, sourceList);
                    tCombinList.RemoveAt(tCombinList.Count - 1);
                }
            }
        }
    }
}