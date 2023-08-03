using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession4
{
    internal class DonDatHang
    {
        public int MaSoDon { get; set; }
        public DateTime NgayDat { get; set; }
        public string TenSanPham { get; set; }
        public double DonGia { get; set; }
        public int sl;
        public int SoLuong { get => sl; set { sl = value;  ThanhTien = SoLuong * DonGia; } }
        public double ThanhTien { get; private set; }
        public string GhiChu { get; set; }
        public void InThongTin()
        {
            Console.WriteLine($"Don hang co so {MaSoDon} dat ngay {NgayDat.ToShortDateString()} co tong tien la {ThanhTien}");
        }
        public DonDatHang()
        {
            Console.Write("Nhap Ma So Don: ");
            MaSoDon = int.Parse( Console.ReadLine() );
            Console.Write("Nhap Ngay Dat: ");
            NgayDat = DateTime.Parse( Console.ReadLine() );
            Console.Write("Nhap Ten San Pham: ");
            TenSanPham = Console.ReadLine();
            Console.Write("Nhap Don Gia: ");
            DonGia = double.Parse( Console.ReadLine() );
            Console.Write("Nhap So Luong: ");
            SoLuong = int.Parse( Console.ReadLine() );
            Console.WriteLine("Nhap Ghi Chu: ");
            GhiChu = Console.ReadLine();

        }
        public DonDatHang(int maSoDon, DateTime ngayDat, string tenSanPham, double donGia, int soLuong, string ghiChu)
        {
            MaSoDon = maSoDon;
            NgayDat = ngayDat;
            TenSanPham = tenSanPham;
            DonGia = donGia;
            SoLuong = soLuong;
            GhiChu = ghiChu;
        }
    }
}
