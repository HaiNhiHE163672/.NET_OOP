using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPList.SOHOC
{
    class Helper
    {
        public int NhapGiaTri(string a)
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
                    Console.WriteLine("Nhap sai dinh dang! Vui Long nhap lai!");
                }
            }

        }
    }
}
