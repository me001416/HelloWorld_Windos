using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public struct File_Owner
    {
        public StreamWriter sWriter;
        public StreamReader sReader;

        public Boolean FileOrDirectoryExists(string name)
        {
            return (Directory.Exists(name) || File.Exists(name));
        }

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

            sWriter = new StreamWriter(_fileName);
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
    }
}