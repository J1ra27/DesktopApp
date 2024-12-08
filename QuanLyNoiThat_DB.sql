CREATE DATABASE QLCUAHANGNOITHAT
USE QLCUAHANGNOITHAT

--drop database QLCUAHANGNOITHAT

CREATE TABLE TheLoai (
MaLoai nvarchar(50) NOT NULL,
TenLoai nvarchar(50) NULL,
CONSTRAINT PK_TheLoai PRIMARY KEY (MaLoai ASC)
)

CREATE TABLE KieuDang (
MaKieu nvarchar(50) NOT NULL,
TenKieu nvarchar(50) NULL,
CONSTRAINT PK_KieuDang PRIMARY KEY (MaKieu ASC)
)

CREATE TABLE MauSac (
MaMau nvarchar(50) NOT NULL,
TenMau nvarchar(50) NULL,
CONSTRAINT PK_MauSac PRIMARY KEY (MaMau ASC)
)

CREATE TABLE ChatLieu (
MaChatLieu nvarchar(50) NOT NULL,
TenChatLieu nvarchar(50) NULL,
CONSTRAINT PK_ChatLieu PRIMARY KEY (MaChatLieu ASC)
)

CREATE TABLE NuocSanXuat (
MaNuocSX nvarchar(50) NOT NULL,
TenNuocSX nvarchar(50) NULL,
CONSTRAINT PK_NuocSanXuat PRIMARY KEY (MaNuocSX ASC)
)

CREATE TABLE CaLam (
MaCa nvarchar(50) NOT NULL,
TenCa nvarchar(50) NULL,
CONSTRAINT PK_CaLam PRIMARY KEY (MaCa ASC)
)

CREATE TABLE KhachHang (
MaKhach nvarchar(50) NOT NULL,
TenKhach nvarchar(50) NULL,
DiaChi nvarchar(50) NULL,
DienThoai nvarchar(50) NULL,
CONSTRAINT PK_KhachHang PRIMARY KEY (MaKhach ASC)
)

CREATE TABLE NhaCungCap (
MaNCC nvarchar(50) NOT NULL,
TenNCC nvarchar(50) NULL,
DiaChi nvarchar(50) NULL,
DienThoai nvarchar(50) NULL,
CONSTRAINT PK_NhaCungCap PRIMARY KEY (MaNCC ASC)
)

CREATE TABLE CongViec (
MaCV nvarchar(50) NOT NULL,
TenCV nvarchar(50) NULL,
CONSTRAINT PK_CongViec PRIMARY KEY (MaCV ASC)
)

--drop table CongViec
CREATE TABLE DMNoiThat (
MaNoiThat nvarchar(50) NOT NULL,
TenNoiThat nvarchar(50) NULL,
MaLoai nvarchar(50) NULL,
MaKieu nvarchar(50) NULL,
MaMau nvarchar(50) NULL,
MaChatLieu nvarchar(50) NULL,
MaNuocSX nvarchar(50) NULL,
SoLuong int NULL,
DonGiaNhap money NULL,
DonGiaBan money NULL,
Anh nvarchar(100) NULL,
ThoiGianBaoHanh int NULL,
CONSTRAINT PK_DMNoiThat PRIMARY KEY (MaNoiThat ASC),
CONSTRAINT FK_DMNoiThat_TheLoai FOREIGN KEY (MaLoai) REFERENCES TheLoai (MaLoai),
CONSTRAINT FK_DMNoiThat_KieuDang FOREIGN KEY (MaKieu) REFERENCES KieuDang (MaKieu),
CONSTRAINT FK_DMNoiThat_MauSac FOREIGN KEY (MaMau) REFERENCES MauSac (MaMau),
CONSTRAINT FK_DMNoiThat_ChatLieu FOREIGN KEY (MaChatLieu) REFERENCES ChatLieu (MaChatLieu),
CONSTRAINT FK_DMNoiThat_NuocSanXuat FOREIGN KEY (MaNuocSX) REFERENCES NuocSanXuat (MaNuocSX)
)

