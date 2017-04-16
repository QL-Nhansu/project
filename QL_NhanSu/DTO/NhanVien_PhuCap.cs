using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO

{
    public class NhanVien_PhuCap
    {
        private string manhanvien;
        private string maphucap;
        private DateTime ngaynhan;
        private DateTime ngayhethan;

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

        public string Maphucap
        {
            get
            {
                return maphucap;
            }

            set
            {
                maphucap = value;
            }
        }

        public DateTime Ngaynhan
        {
            get
            {
                return ngaynhan;
            }

            set
            {
                ngaynhan = value;
            }
        }

        public DateTime Ngayhethan
        {
            get
            {
                return ngayhethan;
            }

            set
            {
                ngayhethan = value;
            }
        }

        public int Them()
        {
            return DATA.them_NVPC(manhanvien, maphucap, ngaynhan, ngayhethan);
        }
        public int Sua()
        {
            return DATA.sua_NVPC(manhanvien, maphucap, ngaynhan, ngayhethan);
        }
        public static int Xoa(string manhanvien, string maphucap, DateTime ngaynhan)
        {
            return DATA.xoa_NVPC(manhanvien, maphucap, ngaynhan);
        }
    }
}

