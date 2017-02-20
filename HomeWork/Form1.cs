using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork
{
    public partial class Form1 : Form
    {
        private MyBMI _bmi;
        public Form1()
        {
            InitializeComponent();
            _bmi = new MyBMI();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text==""|textBox2.Text=="")
            {
                MessageBox.Show("資料不完整，無法計算");
            }
            else
            {
                report();
            }


           
        }

        public void report()
        {
            _bmi.Weight = double.Parse(textBox1.Text);
            _bmi.Height = double.Parse(textBox2.Text);
            if (_bmi.BMI < 18.5)
            {
                MessageBox.Show("您的BMI為:"+ _bmi.BMI.ToString()+ Environment.NewLine + "BMI評估:過輕");
            }
            else if (_bmi.BMI >= 35)
            {
                MessageBox.Show("您的BMI為:" + _bmi.BMI.ToString()+ Environment.NewLine + "BMI評估:重度肥胖");
            }

            else if (_bmi.BMI >= 24 & _bmi.BMI < 27)
            {
                MessageBox.Show("您的BMI為:" + _bmi.BMI.ToString() + Environment.NewLine + "BMI評估:過重");
            }
            else if (_bmi.BMI >= 27 & _bmi.BMI < 30)
            {
                MessageBox.Show("您的BMI為:" + _bmi.BMI.ToString() + Environment.NewLine + "BMI評估:輕度肥胖");
            }
            else if (_bmi.BMI >= 30 & _bmi.BMI <35)
            {
                MessageBox.Show("您的BMI為:" + _bmi.BMI.ToString() + Environment.NewLine + "BMI評估:中度肥胖");
            }
          else
            {
                MessageBox.Show("您的BMI為:" + _bmi.BMI.ToString() + Environment.NewLine + "BMI評估:正常");
            }

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

           
             if (e.KeyChar == '.' & (sender as TextBox).Text.IndexOf('.') == -1)
            {
                TextBox tb1 = (TextBox)sender;
                tb1.Text ="0.";
            }


            if (((int)e.KeyChar < 48 | (int)e.KeyChar > 57) & (int)e.KeyChar != 8 & (int)e.KeyChar !=46 | e.KeyChar == '.' & (sender as TextBox).Text.IndexOf('.') >-1)//如果ASCII編碼不是數字
            {
                if (e.KeyChar == '.')
                {
                    TextBox tb1 = (TextBox)sender;
                    tb1.Text = tb1.Text;
                }
              
                e.Handled = true;
              
            }
        
        }
    }
}
