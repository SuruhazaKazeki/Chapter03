using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT02
{
    class NuocUong: SanPham
    {
        private double loiNhuan;
        private double phiGiuLanh;
        public NuocUong() : base() { }
        public NuocUong(string ten, double giaMua) : base(ten, giaMua)
        {
            loiNhuan = (float)GiaMua * 0.15;
            phiGiuLanh =(float) GiaMua * 0.1;
        }
        public override double TinhGiaBan()
        {
            return GiaMua + loiNhuan + phiGiuLanh;
        }
        public override string InTenChiTiet()
        {
            return "|"+ Ten + " | " + TinhGiaBan()+"|";
        }
        public override void Nhap()
        {
            base.Nhap();
            loiNhuan = (float)GiaMua * 0.15;
            phiGiuLanh =(float) GiaMua * 0.1;
        }
    }
}
