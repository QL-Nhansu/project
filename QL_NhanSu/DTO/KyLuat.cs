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

        public int Them_KL(string ma, string ten, decimal sotien)
        {
            return DATA.ADD_Kyluat(ma, ten, sotien);
        }
        public int Sua_KL(string ma, string ten, decimal sotien)
        {
            return DATA.Change_Kyluat(ma, ten,sotien);
        }
        public static int Xoa_KL(string ma)
        {
            return DATA.DELETE_Kyluat(ma);
        }
        public static DataTable Xem_KL()
        {
            return DATA.xuat_KyLuat();
        }
    }
}
