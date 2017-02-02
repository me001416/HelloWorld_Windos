using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public struct PowerBall
    {
        //
        // number.
        //
        public PowerBallNumber num1;
        public PowerBallNumber num2;
        public PowerBallNumber num3;
        public PowerBallNumber num4;
        public PowerBallNumber num5;
        public PowerBallNumber num6;

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
            return "Num1 : " + num1.num + " ; " + "Num2 : " + num2.num + " ; " + "Num3 : " + num3.num + " ; " + "Num4 : " + num4.num + " ; " + "Num5 : " + num5.num + " ; " + "Num6 : " + num6.num;
        }

        public void SetValue(int x1, int x2, int x3, int x4, int x5, int x6)
        {
            num1.num = x1;
            num2.num = x2;
            num3.num = x3;
            num4.num = x4;
            num5.num = x5;
            num6.num = x6;
        }

        public void ShowData()
        {
            MessageBox.Show("Num1 : " + num1.num + " ; " + "Num2 : " + num2.num + " ; " + "Num3 : " + num3.num + " ; " + "Num4 : " + num4.num + " ; " + "Num5 : " + num5.num + " ; " + "Num6 : " + num6.num);
        }
    }

    public struct PowerBallNumber
    {
        //
        // number.
        //
        public int num;

        //
        // Number to String.
        //
        public string NumToString()
        {
            string str;

            str = num.ToString();

            if (string.IsNullOrEmpty(str))
            {
                str = "NULL";
            }

            return str;
        }
    }
}
