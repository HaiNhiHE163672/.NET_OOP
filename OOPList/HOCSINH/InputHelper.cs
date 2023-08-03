using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPList.HOCSINH
{
    class InputHelper
    {
        public int NhapKieuInt(string a)
        {
            int num;
            while (true)
            {
                Console.Write($"Nhap {a} : ");
                if (int.TryParse(Console.ReadLine(), out num))
                {
                    return num;
                }
                else
                {
                    Console.WriteLine("Nhap sai dinh dang! Vui Long nhap lai so nguyen!");
                }
            }
        }
        public double NhapKieuDouble(string a)
        {
            double num;
            while (true)
            {
                Console.Write($"Nhap {a} : ");
                if (double.TryParse(Console.ReadLine(), out num))
                {
                    if(num >= 0 && num <= 10)
                    {
                        if(num % 0.25 == 0)
                        {
                            return num;
                        }
                        else
                        {
                            Console.WriteLine($"Nhap {a} phai chia het cho 0.25");
                        }

                    }
                    else
                    {
                        Console.WriteLine($"Nhap {a} phai nam trong doan 0-10");
                    }
                    
                }
                else
                {
                    Console.WriteLine("Nhap sai dinh dang! Vui Long nhap lai so thuc!");
                }
            }
        }
        public DateTime NhapKieuDateTime(string a)
        {
            DateTime date;
            while (true)
            {
                Console.Write($"Nhap {a} : ");
                if (DateTime.TryParse(Console.ReadLine(), out date))
                {
                    return date;
                }
                else
                {
                    Console.WriteLine("Nhap sai dinh dang! Vui Long nhap lai thoi gian!");
                }
            }
        }

    }
}
