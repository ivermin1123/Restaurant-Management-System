Use master
Go

Create database QuanLyQuanBeer
GO

Use QuanLyQuanBeer
GO

CREATE TABLE TaiKhoan
(
	TenDangNhap varchar(100) PRIMARY KEY,
	MatKhau nvarchar(100) not null ,
	LoaiTaiKhoan nvarchar(10) NOT NULL
)
GO

INSERT dbo.TaiKhoan(TenDangNhap, MatKhau,LoaiTaiKhoan) 
VALUES
('admin','1', N'Admin'),
('manager','1', N'Quản lý'),
('staff','1', N'Nhân viên')
GO

CREATE TABLE ThongTinTaiKhoan
(
	id INT IDENTITY(1,1) PRIMARY KEY,
	HoTen NVARCHAR(100) not null,
	SoDienThoai INT not null,
	DiaChi NVARCHAR(100) not null,
	CMND INT not null,
	Tuoi INT not null,
	GioiTinh NVARCHAR(100) NOT NULL,
	TenDangNhap varchar(100) NOT NULL,

	FOREIGN KEY (TenDangNhap) REFERENCES dbo.TaiKhoan(TenDangNhap)
	ON DELETE CASCADE
)
GO

SET IDENTITY_INSERT dbo.ThongTinTaiKhoan ON
INSERT dbo.ThongTinTaiKhoan(id,HoTen,SoDienThoai,DiaChi,CMND,Tuoi, GioiTinh, TenDangNhap)
VALUES
(1 ,N'Lê Quốc Hoàng',123456798, N'Quận 9',251120114,20, 'Nam', 'admin'),
(2 ,N'Việt Phi',123456798, N'Quận 9',251120116,20, 'Nam', 'manager'),
(3 ,N'Cao Ngọc Nguyên',123456798, N'Quận 10',251120115,20, 'Nam', 'staff')
GO
SET IDENTITY_INSERT dbo.ThongTinTaiKhoan OFF

CREATE TABLE Ban
(
	id INT IDENTITY(1,1) PRIMARY KEY,
	TenBan NVARCHAR(100) NOT NULL,
	TrangThai NVARCHAR(100) NOT NULL
)
GO

INSERT dbo.Ban(TenBan, TrangThai )
VALUES  ( N'Bàn 01',N'Trống'),
		( N'Bàn 02',N'Trống'),
		( N'Bàn 03',N'Trống'),
		( N'Bàn 04',N'Trống'),
		( N'Bàn 05',N'Trống'),
		( N'Bàn 06',N'Trống'),
		( N'Bàn 07',N'Trống'),
		( N'Bàn 08',N'Trống'),
		( N'Bàn 09',N'Trống'),
		( N'Bàn 10',N'Trống')
GO

CREATE TABLE LoaiSanPham
(
	id INT IDENTITY(1,1) PRIMARY KEY,
	TenLoaiSanPham NVARCHAR(100) not null ,
)
Go

INSERT INTO dbo.LoaiSanPham(TenLoaiSanPham ) VALUES  (N'Cá' ),(N'Bò' ),(N'Lợn' ),(N'Beer')
GO

CREATE TABLE SanPham
(
	id INT IDENTITY(1,1) PRIMARY KEY ,
	TenSanPham NVARCHAR(100) not null,
	DonVi NVARCHAR(100) not null,
	idLoai INT not null,
	Gia FLOAT not null,
	HinhAnh image null

	FOREIGN KEY (idLoai) REFERENCES dbo.LoaiSanPham(id)
	ON DELETE CASCADE
)
GO

INSERT INTO dbo.SanPham(TenSanPham, idLoai,DonVi, Gia )
VALUES  ( N'Cá chép om dưa',1,N'Đĩa',88888),( N'Cá diêu hồng hai món',1,N'Đĩa',99999),
		( N'Bò xiên nướng',2,N'Xiên',100000),( N'Bò lúc lắc khoai tây',2,N'Đĩa',111111),
		( N'Chân giò hun khói',3,N'Phần',87000),( N'Chân giò hầm nấm',3,N'Phần',96000),
		( N'Sài gòn xanh',4,N'Chai',15000),( N'Tiger nâu',4,N'Chai',18000)
GO


CREATE TABLE HoaDon
(
	id INT IDENTITY(100,1) PRIMARY KEY,
	ThoiGianVao Date not null,
	ThoiGianRa DATE NULL,	
	idBan INT not NULl,
	TongCong FLOAT NULL,
	TrangThai NVARCHAR(100) not NULL, -- 1: Da thanh toan || 0: Chua thanh toan

	FOREIGN KEY (idBan) REFERENCES dbo.Ban(id),
)
GO

