namespace QuanLyCuaHangNoiThat.Entities
{
    internal class DonDatHang
    {
        private string soDDH;
        private string maNV;
        private string maKhach;
        private string ngayDat;
        private string ngayGiao;
        private double datCoc;
        private double thue;
        private double tongTien;

        public DonDatHang(string soDDH, string maNV, string maKhach, string ngayDat, string ngayGiao, double datCoc, double thue, double tongTien)
        {
            this.SoDDH = soDDH;
            this.MaNV = maNV;
            this.MaKhach = maKhach;
            this.NgayDat = ngayDat;
            this.NgayGiao = ngayGiao;
            this.DatCoc = datCoc;
            this.Thue = thue;
            this.TongTien = tongTien;
        }

        public string SoDDH { get => soDDH; set => soDDH = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public string MaKhach { get => maKhach; set => maKhach = value; }
        public string NgayDat { get => ngayDat; set => ngayDat = value; }
        public string NgayGiao { get => ngayGiao; set => ngayGiao = value; }
        public double DatCoc { get => datCoc; set => datCoc = value; }
        public double Thue { get => thue; set => thue = value; }
        public double TongTien { get => tongTien; set => tongTien = value; }
    }
}
