using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession4
{
    internal class BinhLinh
    {
        protected double sm = 50;

        public string Ten { get; set; }
        public double SucManh { get; private set; }
        protected bool tb;
        public bool TrangBi { get => tb; set { tb = value; SucManh = TinhSucManh(); } }
        protected virtual double TinhSucManh() => TrangBi ? sm *= 1.1 : sm;
        public void InThongTin()
        {
            Console.WriteLine($"{Ten} co suc manh {SucManh}");
        }
        public int ChienDau(BinhLinh bl)
        {
            if(SucManh > bl.SucManh) return 1;
            else if(SucManh < bl.SucManh) return -1;
            else return 0;
        }

    }
}
