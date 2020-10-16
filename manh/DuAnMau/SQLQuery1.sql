IF OBJECT_ID('NHANVIEN') is not null
DROP TABLE NHANVIEN
GO
CREATE TABLE NHANVIEN(
Id int identity(1,1),
MaNV varchar(20) not null,
HoVaTen nvarchar(50) not null,
Email varchar(50) not null,
DiaChi nvarchar(100) not null,
VaiTro Tinyint not null,
TinhTrang Tinyint not null,
MatKhau nvarchar(100) DEFAULT  'e10adc3949ba59abbe56e057f20f883e',
CONSTRAINT PK_NHANVIEN PRIMARY KEY (MaNV)
)
GO

IF OBJECT_ID('KHACHHANG') is not null
DROP TABLE KHACHHANG
GO

CREATE TABLE KHACHHANG(
DienThoai varchar(15) not null,
TenKhach nvarchar(50) not null,
DiaChi nvarchar(100) not null,
MaNV varchar(20) not null,
GioiTinh nvarchar(5) not null,
CONSTRAINT PK_KHACHHANG PRIMARY KEY(DienThoai),
CONSTRAINT FK_KHACHHANG_NHANVIEN FOREIGN KEY (MaNV) REFERENCES NHANVIEN(MaNV) 
)

GO

IF OBJECT_ID('HANG') is not null
DROP TABLE HANG 
GO
CREATE TABLE HANG(
MaHang int identity(1,1) not null,
TenHang nvarchar(50) not null,
SoLuong int not null,
GiaNhap float not null,
GiaBan float not null,
HinhAnh varchar(400) not null,
GhiChu nvarchar(100) not null,
MaNV varchar(20) not null,
CONSTRAINT PK_HANG PRIMARY KEY (MaHang),
CONSTRAINT FK_HANG_KHACHHANG FOREIGN KEY(MaNV) REFERENCES NHANVIEN(MaNV),
) 
GO


IF OBJECT_ID('sp_DangNhap') is not null
DROP PROC sp_DangNhap
GO

CREATE PROC sp_DangNhap
		@email varchar(50) ,@matkhau varchar(50)
AS
BEGIN
	DECLARE @status int
	IF exists(SELECT * FROM NHANVIEN WHERE Email=@email and MatKhau = @matkhau)
	SET @status = 1
	ELSE SET @status = 0
	SELECT @status
END
GO

IF OBJECT_ID('sp_ChangePassWord') is not null
DROP PROC sp_ChangePassWord
GO
CREATE PROC sp_ChangePassWord
@email varchar(50),
@oldPassword varchar(50),
@newPassword varchar(50)
AS
BEGIN
	DECLARE @oldPass varchar(5)
	SELECT @oldPass = MatKhau FROM NHANVIEN WHERE Email = @email
	if @oldPass = @oldPassword
	BEGIN
		UPDATE NHANVIEN set MatKhau = @newPassword WHERE Email =@email
		RETURN 1
	END
	else RETURN -1
END
GO

IF OBJECT_ID('sp_QuenMatKhau') is not null
DROP PROC sp_QuenMatKhau
GO
CREATE PROC sp_QuenMatKhau
@email varchar(50)
AS
BEGIN
	DECLARE @status int
		IF EXISTS(SELECT MaNV FROM NHANVIEN WHERE Email= @email)
			SET @status = 1
		ELSE SET @status = 0
	SELECT @status
END
GO

IF OBJECT_ID('sp_DanhSachNhanVien') is not null
DROP PROC sp_DanhSachNhanVien
GO

CREATE PROC sp_DanhSachNhanVien
AS
BEGIN
	SELECT * FROM NHANVIEN
END
GO

IF OBJECT_ID('sp_DanhSachHang') is not null
DROP PROC sp_DanhSachHang
GO
CREATE PROC sp_DanhSachHang
AS
BEGIN
	SELECT * FROM HANG
END
GO

IF OBJECT_ID('sp_DanhSachKhachHang') is not null
DROP PROC sp_DanhSachKhachHang
GO
CREATE PROC sp_DanhSachKhachHang
AS
BEGIN
	SELECT * FROM KHACHHANG
