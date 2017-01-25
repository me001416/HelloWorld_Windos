using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public struct PowerBall
    {
        //
        // number.
        //
        public int num1;
        public int num2;
        public int num3;
        public int num4;
        public int num5;
        public int num6;

        //
        // mm/dd/yyyy
        //
        public int mouth;
        public int day;
        public int year;

        //
        // return a string.
        //
        public override string ToString()
        {
            return "num1 : " + num1 + "," + "num2 : " + num2 + "," + "num3 : " + num3 + "," + "num4 : " + num4 + "," + "num5 : " + num5 + "," + "num6 : " + num6;
        }

        public void SetValue(int x1, int x2, int x3, int x4, int x5, int x6)
        {
            num1 = x1;
            num2 = x2;
            num3 = x3;
            num4 = x4;
            num5 = x5;
            num6 = x6;
        }
    }
}