CREATE TABLE NhanVien (
MaNV nvarchar(50) NOT NULL,
TenNV nvarchar(50) NULL,
GioiTinh int NULL,
NgaySinh datetime NULL,
DienThoai nvarchar(20) NULL,
DiaChi nvarchar(50) NULL,
MaCa nvarchar(50) NULL,
MaCV nvarchar(50),
CONSTRAINT PK_NhanVien PRIMARY KEY (MaNV ASC),
CONSTRAINT FK_NhanVien_CaLam FOREIGN KEY (MaCa) REFERENCES CaLam(MaCa),
CONSTRAINT FK_NhanVien_CongViec FOREIGN KEY (MaCV) REFERENCES CongViec(MaCV)
)

CREATE TABLE DonDatHang (
SoDDH nvarchar(50) NOT NULL,
MaNV nvarchar(50) NULL,
MaKhach nvarchar(50) NULL,
NgayDat datetime NULL,
NgayGiao datetime NULL,
DatCoc money NULL,
Thue money NULL,
TongTien money NULL,
CONSTRAINT PK_DonDatHang PRIMARY KEY (SoDDH ASC),
CONSTRAINT FK_DonDatHang_NhanVien FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV),
CONSTRAINT FK_DonDatHang_KhachHang FOREIGN KEY (MaKhach) REFERENCES KhachHang(MaKhach)
)

CREATE TABLE ChiTietDDH (
SODDH nvarchar(50) NOT NULL,
MaNoiThat nvarchar(50) NOT NULL,
SoLuong int NULL,
GiamGia float NULL,
ThanhTien money NULL,
CONSTRAINT PK_ChiTietDDH PRIMARY KEY (SoDDH ASC, MaNoiThat ASC),
CONSTRAINT FK_ChiTietDDH_DonDatHang FOREIGN KEY (SoDDH) REFERENCES DonDatHang(SoDDH),
CONSTRAINT FK_ChiTietDDH_DMNoiTHat FOREIGN KEY (MaNoiThat) REFERENCES DMNoiThat(MaNoiThat)
)


CREATE TABLE HoaDonNhap (
SoHDN nvarchar(50) NOT NULL,
MaNV nvarchar(50) NULL,
NgayNhap datetime NULL,
MaNCC nvarchar(50) NULL,
TongTien money NULL,
CONSTRAINT PK_HoaDonNhap PRIMARY KEY (SoHDN ASC),
CONSTRAINT FK_HoaDonNHap_NhanVien FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV),
CONSTRAINT FK_HoaDonNHap_NhaCungCap FOREIGN KEY (MaNCC) REFERENCES NhaCungCap(MaNCC)
)

CREATE TABLE ChiTietHDN (
SoHDN nvarchar(50) NOT NULL,
MaNoiThat nvarchar(50) NOT NULL,
SoLuong int NULL,
DonGia money NULL,
GiamGia float NULL,
ThanhTien money NULL,
CONSTRAINT PK_ChiTietHDN PRIMARY KEY (SoHDN ASC, MaNoiThat ASC),
CONSTRAINT FK_ChiTietHDN_HoaDonNhap FOREIGN KEY (SoHDN) REFERENCES HoaDonNhap(SoHDN),
CONSTRAINT FK_ChiTietHDN_DMNoiTHat FOREIGN KEY (MaNoiThat) REFERENCES DMNoiThat(MaNoiThat)
)

CREATE TABLE UserAcccount (
UserName nvarchar(50) NOT NULL PRIMARY KEY,
Pass nvarchar(50) NULL,
)


insert into UserAcccount values('admin', '123')

