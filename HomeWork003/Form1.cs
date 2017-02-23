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
        public Form1()
        {
            InitializeComponent();
            list = CreateData();
            dataGridView1.DataSource = list;
        }
        private List<phone> CreateData()
        {
            char[] split = new char[] { ',' };
            string fileName = "phone.csv";
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
            var search = list.Where((x) => x.Tel == textBox1.Text);

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
            dataGridView1.DataSource = search.ToList();
        }
    }
}
