using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class QuyetDinhKyLuat_DTO
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
    }
}

