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
        public static DataTable Get_KhenThuong()
        {
            return DATA.get_khenthuong();
        }
        public int Them()
        {
            return DATA.them_khenthuong(ma, ten, sotien);
        }
        public int Sua()
        {
            return DATA.sua_khenthuong(ma, ten, sotien);
        }
        public static int Xoa(string ma)
        {
            return DATA.xoa_khenthuong(ma);
        }
    }
}
