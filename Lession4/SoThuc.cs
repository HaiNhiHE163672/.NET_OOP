using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession4
{
    internal class SoThuc
    {
        private double gt;
        public double GiaTri { get => gt; set { gt = value; LaSoDuong = GiaTri > 0 ? true : false; } }
        public Boolean LaSoDuong { get; private set; }

        public SoThuc()
        {
            Console.Write("Nhap gia tri: ");
            GiaTri = double.Parse(Console.ReadLine());
        }
        public static double TimMax(double a, double b, double c)
        
          =>  (a > b && a > c) ? a : (b > a && b > c) ? b : c;
        
        public double TinhCanBacN(int n)
        {
            return Math.Pow(GiaTri, 1.0 / n);
        }
    }
}
