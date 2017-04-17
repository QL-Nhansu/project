
create database [NhanSu]
go
use [NhanSu]
go

--1
create table chucdanh(
	ma varchar(10) not null,
	ten nvarchar(20),
	luongcoban money,
	chuthich nvarchar(100)
	constraint PK_chucdanh primary key(ma) 
)

--2
create table kyluat(
	ma varchar(10) not null,
	ten nvarchar(50),
	sotien money
	constraint PK_kyluat primary key(ma) 
)

--3
create table khenthuong(
	ma varchar(10) not null,
	ten nvarchar(50),
	sotien money
	constraint PK_khenthuong primary key(ma)
)

--4
create table phucap(
	ma varchar(10) not null,
	ten nvarchar(50),
	sotien money
	constraint PK_phucap primary key(ma)
)

--5
create table trinhdohocvan(
	ma varchar(10) not null,
	ten nvarchar(50),
	chuthich nvarchar(100)
	constraint PK_trinhdohocvan primary key(ma)
)

--6
create table trinhdongoaingu(
	ma varchar(10) not null,
	ten nvarchar(50),
	ngonngu nvarchar(50),
	chuthich nvarchar(100)
	constraint PK_trinhdongoaingu primary key(ma)
)

--7
create table nhanvien(
	ma varchar(10) not null,
	ten nvarchar(50),
	ngaysinh date,
	gioitinh bit,
	cmnd char(10),
	anh image,
	dantoc nvarchar(20),
	tongiao nvarchar(20),
	sdt char(12),
	email varchar(50),
	ngaykihopdong date,
	ngayhethanhopdong date,
	matkhau varchar(30),
	trinhdongoainguma varchar(10),
	chucdanhma varchar(10),
	trinhdohocvanma varchar(10)
	constraint PK_nhanvien primary key(ma),
	constraint FK_nhanvien_ngoaingu foreign key(trinhdongoainguma) references trinhdongoaingu(ma),
	constraint FK_nhanvien_chucdanh foreign key(chucdanhma) references chucdanh(ma),
	constraint FK_nhanvien_hocvan foreign key(trinhdohocvanma) references trinhdohocvan(ma)
)

--8
create table phongban(
	ma varchar(10) not null,
	ten nvarchar(50),
	diachi nvarchar(150),
	sdt char(12),
	email varchar(50)
	constraint PK_phongban primary key(ma)
)

--9
create table thamgia(
	nhanvienma varchar(10),
	phongbanma varchar(10),
	ngaythamgia date,
	ngayroidi date
	constraint PK_thamgia primary key(nhanvienma, phongbanma, ngaythamgia),
	constraint FK_thamgia_nhanvien foreign key(nhanvienma) references nhanvien(ma),
	constraint FK_thamgia_phongban foreign key(phongbanma) references phongban(ma)
)

--10
create table chamcong(
	thang int,
	nam int,
	nhanvienma varchar(10),
	luongcoban money,
	ngaydilam varchar(100),
	ngaynghicoluong varchar(100)
	constraint PK_chamcong primary key(thang, nam, nhanvienma),
	constraint FK_chamcong_nhanvien foreign key(nhanvienma) references nhanvien(ma)
)

--11
create table nhanvien_phucap(
	nhanvienma varchar(10),
	phucapma varchar(10),
	ngaynhan date,
	ngayhethan date
	constraint PK_nhanvien_phucap primary key(nhanvienma, phucapma),
	constraint FK_nhanvien_phucap_nhanvien foreign key(nhanvienma) references nhanvien(ma),
	constraint FK_nhanvien_phucap_phucap foreign key(phucapma) references phucap(ma),
)

--12
create table quyetdinhkiluat(
	nhanvienma varchar(10),
	kyluatma varchar(10),
	ngay date,
	sotien money
	constraint PK_quyetdinhkiluat primary key(nhanvienma, kyluatma, ngay),
	constraint FK_quyetdinhkiluat_nhanvien foreign key(nhanvienma) references nhanvien(ma),
	constraint FK_quyetdinhkiluat_kiluat foreign key(kyluatma) references kyluat(ma)
)

--13
create table quyetdinhkhenthuong(
	nhanvienma varchar(10),
	khenthuongma varchar(10),
	ngay date,
	sotien money
	constraint PK_quyetdinhkhenthuong primary key(nhanvienma, khenthuongma, ngay),
	constraint FK_quyetdinhkhenthuong_nhanvien foreign key(nhanvienma) references nhanvien(ma),
	constraint FK_quyetdinhkhenthuong_khenthuong foreign key(khenthuongma) references khenthuong(ma)
)

--14
create table truongphong(
	nhanvienma varchar(10),
	phongbanma varchar(10),
	ngaybatdau date,
	ngayketthuc date,
	constraint PK_truongphong primary key(nhanvienma, phongbanma, ngaybatdau),
	constraint FK_truongphong_nhanvien foreign key(nhanvienma) references nhanvien(ma),
	constraint FK_truongphong_phongban foreign key(phongbanma) references phongban(ma)
)
