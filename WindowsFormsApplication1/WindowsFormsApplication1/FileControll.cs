using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;

namespace WindowsFormsApplication1
{
    public class File_Owner
    {
        public StreamWriter sWriter;
        public StreamReader sReader;

        public Boolean FileOrDirectoryExists(string name)
        {
            return (Directory.Exists(name) || File.Exists(name));
        }

        public File_Owner(string FileName, Boolean Active)
        {
            String _fileName;

            if (FileName == null || !FileOrDirectoryExists(FileName))
            {
                if (Active)
                {
                    _fileName = @"D:\CODE\ForFun\C_Sharp\Test\text2.txt";
                }
                else
                {
                    _fileName = @"D:\CODE\ForFun\C_Sharp\Test\text1.txt";
                }
            }
            else
            {
                _fileName = FileName;
            }

            if (Active)
            {
                sWriter = new StreamWriter(_fileName);
            }
            else
            {
                sReader = new StreamReader(_fileName);
            }
        }

        public void WriteNum(string str1, string str2, string str3, string str4, string str5, string str6, string str7)
        {
            if (sWriter == null)
            {
                MessageBox.Show("Open sw Error");
            }

            sWriter.Write(str1);
            sWriter.Write(',');
            sWriter.Write(str2);
            sWriter.Write(',');
            sWriter.Write(str3);
            sWriter.Write(',');
            sWriter.Write(str4);
            sWriter.Write(',');
            sWriter.Write(str5);
            sWriter.Write(',');
            sWriter.Write(str6);
            sWriter.Write(',');
            sWriter.Write(str7);
            sWriter.WriteLine(',');
        }

        public void StopWrite()
        {
            sWriter.Close();
        }

        public List<PowerBall> ReadNum()
        //public void ReadNum()
        {
            String str0, str1 = "", str2 = null;
            Char[] chars = new Char[40];
            int j = 0, index0 = 0;
            Boolean refresh = true;
            PowerBall _nPowerBall;
            List<PowerBall> _PowerBall = new List<PowerBall>();

            while (!sReader.EndOfStream)
            {
                str0 = sReader.ReadLine();
                _nPowerBall = new PowerBall();
                j = 0;
                index0 = 0;
                refresh = true;
                str2 = null;

                //for (int i = 0; i < str0.Length - 1 || str0[i] < '9' || str0[i] == ',' || str0[i] > '0'; i++)
                for (int i = 0; i < str0.Length; i++)
                {
                    //if ( str0[i] > '0' || str0[i] < '9' && str0[i] != ',')
                    if (str0[i] > '0' || str0[i] < '9')
                    {
                        chars[j] = str0[i];
                        j++;
                    }
                }

                for (int i = 0; i < 40; i++)
                {
                    //if (chars[i] != ',' && chars[i] != '0')
                    if (chars[i] != ',')
                    {
                        str1 = chars[i].ToString();

                        if (refresh)
                        {
                            str2 = str1;
                            refresh = false;
                        }
                        else
                        {
                            str2 = str2 + str1;
                        }
                    }
                    else
                    {
                        switch (index0)
                        {
                            case 0:
                                _nPowerBall.num1.num = Int32.Parse(str2);
                                break;
                            case 1:
                                _nPowerBall.num2.num = Int32.Parse(str2);
                                break;
                            case 2:
                                _nPowerBall.num3.num = Int32.Parse(str2);
                                break;
                            case 3:
                                _nPowerBall.num4.num = Int32.Parse(str2);
                                break;
                            case 4:
                                _nPowerBall.num5.num = Int32.Parse(str2);
                                break;
                            case 5:
                                _nPowerBall.num6.num = Int32.Parse(str2);
                                break;
                            case 6:
                                _nPowerBall.num7.num = Int32.Parse(str2);
                                break;
                        }

                        str2 = null;

                        index0++;
                    }
                }

                _PowerBall.Add(_nPowerBall);
            }

            return _PowerBall;

            //MessageBox.Show(str2);
        }

        public void StopRead()
        {
            sReader.Close();
        }
    }
}