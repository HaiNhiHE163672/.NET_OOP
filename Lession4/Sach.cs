using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession4
{
    internal class Sach : TaiLieu
    {
        public string TenTacGia { get; set; }
        public int SoTrang { get; set; }
        public Sach()
        {
            Console.WriteLine("Nhap ten tac gia, so trang: ");
            TenTacGia = Console.ReadLine();
            SoTrang = int.Parse(Console.ReadLine());
        }
        public override void InThongTin()
        {
            base.InThongTin();
            Console.WriteLine($"Sach co ten tac gia la {TenTacGia} va co {SoTrang} trang");
        }
    }
}
