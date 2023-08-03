using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession4
{
    public class HocSinh
    {
        public string HoTen { get; set; }
        public string Lop { get; set; }
        public DateTime NgaySinh { get; set; }
        public double DiemToan { get; set; }
        public double DiemVan { get; set; }
        private double diem;
        public double DiemAnh { get => diem ; set { diem = value; DiemTrungBinh = (DiemToan + DiemVan + DiemAnh) / 3; } }
        public double DiemTrungBinh { get; private set; }
        public HocSinh()
        {
            Console.Write("Nhap Ho Ten Hoc Sinh: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhap Lop: ");
            Lop = Console.ReadLine();
            Console.Write("Nhap Ngay Sinh: ");
            NgaySinh = DateTime.Parse(Console.ReadLine());
            Console.Write("Nhap Diem Toan: ");
            DiemToan = double.Parse(Console.ReadLine());
            Console.Write("Nhap Diem Van: ");
            DiemVan = double.Parse(Console.ReadLine());
            Console.Write("Nhap Diem Anh: ");
            DiemAnh = double.Parse(Console.ReadLine());
        }
        public HocSinh(string hoten, string lop, DateTime ngaysinh, double toan, double van, double anh)
        {
            HoTen = hoten;
            Lop = lop;
            NgaySinh = ngaysinh;
            DiemToan = toan;
            DiemVan = van;
            DiemAnh = anh;
        }
        public void InThongTin()
        {
            Console.WriteLine($"{HoTen} hoc lop {Lop}, co diem trung binh la {DiemTrungBinh}");
        }
    }
    
}
