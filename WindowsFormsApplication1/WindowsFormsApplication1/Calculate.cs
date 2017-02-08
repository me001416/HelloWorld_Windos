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

                    _NumArray[0] = _PowerBall[i].num1.num;
                    _NumArray[1] = _PowerBall[i].num2.num;
                    _NumArray[2] = _PowerBall[i].num3.num;
                    _NumArray[3] = _PowerBall[i].num4.num;
                    _NumArray[4] = _PowerBall[i].num5.num;
                    _NumArray[5] = _PowerBall[i].num6.num;
                    _NumArray[6] = _PowerBall[i].num7.num;

                    for (int j = 0; j < 7; j++)
                    {
                        for (int k = 0; k < 5; k++)
                        {
                            if ((j + k + 2) < 7)
                            {
                                _ThreeCombin.Add(new ThreeCombin(_NumArray[j], _NumArray[j + k + 1], _NumArray[j + k + 2], i, _PowerBall[i].mouth, _PowerBall[i].day, _PowerBall[i].year));
                            }
                        }
                    }
                }
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