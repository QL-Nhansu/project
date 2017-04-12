using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
namespace DTO
{
    public class KhenThuong
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
        public static DataTable Xem_KT()
        {
            return DATA.xuat_KhenThuong();
        }
        public int Them_KT()
        {
            return DATA.ADD_KhenThuong(ma, ten, sotien);
        }
        public int Sua_KT()
        {
            return DATA.Change_KhenThuong(ma, ten, sotien);
        }
        public static int Xoa_KT(string ma)
        {
            return DATA.DELETE_KhenThuong(ma);
        }
    }
}
