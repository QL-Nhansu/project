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
        public static DataTable Xem_NN()
        {
            return DATA.xuat_TrinhDoNgoaiNgu();
        }
        public int Them_NN()
        {
            return DATA.them_trinhdongoaingu(ma, ten, ngonngu, chuthich);
        }
        public  int Sua_NN()
        {
            return DATA.capnhat_trinhdongoaingu(ma, ten, ngonngu, chuthich);
        }
        public static int Xoa_NN(string ma)
        {
            return DATA.xoa_trinhdongoaingu(ma);
        }
    }
}
