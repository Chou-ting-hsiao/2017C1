using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class MyBMI
    {
     
        public double Height { get; set; }
        public double Weight { get; set; }
        public double BMI
        {
            get { return Math.Round(Weight/Math.Pow(Height / 100,2),2); }
        }
    }
}
