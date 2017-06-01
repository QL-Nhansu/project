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
    public partial class UCBangCong : UserControl
    {
        DataTable data;
        DateTime date;
        public UCBangCong()
        {
            InitializeComponent();
        }

        private void txtNam_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FillData();
            }
            if ((e.KeyValue < 48 || e.KeyValue > 57) && e.KeyData != Keys.Back)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private void FillData()
        {
            data = DTO.ChamCong.Get_BangChamCong(int.Parse(txtThang.Text), int.Parse(txtNam.Text));
            date = new DateTime(int.Parse(txtNam.Text), int.Parse(txtThang.Text), 1);

            dgvBC.Rows.Clear();
            int songay = DateTime.DaysInMonth(date.Year, date.Month);

            for (int i = songay+1; i <= 31; i++)
            {
                dgvBC.Columns[i + 1].Visible = false;
            }

            string ngaylam = "", ngaynghicoluong = "";

            for (int index = 0; index < data.Rows.Count; index++)
            {
                dgvBC.Rows.Add(data.Rows[index].ItemArray[2], data.Rows[index].ItemArray[3]);
                ngaylam = data.Rows[index].ItemArray[4].ToString();
                ngaynghicoluong = data.Rows[index].ItemArray[5].ToString();
                dgvBC.Rows[index].Cells[33].Value = 0;
                for (int i = 1; i <= songay; i++)
                {
                    if ((ngaylam != null && ngaylam.Contains(" " + i + " ")) || (ngaynghicoluong != null && ngaynghicoluong.Contains(" " + i + " ")))
                    {
                        dgvBC.Rows[index].Cells[i + 1].Value = "X";
                        dgvBC.Rows[index].Cells[33].Value = (int)dgvBC.Rows[index].Cells[33].Value + 1;
                    }
                    else dgvBC.Rows[index].Cells[i + 1].Value = "O";
                }
            }
        }

        private void UCBangCong_Load(object sender, EventArgs e)
        {
            txtThang.Text = DateTime.Today.Month.ToString();
            txtNam.Text = DateTime.Today.Year.ToString();
            FillData();
        }
    }
}
