using System;
using System.Collections.Generic;

namespace WindowsFormsApplication1
{
    public class ThreeCombin
    {
        public int num1;
        public int num2;
        public int num3;

        public int count;

        public int mouth;
        public int day;
        public int year;

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
    }

    public class FourCombin : ThreeCombin
    {
        public int num4;

        public FourCombin(int x1, int x2, int x3, int x4, int c1, int m1, int d1, int y1) : base(x1, x2, x3, c1, m1, d1, y1)
        {
            num1 = x1;
            num2 = x2;
            num3 = x3;
            num4 = x4;

            count = c1;

            mouth = m1;
            day = d1;
            year = y1;
        }
    }

    public class FiveCombin : FourCombin
    {
        public int num5;

        public FiveCombin(int x1, int x2, int x3, int x4, int x5, int c1, int m1, int d1, int y1) : base(x1, x2, x3, x4, c1, m1, d1, y1)
        {
            num1 = x1;
            num2 = x2;
            num3 = x3;
            num4 = x4;
            num5 = x5;

            count = c1;

            mouth = m1;
            day = d1;
            year = y1;
        }
    }

    public class SixCombin : FiveCombin
    {
        public int num6;
    }
}