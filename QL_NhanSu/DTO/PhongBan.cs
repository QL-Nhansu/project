using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhongBan
    {
        private string ma;
        private string ten;
        private string diachi;
        private string sodienthoai;
        private string email;

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

        public string Diachi
        {
            get
            {
                return diachi;
            }

            set
            {
                diachi = value;
            }
        }

        public string Sodienthoai
        {
            get
            {
                return sodienthoai;
            }

            set
            {
                sodienthoai = value;
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

        public static DataTable Get_PhongBan()
        {
            return DAL.DATA.get_phongban();
        }
    }
}
