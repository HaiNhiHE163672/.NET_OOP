using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession4
{
    internal class SanPham
    {
        public int MaSanPham { get; set; }
        public string TenSanPham { set; get; }
        public string LoaiSanPham { set; get; }
        public bool LaSanPhamMoi { set; get; }
        public SanPham(int maSanPham, string tenSanPham, string loaiSanPham, bool laSanPhamMoi)
        {
            MaSanPham = maSanPham;
            TenSanPham = tenSanPham;
            LoaiSanPham = loaiSanPham;
            LaSanPhamMoi = laSanPhamMoi;
        }
        public void InThongTin()
        {
            Console.WriteLine($"San pham {TenSanPham} co ma la {MaSanPham}, thuoc loai {LoaiSanPham}, {LaSanPhamMoi} la san pham moi");
        }
    }
}
