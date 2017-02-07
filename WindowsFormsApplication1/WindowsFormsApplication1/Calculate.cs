using System;
using System.Collections.Generic;

namespace WindowsFormsApplication1
{
    public class HitCounter
    {
        public void Report(List<PowerBall> _PowerBall)
        {
            int[] array = new int[50];
            string[] stringArray = new string[50];
            File_Owner fileOwner = new File_Owner(@"D:\CODE\ForFun\C_Sharp\Test\Report.txt", true);

            if (_PowerBall.Count != 0)
            {
                for (int i = 0; i < _PowerBall.Count; i++)
                {
                    array[_PowerBall[i].num1.num]++;
                    array[_PowerBall[i].num2.num]++;
                    array[_PowerBall[i].num3.num]++;
                    array[_PowerBall[i].num4.num]++;
                    array[_PowerBall[i].num5.num]++;
                    array[_PowerBall[i].num6.num]++;
                    array[_PowerBall[i].num7.num]++;
                }
            }

            stringArray[0] = "Count = " + _PowerBall.Count;

            for (int i = 1; i < 50; i++)
            {
                stringArray[i] = "Number " + i + " = " + array[i];
            }

            fileOwner.WriteReport(stringArray, 50);

            fileOwner.StopWrite();
        }
    }
}