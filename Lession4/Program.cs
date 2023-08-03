using Lession4.moe;
using System;
using System.Data;

namespace Lession4
{
    public class Program
    {
        
        static void Main(string[] args)
        {

            Lession4.moe.Meo meo = new MeoAnh();
            meo.TiengKeu = new KeuKieuMeoAnh();
            meo.TiengKeu.cachKeu();
            meo.TiengKeu = new KieuKieuMeoNga();
            meo.TiengKeu.cachKeu();
            //List<Meo> meos = new List<Meo>(); 
            //QuanLyMeo o = new QuanLyMeo();
            //while (true)
            //{
            //    o.Menu();
            //    int a = o.choice("Vui long chon mot chuc nang(1-6): ");
            //    switch (a)
            //    {
            //        case 1:
            //            o.Them(meos);
            //            break;
            //        case 2:
            //            int id = o.choice("Nhap ID: ");
            //            o.Xoa(meos, id);
            //            break;
            //        case 3:
            //            o.HienThi(meos);
            //            break;
            //        case 4:
            //            id = o.choice("Nhap ID: ");
            //            o.HienThiTheoID(meos,id);
            //            break;
            //        case 5:
            //            Console.WriteLine("Nhap ID: ");
            //            id = int.Parse(Console.ReadLine());
            //            o.ThayDoiTheoID(meos, id);
            //            break;
            //        case 6: 
            //            return;
            //        default:
            //            Console.WriteLine("Nhap sai khoang! Vui long nhap lai!");
            //            break;
            //    } 
            //}
           

        }
    }
}
