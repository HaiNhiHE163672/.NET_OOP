using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession4
{
    internal class TaiLieu
    {
        public int MaTaiLieu { get; set; }
        public string TenNhaSX { get; set; }
        public int SoBan { get; set; }
        public string TenTaiLieu { get; set; }
        public TaiLieu()
        {
            Console.Write("Nhap Ma Tai lieu: ");
            MaTaiLieu = int.Parse(Console.ReadLine());
            Console.Write("Nhap ten nha san xuat: ");
            TenNhaSX = Console.ReadLine();
            Console.Write("Nhap so ban phat hanh: ");
            SoBan= int.Parse(Console.ReadLine());
            Console.Write("Nhap ten tai lieu: ");
            TenTaiLieu = Console.ReadLine();

        }
        public virtual void InThongTin()
        {
            Console.WriteLine($"Ma tai lieu: {MaTaiLieu}\nTen nha san xuat: {TenNhaSX}\nSo ban Phat hanh: {SoBan}\nTen tai lieu: {TenTaiLieu}");
        }
        public static List<TaiLieu> TimKiem(List<TaiLieu> list, string ten)
        {
            List<TaiLieu> tl = new List<TaiLieu>();
            list.ForEach(x =>
            {
                if(x.TenTaiLieu.ToLower().Contains(ten.ToLower()))
                {
                    tl.Add(x);
                }

            });
            return tl;
        }
    }
}
