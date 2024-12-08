namespace QuanLyCuaHangNoiThat.Entities
{
    internal class ChiTietDDH
    {
        private string soDDH;
        private string maNoiThat;
        private int soLuong;
        private double giamGia;
        private double thanhTien;

        public ChiTietDDH(string soDDH, string maNoiThat, int soLuong, double giamGia, double thanhTien)
        {
            this.SoDDH = soDDH;
            this.MaNoiThat = maNoiThat;
            this.SoLuong = soLuong;
            this.GiamGia = giamGia;
            this.ThanhTien = thanhTien;
        }

        public string SoDDH { get => soDDH; set => soDDH = value; }
        public string MaNoiThat { get => maNoiThat; set => maNoiThat = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public double GiamGia { get => giamGia; set => giamGia = value; }
        public double ThanhTien { get => thanhTien; set => thanhTien = value; }
    }
}
