using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        List<PowerBall> pbList = new List<PowerBall>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PowerBall x = new PowerBall();

            x.num1 = IsStringEmpty(textBox1.Text);
            x.num2 = IsStringEmpty(textBox2.Text);
            x.num3 = IsStringEmpty(textBox3.Text);
            x.num4 = IsStringEmpty(textBox4.Text);
            x.num5 = IsStringEmpty(textBox5.Text);
            x.num6 = IsStringEmpty(textBox6.Text);

            pbList.Add(x);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pbList.Count != 0)
            {
                label3.Text = ListNumToStr(pbList[pbList.Count - 1].num1);
                label4.Text = ListNumToStr(pbList[pbList.Count - 1].num2);
                label5.Text = ListNumToStr(pbList[pbList.Count - 1].num3);
                label6.Text = ListNumToStr(pbList[pbList.Count - 1].num4);
                label7.Text = ListNumToStr(pbList[pbList.Count - 1].num5);
                label8.Text = ListNumToStr(pbList[pbList.Count - 1].num6);
            }
        }

        //
        // 七彩背景
        //
        private void button3_Click(object sender, EventArgs e)
        {
            while (Visible)
            {
                for (int c = 0; c < 254 && Visible; c++)
                {
                    this.BackColor = Color.FromArgb(c, 255 - c, c);
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(3);
                }

                for (int c = 254; c >= 0 && Visible; c--)
                {
                    this.BackColor = Color.FromArgb(c, 255 - c, c);
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(3);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (pbList.Count != 0)
            {
                pbList[pbList.Count - 1].ShowData();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        //
        // 判斷字串是否為空
        //
        public int IsStringEmpty(string str)
        {
            int num;

            if (string.IsNullOrEmpty(str))
            {
                num = 0;
            }
            else
            {
                num = Int32.Parse(str);
            }

            return num;
        }

        //
        // Number to String.
        //
        public string ListNumToStr (int num)
        {
            string str;

            str = num.ToString();

            if (string.IsNullOrEmpty(str))
            {
                str = "NULL";
            }

            return str;
        }
    }
}
