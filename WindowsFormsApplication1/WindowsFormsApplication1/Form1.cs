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
        //PowerBall x = new PowerBall();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //PowerBall x = new PowerBall() { num1 = Int32.Parse(textBox1.Text), num2 = Int32.Parse(textBox2.Text), num3 = Int32.Parse(textBox3.Text), num4 = Int32.Parse(textBox4.Text), num5 = Int32.Parse(textBox5.Text), num6 = Int32.Parse(textBox6.Text) };
            PowerBall x = new PowerBall();

            if (string.IsNullOrEmpty(textBox1.Text))
            {
                x.num1 = 0;
            }
            else
            {
                x.num1 = Int32.Parse(textBox1.Text);
            }

            if (string.IsNullOrEmpty(textBox2.Text))
            {
                x.num2 = 0;
            }
            else
            {
                x.num2 = Int32.Parse(textBox2.Text);
            }

            if (string.IsNullOrEmpty(textBox3.Text))
            {
                x.num3 = 0;
            }
            else
            {
                x.num3 = Int32.Parse(textBox3.Text);
            }

            if (string.IsNullOrEmpty(textBox4.Text))
            {
                x.num4 = 0;
            }
            else
            {
                x.num4 = Int32.Parse(textBox4.Text);
            }

            if (string.IsNullOrEmpty(textBox5.Text))
            {
                x.num5 = 0;
            }
            else
            {
                x.num5 = Int32.Parse(textBox5.Text);
            }

            if (string.IsNullOrEmpty(textBox6.Text))
            {
                x.num6 = 0;
            }
            else
            {
                x.num6 = Int32.Parse(textBox6.Text);
            }

            //x.num2 = Int32.Parse(textBox2.Text);
            //x.num3 = Int32.Parse(textBox3.Text);
            //x.num4 = Int32.Parse(textBox4.Text);
            //x.num5 = Int32.Parse(textBox5.Text);
            //x.num6 = Int32.Parse(textBox6.Text);

            pbList.Add(x);
        }
        /*
        public class PowerBall
        {
            public int num1;
            public int num2;
            public int num3;
            public int num4;
            public int num5;
            public int num6;

            //
            // return a string.
            //
            public override string ToString()
            {
                return "num1 : " + num1 + "," + "num2 : " + num2 + "," + "num3 : " + num3 + "," + "num4 : " + num4 + "," + "num5 : " + num5 + "," + "num6 : " + num6;
            }

            public void SetValue( int x1, int x2, int x3, int x4, int x5, int x6 )
            {
                num1 = x1;
                num2 = x2;
                num3 = x3;
                num4 = x4;
                num5 = x5;
                num6 = x6;
            }
        }
        */
        private void button2_Click(object sender, EventArgs e)
        {
            int listSize = pbList.Count;
            int temp = 0;
            string str = null;
            
            if ( listSize != 0 )
            {
                //textBox7.Text = pbList[listSize].num1.ToString();
                //textBox8.Text = pbList[listSize].num2.ToString();
                //textBox9.Text = pbList[listSize].num3.ToString();
                //textBox10.Text = pbList[listSize].num4.ToString();
                //textBox11.Text = pbList[listSize].num5.ToString();
                //textBox12.Text = pbList[listSize].num6.ToString();

                temp = pbList[listSize].num1;
                str = temp.ToString();

                if (string.IsNullOrEmpty(str))
                {
                    textBox7.Text = "123";
                }
                else
                {
                    textBox8.Text = "456";
                }
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
    }
}
