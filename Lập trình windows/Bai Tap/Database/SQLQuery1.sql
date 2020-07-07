create database QUANLINHANVIEN
Use QUANLINHANVIEN

Create table NhanVien(
Manv char(20) not null,
Tennv nvarchar(100) not null,
Ngaysinh date not null,
Gioitinh nvarchar(3) not null,
Quequan nvarchar(200) not null,
Mapb char(50) not null
)

Create table PhongBan(
Mapb char(50) not null,
Tenpb nvarchar(100) not null
)

Create table ThanhVien(
Tendn char(50) not null primary key,
Matkhau char(100) not null
)

Alter table NhanVien Add Constraint pk_Nhanvien Primary key(Manv)
Alter table PhongBan Add Constraint pk_PhongBan Primary key(Mapb)

Alter table NhanVien Add Constraint fk_NhanVien_PhongBan Foreign Key(Mapb) References PhongBan(Mapb) On delete cascade On update cascade;

Insert into PhongBan values('QL',N'Quản lí')
Insert into PhongBan values('LT',N'Lễ Tân')
Insert into PhongBan values('QD',N'Quét dọn')
Insert into PhongBan values('TK',N'Thư kí')
 
Insert into NhanVien values('NV1',N'Võ Phước Lợi','02/05/1999',N'Nam',N'Vĩnh Long','QL')
Insert into NhanVien values('NV2',N'Huỳnh Thanh Hà','09/04/1999',N'Nữ',N'Vĩnh Long','TK')
Insert into NhanVien values('NV3',N'Nguyễn Duy Huỳnh','07/01/1999',N'Nam',N'Vĩnh Long','QD')


select Manv,Tennv,Ngaysinh,Gioitinh,Quequan,Tenpb from  NhanVien,PhongBan where NhanVien.Mapb=PhongBan.Mapb

Update NhanVien set Tennv='LT',Ngaysinh='ns',Gioitinh=N'Nam',Quequan=N'vl',Mapb='dd' where Manv='NV10'

delete NhanVien where Manv='NV3'

select Tenpb from PhongBan 

select PhongBan.Mapb from PhongBan where Phongban.Tenpb=N'Thư kí'