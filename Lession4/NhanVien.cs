using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession4
{
    public class NhanVien
    {
        public int MaNhanVien { get; set; }
        public string HoVaTen { get; set; }
        public string PhongBan { get; set; }
        public  string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public NhanVien()
        {
            Console.Write("Nhap Ma Nhan Vien: ");
            MaNhanVien = int.Parse(Console.ReadLine());
            Console.Write("Nhap Ho va Ten: ");
            HoVaTen = Console.ReadLine();
            Console.Write("Nhap Phong Ban: ");
            PhongBan = Console.ReadLine();
            Console.Write("Nhap Dia Chi: ");
            DiaChi = Console.ReadLine();
            Console.Write("Nhap So Dien Thoai: ");
            SoDienThoai = Console.ReadLine();
        }     
        public void InThongTin()
        {
            Console.WriteLine($"Nhan vien {HoVaTen} thuoc phong ban {PhongBan} co so dien thoai la {SoDienThoai}");
        }
    }
}
