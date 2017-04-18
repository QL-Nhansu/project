using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.UC.QLCong
{
    public partial class UCChamCong : UserControl
    {
        DataTable data;
        DataView dataview;
        DTO.ChamCong chamcong = new DTO.ChamCong();
        DateTime date = DateTime.Today;
        public UCChamCong()
        {
            InitializeComponent();
        }

        private void UCChamCong_Load(object sender, EventArgs e)
        {
            data = DTO.ChamCong.Get_ChamCongNhanVien();
            cbxSort.SelectedIndex = 0;
        }

        private void FillData(DataView datatable)
        {
            dgvCC.Rows.Clear();
            bool dilam, nghicoluong;
            labNgay.Text = "Ngày " + date.ToShortDateString();
            foreach (DataRow row in datatable.Table.Rows)
            {
                dilam = row.ItemArray[5].ToString().Contains(date.Day.ToString());
                if (!dilam) nghicoluong = row.ItemArray[6].ToString().Contains(date.Day.ToString());
                else nghicoluong = false;
                dgvCC.Rows.Add(row.ItemArray[0], row.ItemArray[1], row.ItemArray[2], row.ItemArray[3], row.ItemArray[4], dilam, (!dilam && !nghicoluong), nghicoluong);
            }
        }

        private void dgvCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > 4 && !(bool)dgvCC.Rows[e.RowIndex].Cells[e.ColumnIndex].Value)
            {
                dgvCC.Rows[e.RowIndex].Cells[5].Value = false;
                dgvCC.Rows[e.RowIndex].Cells[6].Value = false;
                dgvCC.Rows[e.RowIndex].Cells[7].Value = false;
                dgvCC.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = true;
                chamcong.Nhanvienma = dgvCC.Rows[e.RowIndex].Cells[0].Value.ToString();
                chamcong.Thang = date.Month;
                chamcong.Nam = date.Year;

                foreach (DataRow row in data.Rows)
                {
                    if (row.ItemArray[0].ToString() == chamcong.Nhanvienma)
                    {
                        chamcong.Ngaydilam = row.ItemArray[5].ToString();
                        chamcong.Ngaynghicoluong = row.ItemArray[6].ToString();
                        chamcong.Luongcoban = (row.ItemArray[7].ToString() != "") ? decimal.Parse(row.ItemArray[7].ToString()) : -1; ;
                    }
                }

                switch (e.ColumnIndex)
                {
                    case 5:
                        chamcong.Ngaydilam += " " + date.Day + " ";
                        chamcong.Ngaynghicoluong = chamcong.Ngaynghicoluong.Replace(" " + date.Day + " ", "");
                        chamcong.Sua();
                        break;
                    case 6:
                        chamcong.Ngaydilam = chamcong.Ngaydilam.Replace(" " + date.Day + " ", "");
                        chamcong.Ngaynghicoluong = chamcong.Ngaynghicoluong.Replace(" " + date.Day + " ", "");
                        chamcong.Sua();
                        break;
                    case 7:
                        chamcong.Ngaydilam = chamcong.Ngaydilam.Replace(" " + date.Day + " ", "");
                        chamcong.Ngaynghicoluong += " " + date.Day + " ";
                        chamcong.Sua();
                        break;
                    default:
                        break;
                }

            }
        }

        private void cbxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataview = data.AsDataView();
            switch (cbxSort.Text)
            {
                case "Phòng ban, mã nv":
                    dataview.Sort = "[Tên phòng ban] ASC, [Mã nhân viên] ASC";
                    break;
                case "Chức vụ, mã nv":
                    dataview.Sort = "[Chức vụ] ASC, [Mã nhân viên] ASC";
                    break;
            }
            FillData(dataview);
        }
    }
}