insert into TheLoai(MaLoai, TenLoai) values('TL001',N'Căn hộ')
insert into TheLoai(MaLoai, TenLoai) values('TL002',N'Công sở')
insert into TheLoai(MaLoai, TenLoai) values('TL003',N'Cửa hàng')
insert into TheLoai(MaLoai, TenLoai) values('TL004',N'Studio')
insert into TheLoai(MaLoai, TenLoai) values('TL005',N'Công cộng')

insert into KieuDang(MaKieu, TenKieu) values('KD001',N'Bắc Âu')
insert into KieuDang(MaKieu, TenKieu) values('KD002',N'Tối giản')
insert into KieuDang(MaKieu, TenKieu) values('KD003',N'Cổ điển')
insert into KieuDang(MaKieu, TenKieu) values('KD004',N'Rustic')
insert into KieuDang(MaKieu, TenKieu) values('KD005',N'Retro')
insert into KieuDang(MaKieu, TenKieu) values('KD006',N'Maverick')
insert into KieuDang(MaKieu, TenKieu) values('KD007',N'Hiện đại')
insert into KieuDang(MaKieu, TenKieu) values('KD008',N'Contemporary')
insert into KieuDang(MaKieu, TenKieu) values('KD009',N'Đông Dương')

insert into MauSac(MaMau, TenMau) values('MM001',N'Xanh')
insert into MauSac(MaMau, TenMau) values('MM002',N'Đỏ')
insert into MauSac(MaMau, TenMau) values('MM003',N'Tím')
insert into MauSac(MaMau, TenMau) values('MM004',N'Vàng')
insert into MauSac(MaMau, TenMau) values('MM005',N'Đen')
insert into MauSac(MaMau, TenMau) values('MM006',N'Trắng')


insert into ChatLieu(MaChatLieu, TenChatLieu) values('CL001',N'Gỗ')
insert into ChatLieu(MaChatLieu, TenChatLieu) values('CL002',N'Kim loại')
insert into ChatLieu(MaChatLieu, TenChatLieu) values('CL003',N'Đá')
insert into ChatLieu(MaChatLieu, TenChatLieu) values('CL004',N'Nhựa')
insert into ChatLieu(MaChatLieu, TenChatLieu) values('CL005',N'Da')
insert into ChatLieu(MaChatLieu, TenChatLieu) values('CL006',N'Vải')
insert into ChatLieu(MaChatLieu, TenChatLieu) values('CL007',N'Kính')

insert into NuocSanXuat(MaNuocSX, TenNuocSX) values('NSX001',N'Việt Nam')
insert into NuocSanXuat(MaNuocSX, TenNuocSX) values('NSX002',N'Hàn Quốc')
insert into NuocSanXuat(MaNuocSX, TenNuocSX) values('NSX003',N'Mỹ')
insert into NuocSanXuat(MaNuocSX, TenNuocSX) values('NSX004',N'Nhật Bản')
insert into NuocSanXuat(MaNuocSX, TenNuocSX) values('NSX005',N'Trung Quốc')
insert into NuocSanXuat(MaNuocSX, TenNuocSX) values('NSX006',N'Anh')

insert into CaLam(MaCa, TenCa) values('MC001', N'Sáng')
insert into CaLam(MaCa, TenCa) values('MC002', N'Chiều')
insert into CaLam(MaCa, TenCa) values('MC003', N'Tối')


insert into CongViec(MaCV, TenCV) values ('MCV01',N'Thu ngân')
insert into CongViec(MaCV, TenCV) values ('MCV02',N'Kiểm kho')
insert into CongViec(MaCV, TenCV) values ('MCV03',N'Kế toán')

