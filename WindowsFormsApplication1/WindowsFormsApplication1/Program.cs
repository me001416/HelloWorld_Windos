using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            //
            // 測試物件宣告
            //
            PowerBall xyz1 = new PowerBall();
            xyz1.num1 = 0;

            //
            // Test MessageBox item
            //
            MessageBox.Show("xyz1.num1 =" + xyz1.num1);

            //
            // 測試物件初始化
            //
            PowerBall xyz2 = new PowerBall() { num1 = 10 };

        }
    }
}
