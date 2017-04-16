using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public  class TruongPhong
    {
        private string manhanvien;
        private string maphongban;
        private DateTime ngaybatdau;
        private DateTime ngayketthuc;

        public string Manhanvien
        {
            get
            {
                return manhanvien;
            }

            set
            {
                manhanvien = value;
            }
        }

        public string Maphongban
        {
            get
            {
                return maphongban;
            }

            set
            {
                maphongban = value;
            }
        }

        public DateTime Ngaybatdau
        {
            get
            {
                return ngaybatdau;
            }

            set
            {
                ngaybatdau = value;
            }
        }

        public DateTime Ngayketthu
        {
            get
            {
                return ngayketthuc;
            }

            set
            {
                ngayketthuc = value;
            }
        }

        public int Them()
        {
            return DATA.them_truongphong(manhanvien, maphongban, ngaybatdau, ngayketthuc);
        }
        public int Sua()
        {
            return DATA.sua_truongphong(manhanvien, maphongban, ngaybatdau, ngayketthuc);
        }
        public static int Xoa(string manhanvien, string maphongban, DateTime ngaybatdau)
        {
            return DATA.xoa_truongphong(manhanvien, maphongban, ngaybatdau);
        }
    }
}
