using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession4
{
    internal class HocVien
    {
        public int MaHocVien { get; set; }
        private string ht;
        public string HoTen
        {
            get => ht;
            set
            { 
                ht = value;
                Ho = HoTen.Substring(0,HoTen.IndexOf(' '));
                Email = HoTen.Substring(HoTen.LastIndexOf(' ')+1) + "@edusolution.com"; 
            }
        }
        public DateTime NgaySinh { get; set; }
        public string Ho { get; private set; }
        private double hp;
        public double HocPhi { get => hp; set { hp = value;  hp = hp > 3000000 ? hp -= (hp * (5.0/ 100)) : hp; } }
        public string Email { get; private set; }
        public void InThongTin()
        {
            Console.WriteLine($"{MaHocVien} co ten {HoTen} co email la {Email}");
        }
        public static List<HocVien> TimKiemHocVien(List<HocVien> hv)
        {
            List<HocVien> kq = new List<HocVien>();
            Console.Write("Nhap ten hoc vien can tim: ");
            int d = 0;
            string search = Console.ReadLine();
            foreach(var item in hv)
            {
                if(item.HoTen.Contains(search))
                {
                    kq.Add(item);
                    d++;
                }
            }
            if(d == 0)
            {
                Console.WriteLine($"Khong co hoc vien {search} trong danh sach!");
            }
            return kq;
        }
        public HocVien()
        {
            Console.Write("Nhap ma hoc vien: ");
            MaHocVien = int.Parse(Console.ReadLine());
            Console.Write("Nhap ho ten: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhap ngay sinh: ");
            NgaySinh = DateTime.Parse(Console.ReadLine());
        }
        public HocVien(int maHocVien, string hoTen, DateTime ngaySinh)
        {
            MaHocVien = maHocVien;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
        }
    }
}
