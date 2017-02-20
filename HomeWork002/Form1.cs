using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork002
{
    public partial class Form1 : Form
    {
        private List<string> _leftList;
        private List<string> _rightList;
        public Form1()
        {
            InitializeComponent();
            Re();
        }
      
        private void CreateList()
        {
            _leftList = new List<string>
            {
                "農夫","狼","羊","菜"
            };
            _rightList = new List<string>();

        }
        private void SetList()
        {
            listBox1.SelectionMode = SelectionMode.One;
            listBox2.SelectionMode = SelectionMode.One;
        }
        private void ChangeData()
        {
            listBox1.DataSource = null;
            listBox2.DataSource = null;
            listBox1.DataSource = _leftList;
            listBox2.DataSource = _rightList;

        }
        private void Re()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            CreateList();
            SetList();
            ChangeData();
         }
         
        private void button1_Click(object sender, EventArgs e)
        {
           
            if (listBox1.SelectedItem!=null)
            {
              
                string item = (string)listBox1.SelectedItem;
                if (item == "農夫")
                {
                    _leftList.Remove("農夫");
                    _rightList.Add("農夫");
                    ChangeData();
                }
                 if (item != "農夫")
                {
                   
                    _leftList.Remove("農夫");
                    _rightList.Add("農夫");
                    _leftList.Remove(item);
                    _rightList.Add(item);
                    ChangeData();
                }

                button1.Enabled = false;
                button2.Enabled = true;
                Check();
                
            }

          
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            if (listBox2.SelectedItem != null)
            {
                string item = (string)listBox2.SelectedItem;
                if (item == "農夫")
                {
                    _rightList.Remove("農夫");
                    _leftList.Add("農夫");
                    ChangeData();
                }
                if (item != "農夫")
                {
                    _rightList.Remove("農夫");
                    _leftList.Add("農夫");
                    _rightList.Remove(item);
                    _leftList.Add(item);
                    ChangeData();
                }


                Check();
                button2.Enabled = false;
                button1.Enabled = true;
            }
            
        }
        private void Check()
        {
            if (_leftList.Contains("農夫")==false)
            {
                if (_leftList.Contains("羊")  && _leftList.Contains("狼") )
                {
                    MessageBox.Show("羊被狼吃");
                  
                    Re();
                }
                else if (_leftList.Contains("菜")  && _leftList.Contains("羊"))
                {
                    MessageBox.Show("菜被羊吃");
                   
                    Re();
                }
             

            }

            if (_rightList.Contains("農夫")==false)
            {
                if (_rightList.Contains("羊") && _rightList.Contains("狼"))
                {
                    MessageBox.Show("羊被狼吃");
                  
                    Re();
                  
                }
                else if (_rightList.Contains("菜") && _rightList.Contains("羊"))
                {
                    MessageBox.Show("菜被羊吃");
                  
                    Re();
                 
                }

            }
            if (_rightList.Contains("農夫") && _rightList.Contains("狼")&& _rightList.Contains("羊")&&_rightList.Contains("菜"))
            {
                MessageBox.Show("恭喜過關");

                Re();

            }
        }

    }
}
