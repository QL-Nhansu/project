using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
namespace DTO
{
    public class TrinhDoHocVan
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
        public static DataTable Get_HocVan()
        {
            return DATA.get_hocvan();
        }
        public int Them()
        {
            return DATA.them_hocvan(ma, ten, chuthich);
        }
        public int Sua()
        {
            return DATA.sua_hocvan(ma, ten, chuthich);
        }
        public static int Xoa(string ma)
        {
            return DATA.xoa_hocvan(ma);
        }
    }
}