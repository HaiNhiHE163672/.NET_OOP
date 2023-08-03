using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession4
{
    internal class DongHo
    {
        private int g;
        public int Gio 
        {
            get => g;
            set
            {
                g = value;
                LaBuoiSang = Gio <= 12 ? true: false;
            }
        }
        public int Phut { get; set; }
        public int Giay { get; set; }
        public bool LaBuoiSang { get; private set; }
        public void LayThongTin()
        {
            Console.WriteLine($"{Gio} : {Phut} : {Giay}");
            if (LaBuoiSang) Console.WriteLine("Bay gio la buoi sang");
            else Console.WriteLine("Bay gio la buoi chieu");
        }
        public DongHo LayKhoangThoiGian(DongHo dh)
        {
            DongHo ktg = new DongHo(0,0,0);
            int t1, t2, t3;
            t1 = Gio * 3600 + Phut * 60 + Giay;
            t2 = dh.Gio * 3600 + dh.Phut * 60 + dh.Giay;
            t3 = Math.Abs(t1 - t2);
            ktg.Gio = t3/3600;
            ktg.Phut = (t3 - ktg.Gio * 3600) / 60;
            ktg.Giay = t3 - ktg.Gio * 3600 - ktg.Phut * 60;
            return ktg;
        }
        public DongHo( int gio, int phut, int giay)
        {
            Gio = gio;
            Phut = phut;
            Giay = giay;
        }
        public DongHo()
        {
            Gio = NhapGio();
            Phut = NhapPhut();
            Giay = NhapGiay();
        }
        private int NhapGio()
        {
            int num;
            while(true)
            {
                Console.Write("Nhap gio: ");
                if (int.TryParse(Console.ReadLine(), out num))
                {
                    Gio = num;
                    if(Gio >= 0 && Gio <= 24)
                    {
                        return Gio;
                    }
                    else
                    {
                        Console.WriteLine("Gia tri gio cua dong ho (0 - 24)");
                    }
                }
                else
                {
                    Console.WriteLine("Khong hop le!");
                }
            }
        }
        private int NhapPhut()
        {
            int num;
            while (true)
            {
                Console.Write("Nhap phut: ");
                if (int.TryParse(Console.ReadLine(), out num))
                {
                    Phut = num;
                    if (Phut >= 0 && Phut <= 60)
                    {
                        return Phut;
                    }
                    else
                    {
                        Console.WriteLine("Gia tri phut cua dong ho (0 - 60)");
                    }
                }
                else
                {
                    Console.WriteLine("Khong hop le!");
                }
            }
        }
        private int NhapGiay()
        {
            int num;
            while (true)
            {
                Console.Write("Nhap giay: ");
                if (int.TryParse(Console.ReadLine(), out num))
                {
                    Giay = num;
                    if (Giay >= 0 && Giay <= 60)
                    {
                        return Giay;
                    }
                    else
                    {
                        Console.WriteLine("Gia tri giay cua dong ho (0 - 60)");
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