INSERT INTO dbo.HoaDon(ThoiGianVao,idBan,TrangThai)
VALUES
(GETDATE(),1, N'Chưa thanh toán'),
(GETDATE(),2, N'Chưa thanh toán'),
(GETDATE(),3, N'Chưa thanh toán'),
(GETDATE(),4, N'Chưa thanh toán'),
(GETDATE(),5, N'Chưa thanh toán'),
(GETDATE(),6, N'Chưa thanh toán'),
(GETDATE(),7, N'Chưa thanh toán'),
(GETDATE(),8, N'Chưa thanh toán'),
(GETDATE(),9, N'Chưa thanh toán'),
(GETDATE(),10, N'Chưa thanh toán')
GO

CREATE TABLE ThongTinHoaDon
(
	id INT IDENTITY(1,1) PRIMARY KEY,
	idHoaDon INT not null,	
	idSanPham INT not null, 
	SoLuong INT not null DEFAULT 0 

	FOREIGN KEY (idHoaDon) REFERENCES dbo.HoaDon(id),
	FOREIGN KEY (idSanPham) REFERENCES dbo.SanPham(id)
	ON DELETE CASCADE
)
GO

INSERT INTO dbo.ThongTinHoaDon
(idHoaDon,idSanPham,SoLuong)
VALUES
(100, 1, 2 ),
(101, 2, 2 ),
(101, 3, 2 ),
(102, 4, 2 ),
(102, 5, 2 ),
(103, 6, 2 )
GO

create PROC themThongTinTk
@tenDangNhap varchar(100), @hoTen nvarchar(100), @diaChi nvarchar(100), @cMND INT, @sDT INT, @tuoi INT, @gioiTinh nvarchar(100)
AS
BEGIN
	INSERT INTO dbo.ThongTinTaiKhoan(HoTen, SoDienThoai, DiaChi, CMND, Tuoi, GioiTinh, TenDangNhap)
	VALUES
	(   @hoTen, -- HoTen - nvarchar(100)
	    @sDT,   -- SoDienThoai - int
	    @diaChi, -- DiaChi - nvarchar(100)
	    @cMND,   -- CMND - int
	    @tuoi,   -- Tuoi - int
	    @gioiTinh, -- GioiTinh - nvarchar(100)
	    @tenDangNhap   -- TenDangNhap - varchar(100)
	    )
END
GO


CREATE proc dbo.USP_InsertDrink
@TenSanPham nvarchar(100),@DonVi nvarchar(100), @Gia float, @idLoai int
as  
begin
	Insert into dbo.SanPham
	(TenSanPham,DonVi,Gia,idLoai)
	VALUES
	(@TenSanPham,@DonVi, @Gia, @idLoai )
end
GO

CREATE PROC themLoaiSanPham
@tenLoaiSanPham nvarchar(100)
AS
BEGIN
	INSERT INTO dbo.LoaiSanPham(TenLoaiSanPham)
	VALUES(@tenLoaiSanPham )
END
GO

CREATE PROC themBan
@tenBan nvarchar(100)
AS
BEGIN
	INSERT INTO dbo.Ban(TenBan,TrangThai)
	VALUES(@tenBan,N'Trống')
END
GO

CREATE PROC XoaBan
@tenBan NVARCHAR(100)
as
BEGIN
	DELETE dbo.Ban WHERE TenBan = 11
END
GO



CREATE PROC XoaSp
@TenSanPham NVARCHAR(100)
as
BEGIN
	DELETE dbo.SanPham WHERE TenSanPham = @TenSanPham
END
GO

CREATE PROC USP_GetTableList
AS
BEGIN
	SELECT * FROM Ban
END
GO

CREATE PROC USP_GetListFood
AS
BEGIN
	SELECT * FROM SanPham
END
GO

CREATE PROC XoaTK
@tenDn VARCHAR(100)
AS
BEGIN
	DELETE dbo.ThongTinTaiKhoan WHERE TenDangNhap = @tenDn
	DELETE dbo.TaiKhoan WHERE TenDangNhap = @tenDn 
END
GO

CREATE PROC themTaiKhoan
@ten varchar(100), @matKhau nvarchar(100), @loai nvarchar(10)
AS
BEGIN
	INSERT INTO dbo.TaiKhoan( TenDangNhap, MatKhau, LoaiTaiKhoan )
	VALUES (@ten, @matKhau, @loai)
END
GO



