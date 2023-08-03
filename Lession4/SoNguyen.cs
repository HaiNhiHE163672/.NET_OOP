using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession4
{
    internal class SoNguyen
    {
        private int gt;
        public int GiaTri
        {
            get => gt;
            set
            {
                gt = value;
                LaSoChan = KiemTraChan();
                LaSoNguyenTo = KiemTraNguyenTo();
                LaSoDoiXung= KiemTraDoiXung();
            }
        }
        public bool LaSoChan { get; private set; }
        public bool LaSoNguyenTo { get; private set; }
        public bool LaSoDoiXung { get; private set; }
        public void InThongTin()
        {
            Console.Write($"So nguyen {GiaTri}");
            if (LaSoChan)
                Console.Write(" la so chan,");
            else Console.WriteLine(" khong phai so chan,");
            if (LaSoNguyenTo)
                Console.Write(" la so nguyen to");
            else Console.Write(" khong phai so nguyen to");
            Console.WriteLine();
        }
        public static int Cong (SoNguyen a, SoNguyen b)
        {
            return a.GiaTri + b.GiaTri;
        }
        private bool KiemTraChan()
        {
            if (GiaTri % 2 == 0) return true;
            else return false;
        }
        private bool KiemTraNguyenTo()
        {
            if(GiaTri < 2) return false;
            int d = 0;
            for(int i = 2; i <= Math.Sqrt(GiaTri); i++)
            {
                if(GiaTri % i == 0) d++;
            }
            if(d == 0) return true;
            else return false;
        }
        private bool KiemTraDoiXung()
        {
            int dx = 0, t = GiaTri, n;
            while(t != 0)
            {
                n = t % 10;
                dx = dx * 10 + n;
                t /= 10;

            }
            if(dx == GiaTri) return true;
            else return false;
        }
        public SoNguyen(int giaTri)
        {
            GiaTri = giaTri;
        }
        public SoNguyen()
        {
            GiaTri = NhapSo();
        }
        private int NhapSo()
        {
            
            int num;
            while (true)
            {
                Console.Write("Nhap vao mot so nguyen: ");
                if (int.TryParse(Console.ReadLine(),out num))
                {
                    return num;
                }
                else{
                    Console.WriteLine("Gia Tri Khong Hop Le!");
                }
            }
        }
    }
}
