using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPList.SOHOC
{
    class SoHocView
    {
        public void Menu()
        {
            Console.WriteLine("1. Tao so ( Nhap so N roi tao N so ngau nhien)");
            Console.WriteLine("2. Hien thi Tat Ca");
            Console.WriteLine("3. Hien thi So Chan");
            Console.WriteLine("4. Hien thi So Le");
            Console.WriteLine("5. Hien thi so Nguyen To");
            Console.WriteLine("6. Hien thi so Doi Xung");
            Console.WriteLine("7. Thoat");
        }
        public void ThucThi()
        {
            Helper h = new Helper();
            SoHocController c = new SoHocController();
            while (true)
            {
                Menu();
                switch (h.NhapGiaTri("Lua Chon"))
                {
                    case 1:
                        c.TaoNgauNhien(h.NhapGiaTri("Gia Tri"));
                        break;
                    case 2:
                        c.HienThi(LoaiSo.Tatca);
                        break;
                    case 3:
                        c.HienThi(LoaiSo.SoChan);
                        break;
                    case 4:
                        c.HienThi(LoaiSo.SoLe);
                        break;
                    case 5:
                        c.HienThi(LoaiSo.SoNguyenTo);
                        break;
                    case 6:
                        c.HienThi(LoaiSo.SoDoiXung);
                        break;
                    case 7:
                        return;
                    default:
                        Console.WriteLine("Vui long nhap lai! Nhap trong khoang gia tri tu 1 den 7!");
                        break;
                }
            }
        }

    }
}
