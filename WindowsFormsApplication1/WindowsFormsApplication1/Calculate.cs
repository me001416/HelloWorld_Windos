using System;
using System.Collections.Generic;

namespace WindowsFormsApplication1
{
    public class HitCounter
    {
        public void Report(List<PowerBall> _PowerBall)
        {
            int[] array = new int[50];
            int[] _NumArray = new int[7];
            File_Owner fileOwner = new File_Owner(@"D:\CODE\ForFun\C_Sharp\Test\Report.txt", true);
            List<ThreeCombin> _ThreeCombin = new List<ThreeCombin>();
            List<string> stringList = new List<string>();
            int index3 = 0;

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

                    Combinations combin = new Combinations();

                    _ThreeCombin.AddRange(combin.combine(_PowerBall[i], 3, i));
                }
            }

            if (_ThreeCombin.Count != 0)
            {
                stringList.Add("index3 =" + index3);

                for (int i = 0; i < _ThreeCombin.Count; i++)
                {
                    //_ThreeCombin[i].update();
                    stringList.Add("Number Combination [" + _ThreeCombin[i].num1 + "][" + _ThreeCombin[i].num2 + "][" + _ThreeCombin[i].num3 + "], count = " + _ThreeCombin[i].count);
                }

                stringList.Add("\r");
            }

            stringList.Add("Count = " + _PowerBall.Count);

            for (int i = 1; i < 50; i++)
            {
                stringList.Add("Number " + i + " = " + array[i]);
            }

            fileOwner.WriteReport(stringList, stringList.Count);

            fileOwner.StopWrite();
        }
    }
}