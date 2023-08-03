using Lession4.moe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession4
{
    public class Meo
    {
        public int ID { get; private set; }
        public string TenMeo { get; set; }
        public int Tuoi { get; set; }
        public string GioiTinh { get; set; }
        public string TiengKeu { get; set; }
        public Meo(int id, string ten, int tuoi, string gioitinh, string tiengkeu)
        {
            ID = id;
            TenMeo = ten;
            Tuoi = tuoi;
            GioiTinh= gioitinh;
            TiengKeu = tiengkeu;
        }
        public void Hienthi()
        {
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Ten Meo: {TenMeo}");
            Console.WriteLine($"Tuoi: {Tuoi}");
            Console.WriteLine($"Gioi Tinh: {GioiTinh}");
            Console.WriteLine($"Tieng Keu: {TiengKeu}");
        }
    }
}
