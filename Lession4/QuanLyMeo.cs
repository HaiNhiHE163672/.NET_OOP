using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lession4
{
    public class QuanLyMeo
    {
        public void Them(List<Meo> meos)            
        {
            int id = LayID(meos);
            string tenmeo = NhapTen();
            int tuoimeo = NhapTuoi();
            string gioitinh = NhapGioiTinh();
            string tieng = NhapTiengMeo(meos);
            meos.Add(new Meo(id,tenmeo,tuoimeo,gioitinh,tieng));

        }
        public void Xoa(List<Meo> meos, int id)
        {
            bool check = true;
            for(int i = 0; i < meos.Count; i++)
            {
                if (meos[i].ID == id)
                {
                    meos.Remove(meos[i]);
                    check = false;
                }
            }
            if(check)
            {
                Console.WriteLine($"Meo co ID la {id} khong ton tai");
            }
        }
        public void HienThi(List<Meo> meos)
        {
            int index = 1;
            foreach(Meo meo in meos)
            {
                Console.WriteLine($"--- Thong tin meo so {index} la: ---");
                meo.Hienthi();
                index++;
            }
        }
        public void HienThiTheoID(List<Meo> meos, int id)
        {
            bool check = true;
            foreach (Meo meo in meos)
            {
                if (meo.ID == id)
                {
                    meo.Hienthi();
                    check = false;
                }
            }
            if (check)
            {
                Console.WriteLine($"Meo co ID la {id} khong ton tai");
            }
        }
        public void ThayDoiTheoID(List<Meo> meos, int id)
        {
            bool check = true;
            foreach (Meo meo in meos)
            {
                if (meo.ID == id)
                {
                    meo.TiengKeu = NhapTiengMeo(meos);
                    check = false;
                }
            }
            if (check)
            {
                Console.WriteLine($"Meo co ID la {id} khong ton tai");
            }
        }
        private int LayID(List<Meo> m)
        {
            int id = 1;
            if(m != null && m.Count > 0)
            {
                id = m[0].ID;
                foreach(Meo meo in m)
                {
                    if(id < meo.ID)
                    {
                        id = meo.ID;
                    }
                }
                id++;
            }
            return id;
        }
        private int NhapTuoi()
        {
            int tuoi;
            while (true)
            {
                Console.Write("Nhap Tuoi Meo: ");
                if(int.TryParse(Console.ReadLine(), out tuoi))
                {
                    if(tuoi >= 0)
                    {
                        return tuoi;
                    }
                    else
                    {
                        Console.WriteLine("Tuoi khong hop ly! Vui Long nhap lai!");
                    }
                }
                else
                {
                    Console.WriteLine("Nhap sai dinh dang! Vui Long nhap lai!");
                }
            }
        }
        private string NhapTen()
        {
            string ten;
            while (true)
            {
                Console.Write("Nhap Ten Meo: ");
                ten = Console.ReadLine();
                if (!String.IsNullOrEmpty(ten))
                {
                    return ten;
                }
                else
                {
                    Console.WriteLine("Ten Meo khong duoc phep de trong!");
                }
            }
        }
        private string NhapGioiTinh()
        {
            string gt;
            while (true)
            {
                Console.Write("Nhap Gioi Tinh Meo: ");
                gt = Console.ReadLine(); 
                if(gt.ToLower().Equals("duc") || gt.ToLower().Equals("cai"))
                {
                    return gt.ToLower();
                }
                else{
                    Console.WriteLine("Gioi Tinh cua meo sai! Vui long nhap lai!");
                }
            }
        }
        private string NhapTiengMeo(List<Meo> meo)
        {
            string tieng;
            while (true)
            {
                int d = 0;
                Console.Write("Nhap tieng meo keu: ");
                tieng = Console.ReadLine();
                    foreach (Meo m in meo)
                    {
                    
                        if (m.TiengKeu.Equals(tieng))
                        {
                            d++;
                        }
                    }
                    if (d == 0)
                    {
                        return tieng;
                    }
                    else
                    {
                        Console.WriteLine("Tieng meo trung voi tieng meo khac! Vui long nhap lai!");
                    }
                
            }
        }
        public void Menu()
        {
            Console.WriteLine("---------------------- Quan Ly meo cho me ---------------------");
            Console.WriteLine("1. Them meo.");
            Console.WriteLine("2. Xoa Meo theo ID.");
            Console.WriteLine("3. Hien thi toan bo meo.");
            Console.WriteLine("4. Hien Thi Meo Theo ID.");
            Console.WriteLine("5. Thay doi tieng keu theo ID.");
            Console.WriteLine("6. Thoat chuong trinh.");
        }
        public int choice(string a)
        {
            int choice;
            while (true)
            {
                Console.Write(a);
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    return choice;
                }
                else
                {
                    Console.WriteLine("Nhap sai dinh dang! Vui Long nhap lai!");
                }
            }
        }

    }
}
