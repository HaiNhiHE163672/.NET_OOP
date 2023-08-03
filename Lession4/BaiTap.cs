using System;

namespace Lession4
{
    internal class BaiTap
    {
        static void NhapMaTran(int[,] a, int hang, int cot)
        {
            for (int i = 0; i < hang; i++)
            {
                for (int j = 0; j < cot; j++)
                {
                    Console.Write($"a[{i},{j}] = ");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        static void HienThi(int[,] a, int hang, int cot)
        {
            Console.WriteLine("Ma tran: ");
            for (int i = 0; i < hang; i++)
            {
                for (int j = 0; j < cot; j++)
                {
                    Console.Write(a[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
        static int[,] TichHaiMaTran(int[,] a,int hang1, int cot1 ,int[,] b, int hang2, int cot2)
        {
            int tong = 0;
            int[,] Tich = new int[0,0];
            if(cot1 != hang2)
            {
                Console.WriteLine("Vi pham nguyen tac nhan ma tran");
            }
            else
            {
                Tich = new int[hang1, cot2];
                for(int i = 0; i < hang1; i++)
                {
                    for(int j = 0; j < cot2; j++)
                    {
                        for(int k = 0; k < cot1; k++)
                        {
                            tong += a[i, k] * b[k, j];
                        }
                        Tich[i,j] = tong;
                        tong = 0;
                    }
                }
                return Tich;
            }
            return Tich;
        }
        static void Main(string[] args)
        {
            Console.Write("Nhap so hang ma tran 1: ");
            int hang1 = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot ma tran 1: ");
            int cot1 = int.Parse(Console.ReadLine());
            int[,] a = new int[hang1, cot1];
            NhapMaTran(a, hang1, cot1);
            Console.Write("Nhap so hang ma tran 2: ");
            int hang2 = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot ma tran 2: ");
            int cot2 = int.Parse(Console.ReadLine());
            int[,] b = new int[hang2, cot2];
            NhapMaTran(b, hang2, cot2);
            HienThi(a, hang1, cot1);
            HienThi(b, hang2, cot2);
            if (cot1 != hang2)
            {
                Console.WriteLine("Vi pham nguyen tac nhan ma tran");
            }
            else
            {
                HienThi(TichHaiMaTran(a, hang1, cot1, b, hang2, cot2), hang1, cot2);
            }
            
        }
    }
}
