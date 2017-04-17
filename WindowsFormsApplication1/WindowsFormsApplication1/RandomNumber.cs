using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public class RandomNum
    {
        Random mRandom;

        public RandomNum()
        {
            mRandom = new Random(Guid.NewGuid().GetHashCode());
        }

        public List<int> GetRandomNum()
        {
            List<int> NumList = new List<int>();
            int num;

            for (int i = 0 ; i < 6 ; i++)
            {
                num = mRandom.Next(1, 50);
                if (!IsPresent(num, NumList))
                {
                    NumList.Add(num);
                }
                else
                {
                    if (i != 0)
                    {
                        i--;
                    }
                }
            }

            return NumList;
        }

        bool IsPresent(int Num, List<int> NumList)
        {
            if (NumList.Count == 0)
            {
                return false;
            }

            for (int i = 0 ; i < NumList.Count ; i++)
            {
                if (NumList[i] == Num)
                {
                    return true;
                }
            }

            return false;
        }
    }
}