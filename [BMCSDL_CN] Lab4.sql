/*----------------------------------------------------------
MASV: 44.01.104.156
HO TEN: Trương Thị Thảo Nguyên
LAB: 04
NGAY: 15/5/2021
----------------------------------------------------------*/

--3b. Script tạo mới các Table

USE QLSVDG1
GO

CREATE TABLE NHANVIEN(
	MANV VARCHAR(20) PRIMARY KEY,
	HOTEN NVARCHAR(100),
	EMAIL VARCHAR(20),
	LUONG VARBINARY(MAX),
	TENDN NVARCHAR(100),
	MATKHAU VARBINARY(MAX),
)
CREATE TABLE LOP(
	MALOP VARCHAR(20) PRIMARY KEY,
	TENLOP NVARCHAR(100),
	MANV VARCHAR(20),
	
)
GO

CREATE TABLE SINHVIEN(
	MASV NVARCHAR(20) PRIMARY KEY,
	HOTEN NVARCHAR(100),
	NGAYSINH DATETIME,
	DIACHI NVARCHAR(200),
	MALOP VARCHAR(20),
	TENDN NVARCHAR(100),
	MATKHAU VARBINARY(MAX),
	
)
GO

--3c.i. Stored dùng để thêm mới dữ liệu (Insert) vào table SINHVIEN
CREATE PROCEDURE SP_INS_ENCRYPT_SINHVIEN
@masv nvarchar(20), @hoten nvarchar(100),@ngaysinh datetime, @diachi nvarchar(200), @malop varchar(20), @tendn nvarchar(100),@matkhau varchar(max)
AS
BEGIN
	INSERT INTO SINHVIEN VALUES(@masv,@hoten,@ngaysinh,@diachi,@malop,@tendn,CONVERT(VARBINARY(MAX),@matkhau))
END

EXEC SP_INS_ENCRYPT_SINHVIEN 'SV01', 'NGUYEN VAN A', '1/1/1990',
'280 AN DUONG VUONG', 'CNTT-K35', 'NVA', '5450458405804580580458'
EXEC SP_INS_ENCRYPT_SINHVIEN 'SV03', 'NGUYEN VAN D', '1/1/1990',
'280 AN DUONG VUONG', 'CNTT-K35', 'NVD', '123456789'
select * from sinhvien
/* 3c.ii. 
*/
CREATE MASTER KEY ENCRYPTION BY PASSWORD = '44.01.104.156'
CREATE CERTIFICATE MyCertificate0 ENCRYPTION BY PASSWORD = '44.01.104.156' WITH SUBJECT = 'ins_nv'
CREATE SYMMETRIC KEY SSN_Key_INS_NV WITH ALGORITHM = AES_256
ENCRYPTION BY CERTIFICATE MyCertificate0

CREATE PROCEDURE SP_INS_ENCRYPT_NHANVIEN
@manv nvarchar(20), @hoten nvarchar(100),@email varchar(20), @luong varchar(max), @tendn nvarchar(100),@matkhau varchar(max)
AS
BEGIN
	INSERT INTO NHANVIEN VALUES(@manv,@hoten,@email,CONVERT(VARBINARY(MAX),@luong),@tendn,CONVERT(VARBINARY(MAX),@matkhau))
END

ALTER PROCEDURE SP_INS_ENCRYPT_NHANVIEN
@manv nvarchar(20), @hoten nvarchar(100),@email varchar(20), @luong varchar(max), @tendn nvarchar(100),@matkhau varchar(max)
AS
BEGIN
	OPEN SYMMETRIC KEY SSN_Key_INS_NV
	DECRYPTION BY CERTIFICATE MyCertificate0 WITH PASSWORD ='44.01.104.156'

	INSERT INTO NHANVIEN VALUES(@manv,@hoten,@email,CONVERT(VARBINARY(MAX),@luong),@tendn,CONVERT(VARBINARY(MAX),@matkhau))
	CLOSE SYMMETRIC KEY SSN_Key_INS_NV
END
EXEC SP_INS_ENCRYPT_NHANVIEN 'NV01', 'NGUYEN VAN A', 'NVA@',
'aaaaaaaa', 'NVA', 'bbbbbbbb'
EXEC SP_INS_ENCRYPT_NHANVIEN 'NV02', 'NGUYEN VAN A', 'NVB@',
'aaaaaaaa', 'NVB', '123456'
--3c.iii.Stored dùng để truy vấn dữ liệu nhân viên (NHANVIEN) với dữ liệu lương vẫn còn mã hóa.

CREATE PROCEDURE SP_SEL_ENCRYPT_NHANVIEN
AS
BEGIN
	OPEN SYMMETRIC KEY SSN_Key_INS_NV
	DECRYPTION BY CERTIFICATE MyCertificate0 WITH PASSWORD ='44.01.104.156'
	SELECT MANV,HOTEN,EMAIL,convert(varchar(max),LUONG) as LUONGCB
	FROM NHANVIEN
	CLOSE SYMMETRIC KEY SSN_Key_INS_NV
END

EXEC SP_SEL_ENCRYPT_NHANVIEN
--d,e. Phần viết code C# đăng nhập và màn hình danh sách
--LOGIN NHÂN VIÊN
CREATE PROCEDURE LoginNV(
        @UserName nvarchar(100),
        @Password varchar(max)
)
AS
BEGIN	
	SELECT COUNT(*)
	FROM NHANVIEN
	where TENDN = @UserName and MATKHAU = @Password
END

exec LoginNV @UserName='NVA',@Password='bbbbbbbb'
exec LoginNV @UserName='NVB',@Password='123456'

SELECT * FROM NHANVIEN
--Delete
CREATE PROCEDURE DeleteNV
@Manv varchar(20)
AS
BEGIN
	DELETE FROM NHANVIEN WHERE MANV = @Manv
END

--Update
CREATE PROCEDURE SP_UPD_ENCRYPT_NHANVIEN
@manv nvarchar(20), @hoten nvarchar(100),@email varchar(20), @luong varchar(max), @tendn nvarchar(100),@matkhau varchar(max)
AS
BEGIN
	OPEN SYMMETRIC KEY SSN_Key_INS_NV
	DECRYPTION BY CERTIFICATE MyCertificate0 WITH PASSWORD ='44.01.104.156'

	UPDATE NHANVIEN SET MANV=@manv,HOTEN = @hoten,EMAIL = @email,LUONG=CONVERT(VARBINARY(MAX),@luong), TENDN=@tendn,MATKHAU=CONVERT(VARBINARY(MAX),@matkhau)
					WHERE MANV=@manv
	CLOSE SYMMETRIC KEY SSN_Key_INS_NV
END

--f,g,h. SQL Profiler
exec LoginNV @UserName='NA',@Password='|J?	?7b?a? ?=?d???'
exec SP_SEL_ENCRYPT_NHANVIEN
exec SP_INS_ENCRYPT_NHANVIEN @manv='NV04',@hoten='NGUYEN VAN D',@email='NVD@',@tendn='NVD',@matkhau='???t?YG?&????h?k??',@luong='7yZjXub9CiUxX/KTP5l7PekZzqbYRVHfIy3g9OtzoEY='
SELECT * FROM NHANVIEN 
SELECT * FROM SINHVIEN