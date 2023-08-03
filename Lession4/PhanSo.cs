using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession4
{
    internal class PhanSo
    {
        public int TuSo { get; set; }
        public int MauSo { get; set; }
        public void InThongTin()
        {
            Console.WriteLine($"Phan so la {TuSo}/{MauSo}");
        }
        private void ToiGian()
        {
            int a = Math.Abs(TuSo);
            int b = Math.Abs(MauSo);
            while (a != b)
            {
                if (a > b) a -= b;
                else b -= a;
            }
            TuSo /= a;
            MauSo /= b;

        }
        public PhanSo Cong(PhanSo a)
        {
            PhanSo kq = new PhanSo(0,0);
            kq.MauSo = MauSo * a.MauSo;
            kq.TuSo = a.TuSo * MauSo + a.MauSo * TuSo;
            kq.ToiGian();
            return kq;
        } 
        public PhanSo Tru(PhanSo a)
        {
            PhanSo kq = new PhanSo(0,0);
            if (TuSo * a.MauSo == MauSo * a.TuSo)
            {
                return kq;
            }
            else
            {
                kq.MauSo = MauSo * a.MauSo;
                kq.TuSo = a.TuSo * MauSo - a.MauSo * TuSo;
                kq.ToiGian();
                return kq;
            }
        }
        public PhanSo()
        {
            Console.Write("Nhap tu so: ");
            TuSo = int.Parse(Console.ReadLine());
            Console.Write("Nhap mau so: ");
            MauSo = int.Parse(Console.ReadLine());
        }
        public PhanSo(int tuso, int mauso)
        {
            TuSo= tuso;
            MauSo= mauso;
        }
    }
}
