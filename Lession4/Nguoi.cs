using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession4
{
    internal class Nguoi
    {
        public int CMND { get; set; }
        public string HoTen { get; set; }
        public int NamSinh { get; set; }
        public string NgheNghiep { get; set; }
        public Nguoi()
        {
            Console.Write("Nhap CMND: ");
            CMND = int.Parse(Console.ReadLine());
            Console.Write("Nhap Ho Ten: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhap nam sinh: ");
            NamSinh= int.Parse(Console.ReadLine());
            Console.Write("Nhap Nghe Nghiep: ");
            NgheNghiep = Console.ReadLine();
        }
        public void InThongTin()
        {
            Console.WriteLine($"So CMND: {CMND}, Ho Ten: {HoTen}, Sinh Nam : {NamSinh}, Lam nghe: {NgheNghiep}");
        }
    }
}