insert into NhaCungCap(MaNCC, TenNCC, DiaChi, DienThoai) values ('NCC01','NBN', N'Bắc Ninh','0351234567')
insert into NhaCungCap(MaNCC, TenNCC, DiaChi, DienThoai) values ('NCC02','NBG', N'Bắc Giang','0351234568')
insert into NhaCungCap(MaNCC, TenNCC, DiaChi, DienThoai) values ('NCC03','NHN', N'Hà Nội','0351234569')
insert into NhaCungCap(MaNCC, TenNCC, DiaChi, DienThoai) values ('NCC04','NND', N'Nam Định','0351234555')
insert into NhaCungCap(MaNCC, TenNCC, DiaChi, DienThoai) values ('NCC05','NSL', N'Sơn La','0969561912')

insert into KhachHang(MaKhach, TenKhach, DiaChi, DienThoai) values ('MK01',N'Mai Thành Công',N'Sơn La', N'0869886594')
insert into KhachHang(MaKhach, TenKhach, DiaChi, DienThoai) values ('MK02',N'Hoàng Đức Sinh',N'Bắc Giang', N'0356789101')
insert into KhachHang(MaKhach, TenKhach, DiaChi, DienThoai) values ('MK03',N'Lương Khắc Tuân',N'Hà Nội', N'0351234567')


insert into DMNoiThat(MaNoiThat, TenNoiThat, MaLoai, MaKieu, MaMau, MaChatLieu, MaNuocSX, SoLuong, DonGiaNhap, DonGiaBan, Anh, ThoiGianBaoHanh) values('DMNT001', N'Bàn', 'TL001', 'KD001', 'MM001', 'CL001', 'NSX001', 100,100000, 110000, NULL, 1)
insert into DMNoiThat(MaNoiThat, TenNoiThat, MaLoai, MaKieu, MaMau, MaChatLieu, MaNuocSX, SoLuong, DonGiaNhap, DonGiaBan, Anh, ThoiGianBaoHanh) values('DMNT002', N'Tủ', 'TL002', 'KD002', 'MM002', 'CL002', 'NSX002', 200, 200000, 220000, NULL, 2)
insert into DMNoiThat(MaNoiThat, TenNoiThat, MaLoai, MaKieu, MaMau, MaChatLieu, MaNuocSX, SoLuong, DonGiaNhap, DonGiaBan, Anh, ThoiGianBaoHanh) values('DMNT003', N'Giường', 'TL003', 'KD003', 'MM003', 'CL003', 'NSX003', 300, 300000, 330000, NULL,2)
insert into DMNoiThat(MaNoiThat, TenNoiThat, MaLoai, MaKieu, MaMau, MaChatLieu, MaNuocSX, SoLuong, DonGiaNhap, DonGiaBan, Anh, ThoiGianBaoHanh) values('DMNT004', N'Ghế', 'TL004', 'KD004', 'MM004', 'CL004', 'NSX004', 400, 400000, 440000, NULL, 5)
insert into DMNoiThat(MaNoiThat, TenNoiThat, MaLoai, MaKieu, MaMau, MaChatLieu, MaNuocSX, SoLuong, DonGiaNhap, DonGiaBan, Anh, ThoiGianBaoHanh) values('DMNT005', N'Thảm', 'TL005', 'KD005', 'MM005', 'CL005', 'NSX005', 500, 500000, 550000, NULL,1)

insert into NhanVien(MaNV, TenNV, GioiTinh, NgaySinh, DienThoai, DiaChi, MaCa, MaCV)
values(N'NV01', N'Mai Công', 0, CAST(N'2003-10-27T00:00:00.000' AS DateTime), N'0912345678', N'Sơn La', 'MC001', 'MCV01')
insert into NhanVien(MaNV, TenNV, GioiTinh, NgaySinh, DienThoai, DiaChi, MaCa, MaCV)
values(N'NV02', N'Hoàng Sinh', 0, CAST(N'2003-01-12T00:00:00.000' AS DateTime), N'0912345679', N'Bắc Giang', 'MC002', 'MCV02')
insert into NhanVien(MaNV, TenNV, GioiTinh, NgaySinh, DienThoai, DiaChi, MaCa, MaCV)
values(N'NV03', N'Lương Tuân', 0, CAST(N'2003-07-05T00:00:00.000' AS DateTime), N'0912345677', N'Hà Nội', 'MC003', 'MCV03')


