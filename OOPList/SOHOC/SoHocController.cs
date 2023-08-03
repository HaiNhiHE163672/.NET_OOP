using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOPList.SOHOC
{
    class SoHocController
    {
        List<SoHoc> list = new List<SoHoc>();
        public void TaoNgauNhien(int n)
        {

            Random r = new Random();
            for (int i = 1; i <= n; i++)
            {
                list.Add(new SoHoc(r.Next(1, 100)));
            }

        }
        public void HienThi(LoaiSo ls)
        {
            switch (ls)
            {
                case LoaiSo.Tatca:
                    Console.WriteLine("Tat ca cac so: ");
                    list.ForEach(x => x.InThongTin());
                    break;
                case LoaiSo.SoChan:
                    Console.WriteLine("Cac so chan: ");
                    list.FindAll(x => x.LaSoChan).ForEach(x => x.InThongTin());
                    break;
                case LoaiSo.SoLe:
                    Console.WriteLine("Cac so le: ");
                    list.FindAll(x => !x.LaSoChan).ForEach(x => x.InThongTin());
                    break;
                case LoaiSo.SoNguyenTo:
                    Console.WriteLine("Cac so nguyen to: ");
                    list.FindAll(x => x.LaSoNT).ForEach(x => x.InThongTin());
                    break;
                case LoaiSo.SoDoiXung:
                    Console.WriteLine("Cac so doi xung: ");
                    list.FindAll(x => x.LaSoDoiXung).ForEach(x => x.InThongTin());
                    break;
            }
            Console.WriteLine("\n");
        }

    }
}
