using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public class HitCounter
    {
        Dictionary<string, ThreeCombin> ThreeCombinDic = new Dictionary<string, ThreeCombin>();
        Dictionary<string, FourCombin> FourCombinDic = new Dictionary<string, FourCombin>();
        Dictionary<string, FiveCombin> FiveCombinDic = new Dictionary<string, FiveCombin>();
        Dictionary<string, SixCombin> SixCombinDic = new Dictionary<string, SixCombin>();
        Dictionary<int, List<HitCombinations>> HitCombinDic = new Dictionary<int, List<HitCombinations>>();
        List<ThreeCombin> _ThreeCombin = new List<ThreeCombin>();
        List<FourCombin> _FourCombin = new List<FourCombin>();
        List<FiveCombin> _FiveCombin = new List<FiveCombin>();
        List<SixCombin> _SixCombin = new List<SixCombin>();

        public void Report(List<PowerBall> _PowerBall)
        {
            int[] array = new int[50];
            int[] _NumArray = new int[7];
            File_Owner fileOwner = new File_Owner(@"D:\CODE\ForFun\C_Sharp\Test\Report.txt", true);
            List<string> stringList = new List<string>();
            int index3 = 0;
            Boolean ShowMessage = false;

            calculateEachNum(_PowerBall, array);
            calculateCombinations(_PowerBall);

            if (_ThreeCombin.Count != 0)
            {
                index3 = 0;

                for (int i = 0; i < _ThreeCombin.Count; i++)
                {
                    if (_ThreeCombin[i].numList.Count == 0)
                    {
                        _ThreeCombin[i].NumToLIst(true);
                    }

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
                    if (_FourCombin[i].numList.Count == 0)
                    {
                        _FourCombin[i].NumToLIst(true);
                    }

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
                    if (_FiveCombin[i].numList.Count == 0)
                    {
                        _FiveCombin[i].NumToLIst(true);
                    }

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
                    if (_SixCombin[i].numList.Count == 0)
                    {
                        _SixCombin[i].NumToLIst(true);
                    }

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

            RecordThreeCombinations(_ThreeCombin);
            RecordFourCombinations(_FourCombin);
            RecordFiveCombinations(_FiveCombin);
            RecordSixCombinations(_SixCombin);
            ReportCombinations(stringList);

            stringList.Add("Count = " + _PowerBall.Count);

            for (int i = 1; i < 50; i++)
            {
                stringList.Add("Number " + i + " = " + array[i]);
            }

            fileOwner.WriteReport(stringList, stringList.Count);

            fileOwner.StopWrite();
        }

        public void ReportCombinations(List<string> strList)
        {
            int index3 = 0;
            int index4 = 0;
            int index5 = 0;
            int index6 = 0;
            Dictionary<int, int> index3Dic = new Dictionary<int, int>();
            Dictionary<int, int> index4Dic = new Dictionary<int, int>();
            Dictionary<int, int> index5Dic = new Dictionary<int, int>();
            Dictionary<int, int> index6Dic = new Dictionary<int, int>();

            foreach (var item in HitCombinDic)
            {
                if (item.Key != 0)
                {
                    switch (item.Value[item.Value.Count - 1].numList.Count)
                    {
                        case 3:
                            strList.Add("Hit [" + item.Value[item.Value.Count -1].numList[0] + "] [" + item.Value[item.Value.Count-1].numList[1] + "] [" + item.Value[item.Value.Count-1].numList[2] + "], Hit count : [" + item.Value.Count + "]");

                            if (index3Dic.ContainsKey(item.Value.Count))
                            {
                                index3Dic[item.Value.Count]++;
                            }
                            else
                            {
                                index3Dic.Add(item.Value.Count, 1);
                            }
                            break;
                        case 4:
                            strList.Add("Hit [" + item.Value[item.Value.Count - 1].numList[0] + "] [" + item.Value[item.Value.Count - 1].numList[1] + "] [" + item.Value[item.Value.Count - 1].numList[2] + "] [" + item.Value[item.Value.Count - 1].numList[3] + "], Hit count : [" + item.Value.Count + "]");

                            if (index4Dic.ContainsKey(item.Value.Count))
                            {
                                index4Dic[item.Value.Count]++;
                            }
                            else
                            {
                                index4Dic.Add(item.Value.Count, 1);
                            }
                            break;
                        case 5:
                            strList.Add("Hit [" + item.Value[item.Value.Count - 1].numList[0] + "] [" + item.Value[item.Value.Count - 1].numList[1] + "] [" + item.Value[item.Value.Count - 1].numList[2] + "] [" + item.Value[item.Value.Count - 1].numList[3] + "] [" + item.Value[item.Value.Count - 1].numList[4] + "], Hit count : [" + item.Value.Count + "]");

                            if (index5Dic.ContainsKey(item.Value.Count))
                            {
                                index5Dic[item.Value.Count]++;
                            }
                            else
                            {
                                index5Dic.Add(item.Value.Count, 1);
                            }
                            break;
                        case 6:
                            strList.Add("Hit [" + item.Value[item.Value.Count - 1].numList[0] + "] [" + item.Value[item.Value.Count - 1].numList[1] + "] [" + item.Value[item.Value.Count - 1].numList[2] + "] [" + item.Value[item.Value.Count - 1].numList[3] + "] [" + item.Value[item.Value.Count - 1].numList[4] + "] [" + item.Value[item.Value.Count - 1].numList[5] + "], Hit count : [" + item.Value.Count + "]");

                            if (index6Dic.ContainsKey(item.Value.Count))
                            {
                                index6Dic[item.Value.Count]++;
                            }
                            else
                            {
                                index6Dic.Add(item.Value.Count, 1);
                            }
                            break;
                    }

                    for (int i = 0; i < item.Value.Count; i++)
                    {
                        strList.Add("Count [" + item.Value[i].count + "], Hit time " + item.Value[i].mouth + "/" + item.Value[i].day + "/" + item.Value[i].year);
                    }
                }
                else
                {
                    for (int i = 0; i < item.Value.Count; i++)
                    {
                        switch (item.Value[i].numList.Count)
                        {
                            case 3:
                                index3++;
                                break;
                            case 4:
                                index4++;
                                break;
                            case 5:
                                index5++;
                                break;
                            case 6:
                                index6++;
                                break;
                        }
                    }
                }
            }

            strList.Add("Once Three Combinations [" + index3 + "]");
            strList.Add("Once Four Combinations ["  + index4 + "]");
            strList.Add("Once Five Combinations ["  + index5 + "]");
            strList.Add("Once Six Combinations ["   + index6 + "]");

            if (index3Dic.Count != 0)
            {
                int totalNum = 0;

                foreach (var item in index3Dic)
                {
                    strList.Add("Three Combinations [" + item.Key + "] : ["+ item.Value + "]");
                    totalNum = totalNum + (item.Value * item.Key);
                }

                strList.Add("Three Combinations % : [" + (decimal)((decimal)totalNum / (decimal)(index3 + totalNum)) * 100 + "%]");
            }

            if (index4Dic.Count != 0)
            {
                int totalNum = 0;

                foreach (var item in index4Dic)
                {
                    strList.Add("Four Combinations [" + item.Key + "] : [" + item.Value + "]");
                    totalNum = totalNum + (item.Value * item.Key);
                }

                strList.Add("Four Combinations % : [" + (decimal)((decimal)totalNum / (decimal)(index4 + totalNum)) * 100 + "%]");
            }

            if (index5Dic.Count != 0)
            {
                int totalNum = 0;

                foreach (var item in index5Dic)
                {
                    strList.Add("Five Combinations [" + item.Key + "] : [" + item.Value + "]");
                    totalNum = totalNum + (item.Value * item.Key);
                }

                strList.Add("Five Combinations % : [" + (decimal)((decimal)totalNum / (decimal)(index5 + totalNum)) * 100 + "%]");
            }

            if (index6Dic.Count != 0)
            {
                int totalNum = 0;

                foreach (var item in index6Dic)
                {
                    strList.Add("Six Combinations [" + item.Key + "] : [" + item.Value + "]");
                    totalNum = totalNum + (item.Value * item.Key);
                }

                strList.Add("Six Combinations % : [" + (decimal)((decimal)totalNum / (decimal)(index6 + totalNum)) * 100 + "%]");
            }
        }

        public void calculateEachNum(List<PowerBall> pB, int[] array)
        {
            if (pB.Count != 0)
            {
                for (int i = 0; i < pB.Count; i++)
                {
                    array[pB[i].num1.num]++;
                    array[pB[i].num2.num]++;
                    array[pB[i].num3.num]++;
                    array[pB[i].num4.num]++;
                    array[pB[i].num5.num]++;
                    array[pB[i].num6.num]++;
                    array[pB[i].num7.num]++;
                }
            }
        }

        public void calculateCombinations(List<PowerBall> _PowerBall)
        {
            if (_PowerBall.Count != 0)
            {
                for (int i = 0; i < _PowerBall.Count; i++)
                {
                    Combinations combin = new Combinations();
                    List<List<int>> numList = new List<List<int>>();
                    
                    _PowerBall[i].UpdateList(false);
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
        }

        public void RecordThreeCombinations(List<ThreeCombin> combinListFor3)
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
                        tempString = combinListFor3[i].numList[0].ToString() + " " + combinListFor3[i].numList[1].ToString() + " " + combinListFor3[i].numList[2].ToString();

                        if (!ThreeCombinDic.ContainsKey(tempString))
                        {
                            //
                            // First time find this combination
                            //
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

                            //
                            // Record the location of list.
                            //
                            combinListFor3[i].zeroListID = tempHitCobin.Count - 1;

                            //
                            // Add combination to dictionary.
                            //
                            ThreeCombinDic.Add(tempString, combinListFor3[i]);
                        }
                        else
                        {
                            int hitID = 1;

                            if (HitCombinDic.Count != 0)
                            {
                                tempThreeCombin = ThreeCombinDic[tempString];

                                if (HitCombinDic.ContainsKey(1))
                                {
                                    if (tempThreeCombin.HitListID == 0)
                                    {
                                        tempThreeCombin.HitListID = HitCombinDic.Count;
                                        combinListFor3[i].HitListID = HitCombinDic.Count;

                                        List<HitCombinations> tempHitCobin_2 = HitCombinDic[0];
                                        tempHitCobin_2.RemoveAt(tempThreeCombin.zeroListID);

                                        tempHitCobin.Add(new HitCombinations(tempThreeCombin.numList, tempThreeCombin.count, tempThreeCombin.mouth, tempThreeCombin.day, tempThreeCombin.year));
                                        tempHitCobin.Add(new HitCombinations(combinListFor3[i].numList, combinListFor3[i].count, combinListFor3[i].mouth, combinListFor3[i].day, combinListFor3[i].year));
                                        HitCombinDic.Add(tempThreeCombin.HitListID, tempHitCobin);
                                    }
                                    else
                                    {
                                        tempHitCobin = HitCombinDic[tempThreeCombin.HitListID];
                                        tempHitCobin.Add(new HitCombinations(combinListFor3[i].numList, combinListFor3[i].count, combinListFor3[i].mouth, combinListFor3[i].day, combinListFor3[i].year));
                                    }
                                }
                                else
                                {

                                    tempThreeCombin.HitListID = hitID;
                                    combinListFor3[i].HitListID = hitID;
                                    tempHitCobin.Add(new HitCombinations(tempThreeCombin.numList, tempThreeCombin.count, tempThreeCombin.mouth, tempThreeCombin.day, tempThreeCombin.year));
                                    tempHitCobin.Add(new HitCombinations(combinListFor3[i].numList, combinListFor3[i].count, combinListFor3[i].mouth, combinListFor3[i].day, combinListFor3[i].year));

                                    HitCombinDic.Add(hitID, tempHitCobin);
                                    List<HitCombinations> tempHitCobin_2 = HitCombinDic[0];
                                    tempHitCobin_2.RemoveAt(tempThreeCombin.zeroListID);
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

        public void RecordFourCombinations(List<FourCombin> combinListFor4)
        {
            FourCombin tempThreeCombin;
            string tempString;

            if (combinListFor4.Count != 0)
            {
                for (int i = 0; i < combinListFor4.Count; i++)
                {
                    List<HitCombinations> tempHitCobin = new List<HitCombinations>();

                    if (combinListFor4[i].numList.Count != 0)
                    {
                        tempString = combinListFor4[i].numList[0].ToString() + " " + combinListFor4[i].numList[1].ToString() + " " + combinListFor4[i].numList[2].ToString() + " " + combinListFor4[i].numList[3].ToString();

                        if (!FourCombinDic.ContainsKey(tempString))
                        {
                            //
                            // First time find this combination
                            //
                            if (HitCombinDic.Count != 0)
                            {
                                tempHitCobin = HitCombinDic[0];
                                tempHitCobin.Add(new HitCombinations(combinListFor4[i].numList, combinListFor4[i].count, combinListFor4[i].mouth, combinListFor4[i].day, combinListFor4[i].year));
                            }
                            else
                            {
                                tempHitCobin.Add(new HitCombinations(combinListFor4[i].numList, combinListFor4[i].count, combinListFor4[i].mouth, combinListFor4[i].day, combinListFor4[i].year));
                                HitCombinDic.Add(0, tempHitCobin);
                            }

                            //
                            // Record the location of list.
                            //
                            combinListFor4[i].zeroListID = tempHitCobin.Count - 1;

                            //
                            // Add combination to dictionary.
                            //
                            FourCombinDic.Add(tempString, combinListFor4[i]);
                        }
                        else
                        {
                            int hitID = 1;

                            if (HitCombinDic.Count != 0)
                            {
                                tempThreeCombin = FourCombinDic[tempString];

                                if (HitCombinDic.ContainsKey(1))
                                {
                                    if (tempThreeCombin.HitListID == 0)
                                    {
                                        tempThreeCombin.HitListID = HitCombinDic.Count;
                                        combinListFor4[i].HitListID = HitCombinDic.Count;

                                        List<HitCombinations> tempHitCobin_2 = HitCombinDic[0];
                                        tempHitCobin_2.RemoveAt(tempThreeCombin.zeroListID);

                                        tempHitCobin.Add(new HitCombinations(tempThreeCombin.numList, tempThreeCombin.count, tempThreeCombin.mouth, tempThreeCombin.day, tempThreeCombin.year));
                                        tempHitCobin.Add(new HitCombinations(combinListFor4[i].numList, combinListFor4[i].count, combinListFor4[i].mouth, combinListFor4[i].day, combinListFor4[i].year));
                                        HitCombinDic.Add(tempThreeCombin.HitListID, tempHitCobin);
                                    }
                                    else
                                    {
                                        tempHitCobin = HitCombinDic[tempThreeCombin.HitListID];
                                        tempHitCobin.Add(new HitCombinations(combinListFor4[i].numList, combinListFor4[i].count, combinListFor4[i].mouth, combinListFor4[i].day, combinListFor4[i].year));
                                    }
                                }
                                else
                                {

                                    tempThreeCombin.HitListID = hitID;
                                    combinListFor4[i].HitListID = hitID;
                                    tempHitCobin.Add(new HitCombinations(tempThreeCombin.numList, tempThreeCombin.count, tempThreeCombin.mouth, tempThreeCombin.day, tempThreeCombin.year));
                                    tempHitCobin.Add(new HitCombinations(combinListFor4[i].numList, combinListFor4[i].count, combinListFor4[i].mouth, combinListFor4[i].day, combinListFor4[i].year));

                                    HitCombinDic.Add(hitID, tempHitCobin);
                                    List<HitCombinations> tempHitCobin_2 = HitCombinDic[0];
                                    tempHitCobin_2.RemoveAt(tempThreeCombin.zeroListID);
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

        public void RecordFiveCombinations(List<FiveCombin> combinListFor5)
        {
            FiveCombin tempThreeCombin;
            string tempString;

            if (combinListFor5.Count != 0)
            {
                for (int i = 0; i < combinListFor5.Count; i++)
                {
                    List<HitCombinations> tempHitCobin = new List<HitCombinations>();

                    if (combinListFor5[i].numList.Count != 0)
                    {
                        tempString = combinListFor5[i].numList[0].ToString() + " " + combinListFor5[i].numList[1].ToString() + " " + combinListFor5[i].numList[2].ToString() + " " + combinListFor5[i].numList[3].ToString() + " " + combinListFor5[i].numList[4].ToString();

                        if (!FiveCombinDic.ContainsKey(tempString))
                        {
                            //
                            // First time find this combination
                            //
                            if (HitCombinDic.Count != 0)
                            {
                                tempHitCobin = HitCombinDic[0];
                                tempHitCobin.Add(new HitCombinations(combinListFor5[i].numList, combinListFor5[i].count, combinListFor5[i].mouth, combinListFor5[i].day, combinListFor5[i].year));
                            }
                            else
                            {
                                tempHitCobin.Add(new HitCombinations(combinListFor5[i].numList, combinListFor5[i].count, combinListFor5[i].mouth, combinListFor5[i].day, combinListFor5[i].year));
                                HitCombinDic.Add(0, tempHitCobin);
                            }

                            //
                            // Record the location of list.
                            //
                            combinListFor5[i].zeroListID = tempHitCobin.Count - 1;

                            //
                            // Add combination to dictionary.
                            //
                            FiveCombinDic.Add(tempString, combinListFor5[i]);
                        }
                        else
                        {
                            int hitID = 1;

                            if (HitCombinDic.Count != 0)
                            {
                                tempThreeCombin = FiveCombinDic[tempString];

                                if (HitCombinDic.ContainsKey(1))
                                {
                                    if (tempThreeCombin.HitListID == 0)
                                    {
                                        tempThreeCombin.HitListID = HitCombinDic.Count;
                                        combinListFor5[i].HitListID = HitCombinDic.Count;

                                        List<HitCombinations> tempHitCobin_2 = HitCombinDic[0];
                                        tempHitCobin_2.RemoveAt(tempThreeCombin.zeroListID);

                                        tempHitCobin.Add(new HitCombinations(tempThreeCombin.numList, tempThreeCombin.count, tempThreeCombin.mouth, tempThreeCombin.day, tempThreeCombin.year));
                                        tempHitCobin.Add(new HitCombinations(combinListFor5[i].numList, combinListFor5[i].count, combinListFor5[i].mouth, combinListFor5[i].day, combinListFor5[i].year));
                                        HitCombinDic.Add(tempThreeCombin.HitListID, tempHitCobin);
                                    }
                                    else
                                    {
                                        tempHitCobin = HitCombinDic[tempThreeCombin.HitListID];
                                        tempHitCobin.Add(new HitCombinations(combinListFor5[i].numList, combinListFor5[i].count, combinListFor5[i].mouth, combinListFor5[i].day, combinListFor5[i].year));
                                    }
                                }
                                else
                                {

                                    tempThreeCombin.HitListID = hitID;
                                    combinListFor5[i].HitListID = hitID;
                                    tempHitCobin.Add(new HitCombinations(tempThreeCombin.numList, tempThreeCombin.count, tempThreeCombin.mouth, tempThreeCombin.day, tempThreeCombin.year));
                                    tempHitCobin.Add(new HitCombinations(combinListFor5[i].numList, combinListFor5[i].count, combinListFor5[i].mouth, combinListFor5[i].day, combinListFor5[i].year));

                                    HitCombinDic.Add(hitID, tempHitCobin);
                                    List<HitCombinations> tempHitCobin_2 = HitCombinDic[0];
                                    tempHitCobin_2.RemoveAt(tempThreeCombin.zeroListID);
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

        public void RecordSixCombinations(List<SixCombin> combinListFor6)
        {
            SixCombin tempThreeCombin;
            string tempString;

            if (combinListFor6.Count != 0)
            {
                for (int i = 0; i < combinListFor6.Count; i++)
                {
                    List<HitCombinations> tempHitCobin = new List<HitCombinations>();

                    if (combinListFor6[i].numList.Count != 0)
                    {
                        tempString = combinListFor6[i].numList[0].ToString() + " " + combinListFor6[i].numList[1].ToString() + " " + combinListFor6[i].numList[2].ToString() + " " + combinListFor6[i].numList[3].ToString() + " " + combinListFor6[i].numList[4].ToString() + " " + combinListFor6[i].numList[5].ToString();

                        if (!SixCombinDic.ContainsKey(tempString))
                        {
                            //
                            // First time find this combination
                            //
                            if (HitCombinDic.Count != 0)
                            {
                                tempHitCobin = HitCombinDic[0];
                                tempHitCobin.Add(new HitCombinations(combinListFor6[i].numList, combinListFor6[i].count, combinListFor6[i].mouth, combinListFor6[i].day, combinListFor6[i].year));
                            }
                            else
                            {
                                tempHitCobin.Add(new HitCombinations(combinListFor6[i].numList, combinListFor6[i].count, combinListFor6[i].mouth, combinListFor6[i].day, combinListFor6[i].year));
                                HitCombinDic.Add(0, tempHitCobin);
                            }

                            //
                            // Record the location of list.
                            //
                            combinListFor6[i].zeroListID = tempHitCobin.Count - 1;

                            //
                            // Add combination to dictionary.
                            //
                            SixCombinDic.Add(tempString, combinListFor6[i]);
                        }
                        else
                        {
                            int hitID = 1;

                            if (HitCombinDic.Count != 0)
                            {
                                tempThreeCombin = SixCombinDic[tempString];

                                if (HitCombinDic.ContainsKey(1))
                                {
                                    if (tempThreeCombin.HitListID == 0)
                                    {
                                        tempThreeCombin.HitListID = HitCombinDic.Count;
                                        combinListFor6[i].HitListID = HitCombinDic.Count;

                                        List<HitCombinations> tempHitCobin_2 = HitCombinDic[0];
                                        tempHitCobin_2.RemoveAt(tempThreeCombin.zeroListID);

                                        tempHitCobin.Add(new HitCombinations(tempThreeCombin.numList, tempThreeCombin.count, tempThreeCombin.mouth, tempThreeCombin.day, tempThreeCombin.year));
                                        tempHitCobin.Add(new HitCombinations(combinListFor6[i].numList, combinListFor6[i].count, combinListFor6[i].mouth, combinListFor6[i].day, combinListFor6[i].year));
                                        HitCombinDic.Add(tempThreeCombin.HitListID, tempHitCobin);
                                    }
                                    else
                                    {
                                        tempHitCobin = HitCombinDic[tempThreeCombin.HitListID];
                                        tempHitCobin.Add(new HitCombinations(combinListFor6[i].numList, combinListFor6[i].count, combinListFor6[i].mouth, combinListFor6[i].day, combinListFor6[i].year));
                                    }
                                }
                                else
                                {

                                    tempThreeCombin.HitListID = hitID;
                                    combinListFor6[i].HitListID = hitID;
                                    tempHitCobin.Add(new HitCombinations(tempThreeCombin.numList, tempThreeCombin.count, tempThreeCombin.mouth, tempThreeCombin.day, tempThreeCombin.year));
                                    tempHitCobin.Add(new HitCombinations(combinListFor6[i].numList, combinListFor6[i].count, combinListFor6[i].mouth, combinListFor6[i].day, combinListFor6[i].year));

                                    HitCombinDic.Add(hitID, tempHitCobin);
                                    List<HitCombinations> tempHitCobin_2 = HitCombinDic[0];
                                    tempHitCobin_2.RemoveAt(tempThreeCombin.zeroListID);
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