insert into HoaDonNhap(SoHDN, MaNV, NgayNhap, MaNCC, TongTien) values ('HDN01', 'NV02', CAST(N'2023-05-05T00:00:00.000' AS DateTime), 'NCC01',10000000)
insert into HoaDonNhap(SoHDN, MaNV, NgayNhap, MaNCC, TongTien) values ('HDN02', 'NV01', CAST(N'2023-05-08T00:00:00.000' AS DateTime), 'NCC02',20000000)
insert into HoaDonNhap(SoHDN, MaNV, NgayNhap, MaNCC, TongTien) values ('HDN03', 'NV03', CAST(N'2023-05-10T00:00:00.000' AS DateTime), 'NCC03',30000000)
insert into HoaDonNhap(SoHDN, MaNV, NgayNhap, MaNCC, TongTien) values ('HDN04', 'NV02', CAST(N'2023-06-10T00:00:00.000' AS DateTime), 'NCC04',40000000)
insert into HoaDonNhap(SoHDN, MaNV, NgayNhap, MaNCC, TongTien) values ('HDN05', 'NV01', CAST(N'2023-07-10T00:00:00.000' AS DateTime), 'NCC05',50000000)

insert into ChiTietHDN(SoHDN, MaNoiThat, SoLuong, DonGia, GiamGia, ThanhTien) values ('HDN01','DMNT001',100,10000000,0,10000000)
insert into ChiTietHDN(SoHDN, MaNoiThat, SoLuong, DonGia, GiamGia, ThanhTien) values ('HDN02','DMNT002',100,20000000,0,20000000)
insert into ChiTietHDN(SoHDN, MaNoiThat, SoLuong, DonGia, GiamGia, ThanhTien) values ('HDN03','DMNT003',100,30000000,0,30000000)
insert into ChiTietHDN(SoHDN, MaNoiThat, SoLuong, DonGia, GiamGia, ThanhTien) values ('HDN04','DMNT004',100,40000000,0,40000000)
insert into ChiTietHDN(SoHDN, MaNoiThat, SoLuong, DonGia, GiamGia, ThanhTien) values ('HDN05','DMNT005',100,50000000,0,50000000)

insert into DonDatHang(SoDDH, MaNV, MaKhach, NgayDat, NgayGiao, DatCoc, Thue, TongTien) 
values ('DDH01','NV01','MK01', CAST(N'2023-09-09T00:00:00.000' AS DateTime),CAST(N'2022-09-11T00:00:00.000' AS DateTime),500000,0,4400000)
insert into DonDatHang(SoDDH, MaNV, MaKhach, NgayDat, NgayGiao, DatCoc, Thue, TongTien) 
values ('DDH02','NV02','MK02', CAST(N'2023-08-10T00:00:00.000' AS DateTime),CAST(N'2022-08-11T00:00:00.000' AS DateTime),200000,0,11000000)
insert into DonDatHang(SoDDH, MaNV, MaKhach, NgayDat, NgayGiao, DatCoc, Thue, TongTien) 
values ('DDH03','NV03','MK03', CAST(N'2023-10-10T00:00:00.000' AS DateTime),CAST(N'2022-10-12T00:00:00.000' AS DateTime),800000,0,19800000)
insert into DonDatHang(SoDDH, MaNV, MaKhach, NgayDat, NgayGiao, DatCoc, Thue, TongTien) 
values ('DDH04','NV02','MK04', CAST(N'2023-10-04T00:00:00.000' AS DateTime),CAST(N'2022-10-05T00:00:00.000' AS DateTime),500000,0,35200000)
insert into DonDatHang(SoDDH, MaNV, MaKhach, NgayDat, NgayGiao, DatCoc, Thue, TongTien) 
values ('DDH05','NV02','MK05', CAST(N'2023-09-05T00:00:00.000' AS DateTime),CAST(N'2022-09-07T00:00:00.000' AS DateTime),500000,0,55000000)


