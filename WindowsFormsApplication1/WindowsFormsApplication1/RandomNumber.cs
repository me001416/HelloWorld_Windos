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
            Random mRandom = new Random(Guid.NewGuid().GetHashCode());
        }

        public List<int> GetRandomNum()
        {
            List<int> NumList = new List<int>();

            for (int i = 0; i < 6; i++)
            {
                NumList.Add(mRandom.Next(1, 50));
            }

            return NumList;
        }
    }
}