--chamcong
create proc them_chamcong
as
begin
	declare @date date
	set @date = GETDATE()
	insert into chamcong
	select	DATEPART(mm,@date), DATEPART(yyyy,@date), nhanvien.ma, chucdanh.luongcoban, null, null
	from	nhanvien left join chucdanh on nhanvien.chucdanhma = chucdanh.ma
	where not exists 
	(	select * from chamcong 
		where	chamcong.nhanvienma = nhanvien.ma and
				chamcong.thang = DATEPART(mm,@date) and
				chamcong.nam = DATEPART(yyyy,@date)
	)
end
go

create proc xoa_chamcong(
@thang int,
@nam int,
@manhanvien varchar(10))
as
begin
	delete from chamcong where thang = @thang and nam = @nam and nhanvienma = @manhanvien
end
go

create proc sua_chamcong(
@thang int,
@nam int,
@manhanvien varchar(10),
@luongcoban money,
@ngaydilam varchar(100),
@ngaynghicoluong varchar(100))
as
begin
	update chamcong
	set	luongcoban = @luongcoban,
		ngaydilam = @ngaydilam,
		ngaynghicoluong = @ngaynghicoluong
	where thang = @thang and nam = @nam and nhanvienma = @manhanvien 
end
go

--chucdanh
create proc them_chucdanh(
@ma varchar(10),
@ten nvarchar(20),
@luongcoban money,
@chuthich nvarchar(100))
as
begin
	insert into chucdanh values (@ma, @ten, @luongcoban, @chuthich)
end
go

create proc sua_chucdanh(
@ma varchar(10),
@ten nvarchar(20),
@luongcoban money,
@chuthich nvarchar(100))
as
begin
	update chucdanh
	set ten = @ten,
		luongcoban = @luongcoban,
		chuthich = @chuthich
	where ma = @ma
end
go

create proc xoa_chucdanh(
@ma varchar(10))
as
begin
	delete chucdanh where ma = @ma
end
go

--khenthuong
create proc them_khenthuong(
@ma varchar(10),
@ten varchar(50),
@sotien money)
as
begin
	insert into khenthuong values (@ma, @ten, @sotien)
end
go

create proc sua_khenthuong(
@ma varchar(10),
@ten varchar(50),
@sotien money)
as
begin
	update khenthuong
	set ten = @ten,
		sotien = @sotien
	where ma = @ma
end
go

create proc xoa_khenthuong(
@ma varchar(10))
as
begin
	delete quyetdinhkhenthuong where khenthuongma = @ma
	delete khenthuong where ma = @ma
end
go

--kyluat
create proc them_kyluat(
@ma varchar(10),
@ten varchar(50),
@sotien money)
as
begin
	insert into kyluat values (@ma, @ten, @sotien)
end
go

create proc sua_kyluat(
@ma varchar(10),
@ten varchar(50),
@sotien money)
as
begin
	update kyluat
	set ten = @ten,
		sotien = @sotien
	where ma = @ma
end
go

create proc xoa_kyluat(
@ma varchar(10))
as
begin
	delete quyetdinhkiluat where kyluatma = @ma
	delete kyluat where ma = @ma
end
go

--nhanvien
create proc them_nhanvien(
@ma varchar(10),
@ten nvarchar(50),
@ngaysinh date,
@gioitinh bit,
@cmnd char(10),
@anh image,
@dantoc nvarchar(20),
@tongiao nvarchar(20),
@sdt char(12),
@email varchar(50),
@ngaykihopdong date,
@ngayhethanhopdong date,
@matkhau varchar(30),
@mangoaingu varchar(10),
@machucdanh varchar(10),
@mahocvan varchar(10))
as
begin
	insert into nhanvien values (@ma, @ten, @ngaysinh, @gioitinh,
	 @cmnd, @anh, @dantoc, @tongiao, @sdt, @email, @ngaykihopdong,
	 @ngayhethanhopdong, @matkhau, @mangoaingu, @machucdanh, @mahocvan)
end
go

