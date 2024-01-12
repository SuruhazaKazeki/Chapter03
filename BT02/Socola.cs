using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT02
{
    // dinh nghia lop Chocolate
    class Socola:SanPham
    {
        private double loiNhuan;
        public Socola(): base() { }
        public Socola(string ten, double giaMua): base(ten, giaMua)
        {
            loiNhuan =(float) GiaMua * 0.2;
        }
        public override double TinhGiaBan()
        {
            return GiaMua + loiNhuan;
        }
        public override string InTenChiTiet()
        {
            return Ten + " - " + TinhGiaBan();
        }
        public override void Nhap()
        {
            base.Nhap();
            loiNhuan = (float)GiaMua * 0.2;
        }

    }
}
