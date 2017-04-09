using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO

{
    public class NhanVien_PhuCap
    {
        private string manv;
        private string mapc;
        private DateTime ngaynhan;
        private DateTime ngayhethan;

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

        public string Mapc
        {
            get
            {
                return mapc;
            }

            set
            {
                mapc = value;
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
    }
}

