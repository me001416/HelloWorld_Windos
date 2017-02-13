using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public class HitCounter
    {
        Dictionary<string, ThreeCombin> ThreeCombinDic = new Dictionary<string, ThreeCombin>();
        Dictionary<int, List<HitCombinations>> HitCombinDic = new Dictionary<int, List<HitCombinations>>();

        public void Report(List<PowerBall> _PowerBall)
        {
            int[] array = new int[50];
            int[] _NumArray = new int[7];
            File_Owner fileOwner = new File_Owner(@"D:\CODE\ForFun\C_Sharp\Test\Report.txt", true);
            List<ThreeCombin> _ThreeCombin = new List<ThreeCombin>();
            List<FourCombin> _FourCombin = new List<FourCombin>();
            List<FiveCombin> _FiveCombin = new List<FiveCombin>();
            List<SixCombin> _SixCombin = new List<SixCombin>();
            List<string> stringList = new List<string>();
            int index3 = 0;
            Boolean ShowMessage = false;

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
                    List<List<int>> numList = new List<List<int>>();
                    
                    _PowerBall[i].UpdateList();
                    _PowerBall[i].numList.Sort();

                    for (int k = 3; k < 7 ; k++ )
                    {
                        numList = combin.NewCombine(_PowerBall[i].numList, k);

                        if (numList.Count != 0)
                        {
                            for (int j = 0; j < numList.Count; j++)
                            {
                                switch (k)
                                {
                                    case 3:
                                        _ThreeCombin.Add(new ThreeCombin(numList[j], i, _PowerBall[i].mouth, _PowerBall[i].day, _PowerBall[i].year));
                                        break;
                                    case 4:
                                        _FourCombin.Add(new FourCombin(numList[j], i, _PowerBall[i].mouth, _PowerBall[i].day, _PowerBall[i].year));
                                        break;
                                    case 5:
                                        _FiveCombin.Add(new FiveCombin(numList[j], i, _PowerBall[i].mouth, _PowerBall[i].day, _PowerBall[i].year));
                                        break;
                                    case 6:
                                        _SixCombin.Add(new SixCombin(numList[j], i, _PowerBall[i].mouth, _PowerBall[i].day, _PowerBall[i].year));
                                        break;
                                }
                            }
                        }
                    }
                }
            }

            if (_ThreeCombin.Count != 0)
            {
                index3 = 0;

                for (int i = 0; i < _ThreeCombin.Count; i++)
                {
                    _ThreeCombin[i].NumToLIst(true);

                    if (_ThreeCombin[i].count == 0)
                    {
                        index3++;
                    }
                    else
                    {
                        if (_ThreeCombin[i].count == 1)
                        {
                            if (index3 !=0)
                            {
                                stringList.Add("index3 =" + index3);
                                index3 = 0;
                            }
                        }
                    }

                    if (ShowMessage)
                    {
                        stringList.Add("Number Combination [" + _ThreeCombin[i].num1 + "][" + _ThreeCombin[i].num2 + "][" + _ThreeCombin[i].num3 + "], count = " + _ThreeCombin[i].count);
                    }
                }

                stringList.Add("\r");
            }

            if (_FourCombin.Count != 0)
            {
                index3 = 0;

                for (int i = 0; i < _FourCombin.Count; i++)
                {
                    _FourCombin[i].NumToLIst(true);

                    if (_FourCombin[i].count == 0)
                    {
                        index3++;
                    }
                    else
                    {
                        if (_FourCombin[i].count == 1)
                        {
                            if (index3 != 0)
                            {
                                stringList.Add("index3 =" + index3);
                                index3 = 0;
                            }
                        }
                    }

                    if (ShowMessage)
                    {
                        stringList.Add("Number Combination [" + _FourCombin[i].num1 + "][" + _FourCombin[i].num2 + "][" + _FourCombin[i].num3 + "][" + _FourCombin[i].num4 + "], count = " + _FourCombin[i].count);
                    }
                }

                stringList.Add("\r");
            }

            if (_FiveCombin.Count != 0)
            {
                index3 = 0;

                for (int i = 0; i < _FiveCombin.Count; i++)
                {
                    _FiveCombin[i].NumToLIst(true);

                    if (_FiveCombin[i].count == 0)
                    {
                        index3++;
                    }
                    else
                    {
                        if (_FiveCombin[i].count == 1)
                        {
                            if (index3 != 0)
                            {
                                stringList.Add("index3 =" + index3);
                                index3 = 0;
                            }
                        }
                    }

                    if (ShowMessage)
                    {
                        stringList.Add("Number Combination [" + _FiveCombin[i].num1 + "][" + _FiveCombin[i].num2 + "][" + _FiveCombin[i].num3 + "][" + _FiveCombin[i].num4 + "][" + _FiveCombin[i].num5 + "], count = " + _FiveCombin[i].count);
                    }
                }

                stringList.Add("\r");
            }

            if (_SixCombin.Count != 0)
            {
                index3 = 0;

                for (int i = 0; i < _SixCombin.Count; i++)
                {
                    _SixCombin[i].NumToLIst(true);

                    if (_SixCombin[i].count == 0)
                    {
                        index3++;
                    }
                    else
                    {
                        if (_SixCombin[i].count == 1)
                        {
                            if (index3 != 0)
                            {
                                stringList.Add("index3 =" + index3);
                                index3 = 0;
                            }
                        }
                    }

                    if (ShowMessage)
                    {
                        stringList.Add("Number Combination [" + _SixCombin[i].num1 + "][" + _SixCombin[i].num2 + "][" + _SixCombin[i].num3 + "][" + _SixCombin[i].num4 + "][" + _SixCombin[i].num5 + "][" + _SixCombin[i].num6 + "], count = " + _SixCombin[i].count);
                    }
                }
                
                stringList.Add("\r");
            }

            ReportThreeCombinations(_ThreeCombin);

            stringList.Add("Count = " + _PowerBall.Count);

            for (int i = 1; i < 50; i++)
            {
                stringList.Add("Number " + i + " = " + array[i]);
            }

            fileOwner.WriteReport(stringList, stringList.Count);

            fileOwner.StopWrite();
        }

        public void ReportThreeCombinations(List<ThreeCombin> combinListFor3)
        {
            ThreeCombin tempThreeCombin;
            string tempString;

            if ( combinListFor3.Count != 0 )
            {
                for (int i = 0; i < combinListFor3.Count; i++)
                {
                    List<HitCombinations> tempHitCobin = new List<HitCombinations>();

                    if (combinListFor3[i].numList.Count != 0)
                    {
                        tempString = combinListFor3[i].numList[0].ToString() + combinListFor3[i].numList[1].ToString() + combinListFor3[i].numList[2].ToString();

                        if (!ThreeCombinDic.ContainsKey(tempString))
                        {
                            if (HitCombinDic.Count != 0)
                            {
                                tempHitCobin = HitCombinDic[0];
                                tempHitCobin.Add(new HitCombinations(combinListFor3[i].numList, combinListFor3[i].count, combinListFor3[i].mouth, combinListFor3[i].day, combinListFor3[i].year));
                            }
                            else
                            {
                                tempHitCobin.Add(new HitCombinations(combinListFor3[i].numList, combinListFor3[i].count, combinListFor3[i].mouth, combinListFor3[i].day, combinListFor3[i].year));
                                HitCombinDic.Add(0, tempHitCobin);
                            }

                            combinListFor3[i].zeroListID = tempHitCobin.Count - 1;

                            ThreeCombinDic.Add(tempString, combinListFor3[i]);
                        }
                        else
                        {
                            int hitID = 1;

                            if (HitCombinDic.Count != 0)
                            {
                                if (HitCombinDic.ContainsKey(1))
                                {

                                }
                                else
                                {
                                    tempThreeCombin = ThreeCombinDic[tempString];
                                    tempHitCobin.Add(new HitCombinations(tempThreeCombin.numList, tempThreeCombin.count, tempThreeCombin.mouth, tempThreeCombin.day, tempThreeCombin.year));
                                    tempHitCobin.Add(new HitCombinations(combinListFor3[i].numList, combinListFor3[i].count, combinListFor3[i].mouth, combinListFor3[i].day, combinListFor3[i].year));

                                    MessageBox.Show("tempThreeCombin.zeroListID [" + tempThreeCombin.zeroListID + "]");

                                    HitCombinDic.Add(hitID, tempHitCobin);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Something Wrong");
                                return;
                            }
                        }
                    }
                }
            }
            
            
        }
    }
}