create proc sua_nhanvien(
@ma varchar(10),
@ten nvarchar(50),
@ngaysinh date,
@gioitinh bit,
@cmnd char(10),
@anh image,
@dantoc nvarchar(20),
@tongiao nvarchar(20),
@sdt char(12),
@email varchar(50),
@ngaykihopdong date,
@ngayhethanhopdong date,
@matkhau varchar(30),
@mangoaingu varchar(10),
@machucdanh varchar(10),
@mahocvan varchar(10))
as
begin
	update nhanvien
	set ten = @ten,
		ngaysinh = @ngaysinh,
		gioitinh = @gioitinh,
		cmnd = @cmnd,
		anh = @anh,
		dantoc = @dantoc,
		tongiao = @tongiao,
		sdt = @sdt,
		email = @email,
		ngaykihopdong = @ngaykihopdong,
		ngayhethanhopdong = @ngayhethanhopdong,
		matkhau = @matkhau,
		trinhdongoainguma = @mangoaingu,
		chucdanhma = @machucdanh,
		trinhdohocvanma = @mahocvan
	where ma = @ma
end
go

create proc xoa_nhanvien(@ma varchar(10))
as
begin
	delete thamgia where nhanvienma = @ma
	delete quyetdinhkhenthuong where nhanvienma = @ma
	delete quyetdinhkiluat where nhanvienma = @ma
	delete nhanvien_phucap where nhanvienma = @ma
	delete truongphong where nhanvienma = @ma
	delete chamcong where nhanvienma = @ma
	delete nhanvien where ma = @ma
end
go

--nhanvien_phucap
create proc them_NVPC(
@manhanvien varchar(10),
@maphucap varchar(10),
@ngaynhan date,
@ngayhethan date)
as
begin
	insert into nhanvien_phucap values (@manhanvien, @maphucap, @ngaynhan, @ngayhethan)
end
go

create proc sua_NVPC(
@manhanvien varchar(10),
@maphucap varchar(10),
@ngaynhan date,
@ngayhethan date)
as
begin
	update nhanvien_phucap 
	set	ngaynhan = @ngaynhan, 
		ngayhethan = @ngayhethan
	where nhanvienma = @manhanvien and phucapma = @maphucap
end
go

create proc xoa_NVPC(
@manhanvien varchar(10),
@maphucap varchar(10))
as
begin
	delete nhanvien_phucap where nhanvienma = @manhanvien and phucapma = @maphucap
end
go

--phongban
create proc them_phongban(
@ma varchar(10),
@ten varchar(50),
@diachi nvarchar(150),
@sdt char(12),
@email varchar(50))
as
begin
	insert into phongban values (@ma, @ten, @diachi, @sdt, @email)
end 
go

create proc sua_phongban(
@ma varchar(10),
@ten varchar(50),
@diachi nvarchar(150),
@sdt char(12),
@email varchar(50))
as
begin
	update phongban 
	set	ten = @ten, 
		diachi = @diachi, 
		sdt = @sdt, 
		email = @email
	where ma = @ma
end 
go

create proc xoa_phongban(@ma varchar(10))
as
begin
	delete thamgia where phongbanma = @ma
	delete phongban where ma = @ma
end
go

--phucap
create proc them_phucap(
@ma varchar(10),
@ten varchar(50),
@sotien money)
as
begin
	insert into phucap values (@ma, @ten, @sotien)
end
go

create proc sua_phucap(
@ma varchar(10),
@ten varchar(50),
@sotien money)
as
begin
	update phucap
	set ten = @ten,
		sotien = @sotien
	where ma = @ma
end
go

create proc xoa_phucap(
@ma varchar(10))
as
begin
	delete nhanvien_phucap where phucapma = @ma
	delete phucap where ma = @ma
end
go

--quyetdinhkhenthuong
create proc them_QDKT(
@manhanvien varchar(10),
@makhenthuong varchar(10),
@ngay date,
@sotien money)
as
begin
	insert into quyetdinhkhenthuong values (@manhanvien, @makhenthuong, @ngay, @sotien)
end
go

create proc sua_QDKT(
@manhanvien varchar(10),
@makhenthuong varchar(10),
@ngay date,
@sotien money)
as
begin
	update quyetdinhkhenthuong 
	set sotien = @sotien
	where nhanvienma = @manhanvien and khenthuongma = @makhenthuong and ngay = @ngay
end
go

create proc xoa_QDKT(
@manhanvien varchar(10),
@makhenthuong varchar(10),
@ngay date)
as
begin
	delete quyetdinhkhenthuong where nhanvienma = @manhanvien and khenthuongma = @makhenthuong and ngay = @ngay
end
go

--quyetdinhkiluat
create proc them_QDKL(
@manhanvien varchar(10),
@makiluat varchar(10),
@ngay date,
@sotien money)
as
begin
	insert into quyetdinhkiluat values (@manhanvien, @makiluat, @ngay, @sotien)
end
go