END
GO

IF OBJECT_ID('sp_InsertNHANVIEN') is not null
DROP PROC sp_InsertNHANVIEN
GO
CREATE PROC sp_InsertNHANVIEN
	@HoVaTen nvarchar(50),
	@Email nvarchar(50),
	@DiaChi nvarchar(100),
	@VaiTro tinyint,
	@TinhTrang tinyint
AS
BEGIN
	DECLARE @MaNV VARCHAR(20);
	DECLARE @Id INT;

	SELECT @Id = ISNULL(MAX(ID),0) +1 FROM NHANVIEN
	SELECT @MaNV = 'NV' + RIGHT('0000'+CAST(@Id AS varchar(4)),4)
	INSERT INTO NHANVIEN(MaNV,HoVaTen,Email,DiaChi,VaiTro,TinhTrang) VALUES
	(@MaNV,@HoVaTen,@Email,@DiaChi,@VaiTro,@TinhTrang)
END
GO

IF OBJECT_ID('sp_UpdateNHANVIEN') is not null
DROP PROC sp_UpdateNHANVIEN
GO
CREATE PROC sp_UpdateNHANVIEN
	@HoVaTen nvarchar(50),
	@Email nvarchar(50),
	@DiaChi nvarchar(50),
	@VaiTro tinyint,
	@TinhTrang tinyint
AS
BEGIN
	SELECT CONCAT('NV',id) FROM NHANVIEN
	UPDATE NHANVIEN SET HoVaTen= @HoVaTen,DiaChi= @DiaChi,VaiTro=@VaiTro,TinhTrang=@TinhTrang
	WHERE Email =@Email
END
GO

IF OBJECT_ID('sp_SearchNhanVien') is not null
DROP PROC sp_SearchNhanVien
GO
CREATE PROC sp_SearchNhanVien
@tenNV nvarchar(50)
AS
BEGIN
	SELECT Email,HoVaTen,DiaChi,VaiTro,TinhTrang FROM NHANVIEN WHERE HoVaTen like '%' + @tenNV + '%'
END
GO

IF OBJECT_ID('sp_DeleteNHANVIEN') is not null
DROP PROC sp_DeleteNHANVIEN
GO
CREATE PROC sp_DeleteNHANVIEN
	@email varchar(50)
AS
BEGIN
	DELETE FROM NHANVIEN WHERE Email = @email
END
GO

IF OBJECT_ID('sp_InsertHANG') is not null
DROP PROC sp_InsertHANG
GO
CREATE PROC sp_InsertHANG
	@TenHang nvarchar(50),
	@SoLuong int,
	@GiaNhap float,
	@GiaBan float,
	@HinhAnh nvarchar(200),
	@GhiChu nvarchar(50),
	@Email nvarchar(50)
AS
BEGIN
	DECLARE @maNV varchar(20);
	SELECT  MaNV = @maNV FROM NHANVIEN WHERE Email = @Email
	INSERT INTO HANG(TenHang,SoLuong,GiaNhap,GiaBan,HinhAnh,GhiChu,MaNV)
	VALUES(@TenHang,@SoLuong,@GiaNhap,@GiaBan,@HinhAnh,@GhiChu,@maNV)
END
GO

IF OBJECT_ID('sp_UpdateHANG') is not null
DROP PROC sp_UpdateHANG
GO
CREATE PROC sp_UpdateHANG
	@TenHang nvarchar(50),
	@SoLuong int,
	@GiaNhap float,
	@GiaBan float,
	@HinhAnh nvarchar(200),
	@GhiChu nvarchar(50)
AS
BEGIN
	DECLARE @MaHang int;
	SELECT @MaHang = MaHang FROM HANG
	UPDATE HANG SET TenHang = @TenHang, SoLuong = @SoLuong, GiaNhap= @GiaNhap,
					GiaBan=@GiaBan,HinhAnh= @HinhAnh,GhiChu= @GhiChu
	WHERE @MaHang = MaHang
