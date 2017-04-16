using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class QuyetDinhKyLuat
    {
        private string nhanvienma;
        private string kyluatma;
        private DateTime ngay;
        private decimal sotien;

        public decimal Sotien
        {
            get
            {
                return sotien;
            }

            set
            {
                sotien = value;
            }
        }

        public string Nhanvienma
        {
            get
            {
                return nhanvienma;
            }

            set
            {
                nhanvienma = value;
            }
        }

        public string Kyluatma
        {
            get
            {
                return kyluatma;
            }

            set
            {
                kyluatma = value;
            }
        }

        public DateTime Ngay
        {
            get
            {
                return ngay;
            }

            set
            {
                ngay = value;
            }
        }

        public static int Xoa(string nhanvienma, string kyluatma, DateTime ngay)
        {
            return DATA.xoa_QDKL(nhanvienma, kyluatma, ngay);
        }
        public int Them()
        {
            return DATA.them_QDKL(nhanvienma, kyluatma, ngay, sotien);
        }
        public int Sua()
        {
            return DATA.sua_QDKL(nhanvienma, kyluatma, ngay, sotien);
        }
    }
}

