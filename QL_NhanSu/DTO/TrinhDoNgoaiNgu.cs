using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
namespace DTO
{
    public  class TrinhDoNgoaiNgu
    {
        private string ma;
        private string ten;
        private string ngonngu;
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

        public string Ngonngu
        {
            get
            {
                return ngonngu;
            }

            set
            {
                ngonngu = value;
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
        public static DataTable Get_NgoaiNgu()
        {
            return DATA.get_ngoaingu();
        }
        public int Them()
        {
            return DATA.them_ngoaingu(ma, ten, ngonngu, chuthich);
        }
        public  int Sua()
        {
            return DATA.sua_ngoaingu(ma, ten, ngonngu, chuthich);
        }
        public static int Xoa(string ma)
        {
            return DATA.xoa_ngoaingu(ma);
        }
    }
}
