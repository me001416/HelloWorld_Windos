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

        public FourCombin(int x1, int x2, int x3, int x4, int c1, int m1, int d1, int y1) : base(x1, x2, x3, c1, m1, d1, y1)
        {
            num4 = x4;
        }
    }

    public class FiveCombin : FourCombin
    {
        public int num5;

        public FiveCombin(int x1, int x2, int x3, int x4, int x5, int c1, int m1, int d1, int y1) : base(x1, x2, x3, x4, c1, m1, d1, y1)
        {
            num5 = x5;
        }
    }

    public class SixCombin : FiveCombin
    {
        public int num6;

        public SixCombin(int x1, int x2, int x3, int x4, int x5, int x6, int c1, int m1, int d1, int y1) : base(x1, x2, x3, x4, x5, c1, m1, d1, y1)
        {
            num6 = x6;
        }
    }
    
    public class Combinations
    {
        public List<ThreeCombin> combine(PowerBall powerBall, int k, int count)
        {
            List<ThreeCombin> resultList = new List<ThreeCombin>();

            powerBall.UpdateList();

            if (powerBall.numList.Count != 0 && k != 0 && powerBall.numList.Count >= k)
            {
                ThreeCombin tCombinList = new ThreeCombin(count, powerBall.mouth, powerBall.day, powerBall.year);
                doCombin(0, powerBall.numList.Count, k, resultList, tCombinList, powerBall);
            }

            if (count == 0)
            {
                //MessageBox.Show("resultList.Count : " + resultList.Count);
                //MessageBox.Show("ResultList[0] [" + resultList[0].num1 + "][" + resultList[0].num2 + "][" + resultList[0].num3 + "]: ");
            }

            return resultList;
        }

        public void doCombin(int start, int end, int deep, List<ThreeCombin> resultList, ThreeCombin tCombinList, PowerBall sourceList)
        {
            for (int i = start; i < end; i++)
            {
                if (end - i < deep)
                {
                    //MessageBox.Show("i : " + i);
                    //MessageBox.Show("deep : " + deep);
                    //MessageBox.Show("ResultList[0] [" + resultList[0].num1 + "][" + resultList[0].num2 + "][" + resultList[0].num3 + "]: ");
                    return;
                }
                //MessageBox.Show("sourceList.numList[i].num : " + sourceList.numList[i].num);
                tCombinList.numList.Add(sourceList.numList[i].num);

                if (deep - 1 == 0)
                {
                    tCombinList.NumToLIst(false);

                    //MessageBox.Show("tCombinList [" + tCombinList.num1 + "][" + tCombinList.num2 + "][" + tCombinList.num3 + "]: " );

                    //resultList.Add(tCombinList);
                    resultList.Add(new ThreeCombin(tCombinList.num1, tCombinList.num2, tCombinList.num3, tCombinList.count, tCombinList.mouth, tCombinList.day, tCombinList.year));
                    tCombinList.numList.RemoveAt(tCombinList.numList.Count - 1);

                    //MessageBox.Show("ResultList[0] [" + resultList[0].num1 + "][" + resultList[0].num2 + "][" + resultList[0].num3 + "]: ");
                }
                else
                {
                    doCombin(i + 1, end, deep - 1, resultList, tCombinList, sourceList);
                    tCombinList.numList.RemoveAt(tCombinList.numList.Count -1);
                }
            }
        }
    }
}