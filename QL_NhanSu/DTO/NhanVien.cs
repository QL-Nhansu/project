using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace DTO
{
    public class NhanVien
    {
        private string ma;
        private string ten;
        private DateTime ngaysinh;
        private int gioitinh;
        private string cmnd;
        private byte[] anh;
        private string dantoc;
        private string tongiao;
        private string sdt;
        private string email;
        private DateTime ngaykihopdong;
        private DateTime ngayhethanhopdong;
        private string matkhau;
        private string mangoaingu;
        private string machucdanh;
        private string mahocvan;

        public string Ma
        {
            get
            {
                return ma;
            }

            set
            {
                ma = value;
            }
        }

        public string Ten
        {
            get
            {
                return ten;
            }

            set
            {
                ten = value;
            }
        }

        public DateTime Ngaysinh
        {
            get
            {
                return ngaysinh;
            }

            set
            {
                ngaysinh = value;
            }
        }

        public int Gioitinh
        {
            get
            {
                return gioitinh;
            }

            set
            {
                gioitinh = value;
            }
        }

        public string Cmnd
        {
            get
            {
                return cmnd;
            }

            set
            {
                cmnd = value;
            }
        }

        public byte[] Anh
        {
            get
            {
                return anh;
            }

            set
            {
                anh = value;
            }
        }

        public string Dantoc
        {
            get
            {
                return dantoc;
            }

            set
            {
                dantoc = value;
            }
        }

        public string Tongiao
        {
            get
            {
                return tongiao;
            }

            set
            {
                tongiao = value;
            }
        }

        public string Sdt
        {
            get
            {
                return sdt;
            }

            set
            {
                sdt = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public DateTime Ngaykihopdong
        {
            get
            {
                return ngaykihopdong;
            }

            set
            {
                ngaykihopdong = value;
            }
        }

        public DateTime Ngayhethanhopdong
        {
            get
            {
                return ngayhethanhopdong;
            }

            set
            {
                ngayhethanhopdong = value;
            }
        }

        public string Matkhau
        {
            get
            {
                return matkhau;
            }

            set
            {
                matkhau = value;
            }
        }

        public string Mangoaingu
        {
            get
            {
                return mangoaingu;
            }

            set
            {
                mangoaingu = value;
            }
        }

        public string Machucdanh
        {
            get
            {
                return machucdanh;
            }

            set
            {
                machucdanh = value;
            }
        }

        public string Mahocvan
        {
            get
            {
                return mahocvan;
            }

            set
            {
                mahocvan = value;
            }
        }

        public static DataTable Get_DSNhanVien()
        {
            return DATA.get_dsnhanvien();
        }

        public static DataTable Get_NhanVien(string manv)
        {
            return DATA.get_nhanvien(manv);
        }

        public static DataTable Get_LichSuLV(string manv)
        {
            return DATA.get_lichsulv(manv);
        }

        public static DataTable Get_LichSuKT(string manv)
        {
            return DATA.get_lichsukt(manv);
        }

        public static DataTable Get_LichSuKL(string manv)
        {
            return DATA.get_lichsukl(manv);
        }

        public int Them()
        {
            return DATA.them_nhanvien(ma, ten, ngaysinh, gioitinh, cmnd, anh, dantoc, tongiao,
                sdt, email, Ngaykihopdong, ngayhethanhopdong, matkhau, mangoaingu, machucdanh, mahocvan);
        }
        public int Sua()
        {
            return DATA.sua_nhanvien(ma, ten, ngaysinh, gioitinh, cmnd, anh, dantoc, tongiao,
                sdt, email, Ngaykihopdong, ngayhethanhopdong, matkhau, mangoaingu, machucdanh, mahocvan);

        }
        public static int Xoa(string ma)
        {
            return DATA.xoa_nhanvien(ma);
        }
    }
}
