using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession4
{
    internal class TapChi : TaiLieu
    {
        private int s;
        public int SoPhatHanh { get; set;}
        public int ThangPhatHanh { get; set; }
        public TapChi()
        {
            Console.WriteLine("Nhap so phat hanh: ");
            SoPhatHanh = int.Parse(Console.ReadLine());
            ThangPhatHanh = NhapThang();
        }
        private int NhapThang()
        {
            int num;
            while(true)
            {
                Console.Write("Nhap thang phat hanh: ");
                if(int.TryParse(Console.ReadLine(), out num))
                {
                    ThangPhatHanh = num;
                    if(ThangPhatHanh >= 1 && ThangPhatHanh <= 12)
                    {
                        return ThangPhatHanh;
                    }
                    else
                    {
                        Console.WriteLine("Thang phat hanh khong hop le");
                    }
                    
                }
                else
                {
                    Console.WriteLine("Thang phat hanh khong hop le");
                }
            }
        }
        public override void InThongTin()
        {
            base.InThongTin();
            Console.WriteLine($"Tap Chi co so phat hanh {SoPhatHanh} phat hanh thang {ThangPhatHanh}");
        }
    }
}
