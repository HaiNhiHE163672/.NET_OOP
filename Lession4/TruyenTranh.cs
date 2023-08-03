using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession4
{
    internal class TruyenTranh : TaiLieu
    {
        public int NgayPhatHanh { get; set; }
        public TruyenTranh()
        {
            NgayPhatHanh = Nhap();
            
        }
        private int Nhap()
        {
            int num;
            while (true)
            {
                Console.Write("Nhap ngay phat hanh: ");
                if (int.TryParse(Console.ReadLine(), out num))
                {
                    NgayPhatHanh = num;
                    if (NgayPhatHanh >= 1 && NgayPhatHanh <= 31)
                    {
                        return NgayPhatHanh;
                    }
                    else
                    {
                        Console.WriteLine("Ngay phat hanh khong hop le");
                    }

                }
                else
                {
                    Console.WriteLine("Ngay phat hanh khong hop le");
                }
            }
        }
        public override void InThongTin()
        {
            base.InThongTin();
            Console.WriteLine($"Truyen Tranh co ngay phat hanh {NgayPhatHanh}");
        }
    }
}