create proc sua_QDKL(
@manhanvien varchar(10),
@makiluat varchar(10),
@ngay date,
@sotien money)
as
begin
	update quyetdinhkiluat 
	set sotien = @sotien
	where nhanvienma = @manhanvien and kyluatma = @makiluat and ngay = @ngay
end
go

create proc xoa_QDKL(
@manhanvien varchar(10),
@makiluat varchar(10),
@ngay date)
as
begin
	delete quyetdinhkiluat where nhanvienma = @manhanvien and kyluatma = @makiluat and ngay = @ngay
end
go

--thamgia
create proc them_thamgia(
@manhanvien varchar(10),
@maphongban varchar(10),
@ngaythamgia date,
@ngayroidi date)
as
begin
	insert into thamgia values (@manhanvien, @maphongban, @ngaythamgia, @ngayroidi)
end
go

create proc sua_thamgia(
@manhanvien varchar(10),
@maphongban varchar(10),
@ngaythamgia date,
@ngayroidi date)
as
begin
	update thamgia 
	set ngaythamgia = @ngaythamgia, 
		ngayroidi = @ngayroidi
	where nhanvienma = @manhanvien and phongbanma = @maphongban
end
go

create proc xoa_thamgia(
@manhanvien varchar(10),
@maphongban varchar(10),
@ngaythamgia date)
as
begin
	delete thamgia where nhanvienma = @manhanvien and phongbanma = @maphongban and ngaythamgia = @ngaythamgia
end
go

--trinhdohocvan
create proc them_hocvan(
@ma varchar(10),
@ten nvarchar(50),
@chuthich nvarchar(100))
as
begin
	insert into trinhdohocvan values (@ma, @ten, @chuthich)
end
go

create proc sua_hocvan(
@ma varchar(10),
@ten nvarchar(50),
@chuthich nvarchar(100))
as
begin
	update trinhdohocvan 
	set ten = @ten, 
		chuthich = @chuthich
	where ma = @ma
end
go

create proc xoa_hocvan(@ma varchar(10))
as
begin
	delete trinhdohocvan where ma = @ma
end
go

--trinhdongoaingu
create proc them_ngoaingu(
@ma varchar(10),
@ten nvarchar(50),
@ngonngu nvarchar(50),
@chuthich nvarchar(100))
as
begin
	insert into trinhdongoaingu values (@ma, @ten, @ngonngu, @chuthich)
end
go

create proc sua_ngoaingu(
@ma varchar(10),
@ten nvarchar(50),
@ngonngu nvarchar(50),
@chuthich nvarchar(100))
as
begin
	update trinhdongoaingu 
	set ten = @ten, 
		ngonngu = @ngonngu,
		chuthich = @chuthich
	where ma = @ma
end
go

create proc xoa_ngoaingu(@ma varchar(10))
as
begin
	delete trinhdongoaingu where ma = @ma
end
go

--truongphong
create proc them_truongphong(
@manhanvien varchar(10),
@maphongban varchar(10),
@ngaybatdau date,
@ngayketthuc date)
as
begin
	insert into truongphong values (@manhanvien, @maphongban, @ngaybatdau, @ngayketthuc)
end
go

create proc sua_truongphong(
@manhanvien varchar(10),
@maphongban varchar(10),
@ngaybatdau date,
@ngayketthuc date)
as
begin
	update truongphong 
	set ngayketthuc = @ngayketthuc
	where nhanvienma = @manhanvien and phongbanma = @maphongban and ngaybatdau = @ngaybatdau
end
go

create proc xoa_truongphong(
@manhanvien varchar(10),
@maphongban varchar(10),
@ngaybatdau date)
as
begin
	delete truongphong where nhanvienma = @manhanvien and phongbanma = @maphongban and ngaybatdau = @ngaybatdau
end
go

----------------------------------------------------------------------------------------------------
-- proc get du lieu theo chuc nang
create proc get_bangchamcong(@thang int, @nam int)
as
begin
	select thang, nam, nhanvien.ma, nhanvien.ten, ngaydilam, ngaynghicoluong
	from chamcong join nhanvien on chamcong.nhanvienma = nhanvien.ma
	where thang = @thang and nam = @nam
end
go

create proc get_chamcongnv(@thang int, @nam int)
as
begin
	execute them_chamcong
	
	select	nhanvien.ma as N'Mã nhân viên', nhanvien.ten as N'Tên nhân viên',
			case when gioitinh=1 then N'Nam' else N'Nữ' end as N'Giới tính',
			phongban.ten as N'Tên phòng ban', chucdanh.ten as N'Chức vụ',
			ngaydilam, ngaynghicoluong, chamcong.luongcoban
	from	nhanvien join chamcong on nhanvien.ma = chamcong.nhanvienma
			left join thamgia on nhanvien.ma = thamgia.nhanvienma and thamgia.ngayroidi is null
			left join phongban on thamgia.phongbanma = phongban.ma 
			left join chucdanh on nhanvien.chucdanhma = chucdanh.ma
	where	chamcong.thang = @thang and chamcong.nam = @nam
