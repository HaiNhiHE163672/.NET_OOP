using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPList.HOCSINH
{
    enum ErrorType
    {
        HSDaTonTai,
        MHDaTonTai, 
        HSChuaTonTai,
        MHChuaTonTai,
        DanhSachTrong,
        ThanhCong
    }
     class DiemController
    {
        List<HocSinh> hsList = new List<HocSinh>();
        List<MonHoc> mhList = new List<MonHoc>();
        List<Diem> dList = new List<Diem>();
        
        public ErrorType ThemHS(HocSinh hs)
        {
            if(hsList.Count == 0)
            {
                hsList.Add(hs);
                return ErrorType.ThanhCong;
            }
            else
            {
                int ma = hsList.FindIndex(x => x.MaHS == hs.MaHS);
                if(ma == -1)
                {
                    hsList.Add(hs);
                    return ErrorType.ThanhCong;
                }
                else
                {
                    return ErrorType.HSDaTonTai;
                }
            }
        }
        public ErrorType ThemMonHoc(MonHoc mh)
        {
            if(mhList.Count == 0)
            {
                mhList.Add(mh);
                return ErrorType.ThanhCong;
            }
            else
            {
                int ma = mhList.FindIndex(x => x.MaMH == mh.MaMH);
                if(ma == -1)
                {
                    mhList.Add(mh);
                    return ErrorType.ThanhCong;
                }
                else
                {
                    return ErrorType.MHDaTonTai;
                }

            }
        }
        public ErrorType ChamDiem(int maHS, int maMH)
        {
            InputHelper ip = new InputHelper();
            int hs = hsList.FindIndex(x => x.MaHS == maHS);
            int mh = mhList.FindIndex(x => x.MaMH == maMH);
            if (hs != -1 && mh != -1)
            {
                    dList.Add(new Diem(maHS, maMH, ip.NhapKieuDouble("Diem")));
                    return ErrorType.ThanhCong;
            }
            else
            {
                if (hs == -1)
                {
                    return ErrorType.HSChuaTonTai;
                }
                else if (mh == -1)
                {
                    return ErrorType.MHChuaTonTai;
                }
                else
                {
                    return ErrorType.HSChuaTonTai;
                }
               
            }
        }
        public ErrorType BangDiem(int maHS)
        {
            if(dList.Count == 0)
            {
                return ErrorType.DanhSachTrong;
            }
            else
            {
                int ma = hsList.FindIndex(x => x.MaHS == maHS);
                if(ma == -1)
                {
                    return ErrorType.HSChuaTonTai;
                }
                else
                {
                    Console.WriteLine("MaHS\t\tMaMH\t\tDiem");
                    dList.FindAll(x => x.MaHS == maHS).ForEach(x => x.InThongTin());
                    return ErrorType.ThanhCong;
                }
            }
        }
        public ErrorType TongKetMon(int maMH)
        {
            if (dList.Count == 0)
            {
                return ErrorType.DanhSachTrong;
            }
            else
            {
                int ma = mhList.FindIndex(x => x.MaMH == maMH);
                if (ma == -1)
                {
                    return ErrorType.MHChuaTonTai;
                }
                else
                {
                    Console.WriteLine("MaHocSinh\t\tMaMonHoc\t\tDiem");
                    dList.FindAll(x => x.MaMH == maMH).ForEach(x => x.InThongTin());
                    return ErrorType.ThanhCong;
                }
            }
        }
        public static void Error(ErrorType e)
        {
            switch (e)
            {
                case ErrorType.DanhSachTrong:
                    Console.WriteLine("Danh sach trong!");
                    break;
                case ErrorType.HSDaTonTai:
                    Console.WriteLine("Hoc Sinh nay da ton tai!");
                    break;
                case ErrorType.MHDaTonTai:
                    Console.WriteLine("Mon Hoc nay da ton tai!");
                    break;
                case ErrorType.HSChuaTonTai:
                    Console.WriteLine("Hoc Sinh nay khong co trong danh sach!");
                    break;
                case ErrorType.MHChuaTonTai:
                    Console.WriteLine("Mon Hoc nay khong co trong danh sach!");
                    break;
                case ErrorType.ThanhCong:
                    Console.WriteLine("Thanh Cong!");
                    break;
            }
        }

    }
}
