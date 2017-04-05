using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
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
    }
}
