using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPList.HOCSINH
{
     class HocSinh
    {
        public int MaHS { get; set; }
        public string TenHS { get; set; }
        public DateTime NgaySinh { get; set; }
        public HocSinh()
        {
            InputHelper h = new InputHelper();
            MaHS = h.NhapKieuInt("Ma Hoc Sinh");
            Console.Write("Nhap Ten Hoc Sinh: ");
            TenHS = Console.ReadLine();
            NgaySinh = h.NhapKieuDateTime("Ngay Sinh");
        }
        public void InThongTin()
        {
            Console.WriteLine($"Ma Hoc Sinh: {MaHS}");
            Console.WriteLine($"Ten Hoc Sinh: {TenHS}");
            Console.WriteLine($"Ngay Sinh: {NgaySinh.ToShortDateString}");
        }
    }
}
