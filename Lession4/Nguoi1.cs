using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession4
{
    internal class Nguoi1
    {
        public int MaSo { get; set; }
        private string ht;
        public string HoTen { 
            get => ht; 
            set
            {
                ht = value;
                Ho = HoTen.Substring(0,HoTen.IndexOf(' '));
                Dem = HoTen.Substring(HoTen.IndexOf(' ') + 1,HoTen.LastIndexOf(' ') - Ho.Length-1);
                Ten= HoTen.Substring(HoTen.LastIndexOf(' ')+1);
            }
        }
        public DateTime NgaySinh { get; set; }
        public string Ho { get; private set; }
        public string Dem { get; private set; }
        public string Ten { get; private set; }
        public void InThongTin()
        {
            Console.WriteLine($"{MaSo} co ten la {HoTen} sinh ngay {NgaySinh.ToShortDateString()}");
        }
        public Nguoi1()
        {
            Console.Write("Nhap ma so: ");
            MaSo = int.Parse(Console.ReadLine());
            Console.Write("Nhap Ho Ten: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhap ngay sinh: ");
            NgaySinh = DateTime.Parse(Console.ReadLine());
        }
        public Nguoi1(int maSo, string hoTen, DateTime ngaySinh)
        {
            MaSo = maSo;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
        }
    }
   
}
