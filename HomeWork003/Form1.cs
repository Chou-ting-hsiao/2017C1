using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HomeWork003
{
    public partial class Form1 : Form
    {
        private List<phone> list;
        string fileName = "phone.csv";
        int i = 0;
        public Form1()
        {
            InitializeComponent();
            gvInit();
        }

        public void gvInit()
        {
            list = CreateData();
            dataGridView1.DataSource = list;
        }
        private List<phone> CreateData()
        {
            char[] split = new char[] { ',' };
            List<phone> result = new List<phone>();
            if (File.Exists(fileName))
            {
                string[] lines = File.ReadAllLines(fileName);
                for (int i = 1; i < lines.Count(); i++)
                {
                    string[] items = lines[i].Split(split);

                    var phone = new phone
                    {
                        Seq = int.Parse(items[0]),
                        Name = items[1],
                        Tel = items[2],
                        Address = items[3]
                    };
                    result.Add(phone);
                }
            }

            return result;

        }

      
        private void button1_Click(object sender, EventArgs e)
        {
            /* List<phone> result = new List<phone>();
            foreach (var item in search)
            {
                var phone = new phone
                {
                    Seq = item.Seq,
                    Name = item.Name,
                    Tel = item.Tel,
                    Address = item.Address
                };
                result.Add(phone);
                // MessageBox.Show(item.Seq+","+item.Name + "," + item.Tel + "," + item.Address);
            }
            */
            char[] split = new char[] { ',' };
            List<phone> result = new List<phone>();
            if (File.Exists(fileName))
            {
                string[] lines = File.ReadAllLines(fileName);
                for (int i = 1; i < lines.Count(); i++)
                {
                    string[] items = lines[i].Split(split);

                    if (items[1]==textBox2.Text)
                    {
                      
                        MessageBox.Show(items[0] + "," + items[1] + "," + items[2] + "," + items[3]);
                    }
                 
                }
            }
            //var search = list.Where((x) => x.Name == textBox2.Text);
           // dataGridView1.DataSource = search.ToList();
            //textBox1.Text = "";
        }

      
        private void button2_Click_1(object sender, EventArgs e)
        {
            gvInit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (i==0)
            {
                label1.Visible = true;
                label3.Visible = true;
                textBox1.Visible = true;
                textBox3.Visible = true;
                i++;
            }
            else
            {
                if (File.Exists(fileName))
                {
                    //File.AppendAllText(fileName,list.Count()+1.ToString()+","+"555" + "," + "5555" + "," + "5555");
                    File.AppendAllText(fileName, "\r\n" + Convert.ToString(list.Count() + 1) + "," + textBox2.Text + "," + textBox1.Text + "," + textBox3.Text, Encoding.Unicode);
                  
                    gvInit();
                }
                else
                {
                    MessageBox.Show("檔案不存在");
                }
                label1.Visible = false;
                label3.Visible = false;
                textBox1.Visible = false;
                textBox3.Visible =false;
                i = 0;
            }
          
        }
    }
}
