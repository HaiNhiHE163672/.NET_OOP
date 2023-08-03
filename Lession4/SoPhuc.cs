using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession4
{
    internal class SoPhuc
    {
        public double PhanThuc { get; set; }
        public double PhanAo { get; set; }
        public void InThongTin()
        {
            Console.WriteLine($"{PhanThuc} + {PhanAo}i");
        }
    }
}
