using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class KyLuat_DTO
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
    }
}
