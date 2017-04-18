using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.UC.MoRong
{
    public partial class UCNgoaiNgu : UserControl
    {
        private DTO.TrinhDoNgoaiNgu ngoaingu = new DTO.TrinhDoNgoaiNgu();
        public UCNgoaiNgu()
        {
            InitializeComponent();
        }

        private void btnThem_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pnlInput.Visible = true;
                btnSave.Text = ((Class.btnImage)sender).Text;
                txtTen.Text = "";
                txtNN.Text = "";
                txtCT.Text = "";
                switch (btnSave.Text)
                {
                    case "Thêm":
                        if (dgvNN.RowCount > 0)
                        {
                            txtMa.Text = (string)((DataTable)dgvNN.DataSource).Select("Mã is not null", "Mã DESC")[0].ItemArray[0];
                            txtMa.Text = "nn" + string.Format("{0:d3}", int.Parse(txtMa.Text.Replace("nn", "00")) + 1);
                        }
                        else txtMa.Text = "nn001";
                        break;
                    case "Sửa":
                        if (dgvNN.RowCount > 0)
                        {
                            txtMa.Text = dgvNN.CurrentRow.Cells[0].Value.ToString();
                            txtTen.Text = dgvNN.CurrentRow.Cells[1].Value.ToString();
                            txtNN.Text = dgvNN.CurrentRow.Cells[2].Value.ToString();
                            txtCT.Text = dgvNN.CurrentRow.Cells[3].Value.ToString();
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        private void btnKT_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pnlInput.Visible = false;
                txtMa.Text = "";
                txtTen.Text = "";
                txtNN.Text = "";
                txtCT.Text = "";
                btnXoa.Actived = true;
            }
        }

        private void btnXoa_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (pnlInput.Visible) pnlInput.Visible = false;

                if (dgvNN.RowCount > 0)
                {
                    MessageBox.Show("Đã xóa " + DTO.TrinhDoNgoaiNgu.Xoa((string)dgvNN.CurrentRow.Cells[0].Value).ToString());
                    LoadData();
                }

                txtMa.Text = "";
                txtTen.Text = "";
                txtNN.Text = "";
                txtCT.Text = "";
                btnXoa.Actived = true;
            }
        }

        private void dgvNN_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (pnlInput.Visible) pnlInput.Visible = false;
                txtMa.Text = "";
                txtTen.Text = "";
                txtCT.Text = "";
                txtNN.Text = "";
                btnXoa.Actived = true;
            }
        }

        private void btnSave_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ngoaingu.Ma = txtMa.Text;
                ngoaingu.Ten = txtTen.Text;
                ngoaingu.Ngonngu = txtNN.Text;
                ngoaingu.Chuthich = txtCT.Text;
                switch (btnSave.Text)
                {
                    case "Thêm":
                        MessageBox.Show("Đã thêm " + ngoaingu.Them().ToString());
                        txtMa.Text = "nn" + string.Format("{0:d3}", int.Parse(txtMa.Text.Replace("nn", "00")) + 1);
                        txtTen.Text = "";
                        txtCT.Text = "";
                        txtNN.Text = "";
                        LoadData();
                        break;
                    case "Sửa":
                        ngoaingu.Sua();
                        MessageBox.Show("Đã sửa " + ngoaingu.Sua().ToString());
                        txtMa.Text = "";
                        txtTen.Text = "";
                        txtCT.Text = "";
                        txtNN.Text = "";
                        btnXoa.Actived = true;
                        pnlInput.Visible = false;
                        LoadData();
                        break;
                    default:
                        break;
                }
            }
        }

        private void LoadData()
        {
            dgvNN.DataSource = DTO.TrinhDoNgoaiNgu.Get_NgoaiNgu();
        }

        private void UCNgoaiNgu_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
