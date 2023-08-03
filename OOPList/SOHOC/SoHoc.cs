using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPList.SOHOC
{
    enum LoaiSo
    {
        Tatca,
        SoChan,
        SoLe,
        SoNguyenTo,
        SoDoiXung
    }
    class SoHoc
    {

        private int gt;
        public int GiaTri
        {
            get => gt;
            set
            {
                gt = value;
                LaSoChan = SoChan();
                LaSoNT = SoNT();
                LaSoDoiXung = SoDoiXung();
            }
        }
        public bool LaSoChan { get; private set; }
        public bool LaSoNT { get; private set; }
        public bool LaSoDoiXung { get; private set; }
        private bool SoChan()
        {
            if (gt % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool SoNT()
        {
            int d = 0;
            if (gt < 2) return false;
            for (int i = 2; i <= Math.Sqrt(gt); i++)
            {
                if (gt % i == 0)
                {
                    d++;
                }
            }
            if (d == 0) return true;
            else return false;
        }
        private bool SoDoiXung()
        {
            int sd = 0, r, t = gt;
            while (t != 0)
            {
                r = t % 10;
                sd = sd * 10 + r;
                t /= 10;
            }
            if (sd == gt)
            {
                return true;
            }
            else return false;
        }
        public SoHoc(int giatri)
        {
            GiaTri = giatri;
        }
        public void InThongTin()
        {
            Console.Write($"{GiaTri} ");
        }
    }
}
