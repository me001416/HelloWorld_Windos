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

                    _NumArray[0] = _PowerBall[i].num1.num;
                    _NumArray[1] = _PowerBall[i].num2.num;
                    _NumArray[2] = _PowerBall[i].num3.num;
                    _NumArray[3] = _PowerBall[i].num4.num;
                    //_NumArray[4] = _PowerBall[i].num5.num;
                    //_NumArray[5] = _PowerBall[i].num6.num;
                    //_NumArray[6] = _PowerBall[i].num7.num;

                    for (int index0 = 2; index0 < 7; index0++)
                    {
                        for (int index1 = 1; index1 < 6; index1++)
                        {
                            for (int index2 = 0; index2 < 5; index2++)
                            {
                                //if (((index2 + index1) < 6 && (index2 + index0) < 7) && ((index2 != (index2 + index1)) && (index2 != (index2 + index0)) && ((index2 + index1) != (index2 + index0))))
                                //if ((index2 + index1) < 7 && (index2 + index0) < 7 && (index0 + index1) < 7)
                                if ((index2 + index1) < 7 && (index2 + index0) < 7)
                                {
                                    if ((index2 != index1) && (index2 != index0) && (index1 != index0))
                                    {
                                        //_ThreeCombin.Add(new ThreeCombin(_NumArray[index2], _NumArray[index2 + index1], _NumArray[index2 + index0], i + 1, _PowerBall[i].mouth, _PowerBall[i].day, _PowerBall[i].year));
                                        _ThreeCombin.Add(new ThreeCombin(_NumArray[index2], _NumArray[index1], _NumArray[index0], i + 1, _PowerBall[i].mouth, _PowerBall[i].day, _PowerBall[i].year));

                                        if (i == 0)
                                        {
                                            index3++;
                                        }
                                    }
                                }
                            }
                        }
                    }
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