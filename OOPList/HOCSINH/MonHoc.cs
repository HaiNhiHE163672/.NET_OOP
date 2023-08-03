using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPList.HOCSINH
{
     class MonHoc
    {
        public int MaMH { get; set; }
        public string TenMH { get; set; }
        public int SoTiet { get; set; }
        public MonHoc()
        {
            InputHelper h = new InputHelper();
            MaMH = h.NhapKieuInt("Ma Mon Hoc");
            Console.Write("Nhap Ten Mon Hoc: ");
            TenMH = Console.ReadLine();
            SoTiet = h.NhapKieuInt("So Tiet");
        }
        public void InThongTin()
        {
            Console.WriteLine($"Ma Mon Hoc: {MaMH}");
            Console.WriteLine($"Ten Mon Hoc: {TenMH}");
            Console.WriteLine($"So Tiet: {SoTiet}");
        }
    }
}
