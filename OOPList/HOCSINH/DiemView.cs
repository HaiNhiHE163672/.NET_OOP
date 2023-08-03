using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPList.HOCSINH
{
     class DiemView
    {
        public void Menu()
        {
            Console.WriteLine("1. Them Hoc Sinh");
            Console.WriteLine("2. Them Mon Hoc");
            Console.WriteLine("3. Cham Diem");
            Console.WriteLine("4. Xem Bang Diem Hoc Sinh");
            Console.WriteLine("5. Xem Tong Ket Diem Hoc Sinh Theo Mon");
            Console.WriteLine("6. Thoat");
        }
        public void ThucThi()
        {
            InputHelper h = new InputHelper();
            DiemController d = new DiemController();
            
            while (true)
            {
                Menu();
                switch (h.NhapKieuInt("Lua Chon"))
                {
                    case 1:
                        DiemController.Error(d.ThemHS(new HocSinh()));
                        break;
                    case 2:
                        DiemController.Error(d.ThemMonHoc(new MonHoc()));
                        break;
                    case 3:
                        int maHS = h.NhapKieuInt("Ma Hoc Sinh");
                        int maMH = h.NhapKieuInt("Ma Mon Hoc");
                        DiemController.Error(d.ChamDiem(maHS, maMH));
                        break;
                    case 4:
                        maHS = h.NhapKieuInt("Ma Hoc Sinh");
                        DiemController.Error(d.BangDiem(maHS));
                        break;
                    case 5:
                        maMH = h.NhapKieuInt("Ma Mon Hoc");
                        DiemController.Error(d.TongKetMon(maMH));
                        break;
                    case 6:
                        return;
                    default:
                        Console.WriteLine("Vui long nhap lai! Nhap so tu 1-6!");
                        break;
                }
            }
        }
    }
}
