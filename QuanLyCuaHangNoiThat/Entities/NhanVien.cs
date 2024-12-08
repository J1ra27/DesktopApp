using QuanLyCuaHangNoiThat.Enum;
using System;

namespace QuanLyCuaHangNoiThat.Entities
{
    internal class NhanVien
    {
        private string maNV;
        private string tenNV;
        private Gender gioiTinh;
        private DateTime ngaySinh;
        private string dienThoai;
        private string diaChi;
        private string maCa;
        private string maCV;

        public NhanVien(string maNV, string tenNV, Gender gioiTinh, DateTime ngaySinh,
            string dienThoai, string diaChi, string maCa, string maCV)
        {
            this.maNV = maNV;
            this.tenNV = tenNV;
            this.gioiTinh = gioiTinh;
            this.ngaySinh = ngaySinh;
            this.dienThoai = dienThoai;
            this.diaChi = diaChi;
            this.maCa = maCa;
            this.maCV = maCV;
        }

        public string MaNV { get => maNV; set => maNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public Gender GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string DienThoai { get => dienThoai; set => dienThoai = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string MaCa { get => maCa; set => maCa = value; }
        public string MaCV { get => maCV; set => maCV = value; }

    }

}
