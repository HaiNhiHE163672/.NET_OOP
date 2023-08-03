using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession4
{
    internal class MaTran
    {
        public int SoHang { get; set; }
        public int SoCot { get; set; }
        public int[,] Matrix { get; set; }
        public void InMaTran()
        {
            Console.WriteLine("Ma Tran: ");
            for(int i = 0; i < SoHang; i++)
            {
                for(int j = 0; j < SoCot; j++)
                {
                    Console.Write($"{Matrix[i,j]} ");
                }
                Console.WriteLine();
            }
        }
        public int[,] NhapMaTran()
        {
            int[,] a = new int[SoHang, SoCot];
            for (int i = 0; i < SoHang; i++)
            {
                for (int j = 0; j < SoCot; j++)
                {
                    Console.Write($"Matrix[{i}, {j}] =  ");
                    a[i,j] = int.Parse( Console.ReadLine() );
                }
            }
            return a;
        }
        public MaTran CongMaTran(MaTran mt)
        {
            int[,] kq = new int[mt.SoHang, mt.SoCot];
            for (int i = 0; i < SoHang; i++)
            {
                for (int j = 0; j < SoCot; j++)
                {
                    kq[i, j] = mt.Matrix[i, j] + Matrix[i, j];
                }
            }
            MaTran mtkq = new MaTran(mt.SoHang, mt.SoCot, kq);  
            return mtkq;
        }
        public MaTran()
        {
            Console.Write("Nhap so hang: ");
            SoHang = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot: ");
            SoCot = int.Parse(Console.ReadLine());
            Matrix = NhapMaTran();
        }
        public MaTran(int hang, int cot, int[,] matran)
        {
            SoHang = hang;
            SoCot = cot;
            Matrix = matran;
        }
    }
}