insert into ChiTietDDH(SODDH, MaNoiThat, SoLuong, GiamGia, ThanhTien) values  ('DDH01','DMNT001',40,0,4400000)
insert into ChiTietDDH(SODDH, MaNoiThat, SoLuong, GiamGia, ThanhTien) values  ('DDH02','DMNT002',50,0,11000000)
insert into ChiTietDDH(SODDH, MaNoiThat, SoLuong, GiamGia, ThanhTien) values  ('DDH03','DMNT003',60,0,19800000)
insert into ChiTietDDH(SODDH, MaNoiThat, SoLuong, GiamGia, ThanhTien) values  ('DDH04','DMNT004',80,0,35200000)
insert into ChiTietDDH(SODDH, MaNoiThat, SoLuong, GiamGia, ThanhTien) values  ('DDH05','DMNT005',100,0,55000000)

ALTER TABLE DonDatHang DROP CONSTRAINT FK_DonDatHang_NhanVien;
ALTER TABLE DonDatHang DROP CONSTRAINT FK_DonDatHang_KhachHang;
ALTER TABLE ChiTietDDH DROP CONSTRAINT FK_ChiTietDDH_DMNoiTHat;
ALTER TABLE ChiTietHDN DROP CONSTRAINT FK_ChiTietHDN_DMNoiTHat;
ALTER TABLE HoaDonNhap DROP CONSTRAINT FK_HoaDonNhap_NhanVien;

SELECT * FROM ChiTietDDH;
--new code NhanVien
create or alter function getMaNhanVienNew() returns nvarchar(10)
as 
begin 
	declare @MaNV nvarchar(10),@id int
	set @MaNV= (select max(MaNV) from NhanVien) 
	set @id= cast(substring(@MaNV,3,2) as int)+1
	return 'NV'+ (case when @id<10 then '0'else '' end)+ cast(@id as nvarchar(2))
end

--new code DDH
create or alter function getSoDDH() returns nvarchar(10)
as 
begin 
	declare @soDDH nvarchar(10),@id int
	set @soDDH= (select max(soDDH) from DonDatHang) 
	set @id= cast(substring(@soDDH,4,2) as int)+1
	return 'DDH'+ (case when @id<10 then '0'else '' end)+ cast(@id as nvarchar(2))
end
--get code MaNoiThat
create or alter function getMaNoiThatNew() returns nvarchar(10)
as 
begin 
	declare @MaNoiThat nvarchar(10),@id int
	set @MaNoiThat= (select max(MaNoiThat) from DMNoiThat) 
	set @id= cast(substring(@MaNoiThat,5,3) as int)+1
	return 'DMNT'+ (case when @id<10 then '00' when @id >=10 and @id<100 then '0' else '' end)+ cast(@id as nvarchar(2))
end

--New  code HDN
create or alter function getsohdnnew() returns nvarchar(10)
as 
begin 
	declare @soHDN nvarchar(10),@id int
	set @soHDN= (select max(soHDN) from HoaDonNhap) 
	set @id= cast(substring(@soHDN,4,2) as int)+1
	return 'HDN'+ (case when @id<10 then '0'else '' end)+ cast(@id as nvarchar(2))
end

