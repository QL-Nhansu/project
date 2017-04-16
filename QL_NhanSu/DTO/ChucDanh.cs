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
        private decimal luongcoban;
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

        public decimal Luongcoban
        {
            get
            {
                return luongcoban;
            }

            set
            {
                luongcoban = value;
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

        public static DataTable Get_ChucDanh()
        {
            return DATA.get_chucdanh();
        }
        
        public int Them()
        {
            return DATA.them_chucdanh(ma, ten, luongcoban, chuthich);
        }
        public int Sua()
        {
            return DATA.sua_chucdanh(ma, ten, luongcoban, chuthich);
        }
        public static int Xoa(string ma)
        {
            return DATA.xoa_chucdanh(ma);
        }
    }
}
