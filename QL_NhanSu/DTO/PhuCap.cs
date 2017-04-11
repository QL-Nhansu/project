using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace DTO
{
    public class PhuCap
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
        public static DataTable get_PC ()
        {
            return DATA.xuat_phucap();
        }
        public static int Xoa_pc(string ma)
        {
            return DATA.xoa_phucap(ma);
        }
        public int Them_pc(string ma, string ten, decimal tien)
        {
            return DATA.them_phucap(ma, ten, tien);
        }
        public int Sua_pc(string ma, string ten, decimal tien)
        {
            return DATA.capnhat_phucap(ma, ten, tien);
        }
    }
}
