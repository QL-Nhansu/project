using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAL
{
    class DATA
    {
        #region ChamCong
        public static DataTable xuat_chamcong()
        {
            return DBConnect.GetData("ChamCong");
        }
        public static int ADD_ChamCong(ChamCong a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@dateend",a.Dateend),
                new SqlParameter("@luongcoban",a.Luongcoban),
                new SqlParameter("@songaylam",a.Songaylam),
                new SqlParameter("@songaynghicoluong",a.Songaynghicoluong),
                new SqlParameter("@nhanvienma",a.Nhanvienma),
                new SqlParameter("@ngaydilam",a.Ngaydilam),
            };
            return DBConnect.ExecuteNonQuery("ADD_ChamCong", para);
        }
        public static int Change_ChamCong(ChamCong a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@dateend",a.Dateend),
                new SqlParameter("@luongcoban",a.Luongcoban),
                new SqlParameter("@songaylam",a.Songaylam),
                new SqlParameter("@songaynghicoluong",a.Songaynghicoluong),
                new SqlParameter("@nhanvienma",a.Nhanvienma),
                new SqlParameter("@ngaydilam",a.Ngaydilam),
            };
            return DBConnect.ExecuteNonQuery("Change_ChamCong", para);
        }
        public static int DELETE_ChamCong(string Dateend)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@dateend",Dateend),
            };
            return DBConnect.ExecuteNonQuery("DELETE_ChamCong", para);
        }

        #endregion

        #region KyLuat
        public static DataTable xuat_KyLuat()
        {
            return DBConnect.GetData("KyLuat");
        }
        public static int ADD_Kyluat(KyLuat a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",a.Ma),
                new SqlParameter("@ten",a.Ten),
                new SqlParameter("@sotien",a.Sotien),
            };
            return DBConnect.ExecuteNonQuery("ADD_Kyluat", para);
        }
        public static int Change_Kyluat(KyLuat a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",a.Ma),
                new SqlParameter("@ten",a.Ten),
                new SqlParameter("@sotien",a.Sotien),
            };
            return DBConnect.ExecuteNonQuery("Change_Kyluat", para);
        }
        public static int DELETE_Kyluat(string Ma)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",Ma),
            };
            return DBConnect.ExecuteNonQuery("DELETE_Kyluat", para);
        }
        #endregion

        #region KhenThuong
        public static DataTable xuat_KhenThuong()
        {
            return DBConnect.GetData("KhenThuong");
        }
        public static int ADD_KhenThuong(KhenThuong a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",a.Ma),
                new SqlParameter("@ten",a.Ten),
                new SqlParameter("@sotien",a.Sotien),
            };
            return DBConnect.ExecuteNonQuery("ADD_KhenThuong", para);
        }
        public static int Change_KhenThuong(KhenThuong a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",a.Ma),
                new SqlParameter("@ten",a.Ten),
                new SqlParameter("@sotien",a.Sotien),
            };
            return DBConnect.ExecuteNonQuery("Change_KhenThuong", para);
        }
        public static int DELETE_KhenThuong(string Ma)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",Ma),
            };
            return DBConnect.ExecuteNonQuery("DELETE_KhenThuong", para);
        }
        #endregion

        #region Nhanvien
        public static DataTable xuat_Nhanvien()
        {
            return DBConnect.GetData("NhanVien");
        }
        public static int ADD_Nhanvien(NhanVien a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",a.Ma),
                new SqlParameter("@ten",a.Ten),
                new SqlParameter("@ngaysinh",a.Ngaysinh),
                new SqlParameter("@gioitinh",a.Gioitinh),
                new SqlParameter("@dantoc",a.Dantoc),
                new SqlParameter("@cmnd",a.Cmnd),
                new SqlParameter("@anh",a.Anh),
                new SqlParameter("@tongiao",a.Tongiao),
                new SqlParameter("@trinhdongoainguma",a.Trinhdongoainguma),
                new SqlParameter("@trinhdohocvanma",a.Trinhdohocvanma),
                new SqlParameter("@chucdanhma",a.Chucdanhma),
                new SqlParameter("@ngaykihopdong",a.Ngaykihopdong),
                new SqlParameter("@ngayhethanhopdong",a.Ngayhethanhopdong),
                new SqlParameter("@matkhau",a.Matkhau),
            };
            return DBConnect.ExecuteNonQuery("ADD_Nhanvien", para);
        }
        public static int Change_Nhanvien(NhanVien a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",a.Ma),
                new SqlParameter("@ten",a.Ten),
                new SqlParameter("@ngaysinh",a.Ngaysinh),
                new SqlParameter("@gioitinh",a.Gioitinh),
                new SqlParameter("@dantoc",a.Dantoc),
                new SqlParameter("@cmnd",a.Cmnd),
                new SqlParameter("@anh",a.Anh),
                new SqlParameter("@tongiao",a.Tongiao),
                new SqlParameter("@trinhdongoainguma",a.Trinhdongoainguma),
                new SqlParameter("@trinhdohocvanma",a.Trinhdohocvanma),
                new SqlParameter("@chucdanhma",a.Chucdanhma),
            };
            return DBConnect.ExecuteNonQuery("Change_Nhanvien", para);
        }
        public static int DELETE_Nhanvien(string Ma)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",Ma),
            };
            return DBConnect.ExecuteNonQuery("DELETE_Nhanvien", para);
        }
        #endregion

        #region QuyetDinhKyLuat
        public static DataTable xuat_QuyetDinhKyLuat()
        {
            return DBConnect.GetData("QuyetDinhKyLuat");
        }
        public static int ADD_QuyetDinhKyLuat(QuyetDinhKyLuat a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@nhanvienma",a.Nhanvienma),
                new SqlParameter("@kyluatma",a.Kyluatma),
                new SqlParameter("@ngay",a.Ngay),
                new SqlParameter("@sotien",a.Sotien),
            };
            return DBConnect.ExecuteNonQuery("ADD_QuyetDinhKyLuat", para);
        }
        public static int Change_QuyetDinhKyLuat(QuyetDinhKyLuat a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@nhanvienma",a.Nhanvienma),
                new SqlParameter("@kyluatma",a.Kyluatma),
                new SqlParameter("@ngay",a.Ngay),
                new SqlParameter("@sotien",a.Sotien),
            };
            return DBConnect.ExecuteNonQuery("Change_QuyetDinhKyLuat", para);
        }
        public static int DELETE_QuyetDinhKyLuat(string Nhanvienma)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@nhanvienma",Nhanvienma),
            };
            return DBConnect.ExecuteNonQuery("DELETE_QuyetDinhKyLuat", para);
        }
        #endregion

        #region QuyetDinhKhenThuong
        public static DataTable xuat_QuyetDinhKhenThuong()
        {
            return DBConnect.GetData("QuyetDinhKhenThuong");
        }
        public static int ADD_QuyetDinhKhenThuong(QuyetDinhKhenThuong a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@nhanvienma",a.Nhanvienma),
                new SqlParameter("@khenthuongma",a.Khenthuongma),
                new SqlParameter("@ngay",a.Ngay),
                new SqlParameter("@sotien",a.Sotien),
            };
            return DBConnect.ExecuteNonQuery("ADD_QuyetDinhKhenThuong", para);
        }
        public static int Change_QuyetDinhKhenThuong(QuyetDinhKhenThuong a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@sotien",a.Sotien),
            };
            return DBConnect.ExecuteNonQuery("Change_QuyetDinhKhenThuong", para);
        }
        public static int DELETE_QuyetDinhKhenThuong(string Nhanvienma)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@nhanvienma",Nhanvienma),
            };
            return DBConnect.ExecuteNonQuery("DELETE_QuyetDinhKhenThuong", para);
        }
        #endregion

        #region PhongBan
        public static DataTable xuat_PhongBan()
        {
            return DBConnect.GetData("PhongBan");
        }
        public static int them_phongban(PhongBan a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",a.Ma),
                new SqlParameter("@ten",a.Ten),
                new SqlParameter("@diachi",a.Diachi),
                new SqlParameter("@sodienthoai",a.Sodienthoai),
                new SqlParameter("@email",a.Email),
            };
            return DBConnect.ExecuteNonQuery("them_phongban", para);
        }
        public static int capnhap_phongban(PhongBan a)
        {
            SqlParameter[] para = new SqlParameter[]
            {

                new SqlParameter("@ten",a.Ten),
                new SqlParameter("@diachi",a.Diachi),
                new SqlParameter("@sodienthoai",a.Sodienthoai),
                new SqlParameter("@email",a.Email),
            };
            return DBConnect.ExecuteNonQuery("capnhat_phongban", para);
        }
        public static int xoa_phongban(string Ma)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",Ma),
            };
            return DBConnect.ExecuteNonQuery("xoa_phongban", para);
        }
        #endregion

        #region TrinhDoHocVan
        public static DataTable xuat_TrinhDoHocVan()
        {
            return DBConnect.GetData("TrinhDoHocVan");
        }
        public static int them_trinhdohocvan(TrinhDoHocVan a)
        {
            {
                SqlParameter[] para = new SqlParameter[]
                {
                    new SqlParameter("@ma",a.Ma),
                    new SqlParameter("@ten",a.Ten),
                    new SqlParameter("@chuthich",a.Chuthich),
                };
                return DBConnect.ExecuteNonQuery("them_trinhdohocvan", para);
            }
        }
        public static int capnhat_trinhdohocvan(TrinhDoHocVan a)
        {
            {
                SqlParameter[] para = new SqlParameter[]
                {
                    new SqlParameter("@ma",a.Ma),
                    new SqlParameter("@ten",a.Ten),
                    new SqlParameter("@chuthich",a.Chuthich),
                };
                return DBConnect.ExecuteNonQuery("capnhat_trinhdohocvan", para);
            }
        }
        public static int xoa_trinhdohocvan(string Ma)
        {
            {
                SqlParameter[] para = new SqlParameter[]
                {
                    new SqlParameter("@ma",Ma)
                };
                return DBConnect.ExecuteNonQuery("xoa_trinhdohocvan", para);
            }
        }
        #endregion

        #region TrinhDoNgoaiNgu
        public static DataTable xuat_TrinhDoNgoaiNgu()
        {
            return DBConnect.GetData("TrinhDoNgoaiNgu");
        }
        public static int them_trinhdongoaingu(TrinhDoNgoaiNgu a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                    new SqlParameter("@ma",a.Ma),
                    new SqlParameter("@ten",a.Ten),
                    new SqlParameter("@ngonngu",a.Ngonngu),
                    new SqlParameter("@chuthich",a.Chuthich),
            };
            return DBConnect.ExecuteNonQuery("them_trinhdongoaingu", para);
        }
        public static int capnhat_trinhdongoaingu(TrinhDoNgoaiNgu a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                    new SqlParameter("@ma",a.Ma),
                    new SqlParameter("@ten",a.Ten),
                    new SqlParameter("@ngonngu",a.Ngonngu),
                    new SqlParameter("@chuthich",a.Chuthich),
            };
            return DBConnect.ExecuteNonQuery("capnhat_trinhdongoaingu", para);
        }
        public static int xoa_trinhdongoaingu(string Ma)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                    new SqlParameter("@ma",Ma)
            };
            return DBConnect.ExecuteNonQuery("xoa_trinhdongoaingu", para);
        }
        #endregion

        #region ChucDanh
        public static DataTable xuat_ChucDanh()
        {
            return DBConnect.GetData("ChucDanh");
        }
        public static int them_chucdanh(ChucDanh a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                    new SqlParameter("@ma",a.Ma),
                    new SqlParameter("@ten",a.Ten),
                    new SqlParameter("@chuthich",a.Chuthich),
            };
            return DBConnect.ExecuteNonQuery("them_chucdanh", para);
        }
        public static int capnhat_chucdanh(ChucDanh a)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                    new SqlParameter("@ma",a.Ma),
                    new SqlParameter("@ten",a.Ten),
                    new SqlParameter("@chuthich",a.Chuthich),
            };
            return DBConnect.ExecuteNonQuery("capnhat_chucdanh", para);
        }
        public static int xoa_chucdanh(string Ma)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                    new SqlParameter("@ma",Ma)
            };
            return DBConnect.ExecuteNonQuery("xoa_chucdanh", para);
        }
        #endregion
    }
}