--trigger  
create or alter trigger hazzz on ChiTietDDH
for insert ,update ,delete 
as begin
	declare @SL int ,@MaNoiThat nvarchar(10)
	declare @ThanhTien int,@soDDH nvarchar(10)
	set @MaNoiThat= (select MaNoiThat from inserted)
	set @SL=(select SoLuong from inserted )
	update DMNoiThat
	set SoLuong = isnull(SoLuong,0) - isnull(@SL,0)
	where MaNoiThat=@MaNoiThat

	set @MaNoiThat= (select MaNoiThat from deleted )
	set @SL=(select SoLuong from deleted )
	update DMNoiThat
	set SoLuong = isnull(SoLuong,0) + isnull(@SL,0)
	where MaNoiThat=@MaNoiThat

	set @soDDH=(select SODDH from inserted)
	set @ThanhTien=(select ThanhTien from inserted)
	update DonDatHang set TongTien =isnull(TongTien,0) + isnull(@ThanhTien,0)
	where SoDDH=@soDDH

	set @soDDH=(select SODDH from deleted)
	set @ThanhTien=(select ThanhTien from deleted)
	update DonDatHang set TongTien =isnull(TongTien,0) - isnull(@ThanhTien,0)
	where SoDDH=@soDDH
end
-------
create or alter trigger capnhattongtien on ChiTietHDN
for insert ,update ,delete 
as begin
	declare @SL int ,@MaNoiThat nvarchar(10),@Dongia Money
	set @MaNoiThat= (select MaNoiThat from inserted )
	set @SL=(select SoLuong from inserted )
	set @Dongia= (select DonGia from inserted )
	update DMNoiThat
	set  SoLuong = isnull(SoLuong,0) + isnull(@SL,0),DonGiaNhap=@Dongia,dongiaban=1.1*@Dongia
	where MaNoiThat=@MaNoiThat

	set @MaNoiThat= (select MaNoiThat from deleted )
	set @SL=(select SoLuong from deleted )
	update DMNoiThat
	set SoLuong = isnull(SoLuong,0) - isnull(@SL,0)
	where MaNoiThat=@MaNoiThat

	declare @thanhtien int, @sohdn nvarchar(20)
    set @sohdn = (select sohdn from inserted)
    set @thanhtien = (select thanhtien from inserted)
    update HoaDonNhap
    set tongtien = isnull(tongtien,0) + isnull(@thanhtien, 0)
    where sohdn = @sohdn

	set @sohdn = (select sohdn from deleted)
	set @thanhtien = (select thanhtien from deleted)
	update HoaDonNhap
	set tongtien = isnull(tongtien,0) - isnull(@thanhtien, 0)
	where sohdn = @sohdn 
end

--proc Insert NhanVien
Create procedure InsertNhanVien
(  
@MaNV Varchar (50),  
@TenNV nvarchar (50),  
@GioiTinh int ,
@NgaySinh datetime,
@DienThoai varchar(20),
@DiaChi nvarchar(100),
@MaCa varchar(10),
@MaCV varchar(10)
)  
as  
begin  
Insert into NhanVien values (@MaNV,@TenNV ,@GioiTinh,@NgaySinh,@DienThoai,@DiaChi,@MaCa,@MaCV)
end  

--update nhanVien
Create procedure UpdateNhanVien
(  
@MaNV Varchar (50),  
@TenNV nvarchar (50),  
@GioiTinh int ,
@NgaySinh datetime,
@DienThoai varchar(20),
@DiaChi nvarchar(100),
@MaCa varchar(10),
@MaCV varchar(10)
)  
as  
begin  
update nhanvien set TenNV=@TenNV ,GioiTinh=@GioiTinh,NgaySinh=@NgaySinh,
DienThoai=@DienThoai,DiaChi=@DiaChi,MaCa=@MaCa,MaCV=@MaCV
where MaNV=@MaNV
end  

--funt
create or alter function BaoCao1(@maHang nvarchar(10)) returns table 
as
return select a.SODDH,maNV,MaKhach,NgayDat,NgayGiao,DatCoc,Thue,soluong,giamgia,ThanhTien from ChiTietDDH a
join DonDatHang b on a.SODDH=b.SoDDH
where MaNoiThat=@maHang