end
go

create proc get_dsnhanvien
as begin
	select	nhanvien.ma as N'Mã', nhanvien.ten as N'Họ và tên', 
			case when gioitinh=1 then N'Nam' else N'Nữ' end as N'Giới tính',
			ngaysinh as N'Ngày sinh', nhanvien.email as 'Email', nhanvien.sdt as N'SDT',
			ngayhethanhopdong as N'Hạn hợp đồng', phongban.ten as N'Phòng ban',
			chucdanh.ten as N'Chức danh'
	from	nhanvien left join chucdanh on nhanvien.chucdanhma = chucdanh.ma
			left join  thamgia on nhanvien.ma = thamgia.nhanvienma and ngayroidi is null
			left join phongban on thamgia.phongbanma = phongban.ma
	order by chucdanh.ten
end
go

create proc get_nhanvien(@manhanvien varchar(10))
as begin
	select	anh, nhanvien.ma, nhanvien.ten, ngaysinh, case when gioitinh=1 then N'Nam' else N'Nữ' end as N'gioitinh',
			cmnd, chucdanh.ten, dantoc, tongiao, nhanvien.sdt, email, trinhdohocvan.ten as 'hocvan',
			trinhdongoaingu.ten as 'ngoaingu', ngaykihopdong, ngayhethanhopdong
	from	nhanvien left join chucdanh on nhanvien.chucdanhma = chucdanh.ma
			left join trinhdohocvan on nhanvien.trinhdohocvanma = trinhdohocvan.ma
			left join trinhdongoaingu on nhanvien.trinhdongoainguma = trinhdongoaingu.ma
	where	nhanvien.ma = @manhanvien
end
go

create proc get_lichsulv(@manhanvien varchar(10))
as begin
	select	phongban.ten as N'Phòng ban', ngaythamgia as N'Ngày tham gia',
			ngayroidi as N'Ngày kết thúc'
	from	thamgia join phongban on thamgia.phongbanma = phongban.ma
			join nhanvien on thamgia.nhanvienma = nhanvien.ma
	where	thamgia.nhanvienma = @manhanvien
end
go

create proc get_lichsukt(@manhanvien varchar(10))
as begin
	select	khenthuong.ten as N'Tên khen thưởng', ngay as N'Ngày khen thưởng', 
			quyetdinhkhenthuong.sotien as N'Số tiền'
	from	quyetdinhkhenthuong join khenthuong on quyetdinhkhenthuong.khenthuongma = khenthuong.ma
	where quyetdinhkhenthuong.nhanvienma = @manhanvien
end
go

create proc get_lichsukl(@manhanvien varchar(10))
as begin
	select	kyluat.ten as N'Tên kỉ luật', ngay as N'Ngày kỉ luật', 
			quyetdinhkiluat.sotien as N'Số tiền'
	from	quyetdinhkiluat join kyluat on quyetdinhkiluat.kyluatma = kyluat.ma
	where quyetdinhkiluat.nhanvienma = @manhanvien
end
go

create proc get_chucdanh
as begin
	select ma as N'Mã', ten as N'Tên chức danh', luongcoban as N'Lương cơ bản', chuthich as N'Chú thích'
	from chucdanh
end
go

create proc get_khenthuong
as begin
	select ma as N'Mã', ten as N'Tên khen thưởng', sotien as N'Số tiền'
	from khenthuong
end
go

create proc get_kyluat
as begin
	select ma as N'Mã', ten as N'Tên kỉ luật', sotien as N'Số tiền'
	from kyluat
end
go

create proc get_hocvan
as begin
	select ma as N'Mã', ten as N'Tên học vấn', chuthich as N'Chú thích'
	from trinhdohocvan
end
go

create proc get_ngoaingu
as begin
	select ma as N'Mã', ten as N'Tên ngoại ngữ', ngonngu as N'Ngôn ngữ', chuthich as N'Chú thích'
	from trinhdongoaingu
end
go

create proc get_phucap
as begin
	select ma as N'Mã', ten as N'Tên phụ cấp', sotien as N'Số tiền'
	from phucap
end
go

create proc get_phongban
as begin
	select ma, ten
	from phongban
end
go