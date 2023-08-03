using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession4
{
     public class MonAn
    {
        public string TenMonAn { get; set; }
        public int GiaBan { get; set; }
        public string GioiThieu { get; set; }
        public string NguyenLieuChinh { get; set; }
        public MonAn()
        {
            Console.Write("Nhap Ten Mon An: ");
            TenMonAn = Console.ReadLine();
            Console.Write("Nhap Gia Ban: ");
            GiaBan = int.Parse(Console.ReadLine());
            Console.Write("Nhap Gioi Thieu: ");
            GioiThieu = Console.ReadLine();
            Console.Write("Nhap nguyen lieu chinh: ");
            NguyenLieuChinh = Console.ReadLine();
        }
        public void InThongTin()
        {
            Console.WriteLine($"Mon {TenMonAn}, {GioiThieu} duoc lam tu cac nguyen lieu chinh {NguyenLieuChinh}");
        }
        
    }
}