create or alter function BaoCaoNCC(@maHang nvarchar(10),@month int) returns table 
as
return select TenNCC from NhaCungCap a join HoaDonNhap b on a.MaNCC=b.MaNCC
join ChiTietHDN c on b.SoHDN=c.SoHDN
where MaNoiThat=@maHang and month(NgayNhap)= @month and year(NgayNhap)=year(getdate())

----

create or alter function BaoCaoNhap(@quy int,@nam int,@maNV nvarchar(10)) returns table
as
return select  b.SoHDN,TongTien from NhanVien a join HoaDonNhap b on a.MaNV=b.MaNV
join ChiTietHDN c on b.SoHDN=c.SoHDN
where (((month(ngaynhap)=1 or month(ngaynhap)=2 or month(ngaynhap)=3 )and @quy=1)
or ((month(ngaynhap)=4 or month(ngaynhap)=5 or month(ngaynhap)=6 )and @quy=2)
or ((month(ngaynhap)=7 or month(ngaynhap)=8 or month(ngaynhap)=9 ) and @quy=3)
or ((month(ngaynhap)=10 or month(ngaynhap)=11 or month(ngaynhap)=12) and @quy=4))
and a.MaNV=@maNV and YEAR(ngaynhap)=@nam
group by b.SoHDN,TongTien

---tt nhap
create or alter function GetTongTien(@maNT nvarchar(10)) returns money
as
begin
declare @tt money
set @tt=(select sum(thanhTien) from ChiTietDDH where MaNoiThat=@maNT)
return @tt
end

---
create or alter function GetTongTienNhap(@quy int,@nam int,@maNV nvarchar(10)) returns money
as
begin
declare @tt money
set @tt=(select sum(TongTien) as tt from dbo.BaoCaoNhap(@quy ,@nam ,@maNV) )
return @tt
end

create or alter function getSoHDNnew() returns nvarchar(20)
as 
begin 
declare @sohdn nvarchar(20), @id int
set @sohdn = (select max(sohdn) from HoaDonNhap)
set @id = cast(substring(@sohdn,4,2) as int) + 1
return 'HDN' + (case when @id<10 then '0'else '' end)+ cast(@id as nvarchar(2))
end

create or alter function dongianhap(@manoithat nvarchar(20), @soluong int)
returns int
as 
begin
declare @dongia int 
set @dongia = (select (@soluong * DonGiaNhap) as DonGia from DMNoiThat
where MaNoiThat = @manoithat )
return @dongia
end

create or alter function baocaosanpham(@makh nvarchar(20), @thang int, @nam int)
returns table
as 
return
select a.manoithat, tennoithat,sum(b.soluong) as 'SL'
from DMNoiThat a join ChiTietDDH b on a.MaNoiThat = b.MaNoiThat
join DonDatHang c on b.SoDDh = c.SoDDH 
where makhach = @makh and month(ngaydat) = @thang and year(ngaydat) = @nam
group by a.MaNoiThat,tennoithat

--phan trang 
CREATE PROCEDURE [dbo].[GetMatHangPaging]
      @PageIndex INT = 1
      ,@PageSize INT = 10
      ,@RecordCount INT OUTPUT
AS
BEGIN
      SET NOCOUNT ON;
      -- Lấy lữ liệu từ bảng dữ liệu MatHang và lưu vào bảng tạm tblTemp cùng với số dòng
      SELECT ROW_NUMBER() OVER
      (
            ORDER BY ManoiThat ASC
      )AS Hang
            , *
      INTO #tblTemp
      FROM DMNoiThat
      --Đếm số lượng bản ghi
      SELECT @RecordCount = COUNT(*)
      FROM #tblTemp
         
      SELECT *
      FROM #tblTemp
      WHERE Hang BETWEEN(@PageIndex -1) * @PageSize + 1 AND(((@PageIndex -1) * @PageSize + 1) + @PageSize) - 1
      --Xóa bảng tạm tblTemp
      DROP TABLE #tblTemp
END

