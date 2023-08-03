using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession4
{
    internal class LopHoc
    {
        public int MaLop { get; set; }
        public string TenLop { get; set; }
        public int SiSo { get; set; }
        public string DiaChi { get; set; }
        public string GVCN { get; set; }
        public void InThongTin()
        {
            Console.WriteLine($"Lop {TenLop} co ma la {MaLop} o {DiaChi}");
            Console.WriteLine($"Lop co {SiSo} hoc sinh va co {GVCN} la GiaoVienChuNhiem");
        }
        public LopHoc()
        {
            Console.Write("Nhap Ma Lop: ");
            MaLop = int.Parse(Console.ReadLine());
            Console.Write("Nhap Ten Lop: ");
            TenLop = Console.ReadLine();
            Console.Write("Nhap Si So: ");
            SiSo = int.Parse(Console.ReadLine());
            Console.Write("Nhap Dia Chi: ");
            DiaChi = Console.ReadLine();
            Console.Write("Nhap GVCN: ");
            GVCN = Console.ReadLine();
        }
        public LopHoc(int maLop, string tenLop, int siSo, string diaChi, string gVCN)
        {
            MaLop = maLop;
            TenLop = tenLop;
            SiSo = siSo;
            DiaChi = diaChi;
            GVCN = gVCN;
        }
    }
}
