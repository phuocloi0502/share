create database QUANLISINHVIEN
USE QUANLISINHVIEN

Create table SINHVIEN(
	mssv char(20) not null,
	hoten nvarchar(200) not null,
	gioitinh nvarchar(5) not null,
	ngaysinh date not null,
	quequan nvarchar(100) not null,
	makhoa nvarchar(100) not null
)


Create table KHOA(
	makhoa nvarchar(100) not null,
	tenkhoa nvarchar(200) not null
)

Alter table SINHVIEN ADD CONSTRAINT ms PRIMARY KEY(mssv)
Alter table KHOA ADD CONSTRAINT mk PRIMARY KEY(makhoa)

Alter table SINHVIEN ADD FOREIGN  KEY(makhoa) REFERENCES KHOA(makhoa)
ON delete cascade ON update cascade;

Insert into KHOA values('CNTT',N'Công nghệ thông tin')
Insert into KHOA values('DDT',N'Điện điện tử')
Insert into KHOA values('CNTP',N'Công nghệ thực phẩm')
Insert into KHOA values('CNSH',N'Công nghệ sinh học')
Insert into KHOA values('DL',N'Du lịch')

Insert into SINHVIEN values('17104018',N'Võ Phước Lợi',N'Nam','05/02/1999',N'Vĩnh Long','CNTT')
Insert into SINHVIEN values('17104019',N'Ngô Minh Kha',N'Nam','06/06/1999',N'Cần Thơ','DL')
Insert into SINHVIEN values('17104020',N'Nguyễn Duy Huỳnh',N'Nữ','07/05/1999',N'Vĩnh Long','CNTT')
Insert into SINHVIEN values('17104021',N'Đoàn Tuấn Kiệt',N'Nam','08/04/1999',N'Đồng Tháp','CNSH')
Insert into SINHVIEN values('17104022',N'Nguyễn Quốc thắng',N'Nữ','09/03/1999',N'Vĩnh Long','DDT')

