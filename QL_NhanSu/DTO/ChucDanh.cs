using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
namespace DTO
{
    public class ChucDanh
    {
        private string ma;
        private string ten;
        private string chuthich;

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

        public string Chuthich
        {
            get
            {
                return chuthich;
            }

            set
            {
                chuthich = value;
            }
        }
        public int Them_CD()
        {
            return DATA.them_chucdanh(ma, ten, chuthich);
        }
        public int Sua_CD()
        {
            return DATA.capnhat_chucdanh(ma, ten, chuthich);
        }
        public static int Xoa_CD(string ma)
        {
            return DATA.xoa_chucdanh(ma);
        }
        public static DataTable Xem_CD()
        {
            return DATA.xuat_ChucDanh();
        }
    }
}
