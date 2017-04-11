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
        public static DataTable Xem_HV()
        {
            return DATA.xuat_TrinhDoHocVan();
        }
        public int Them_HV(string ma, string ten, string chuthich)
        {
            return DATA.them_trinhdohocvan(ma, ten, chuthich);
        }
        public int Sua_HV(string ma, string ten, string chuthich)
        {
            return DATA.capnhat_trinhdohocvan(ma, ten, chuthich);
    }
        public static int Xoa_HV(string ma)
        {
            return DATA.xoa_trinhdohocvan(ma);
        }
    }
}