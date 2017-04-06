using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
   public  class TruongPhong_DTO
    {
        private string manv;
        private string mapb;
        private DateTime ngaybatdau;
        private string ngayketthuc;

        public string Manv
        {
            get
            {
                return manv;
            }

            set
            {
                manv = value;
            }
        }

        public string Mapb
        {
            get
            {
                return mapb;
            }

            set
            {
                mapb = value;
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

        public string Ngayketthuc
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
    }
}
