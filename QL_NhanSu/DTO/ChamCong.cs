using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace DTO
{
    public class ChamCong
    {
        private int thang;
        private int nam;
        private string nhanvienma;
        private decimal luongcoban;
        private string ngaydilam;
        private string ngaynghicoluong;

        public int Thang
        {
            get
            {
                return thang;
            }

            set
            {
                thang = value;
            }
        }

        public int Nam
        {
            get
            {
                return nam;
            }

            set
            {
                nam = value;
            }
        }

        public string Nhanvienma
        {
            get
            {
                return nhanvienma;
            }

            set
            {
                nhanvienma = value;
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

        public string Ngaydilam
        {
            get
            {
                return ngaydilam;
            }

            set
            {
                ngaydilam = value;
            }
        }

        public string Ngaynghicoluong
        {
            get
            {
                return ngaynghicoluong;
            }

            set
            {
                ngaynghicoluong = value;
            }
        }

        public static DataTable Get_BangChamCong(int thang, int nam)
        {
            return DATA.get_bangchamcong(thang, nam);
        }
        public static DataTable Get_ChamCongNhanVien(int thang, int nam)
        {
            return DATA.get_chamcongnv(thang, nam);
        }
        public int Sua()
        {
            return DATA.sua_chamcong(thang, nam, nhanvienma, luongcoban, ngaydilam, ngaynghicoluong);
        }
        public static int Xoa(int thang, int nam, string nhanvienma)
        {
            return DATA.xoa_chamcong(thang, nam, nhanvienma);
        }
    }
}
