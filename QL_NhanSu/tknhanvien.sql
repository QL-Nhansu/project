create view VIEW_PhongBan
as
select ma,ten from phongban
go
create proc VIEW_NVOPB @mapb varchar(10)
as
begin
select nhanvien.ma,nhanvien.ten,nhanvien.ngaysinh,nhanvien.gioitinh
,nhanvien.sdt,nhanvien.email,chucdanh.ten
from nhanvien , thamgia ,phongban,chucdanh where (thamgia.manv = nhanvien.ma) 
and thamgia.maqb=phongban.ma and chucdanh.ma= nhanvien.chucdanhma and @mapb=phongban.ma
end
go
create proc VIEW_CVNV @cdma varchar(10)
as
begin
select nv.ma,nv.ten,nv.ngaysinh,nv.gioitinh,nv.sdt,nv.email,pb.ten from nhanvien nv,thamgia tg,phongban pb where nv.ma=tg.manv and tg.maqb=pb.ma and @cdma=nv.chucdanhma
end
go
create proc VIEW_NV @ma varchar(10)
as
begin
select * from nhanvien where @ma=ma
end
go

