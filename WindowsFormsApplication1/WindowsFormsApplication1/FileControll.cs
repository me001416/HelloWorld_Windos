using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public struct File_Owner
    {
        //protected string dirPath = @"D:\CODE\ForFun\C_Sharp\Test";
        //protected string txtPath = @"D:\CODE\ForFun\C_Sharp\Test\text1.txt";

        public StreamWriter sw;

        public Boolean FileOrDirectoryExists(string name)
        {
            return (Directory.Exists(name) || File.Exists(name));
        }

        //public File_Owner()
        //{
        //    String _fileName;

        //    _fileName = @"D:\CODE\ForFun\C_Sharp\Test\text1.txt";

        //    sw = new StreamWriter(_fileName);
        //}

        public File_Owner(string FileName, Boolean Active) : this()
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

            sw = new StreamWriter(_fileName);
        }

        public void WriteNum(string str1, string str2, string str3, string str4, string str5, string str6, string str7)
        {
            if (sw == null)
            {
                MessageBox.Show("Open sw Error");
            }

            sw.Write(str1);
            sw.Write(str2);
            sw.Write(str3);
            sw.Write(str4);
            sw.Write(str5);
            sw.Write(str6);
            sw.WriteLine(str7);
        }

        public void StopWrite()
        {
            sw.Close();
        }
    }
}