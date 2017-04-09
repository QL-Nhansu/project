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
        public static int ADD_ChamCong(DateTime dateend, decimal luongcoban, int songaylam, int songaynghicoluong, string nhanvienma, string ngaydilam)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@dateend",dateend),
                new SqlParameter("@luongcoban",luongcoban),
                new SqlParameter("@songaylam",songaylam),
                new SqlParameter("@songaynghicoluong",songaynghicoluong),
                new SqlParameter("@nhanvienma",nhanvienma),
                new SqlParameter("@ngaydilam",ngaydilam),
            };
            return DBConnect.ExecuteNonQuery("ADD_ChamCong", para);
        }
        public static int Change_ChamCong(DateTime dateend, decimal luongcoban, int songaylam, int songaynghicoluong, string nhanvienma, string ngaydilam)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@dateend",dateend),
                new SqlParameter("@luongcoban",luongcoban),
                new SqlParameter("@songaylam",songaylam),
                new SqlParameter("@songaynghicoluong",songaynghicoluong),
                new SqlParameter("@nhanvienma",nhanvienma),
                new SqlParameter("@ngaydilam",ngaydilam),
            };
            return DBConnect.ExecuteNonQuery("Change_ChamCong", para);
        }
        public static int DELETE_ChamCong(string dateend)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@dateend",dateend),
            };
            return DBConnect.ExecuteNonQuery("DELETE_ChamCong", para);
        }

        #endregion

        #region KyLuat
        public static DataTable xuat_KyLuat()
        {
            return DBConnect.GetData("KyLuat");
        }
        public static int ADD_Kyluat(string ma, string ten, decimal sotien)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",ma),
                new SqlParameter("@ten",ten),
                new SqlParameter("@sotien",sotien),
            };
            return DBConnect.ExecuteNonQuery("ADD_Kyluat", para);
        }
        public static int Change_Kyluat(string ma, string ten, decimal sotien)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",ma),
                new SqlParameter("@ten",ten),
                new SqlParameter("@sotien",sotien),
            };
            return DBConnect.ExecuteNonQuery("Change_Kyluat", para);
        }
        public static int DELETE_Kyluat(string ma)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",ma),
            };
            return DBConnect.ExecuteNonQuery("DELETE_Kyluat", para);
        }
        #endregion

        #region KhenThuong
        public static DataTable xuat_KhenThuong()
        {
            return DBConnect.GetData("KhenThuong");
        }
        public static int ADD_KhenThuong(string ma, string ten, decimal sotien)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",ma),
                new SqlParameter("@ten",ten),
                new SqlParameter("@sotien",sotien),
            };
            return DBConnect.ExecuteNonQuery("ADD_KhenThuong", para);
        }
        public static int Change_KhenThuong(string ma, string ten, decimal sotien)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",ma),
                new SqlParameter("@ten",ten),
                new SqlParameter("@sotien",sotien),
            };
            return DBConnect.ExecuteNonQuery("Change_KhenThuong", para);
        }
        public static int DELETE_KhenThuong(string ma)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",ma),
            };
            return DBConnect.ExecuteNonQuery("DELETE_KhenThuong", para);
        }
        #endregion

        #region Nhanvien
        public static DataTable xuat_Nhanvien()
        {
            return DBConnect.GetData("NhanVien");
        }
        public static int ADD_Nhanvien(string ma, string ten, DateTime ngaysinh, string gioitinh, int cmnd, object anh, string dantoc, string tongiao, string trinhdongoainguma, string chucdanhma, string trinhdohocvanma, DateTime ngaykihopdong, DateTime ngayhethanhopdong, string matkhau)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",ma),
                new SqlParameter("@ten",ten),
                new SqlParameter("@ngaysinh",ngaysinh),
                new SqlParameter("@gioitinh",gioitinh),
                new SqlParameter("@dantoc",dantoc),
                new SqlParameter("@cmnd",cmnd),
                new SqlParameter("@anh",anh),
                new SqlParameter("@tongiao",tongiao),
                new SqlParameter("@trinhdongoainguma",trinhdongoainguma),
                new SqlParameter("@trinhdohocvanma",trinhdohocvanma),
                new SqlParameter("@chucdanhma",chucdanhma),
                new SqlParameter("@ngaykihopdong",ngaykihopdong),
                new SqlParameter("@ngayhethanhopdong",ngayhethanhopdong),
                new SqlParameter("@matkhau",matkhau),
            };
            return DBConnect.ExecuteNonQuery("ADD_Nhanvien", para);
        }
        public static int Change_Nhanvien(string ma, string ten, DateTime ngaysinh, string gioitinh, int cmnd, object anh, string dantoc, string tongiao, string trinhdongoainguma, string chucdanhma, string trinhdohocvanma)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",ma),
                new SqlParameter("@ten",ten),
                new SqlParameter("@ngaysinh",ngaysinh),
                new SqlParameter("@gioitinh",gioitinh),
                new SqlParameter("@dantoc",dantoc),
                new SqlParameter("@cmnd",cmnd),
                new SqlParameter("@anh",anh),
                new SqlParameter("@tongiao",tongiao),
                new SqlParameter("@trinhdongoainguma",trinhdongoainguma),
                new SqlParameter("@trinhdohocvanma",trinhdohocvanma),
                new SqlParameter("@chucdanhma",chucdanhma),
            };
            return DBConnect.ExecuteNonQuery("Change_Nhanvien", para);
        }
        public static int DELETE_Nhanvien(string ma)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",ma),
            };
            return DBConnect.ExecuteNonQuery("DELETE_Nhanvien", para);
        }
        #endregion

        #region QuyetDinhKyLuat
        public static DataTable xuat_QuyetDinhKyLuat()
        {
            return DBConnect.GetData("QuyetDinhKyLuat");
        }
        public static int ADD_QuyetDinhKyLuat(string nhanvienma, string kyluatma, DateTime ngay, decimal sotien)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@nhanvienma",nhanvienma),
                new SqlParameter("@kyluatma",kyluatma),
                new SqlParameter("@ngay",ngay),
                new SqlParameter("@sotien",sotien),
            };
            return DBConnect.ExecuteNonQuery("ADD_QuyetDinhKyLuat", para);
        }
        public static int Change_QuyetDinhKyLuat(string nhanvienma, string kyluatma, DateTime ngay, decimal sotien)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@nhanvienma",nhanvienma),
                new SqlParameter("@kyluatma",kyluatma),
                new SqlParameter("@ngay",ngay),
                new SqlParameter("@sotien",sotien),
            };
            return DBConnect.ExecuteNonQuery("Change_QuyetDinhKyLuat", para);
        }
        public static int DELETE_QuyetDinhKyLuat(string nhanvienma)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@nhanvienma",nhanvienma),
            };
            return DBConnect.ExecuteNonQuery("DELETE_QuyetDinhKyLuat", para);
        }
        #endregion

        #region QuyetDinhKhenThuong
        public static DataTable xuat_QuyetDinhKhenThuong()
        {
            return DBConnect.GetData("QuyetDinhKhenThuong");
        }
        public static int ADD_QuyetDinhKhenThuong(string nhanvienma, string khenthuongma, DateTime ngay, decimal sotien)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@nhanvienma",nhanvienma),
                new SqlParameter("@khenthuongma",khenthuongma),
                new SqlParameter("@ngay",ngay),
                new SqlParameter("@sotien",sotien),
            };
            return DBConnect.ExecuteNonQuery("ADD_QuyetDinhKhenThuong", para);
        }
        public static int Change_QuyetDinhKhenThuong( decimal sotien)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@sotien",sotien),
            };
            return DBConnect.ExecuteNonQuery("Change_QuyetDinhKhenThuong", para);
        }
        public static int DELETE_QuyetDinhKhenThuong(string nhanvienma)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@nhanvienma",nhanvienma),
            };
            return DBConnect.ExecuteNonQuery("DELETE_QuyetDinhKhenThuong", para);
        }
        #endregion

        #region PhongBan
        public static DataTable xuat_PhongBan()
        {
            return DBConnect.GetData("PhongBan");
        }
        public static int them_phongban(string ma, string ten, string diachi, string sodienthoai, string email)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",ma),
                new SqlParameter("@ten",ten),
                new SqlParameter("@diachi",diachi),
                new SqlParameter("@sodienthoai",sodienthoai),
                new SqlParameter("@email",email),
            };
            return DBConnect.ExecuteNonQuery("them_phongban", para);
        }
        public static int capnhap_phongban(string ma, string ten, string diachi, string sodienthoai, string email)
        {
            SqlParameter[] para = new SqlParameter[]
            {

                new SqlParameter("@ten",ten),
                new SqlParameter("@diachi",diachi),
                new SqlParameter("@sodienthoai",sodienthoai),
                new SqlParameter("@email",email),
            };
            return DBConnect.ExecuteNonQuery("capnhat_phongban", para);
        }
        public static int xoa_phongban(string ma)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",ma),
            };
            return DBConnect.ExecuteNonQuery("xoa_phongban", para);
        }
        #endregion

        #region TrinhDoHocVan
        public static DataTable xuat_TrinhDoHocVan()
        {
            return DBConnect.GetData("TrinhDoHocVan");
        }
        public static int them_trinhdohocvan(string ma, string ten, string chuthich)
        {
            {
                SqlParameter[] para = new SqlParameter[]
                {
                    new SqlParameter("@ma",ma),
                    new SqlParameter("@ten",ten),
                    new SqlParameter("@chuthich",chuthich),
                };
                return DBConnect.ExecuteNonQuery("them_trinhdohocvan", para);
            }
        }
        public static int capnhat_trinhdohocvan(string ma, string ten, string chuthich)
        {
            {
                SqlParameter[] para = new SqlParameter[]
                {
                    new SqlParameter("@ma",ma),
                    new SqlParameter("@ten",ten),
                    new SqlParameter("@chuthich",chuthich),
                };
                return DBConnect.ExecuteNonQuery("capnhat_trinhdohocvan", para);
            }
        }
        public static int xoa_trinhdohocvan(string ma)
        {
            {
                SqlParameter[] para = new SqlParameter[]
                {
                    new SqlParameter("@ma",ma)
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
        public static int them_trinhdongoaingu(string ma, string ten, string ngonngu, string chuthich)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                    new SqlParameter("@ma",ma),
                    new SqlParameter("@ten",ten),
                    new SqlParameter("@ngonngu",ngonngu),
                    new SqlParameter("@chuthich",chuthich),
            };
            return DBConnect.ExecuteNonQuery("them_trinhdongoaingu", para);
        }
        public static int capnhat_trinhdongoaingu(string ma, string ten, string ngonngu, string chuthich)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                    new SqlParameter("@ma",ma),
                    new SqlParameter("@ten",ten),
                    new SqlParameter("@ngonngu",ngonngu),
                    new SqlParameter("@chuthich",chuthich),
            };
            return DBConnect.ExecuteNonQuery("capnhat_trinhdongoaingu", para);
        }
        public static int xoa_trinhdongoaingu(string ma)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                    new SqlParameter("@ma",ma)
            };
            return DBConnect.ExecuteNonQuery("xoa_trinhdongoaingu", para);
        }
        #endregion

        #region ChucDanh
        public static DataTable xuat_ChucDanh()
        {
            return DBConnect.GetData("ChucDanh");
        }
        public static int them_chucdanh(string ma, string ten, string chuthich)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                    new SqlParameter("@ma",ma),
                    new SqlParameter("@ten",ten),
                    new SqlParameter("@chuthich",chuthich),
            };
            return DBConnect.ExecuteNonQuery("them_chucdanh", para);
        }
        public static int capnhat_chucdanh(string ma, string ten, string chuthich)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                    new SqlParameter("@ma",ma),
                    new SqlParameter("@ten",ten),
                    new SqlParameter("@chuthich",chuthich),
            };
            return DBConnect.ExecuteNonQuery("capnhat_chucdanh", para);
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
    }
}
