using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPList.HINHHOC
{
    class Diem
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int TTDiem()
        {
            int tt;
            List<Diem> d = new List<Diem>();
            if(d.Count == 0)
            {
                tt = 1;
            }
            else
            {
                tt = d.Count + 1;
            }
            return tt;
        }
        public Diem(int x, int y)
        {
            X = x;
            Y = y;
        }
        public void InThongTin()
        {
            Console.WriteLine($"{TTDiem()}: [{X},{Y}]");
        }
    }
}
