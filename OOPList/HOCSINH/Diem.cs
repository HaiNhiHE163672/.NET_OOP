using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPList.HOCSINH
{
     class Diem
    {
        public int MaHS { get; set; }
        public int MaMH { get; set; }
        public double diem { get; set; }
        public Diem(int maHS, int maMH, double diemthi)
        {
            MaHS = maHS;
            MaMH = maMH;
            diem = diemthi;
        }
        public void InThongTin()
        {
            Console.WriteLine($"{MaHS}\t\t{MaMH}\t\t{diem}");
        }
        
    }
}
