using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession4
{
    internal class ThoiGian
    {
        public int Ngay { get; set; }
        public int Thang { get; set; }
        private int n;
        public int Nam 
        { 
            get => n;
            set
            {
                n = value;
                LaNamNhuan = DateTime.IsLeapYear(Nam);
            }
        }
        public bool LaNamNhuan { get; private set; }
        public string Thu { get;private set; }
        public override string ToString()
        {
            return $"{Ngay}/{Thang}/{Nam}";
        }
        public void LayThongTin()
        {
            Console.WriteLine($"Thoi gian hien tai la: Thu {Thu}, ngay {Ngay}, thang {Thang}, nam {Nam}");
            if (LaNamNhuan) Console.WriteLine("Day la nam nhuan");
            else Console.WriteLine("Day khong phai la nam nhuan");
        }
        public int LayKhoangThoiGian(ThoiGian tg)
        {
            string n1 = this.ToString();
            string n2 = tg.ToString();
            DateTime dt1 = DateTime.Parse(n1);
            DateTime dt2 = DateTime.Parse(n2);
            int ktg = Math.Abs(dt1.Subtract(dt2).Days);
            return ktg;
        }
        public string LaThu(int ngay, int thang, int nam)
        {
            DateTime dt = new DateTime(nam, thang, ngay);
            DayOfWeek thu = dt.DayOfWeek;
            return thu.ToString();
        }
        public ThoiGian(int ngay, int thang, int nam)
        {
            Ngay = ngay;
            Thang = thang;
            Nam = nam;
            Thu = LaThu(ngay, thang, nam);
        }
        public ThoiGian()
        {
            do
            {
                Ngay = NhapNgay();
                Thang = NhapThang();
                Nam = NhapNam();
                if (Ngay > DateTime.DaysInMonth(Nam, Thang))
                {
                    Console.WriteLine("Ngay thang nam khong hop le!");
                }
            } while (Ngay > DateTime.DaysInMonth(Nam, Thang));
            Thu = LaThu(Ngay, Thang, Nam);

        }
        private int NhapNgay()
        {
            int num;
            while (true)
            {
                Console.Write("Nhap ngay: ");
                if (int.TryParse(Console.ReadLine(), out num))
                {
                    Ngay = num;
                    if (Ngay >= 1 && Ngay <= 31)
                    {
                        return Ngay;
                    }
                    else
                    {
                        Console.WriteLine("Gia tri ngay cua thoi gian(1 - 31)");
                    }
                }
                else
                {
                    Console.WriteLine("Khong hop le!");
                }
            }
        }
        private int NhapThang()
        {
            int num;
            while (true)
            {
                Console.Write("Nhap thang: ");
                if (int.TryParse(Console.ReadLine(), out num))
                {
                    Thang = num;
                    if (Thang >= 1 && Thang <= 12)
                    {
                        return Thang;
                    }
                    else
                    {
                        Console.WriteLine("Gia tri thang cua thoi gian(1 - 12)");
                    }
                }
                else
                {
                    Console.WriteLine("Khong hop le!");
                }
            }
        }
        private int NhapNam()
        {
            int num;
            while (true)
            {
                Console.Write("Nhap nam: ");
                if (int.TryParse(Console.ReadLine(), out num))
                {
                    Nam = num;
                    if (Nam >= 1000 && Nam <= DateTime.Now.Year)
                    {
                        return Nam;
                    }
                    else
                    {
                        Console.WriteLine("Gia tri nam cua thoi gian(1000 - nam hien tai)");
                    }
                }
                else
                {
                    Console.WriteLine("Khong hop le!");
                }
            }
        }

    }
}
