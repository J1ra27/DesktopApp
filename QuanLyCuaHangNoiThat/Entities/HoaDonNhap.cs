using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangNoiThat.Entities
{
    internal class HoaDonNhap
    {
        private string sohdn;
        private string nhanvien;
        private string ngaynhap;
        private string nhacungcap;
        private double tongtien;

        public HoaDonNhap(string sohdn, string nhanvien, string ngaynhap, string nhacungcap, double tongtien)
        {
            this.sohdn = sohdn;
            this.nhanvien = nhanvien;
            this.ngaynhap = ngaynhap;
            this.nhacungcap = nhacungcap;
            this.tongtien = tongtien;
        }

        public string Sohdn { get => sohdn; set => sohdn = value; }
        public string Nhanvien { get => nhanvien; set => nhanvien = value; }
        public string Ngaynhap { get => ngaynhap; set => ngaynhap = value; }
        public string Nhacungcap { get => nhacungcap; set => nhacungcap = value; }
        public double Tongtien { get => tongtien; set => tongtien = value; }
    }
}
