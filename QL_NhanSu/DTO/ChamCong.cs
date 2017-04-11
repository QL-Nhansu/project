using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace DTO
{
    public class ChamCong
    {

        private DateTime dateend;
        private decimal luongcoban;
        private int songaylam;
        private int songaynghicoluong;
        private string nhanvienma;
        private string ngaydilam;

        public DateTime Dateend
        {
            get
            {
                return dateend;
            }

            set
            {
                dateend = value;
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

        public int Songaylam
        {
            get
            {
                return songaylam;
            }

            set
            {
                songaylam = value;
            }
        }

        public int Songaynghicoluong
        {
            get
            {
                return songaynghicoluong;
            }

            set
            {
                songaynghicoluong = value;
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
        public int ADD_CC(DateTime dateend, decimal luongcoban, int songaylam, int songaynghicoluong, string nhanvienma, string ngaydilam)
        {
            return DATA.ADD_ChamCong(dateend,luongcoban,songaylam,songaynghicoluong,nhanvienma,ngaydilam);
        }
        public static int Xem_CC(DateTime dateend)
        {
            return DATA.VIEW_ChamCong(dateend);
        }

    }
}
