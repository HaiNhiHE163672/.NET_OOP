using Lession5.meo;
using System.ComponentModel.Design;
using Lession5.tiengkeu;
using System.Net.Http.Headers;

namespace Lession5
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            List<Meo> meos = new List<Meo>();
            KiemTraDauVao o = new KiemTraDauVao();

            while (true) 
            {
                o.Menu();
                Console.Write("Nhap lua chon: ");
                int a = int.Parse(Console.ReadLine());

                switch (a)
                {
                    case 1:

                        Meo meo;
                        Console.Write("a. Meo Anh\nb. Meo Ba Tu\n");
                        Console.Write("Chon giong meo: ");
                        int giong = char.Parse(Console.ReadLine());
                        switch (giong)
                        {
                            case 'a':
                                meo = new Meo(o.LayID(meos), o.NhapTen(), o.NhapTuoi(), o.NhapGioiTinh(), new TiengKeuMeoAnh());
                                meos.Add(meo);
                                break;
                            case 'b':
                                meo = new Meo(o.LayID(meos), o.NhapTen(), o.NhapTuoi(), o.NhapGioiTinh(), new TiengKeuMeoBaTu());
                                meos.Add(meo);
                                break;
                            default: break;
                        }
                        break;
                    case 2:
                        int id = o.choice("Nhap ID: ");
                        o.Xoa(meos, id);
                        break;
                    case 3:
                        o.HienThi(meos);
                        break;
                    case 4:
                        id = o.choice("Nhap ID: ");
                        o.HienThiTheoID(meos, id);
                        break;
                    case 5:
                        Console.WriteLine("Nhap ID: ");
                        id = int.Parse(Console.ReadLine());
                        o.ThayDoiTheoID(meos, id);
                        break;
                    case 6:
                        return;
                    default:
                        Console.WriteLine("Nhap sai khoang! Vui long nhap lai!");
                        break;
                }
            }


        }
    }
}