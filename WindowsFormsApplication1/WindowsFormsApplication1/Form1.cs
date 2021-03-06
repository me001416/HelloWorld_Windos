﻿using System;
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

            x.SetNum(IsStringEmpty(textBox1.Text), IsStringEmpty(textBox2.Text), IsStringEmpty(textBox3.Text), IsStringEmpty(textBox4.Text), IsStringEmpty(textBox5.Text), IsStringEmpty(textBox6.Text), IsStringEmpty(textBox12.Text));

            pbList.Add(x);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pbList.Count != 0)
            {
                label3.Text = pbList[pbList.Count - 1].num1.NumToString();
                label4.Text = pbList[pbList.Count - 1].num2.NumToString();
                label5.Text = pbList[pbList.Count - 1].num3.NumToString();
                label6.Text = pbList[pbList.Count - 1].num4.NumToString();
                label7.Text = pbList[pbList.Count - 1].num5.NumToString();
                label8.Text = pbList[pbList.Count - 1].num6.NumToString();
                label9.Text = pbList[pbList.Count - 1].num7.NumToString();
            }
        }

        //
        // 七彩背景
        //
        private void button3_Click(object sender, EventArgs e)
        {
            Random randomizer = new Random();

            while (Visible)
            {
                for (int c = 0; c < 254 && Visible; c++)
                {
                    int green1;

                    green1 = randomizer.Next(254);
                    this.BackColor = Color.FromArgb(green1, 255 - c, c);
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(100);
                }

                for (int c = 254; c >= 0 && Visible; c--)
                {
                    int green2;

                    green2 = randomizer.Next(254);
                    this.BackColor = Color.FromArgb(green2, 255 - c, c);
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(100);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HitCounter _HitCounter = new HitCounter();

            _HitCounter.Report(pbList);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            File_Owner fileOwner = new File_Owner(null, true);

            if (pbList.Count != 0)
            {
                for (int i = 0; i < pbList.Count; i++)
                {
                    List<string> stringList = new List<string>();

                    stringList.Add(pbList[i].num1.NumToString());
                    stringList.Add(pbList[i].num2.NumToString());
                    stringList.Add(pbList[i].num3.NumToString());
                    stringList.Add(pbList[i].num4.NumToString());
                    stringList.Add(pbList[i].num5.NumToString());
                    stringList.Add(pbList[i].num6.NumToString());
                    stringList.Add(pbList[i].num7.NumToString());
                    stringList.Add(pbList[i].mouth.ToString());
                    stringList.Add(pbList[i].day.ToString());
                    stringList.Add(pbList[i].year.ToString());
                    fileOwner.WriteNum(stringList);
                }

                fileOwner.StopWrite();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            File_Owner fileOwner = new File_Owner(null, false);
            List<PowerBall> _PowerBall;
            
            _PowerBall = fileOwner.ReadNum();

            fileOwner.StopRead();

            if (_PowerBall.Count != 0)
            {
                for (int i = 0; i < _PowerBall.Count; i++)
                {
                    pbList.Add(_PowerBall[i]);
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

        //
        // 判斷字串是否為空
        //
        public int IsStringEmpty(string str)
        {
            int num;

            if (string.IsNullOrEmpty(str))
            {
                num = 1;
            }
            else
            {
                num = Int32.Parse(str);
            }

            return num;
        }
    }
}
