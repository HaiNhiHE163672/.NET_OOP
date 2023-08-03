using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession4
{
    internal class HoDan
    {
        public int SoThanhVien { get; set; }
        public int SoNha { get; set; }
        List<Nguoi> tv = new List<Nguoi>();
        public HoDan()
        {
            Console.Write("Nhap so thanh vien: ");
            SoThanhVien = int.Parse(Console.ReadLine());
            Console.Write("Nhap so nha: ");
            SoNha = int.Parse(Console.ReadLine());
            for(int i = 0; i < SoThanhVien; i++)
            {
                Console.WriteLine($"Nhap Thong Tin Thanh vien {i+1}");
                Nguoi ng = new Nguoi();
                tv.Add(ng);
            }
        }
        public void InThongTin()
        {
            Console.WriteLine($"Ho dan o so nha {SoNha}, co {SoThanhVien} thanh vien");
            Console.WriteLine($"Thong tin chi tiet cua cac thanh vien trong ho {SoNha}: ");
            tv.ForEach(ng => ng.InThongTin());
        }
    }
}
