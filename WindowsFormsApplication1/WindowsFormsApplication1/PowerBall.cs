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
        int _mouth;
        int _day;
        int _year;

        //
        // number.
        //
        public PowerBallNumber num1;
        public PowerBallNumber num2;
        public PowerBallNumber num3;
        public PowerBallNumber num4;
        public PowerBallNumber num5;
        public PowerBallNumber num6;
        public PowerBallNumber num7;

        //
        // mm/dd/yyyy
        //
        public int mouth
        {
            get
            {
                return _mouth;
            }
            set
            {
                if (value < 1 || value > 12)
                {
                    MessageBox.Show("The value " + value + " was wrong " + "\r" + "It shound > 0 and < 13");
                }
                else
                {
                    _mouth = value;
                }
            }
        }

        public int day
        {
            get
            {
                return _day;
            }
            set
            {
                if (value < 1 || value > 31)
                {
                    MessageBox.Show("The value " + value + " was wrong " + "\r" + "It shound > 0 and < 32");
                }
                else
                {
                    _day = value;
                }
            }
        }

        public int year
        {
            get
            {
                return _year;
            }
            set
            {
                if (value < 1990 || value > 2050)
                {
                    MessageBox.Show("The value " + value + " was wrong " + "\r" + "It shound > 1989 and < 2051");
                }
                else
                {
                    _year = value;
                }
            }
        }

        public PowerBall(int xx) : this()
        {
            this.num1.num = xx;
        }

        //
        // return a string.
        //
        public override string ToString()
        {
            return "Num1 : " + num1.num + " ; " + "Num2 : " + num2.num + " ; " + "Num3 : " + num3.num + " ; " + "Num4 : " + num4.num + " ; " + "Num5 : " + num5.num + " ; " + "Num6 : " + num6.num + " ; " + "Num7 : " + num7.num;
        }

        public void SetNum(int x1, int x2, int x3, int x4, int x5, int x6, int x7)
        {
            num1.num = x1;
            num2.num = x2;
            num3.num = x3;
            num4.num = x4;
            num5.num = x5;
            num6.num = x6;
            num7.num = x7;

            num1.SpecialNum = false;
            num2.SpecialNum = false;
            num3.SpecialNum = false;
            num4.SpecialNum = false;
            num5.SpecialNum = false;
            num6.SpecialNum = false;
            num7.SpecialNum = true;

            mouth = 1;
            day   = 1;
            year  = 1990;
        }

        public void ShowData()
        {
            MessageBox.Show("Num1 : " + num1.num + " ; " + "Num2 : " + num2.num + " ; " + "Num3 : " + num3.num + " ; " + "Num4 : " + num4.num + " ; " + "Num5 : " + num5.num + " ; " + "Num6 : " + num6.num + " ; " + "Num7 : " + num7.num);
        }
    }

    public struct PowerBallNumber
    {
        int _num;

        //
        // number.
        //
        public int num
        {
            get
            {
                return _num;
            }
            set
            {
                if (value < 1 || value > 49)
                {
                    MessageBox.Show("The value " + value + " was wrong " + "\r" + "It shound > 0 and < 50");
                }
                else
                {
                    _num = value;
                }
            }
        }

        //
        // Is Special Number or not.
        //
        public Boolean SpecialNum;

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
