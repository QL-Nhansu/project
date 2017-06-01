using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
   public class DATA
    {
        #region ChamCong
        public static DataTable get_bangchamcong(int thang, int nam)
        {
            return DBConnect.GetData("get_bangchamcong " + "'" + thang + "','" + nam + "'");
        }
        public static DataTable get_chamcongnv(int thang, int nam)
        {
            return DBConnect.GetData("get_chamcongnv " + "'" + thang + "','" + nam + "'");
        }
        public static int sua_chamcong(
            int thang,
            int nam,
            string manhanvien,
            decimal luongcoban, 
            string ngaydilam,
            string ngaynghicoluong)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@thang",thang),
                new SqlParameter("@nam",nam),
                new SqlParameter("@manhanvien",manhanvien),
                new SqlParameter("@luongcoban",(luongcoban>0)?(object)luongcoban:DBNull.Value),
                new SqlParameter("@ngaydilam",(ngaydilam!=null && ngaydilam.Trim()!="")?(object)ngaydilam:DBNull.Value),
                new SqlParameter("@ngaynghicoluong",(ngaynghicoluong!=null && ngaynghicoluong.Trim()!="")?(object)ngaynghicoluong:DBNull.Value)
            };
            return DBConnect.ExecuteNonQuery("sua_chamcong", para);
        }
        public static int xoa_chamcong(
            int thang,
            int nam,
            string manhanvien)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@thang",thang),
                new SqlParameter("@nam",nam),
                new SqlParameter("@manhanvien",manhanvien)
            };
            return DBConnect.ExecuteNonQuery("xoa_chamcong", para);
        }
        #endregion

        #region ChucDanh
        public static DataTable get_chucdanh()
        {
            return DBConnect.GetData("get_chucdanh");
        }
        public static int them_chucdanh(
            string ma, 
            string ten, 
            decimal luongcoban,
            string chuthich)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                    new SqlParameter("@ma",ma),
                    new SqlParameter("@ten",(ten!=null && ten.Trim()!="")?(object)ten:DBNull.Value),
                    new SqlParameter("@luongcoban",(luongcoban>0)?(object)luongcoban:DBNull.Value),
                    new SqlParameter("@chuthich",(chuthich!=null && chuthich.Trim()!="")?(object)chuthich:DBNull.Value)
            };
            return DBConnect.ExecuteNonQuery("them_chucdanh", para);
        }
        public static int sua_chucdanh(
            string ma,
            string ten,
            decimal luongcoban,
            string chuthich)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                    new SqlParameter("@ma",ma),
                    new SqlParameter("@ten",(ten!=null && ten.Trim()!="")?(object)ten:DBNull.Value),
                    new SqlParameter("@luongcoban",(luongcoban>0)?(object)luongcoban:DBNull.Value),
                    new SqlParameter("@chuthich",(chuthich!=null && chuthich.Trim()!="")?(object)chuthich:DBNull.Value)
            };
            return DBConnect.ExecuteNonQuery("sua_chucdanh", para);
        }
        public static int xoa_chucdanh(string ma)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                    new SqlParameter("@ma",ma)
            };
            return DBConnect.ExecuteNonQuery("xoa_chucdanh", para);
        }
        #endregion

        #region KhenThuong
        public static DataTable get_khenthuong()
        {
            return DBConnect.GetData("get_khenthuong");
        }
        public static int them_khenthuong(
            string ma, 
            string ten, 
            decimal sotien)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",ma),
                new SqlParameter("@ten",(ten!=null && ten.Trim()!="")?(object)ten:DBNull.Value),
                new SqlParameter("@sotien",(sotien>0)?(object)sotien:DBNull.Value)
            };
            return DBConnect.ExecuteNonQuery("them_KhenThuong", para);
        }
        public static int sua_khenthuong(
            string ma, 
            string ten, 
            decimal sotien)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",ma),
                new SqlParameter("@ten",(ten!=null && ten.Trim()!="")?(object)ten:DBNull.Value),
                new SqlParameter("@sotien",(sotien>0)?(object)sotien:DBNull.Value)
            };
            return DBConnect.ExecuteNonQuery("sua_khenthuong", para);
        }
        public static int xoa_khenthuong(string ma)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",ma)
            };
            return DBConnect.ExecuteNonQuery("xoa_khenthuong", para);
        }
        #endregion

        #region KyLuat
        public static DataTable get_kyluat()
        {
            return DBConnect.GetData("get_kyluat");
        }
        public static int them_kyluat(
            string ma, 
            string ten, 
            decimal sotien)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",ma),
                new SqlParameter("@ten",(ten!=null && ten.Trim()!="")?(object)ten:DBNull.Value),
                new SqlParameter("@sotien",(sotien>0)?(object)sotien:DBNull.Value)
            };
            return DBConnect.ExecuteNonQuery("them_kyluat", para);
        }
        public static int sua_kyluat(
            string ma, 
            string ten, 
            decimal sotien)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",ma),
                new SqlParameter("@ten",(ten!=null && ten.Trim()!="")?(object)ten:DBNull.Value),
                new SqlParameter("@sotien",(sotien>0)?(object)sotien:DBNull.Value)
            };
            return DBConnect.ExecuteNonQuery("sua_kyluat", para);
        }
        public static int xoa_kyluat(string ma)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",ma),
            };
            return DBConnect.ExecuteNonQuery("xoa_kyluat", para);
        }
        #endregion

        #region Nhanvien
        public static DataTable get_dsnhanvien()
        {
            return DBConnect.GetData("get_dsnhanvien");
        }
        public static DataTable get_nhanvien(string ma)
        {
            return DBConnect.GetData("get_nhanvien '" + ma+"'");
        }
        public static DataTable get_lichsulv(string ma)
        {
            return DBConnect.GetData("get_lichsulv '" + ma + "'");
        }
        public static DataTable get_lichsukt(string ma)
        {
            return DBConnect.GetData("get_lichsukt '" + ma + "'");
        }
        public static DataTable get_lichsukl(string ma)
        {
            return DBConnect.GetData("get_lichsukl '" + ma + "'");
        }
        public static int them_nhanvien(
            string ma, 
            string ten, 
            DateTime ngaysinh, 
            int gioitinh, 
            string cmnd,
            object anh, 
            string dantoc, 
            string tongiao, 
            string sdt,
            string email,
            DateTime ngaykihopdong,
            DateTime ngayhethanhopdong,
            string matkhau,
            string mangoaingu, 
            string machucdanh, 
            string mahocvan)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",ma),
                new SqlParameter("@ten",(ten!=null && ten.Trim()!="")?(object)ten:DBNull.Value),
                new SqlParameter("@ngaysinh",(ngaysinh.Year!=1000)?(object)ngaysinh:DBNull.Value),
                new SqlParameter("@gioitinh",gioitinh),
                new SqlParameter("@cmnd",(cmnd!=null && cmnd.Trim()!="")?(object)cmnd:DBNull.Value),
                new SqlParameter("@anh", SqlDbType.Image) { SqlValue = (anh!=null)?anh:DBNull.Value},
                new SqlParameter("@dantoc",(dantoc!=null && dantoc.Trim()!="")?(object)dantoc:DBNull.Value),
                new SqlParameter("@tongiao",(tongiao!=null && tongiao.Trim()!="")?(object)tongiao:DBNull.Value),
                new SqlParameter("@sdt",(sdt!=null && sdt.Trim()!="")?(object)sdt:DBNull.Value),
                new SqlParameter("@email",(email!=null && email.Trim()!="")?(object)email:DBNull.Value),
                new SqlParameter("@ngaykihopdong",(ngaykihopdong.Year!=1000)?(object)ngaykihopdong:DBNull.Value),
                new SqlParameter("@ngayhethanhopdong",(ngayhethanhopdong.Year!=1000)?(object)ngayhethanhopdong:DBNull.Value),
                new SqlParameter("@matkhau",(matkhau!=null && matkhau.Trim()!="")?(object)matkhau:DBNull.Value),
                new SqlParameter("@mangoaingu",(mangoaingu!=null && mangoaingu.Trim()!="")?(object)mangoaingu:DBNull.Value),
                new SqlParameter("@machucdanh",(machucdanh!=null && machucdanh.Trim()!="")?(object)machucdanh:DBNull.Value),
                new SqlParameter("@mahocvan",(mahocvan!=null && mahocvan.Trim()!="")?(object)mahocvan:DBNull.Value)
            };
            return DBConnect.ExecuteNonQuery("them_nhanvien", para);
        }
        public static int sua_nhanvien(
            string ma,
            string ten,
            DateTime ngaysinh,
            int gioitinh,
            string cmnd,
            object anh,
            string dantoc,
            string tongiao,
            string sdt,
            string email,
            DateTime ngaykihopdong,
            DateTime ngayhethanhopdong,
            string matkhau,
            string mangoaingu,
            string machucdanh,
            string mahocvan)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",ma),
                new SqlParameter("@ten",(ten!=null && ten.Trim()!="")?(object)ten:DBNull.Value),
                new SqlParameter("@ngaysinh",(ngaysinh.Year!=1000)?(object)ngaysinh:DBNull.Value),
                new SqlParameter("@gioitinh",gioitinh),
                new SqlParameter("@cmnd",(cmnd!=null && cmnd.Trim()!="")?(object)cmnd:DBNull.Value),
                new SqlParameter("@anh", SqlDbType.Image) { SqlValue = (anh!=null)?anh:DBNull.Value},
                new SqlParameter("@dantoc",(dantoc!=null && dantoc.Trim()!="")?(object)dantoc:DBNull.Value),
                new SqlParameter("@tongiao",(tongiao!=null && tongiao.Trim()!="")?(object)tongiao:DBNull.Value),
                new SqlParameter("@sdt",(sdt!=null && sdt.Trim()!="")?(object)sdt:DBNull.Value),
                new SqlParameter("@email",(email!=null && email.Trim()!="")?(object)email:DBNull.Value),
                new SqlParameter("@ngaykihopdong",(ngaykihopdong.Year!=1000)?(object)ngaykihopdong:DBNull.Value),
                new SqlParameter("@ngayhethanhopdong",(ngayhethanhopdong.Year!=1000)?(object)ngayhethanhopdong:DBNull.Value),
                new SqlParameter("@matkhau",(matkhau!=null && matkhau.Trim()!="")?(object)matkhau:DBNull.Value),
                new SqlParameter("@mangoaingu",(mangoaingu!=null && mangoaingu.Trim()!="")?(object)mangoaingu:DBNull.Value),
                new SqlParameter("@machucdanh",(machucdanh!=null && machucdanh.Trim()!="")?(object)machucdanh:DBNull.Value),
                new SqlParameter("@mahocvan",(mahocvan!=null && mahocvan.Trim()!="")?(object)mahocvan:DBNull.Value)
            };
            return DBConnect.ExecuteNonQuery("sua_nhanvien", para);
        }
        public static int xoa_nhanvien(string ma)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",ma),
            };
            return DBConnect.ExecuteNonQuery("xoa_nhanvien", para);
        }
        #endregion

        #region NhanVien_PhuCap
        public static int them_NVPC(
            string manhanvien,
            string maphucap,
            DateTime ngaynhan,
            DateTime ngayhethan
            )
        {
            SqlParameter[] para = new SqlParameter[]
            {
                    new SqlParameter("@manhanvien",manhanvien),
                    new SqlParameter("@maphucap",maphucap),
                    new SqlParameter("@ngaynhan",(ngaynhan.Year!=1000)?(object)ngaynhan:DBNull.Value),
                    new SqlParameter("@ngayhethan",(ngayhethan.Year!=1000)?(object)ngayhethan:DBNull.Value)
            };
            return DBConnect.ExecuteNonQuery("them_NVPC", para);
        }
        public static int sua_NVPC(
            string manhanvien,
            string maphucap,
            DateTime ngaynhan,
            DateTime ngayhethan
            )
        {
            SqlParameter[] para = new SqlParameter[]
            {
                    new SqlParameter("@manhanvien",manhanvien),
                    new SqlParameter("@maphucap",maphucap),
                    new SqlParameter("@ngaynhan",(ngaynhan.Year!=1000)?(object)ngaynhan:DBNull.Value),
                    new SqlParameter("@ngayhethan",(ngayhethan.Year!=1000)?(object)ngayhethan:DBNull.Value)
            };
            return DBConnect.ExecuteNonQuery("sua_NVPC", para);
        }
        public static int xoa_NVPC(
            string manhanvien,
            string maphucap,
            DateTime ngaynhan
            )
        {
            SqlParameter[] para = new SqlParameter[]
            {
                    new SqlParameter("@manhanvien",manhanvien),
                    new SqlParameter("@maphucap",maphucap),
                    new SqlParameter("@ngaynhan",ngaynhan)
            };
            return DBConnect.ExecuteNonQuery("xoa_NVPC", para);
        }
        #endregion

        #region phucap
        public static DataTable get_phucap()
        {
            return DBConnect.GetData("get_phucap");
        }
        public static int them_phucap(
            string ma, 
            string ten, 
            decimal sotien)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                    new SqlParameter("@ma",ma),
                    new SqlParameter("@ten",(ten!=null && ten.Trim()!="")?(object)ten:DBNull.Value),
                    new SqlParameter("@sotien",(sotien>0)?(object)sotien:DBNull.Value)
            };
            return DBConnect.ExecuteNonQuery("them_phucap", para);
        }
        public static int sua_phucap(
            string ma,
            string ten,
            decimal sotien)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                    new SqlParameter("@ma",ma),
                    new SqlParameter("@ten",(ten!=null && ten.Trim()!="")?(object)ten:DBNull.Value),
                    new SqlParameter("@sotien",(sotien>0)?(object)sotien:DBNull.Value)
            };
            return DBConnect.ExecuteNonQuery("sua_phucap", para);
        }
        public static int xoa_phucap(string ma)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                    new SqlParameter("@ma",ma)
            };
            return DBConnect.ExecuteNonQuery("xoa_phucap", para);
        }
        #endregion

        #region QuyetDinhKyLuat
        public static int them_QDKL(
            string manhanvien, 
            string makiluat, 
            DateTime ngay, 
            decimal sotien)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@manhanvien",manhanvien),
                new SqlParameter("@makiluat",makiluat),
                new SqlParameter("@ngay",(ngay.Year!=1000)?(object)ngay:DBNull.Value),
                new SqlParameter("@sotien",(sotien>0)?(object)sotien:DBNull.Value)
            };
            return DBConnect.ExecuteNonQuery("them_QDKL", para);
        }
        public static int sua_QDKL(
            string manhanvien,
            string makiluat,
            DateTime ngay,
            decimal sotien)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@manhanvien",manhanvien),
                new SqlParameter("@makiluat",makiluat),
                new SqlParameter("@ngay",(ngay.Year!=1000)?(object)ngay:DBNull.Value),
                new SqlParameter("@sotien",(sotien>0)?(object)sotien:DBNull.Value)
            };
            return DBConnect.ExecuteNonQuery("sua_QDKL", para);
        }
        public static int xoa_QDKL(
            string manhanvien,
            string makiluat,
            DateTime ngay)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@manhanvien",manhanvien),
                new SqlParameter("@makiluat",makiluat),
                new SqlParameter("@ngay",ngay)
            };
            return DBConnect.ExecuteNonQuery("xoa_QDKL", para);
        }
        #endregion

        #region QuyetDinhKhenThuong
        public static int them_QDKT(
            string manhanvien, 
            string makhenthuong, 
            DateTime ngay, 
            decimal sotien)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@manhanvien",manhanvien),
                new SqlParameter("@makhenthuong",makhenthuong),
                new SqlParameter("@ngay",(ngay.Year!=1000)?(object)ngay:DBNull.Value),
                new SqlParameter("@sotien",(sotien>0)?(object)sotien:DBNull.Value)
            };
            return DBConnect.ExecuteNonQuery("them_QDKT", para);
        }
        public static int sua_QDKT(
            string manhanvien,
            string makhenthuong,
            DateTime ngay,
            decimal sotien)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@manhanvien",manhanvien),
                new SqlParameter("@makhenthuong",makhenthuong),
                new SqlParameter("@ngay",(ngay.Year!=1000)?(object)ngay:DBNull.Value),
                new SqlParameter("@sotien",(sotien>0)?(object)sotien:DBNull.Value)
            };
            return DBConnect.ExecuteNonQuery("sua_QDKT", para);
        }
        public static int xoa_QDKT(
            string manhanvien,
            string makhenthuong,
            DateTime ngay)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@manhanvien",manhanvien),
                new SqlParameter("@makhenthuong",makhenthuong),
                new SqlParameter("@ngay",ngay)
            };
            return DBConnect.ExecuteNonQuery("xoa_QDKT", para);
        }
        #endregion

        #region ThamGia
        public static int them_thamgia(
            string manhanvien,
            string maphongban,
            DateTime ngaythamgia,
            DateTime ngayroidi
            )
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@manhanvien",manhanvien),
                new SqlParameter("@maphongban",maphongban),
                new SqlParameter("@ngaythamgia",(ngaythamgia.Year!=1000)?(object)ngaythamgia:DBNull.Value),
                new SqlParameter("@ngayroidi",(ngayroidi.Year!=1000)?(object)ngayroidi:DBNull.Value)
            };
            return DBConnect.ExecuteNonQuery("them_thamgia", para);
        }
        public static int sua_thamgia(
            string manhanvien,
            string maphongban,
            DateTime ngaythamgia,
            DateTime ngayroidi
            )
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@manhanvien",manhanvien),
                new SqlParameter("@maphongban",maphongban),
                new SqlParameter("@ngaythamgia",(ngaythamgia.Year!=1000)?(object)ngaythamgia:DBNull.Value),
                new SqlParameter("@ngayroidi",(ngayroidi.Year!=1000)?(object)ngayroidi:DBNull.Value)
            };
            return DBConnect.ExecuteNonQuery("sua_thamgia", para);
        }
        public static int xoa_thamgia(
            string manhanvien,
            string maphongban,
            DateTime ngaythamgia
            )
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@manhanvien",manhanvien),
                new SqlParameter("@maphongban",maphongban),
                new SqlParameter("@ngaythamgia",ngaythamgia)
            };
            return DBConnect.ExecuteNonQuery("xoa_thamgia", para);
        }
        #endregion

        #region TrinhDoHocVan
        public static DataTable get_hocvan()
        {
            return DBConnect.GetData("get_hocvan");
        }
        public static int them_hocvan(
            string ma, 
            string ten, 
            string chuthich)
        {
            {
                SqlParameter[] para = new SqlParameter[]
                {
                    new SqlParameter("@ma",ma),
                    new SqlParameter("@ten",(ten!=null && ten.Trim()!="")?(object)ten:DBNull.Value),
                    new SqlParameter("@chuthich",(chuthich!=null && chuthich.Trim()!="")?(object)chuthich:DBNull.Value)
                };
                return DBConnect.ExecuteNonQuery("them_hocvan", para);
            }
        }
        public static int sua_hocvan(
            string ma, 
            string ten, 
            string chuthich)
        {
            {
                SqlParameter[] para = new SqlParameter[]
                {
                    new SqlParameter("@ma",ma),
                    new SqlParameter("@ten",(ten!=null && ten.Trim()!="")?(object)ten:DBNull.Value),
                    new SqlParameter("@chuthich",(chuthich!=null && chuthich.Trim()!="")?(object)chuthich:DBNull.Value)
                };
                return DBConnect.ExecuteNonQuery("sua_hocvan", para);
            }
        }
        public static int xoa_hocvan(string ma)
        {
            {
                SqlParameter[] para = new SqlParameter[]
                {
                    new SqlParameter("@ma",ma)
                };
                return DBConnect.ExecuteNonQuery("xoa_hocvan", para);
            }
        }
        #endregion

        #region TrinhDoNgoaiNgu
        public static DataTable get_ngoaingu()
        {
            return DBConnect.GetData("get_ngoaingu");
        }
        public static int them_ngoaingu(
            string ma, 
            string ten, 
            string ngonngu, 
            string chuthich)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                    new SqlParameter("@ma",ma),
                    new SqlParameter("@ten",(ten!=null && ten.Trim()!="")?(object)ten:DBNull.Value),
                    new SqlParameter("@ngonngu",(ngonngu!=null && ngonngu.Trim()!="")?(object)ngonngu:DBNull.Value),
                    new SqlParameter("@chuthich",(chuthich!=null && chuthich.Trim()!="")?(object)chuthich:DBNull.Value)
            };
            return DBConnect.ExecuteNonQuery("them_ngoaingu", para);
        }
        public static int sua_ngoaingu(
            string ma, 
            string ten, 
            string ngonngu, 
            string chuthich)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                    new SqlParameter("@ma",ma),
                    new SqlParameter("@ten",(ten!=null && ten.Trim()!="")?(object)ten:DBNull.Value),
                    new SqlParameter("@ngonngu",(ngonngu!=null && ngonngu.Trim()!="")?(object)ngonngu:DBNull.Value),
                    new SqlParameter("@chuthich",(chuthich!=null && chuthich.Trim()!="")?(object)chuthich:DBNull.Value)
            };
            return DBConnect.ExecuteNonQuery("sua_ngoaingu", para);
        }
        public static int xoa_ngoaingu(string ma)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                    new SqlParameter("@ma",ma)
            };
            return DBConnect.ExecuteNonQuery("xoa_ngoaingu", para);
        }
        #endregion

        #region TruongPhong
        public static int them_truongphong(
            string manhanvien,
            string maphongban,
            DateTime ngaybatdau,
            DateTime ngayketthuc)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                    new SqlParameter("@manhanvien",manhanvien),
                    new SqlParameter("@maphongban",maphongban),
                    new SqlParameter("@ngaybatdau",(ngaybatdau.Year!=1000)?(object)ngaybatdau:DBNull.Value),
                    new SqlParameter("@ngayketthuc",(ngayketthuc.Year!=1000)?(object)ngayketthuc:DBNull.Value)
            };
            return DBConnect.ExecuteNonQuery("them_truongphong", para);
        }
        public static int sua_truongphong(
            string manhanvien,
            string maphongban,
            DateTime ngaybatdau,
            DateTime ngayketthuc)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                    new SqlParameter("@manhanvien",manhanvien),
                    new SqlParameter("@maphongban",maphongban),
                    new SqlParameter("@ngaybatdau",(ngaybatdau.Year!=1000)?(object)ngaybatdau:DBNull.Value),
                    new SqlParameter("@ngayketthuc",(ngayketthuc.Year!=1000)?(object)ngayketthuc:DBNull.Value)
            };
            return DBConnect.ExecuteNonQuery("sua_truongphong", para);
        }
        public static int xoa_truongphong(
            string manhanvien,
            string maphongban,
            DateTime ngaybatdau)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                    new SqlParameter("@manhanvien",manhanvien),
                    new SqlParameter("@maphongban",maphongban),
                    new SqlParameter("@ngaybatdau",ngaybatdau)
            };
            return DBConnect.ExecuteNonQuery("xoa_truongphong", para);
        }
        #endregion

        #region PhongBan
        public static DataTable get_phongban()
        {
            return DBConnect.GetData("get_phongban");
        }
        #endregion
    }
}
