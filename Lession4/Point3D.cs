using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession4
{
    internal class Point3D
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        public Point3D(double x, double y, double z)
        {
            X = x; Y = y; Z = z;
        }
        public Point3D()
        {
            Console.Write("Nhap X = ");
            X = double.Parse(Console.ReadLine());
            Console.Write("Nhap Y = ");
            Y = double.Parse(Console.ReadLine());
            Console.Write("Nhap Z = ");
            Z = double.Parse(Console.ReadLine());
        }
        public void InThongTin()
        {
            Console.WriteLine($"({X},{Y},{Z})");
        }
        public double TinhKhoangCach(Point3D a)
        {
            double kc = Math.Sqrt(Math.Pow(a.X - X,2) + Math.Pow(a.Y - Y,2) + Math.Pow(a.Z - Z,2));
            return kc;
        }
    }
}
