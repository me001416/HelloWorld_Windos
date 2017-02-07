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
                _fileName = @"D:\CODE\ForFun\C_Sharp\Test\text1.txt";
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
            sWriter.WriteLine(str7);
        }

        public void StopWrite()
        {
            sWriter.Close();
        }

        //public List<PowerBall> ReadNum()
        public void ReadNum()
        {
            String str0, str1 = "", str2 = null;
            Char[] chars = new Char[14];
            int j = 0;
            //PowerBall _nPowerBall;
            //List<PowerBall> _PowerBall;

            //while(!sReader.EndOfStream)
            //{
            str0 = sReader.ReadLine();

            //MessageBox.Show("" + str0.Length);

            //for (int i = 0; i < str0.Length - 1 || str0[i] < '9' || str0[i] == ',' || str0[i] > '0'; i++)
            for (int i = 0; i < str0.Length; i++)
            {
                if ( str0[i] > '0' || str0[i] < '9' )
                {
                    chars[j] = str0[i];
                    j++;
                }
            }

            for (int i = 0; i < 14 ; i++)
            {
                str1 = chars[i].ToString();

                if (i == 0)
                {
                    str2 = str1;
                }
                else
                {
                    str2 = str2 + str1;
                }
            }

            MessageBox.Show(str2);
            //}
        }

        public void StopRead()
        {
            sReader.Close();
        }
    }
}