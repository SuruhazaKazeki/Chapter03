using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT02
{
    class QuanLySanPham
    {
        private string tenCH;
        private SanPham[] dssp;
        private int n;// so san pham
        public QuanLySanPham()
        {
            tenCH = " Cua hang ban le";
            dssp = new SanPham[100];
            n = 0;
        }
        public QuanLySanPham (int size)
        {
            tenCH = " Cua hang ban le";
            dssp = new SanPham[size];
            n = 0;
        }
        public void Nhap()
        {
            int chon;
            SanPham sp;
            while (true)
            {
                Console.WriteLine("Them san pham Loai(1.Socola/ 2.NuocUong): ");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        sp = new Socola();
                        sp.Nhap();
                        dssp[n++] = sp;
                        break;
                    case 2:
                        sp = new NuocUong();
                        sp.Nhap();
                        dssp[n++] = sp;
                        break;
                }
                Console.Write("Ban co muon tiep tuc?(0.Thoat!)");
                chon = int.Parse(Console.ReadLine());
                if (chon == 0) 
                break;
            }
        }
        public void InDanhSanhSP()
        {
            Console.WriteLine(" Ten cua hang: " + tenCH);
            Console.WriteLine(" Danh sach cac san pham: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(dssp[i].InTenChiTiet());
            }
        }
    }
}
