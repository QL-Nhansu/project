using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
namespace DTO
{
    public class KyLuat
    {
        private string ma;
        private string ten;
        private decimal sotien;

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

        public static DataTable Get_KyLuat()
        {
            return DATA.get_kyluat();
        }
        public int Them()
        {
            return DATA.them_kyluat(ma, ten, sotien);
        }
        public int Sua()
        {
            return DATA.sua_kyluat(ma, ten,sotien);
        }
        public static int Xoa(string ma)
        {
            return DATA.xoa_kyluat(ma);
        }
    }
}
