using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO

{
    public class QuyetDinhKhenThuong
    {
        private string nhanvienma;
        private string khenthuongma;
        private DateTime ngay;
        private decimal sotien;

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

        public string Khenthuongma
        {
            get
            {
                return khenthuongma;
            }

            set
            {
                khenthuongma = value;
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

        public static int Xoa(string nhanvienma, string khenthuongma, DateTime ngay)
        {
            return DATA.xoa_QDKT(nhanvienma, khenthuongma, ngay);
        }
        public int Them()
        {
            return DATA.them_QDKT(nhanvienma, khenthuongma, ngay, sotien);
        }
        public int Sua()
        {
            return DATA.sua_QDKT(nhanvienma, khenthuongma, ngay, sotien);
        }
    }
}
