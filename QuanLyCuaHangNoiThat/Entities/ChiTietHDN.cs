using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangNoiThat.Entities
{
    internal class ChiTietHDN
    {
        string sohdn;
        string manoithat;
        int soluong;
        double dongia;
        double giamgia;
        double thanhtien;

        public ChiTietHDN(string sohdn, string manoithat, int soluong, double dongia, double giamgia, double thanhtien)
        {
            this.sohdn = sohdn;
            this.manoithat = manoithat;
            this.soluong = soluong;
            this.dongia = dongia;
            this.giamgia = giamgia;
            this.thanhtien = thanhtien;
        }

        public string Sohdn { get => sohdn; set => sohdn = value; }
        public string Manoithat { get => manoithat; set => manoithat = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public double Dongia { get => dongia; set => dongia = value; }
        public double Giamgia { get => giamgia; set => giamgia = value; }
        public double Thanhtien { get => thanhtien; set => thanhtien = value; }
    }
}