END
GO

IF OBJECT_ID('sp_VaiTroNV') is not null
DROP PROC sp_VaiTroNV
GO
CREATE PROC sp_VaiTroNV
@email varchar(50)
AS
BEGIN
	SELECT VaiTro FROM NHANVIEN Where Email = @email
END
GO

IF OBJECT_ID('sp_DeleteHANG') is not null
DROP PROC sp_DeleteHANG
GO
CREATE PROC sp_DeleteHANG
	@MaHang int
AS 
BEGIN
	DELETE FROM HANG WHERE @MaHang = MaHang
END
GO

IF OBJECT_ID('sp_SearchHang') is not null
DROP PROC sp_SearchHang
GO
CREATE PROC sp_SearchHang
@tenHang nvarchar(50)
AS
BEGIN
	SELECT * FROM HANG WHERE TenHang like '%' + @tenHang + '%'
END
GO

IF OBJECT_ID('sp_InsertKHACH') is not null
DROP PROC sp_InsertKHACH
GO
CREATE PROC sp_InsertKHACH
	@DienThoai nvarchar(10),
	@TenKhach nvarchar(20),
	@DiaChi nvarchar(50),
	@GioiTinh nvarchar(5),
	@email varchar(50)
AS
BEGIN
	DECLARE @MaNV varchar(20);
	SELECT @MaNV MaNV FROM NHANVIEN WHERE Email = @email
	INSERT INTO KHACHHANG VALUES(@DienThoai,@TenKhach,@DiaChi,@MaNV,@GioiTinh)
END
GO

IF OBJECT_ID('sp_UpdateKHACH') is not null
DROP PROC sp_UpdateKHACH
GO
CREATE PROC sp_UpdateKHACH
	@DienThoai nvarchar(15),
	@TenKhach nvarchar(20),
	@DiaChi nvarchar(50),
	@email varchar(20),
	@GioiTinh nvarchar(5)
AS
BEGIN
	DECLARE @MaNV varchar(20);
	SELECT MaNV FROM NHANVIEN WHERE @email = Email
	UPDATE KHACHHANG SET TenKhach = @TenKhach,DiaChi=@DiaChi,GioiTinh=@GioiTinh
	WHERE @DienThoai= DienThoai
END
GO

IF OBJECT_ID('sp_DeleteKHACH') is not null
DROP PROC sp_DeleteKHACH
GO
CREATE PROC sp_DeleteKHACH
	@DienThoai varchar(12)
AS
BEGIN
	DELETE FROM KHACHHANG WHERE @DienThoai= DienThoai
END
GO

IF OBJECT_ID('sp_SearchKhachHang') is not null
DROP PROC sp_SearchKhachHang
GO
CREATE PROC sp_SearchKhachHang
@tenKhach varchar(13)
AS
BEGIN
	SELECT * FROM KHACHHANG WHERE TenKhach like '%' + @tenKhach + '%'
END
GO

IF OBJECT_ID('sp_ThongKeTonKho') is not null
DROP PROC sp_ThongKeTonKho
GO
CREATE PROC sp_ThongKeTonKho
AS
BEGIN
	SELECT TenHang,SUM(SoLuong) FROM HANG
	GROUP BY TenHang
END
GO

IF OBJECT_ID('sp_ThongKeSp') is not null
DROP PROC sp_ThongKeSp
GO
CREATE PROC sp_ThongKeSp
AS
BEGIN
	SELECT Hang.MaNV, HoVaTen,COUNT(MaHang) FROM HANG inner join NHANVIEN ON HANG.MaNV = NHANVIEN.MaNV
	GROUP BY HANG.MaNV,HoVaTen
END
GO

IF OBJECT_ID('sp_TaoMatKhauMoi') is not null
DROP PROC sp_TaoMatKhauMoi
GO
CREATE PROC sp_TaoMatKhauMoi
	@email varchar(50),
	@newPassword nvarchar(50)
AS
BEGIN
	UPDATE NHANVIEN SET MatKhau = @newPassword WHERE @email = Email
END
GO