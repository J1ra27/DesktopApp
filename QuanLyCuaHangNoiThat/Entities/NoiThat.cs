namespace QuanLyCuaHangNoiThat.Entities
{
    internal class NoiThat
    {
        private string maNoiThat;
        private string tenNoiThat;
        private string maLoai;
        private string maKieu;
        private string maMau;
        private string maChatLieu;
        private string maNuocSX;
        private int soLuong;
        private double donGiaNhap;
        private double donGiaBan;
        private string imageNT;
        private int thoiGianBaoHanh;

        public NoiThat()
        {
        }

        public NoiThat(string maNoiThat, string tenNoiThat, string maLoai, string maKieu,
            string maMau, string maChatLieu, string maNuocSX, int soLuong, double donGiaNhap,
            double donGiaBan, string imageNT, int thoiGianBaoHanh)
        {
            this.maNoiThat = maNoiThat;
            this.tenNoiThat = tenNoiThat;
            this.maLoai = maLoai;
            this.maKieu = maKieu;
            this.maMau = maMau;
            this.maChatLieu = maChatLieu;
            this.maNuocSX = maNuocSX;
            this.soLuong = soLuong;
            this.donGiaNhap = donGiaNhap;
            this.donGiaBan = donGiaBan;
            this.imageNT = imageNT;
            this.thoiGianBaoHanh = thoiGianBaoHanh;
        }
        public string MaNoiThat { get => maNoiThat; set => maNoiThat = value; }
        public string TenNoiThat { get => tenNoiThat; set => tenNoiThat = value; }
        public string MaLoai { get => maLoai; set => maLoai = value; }
        public string MaKieu { get => maKieu; set => maKieu = value; }
        public string MaMau { get => maMau; set => maMau = value; }
        public string MaChatLieu { get => maChatLieu; set => maChatLieu = value; }
        public string MaNuocSX { get => maNuocSX; set => maNuocSX = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public double DonGiaBan { get => donGiaBan; set => donGiaBan = value; }
        public double DonGiaNhap { get => donGiaNhap; set => donGiaNhap = value; }
        public string ImageNT { get => imageNT; set => imageNT = value; }
        public int ThoiGianBaoHanh { get => thoiGianBaoHanh; set => thoiGianBaoHanh = value; }
    }
}
