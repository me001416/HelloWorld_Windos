using System;
using System.IO;

namespace WindowsFormsApplication1
{
    public struct File_Owner
    {
        protected string dirPath = @"D:\CODE\ForFun\C_Sharp\Test";
        protected string txtPath = @"D:\CODE\ForFun\C_Sharp\Test\text1.txt";

        public StreamWriter sw;

        public Boolean FileOrDirectoryExists(string name)
        {
            return (Directory.Exists(name) || File.Exists(name));
        }

        public File_Owner(string FileName, Boolean Active) : this()
        {
            String _fileName;

            if (FileName == null || !FileOrDirectoryExists(FileName))
            {
                _fileName = txtPath;
            }
            else
            {
                _fileName = FileName;
            }

            sw = new StreamWriter(_fileName);
        }
    }
}