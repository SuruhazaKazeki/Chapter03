using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT02
{
    // dinh nghia lop san pham
    class SanPham
    {
        private string ten;
        private double giaMua;
        public SanPham() { }
        public SanPham(string ten, double giaMua)
        {
            this.ten = ten;
            this.giaMua = giaMua;
        }
        public string Ten 
        {
            get { return ten; }
            set { ten = value; }
        }
        public double GiaMua 
        { 
            get { return giaMua; } set
            {
                if (value >= 0)
                    giaMua = value;
            }
        }
        public virtual double TinhGiaBan()
        {
            return 0;
        }
        public virtual string InTenChiTiet()
        {
            return Ten;
        }
        public virtual void Nhap () 
        {
            Console.Write("Nhap ten san pham: ");
            ten = Console.ReadLine();
            Console.Write("Gia Mua: ");
            giaMua = double.Parse(Console.ReadLine());
        }

    }
}
