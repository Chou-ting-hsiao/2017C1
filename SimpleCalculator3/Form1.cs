using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator3
{
    public partial class Form1 : Form
    {
        private MyData _data;
        public Form1()
        {
            InitializeComponent();
            _data = new MyData();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int v = 1;

            Caculator(v);


        }
       

        private void button2_Click(object sender, EventArgs e)
        {
            int v = 2;

            Caculator(v);

        }
        private void button3_Click(object sender, EventArgs e)
        {
            int v = 3;

            Caculator(v);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int v = 4;

          Caculator(v);

        }

        private void Caculator(int i)
        {
            _data.X = float.Parse(textBox1.Text);
            _data.Y= float.Parse(textBox2.Text);
            

            switch (i)
            {
                case 1:
                   
                    label1.Text= _data.Add().ToString();
                    break;
                case 2:

                    label1.Text = _data.Less().ToString();
                    break;
                case 3:

                    label1.Text = _data.Mul().ToString();
                    break;
                default:
                    label1.Text = _data.exc().ToString();
                    break;
            }
        }

      
    }
}
