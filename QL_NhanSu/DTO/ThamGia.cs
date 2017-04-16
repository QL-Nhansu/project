using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThamGia
    {
        private string manhanvien;
        private string maphongban;
        private DateTime ngaythamgia;
        private DateTime ngayroidi;

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

        public DateTime Ngaythamgia
        {
            get
            {
                return ngaythamgia;
            }

            set
            {
                ngaythamgia = value;
            }
        }

        public DateTime Ngayroidi
        {
            get
            {
                return ngayroidi;
            }

            set
            {
                ngayroidi = value;
            }
        }

        public static int Xoa(string manhanvien, string maphongban, DateTime ngaythamgia)
        {
            return DATA.xoa_thamgia(manhanvien, maphongban, ngaythamgia);
        }
        public int Them()
        {
            return DATA.them_thamgia(manhanvien, maphongban, ngaythamgia, ngayroidi);
        }
        public int Sua()
        {
            return DATA.sua_thamgia(manhanvien, maphongban, ngaythamgia, ngayroidi);
        }
    }
}
