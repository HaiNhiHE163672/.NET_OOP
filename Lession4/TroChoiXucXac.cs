using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession4
{
    internal class TroChoiXucXac
    {
        private int gt2;
        public int GiaTri_1 { get; set; }
        public int GiaTri_2 { get => gt2;set { gt2 = value; Thang = GiaTri_1 > GiaTri_2 ? true : false; Thua = GiaTri_1 < GiaTri_2 ? true : false; Hoa = GiaTri_1 == GiaTri_2 ? true : false; } }
        public bool Thang { get; private set; }
        public bool Thua { get; private set; }
        public bool Hoa { get; private set; }
        public void BatDau()
        {

            do
            {
                
                GiaTri_1 = NhapGiaTri();
                if (GiaTri_1 < 3 || GiaTri_1 > 18)
                {
                    Console.WriteLine("Tro Choi Ket Thuc!");
                    return;
                }
                Random rd = new Random();
                int l1 = rd.Next(1, 6);
                int l2 = rd.Next(1, 6);
                int l3 = rd.Next(1, 6);
                Console.WriteLine($"Ket qua: {l1}, {l2}, {l3}");
                GiaTri_2 = l1 + l2 + l3;
                Console.WriteLine($"Tong sau 3 lan xuc xac: {GiaTri_2}");
                InThongTin();
                Thang = Thua = Hoa = false;

            } while (GiaTri_1 >= 3 && GiaTri_1 <= 18);
        }
        private void InThongTin()
        {
            if(Thang)
            {
                Console.WriteLine("Nguoi choi thang!");
            }else if (Thua)
            {
                Console.WriteLine("Nguoi choi thua!");
            }
            else
            {
                Console.WriteLine("Van Hoa!");
            }
        }
        private int NhapGiaTri()
        {
            Console.Write("Nhap gia tri nguoi dung dat: ");
            return int.Parse(Console.ReadLine());

        }
    }
}
