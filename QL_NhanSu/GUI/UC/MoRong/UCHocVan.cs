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
    public partial class UCHocVan : UserControl
    {
        private DTO.TrinhDoHocVan hocvan = new DTO.TrinhDoHocVan();
        public UCHocVan()
        {
            InitializeComponent();
        }

        private void btnThem_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                pnlInput.Visible = true;
                btnSave.Text = ((Class.btnImage)sender).Text;
                txtTen.Text = "";
                txtCT.Text = "";
                switch (btnSave.Text)
                {
                    case "Thêm":
                        if (dgvHV.RowCount > 0)
                        {
                            txtMa.Text = (string)((DataTable)dgvHV.DataSource).Select("Mã is not null", "Mã DESC")[0].ItemArray[0];
                            txtMa.Text = "hv" + string.Format("{0:d3}", int.Parse(txtMa.Text.Replace("hv", "00")) + 1);
                        }
                        else txtMa.Text = "hv001";
                        break;
                    case "Sửa":
                        if (dgvHV.RowCount > 0)
                        {
                            txtMa.Text = dgvHV.CurrentRow.Cells[0].Value.ToString();
                            txtTen.Text = dgvHV.CurrentRow.Cells[1].Value.ToString();
                            txtCT.Text = dgvHV.CurrentRow.Cells[2].Value.ToString();
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
                txtCT.Text = "";
                btnXoa.Actived = true;
            }
        }

        private void btnXoa_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                if (pnlInput.Visible) pnlInput.Visible = false;

                //xoa doi tuong

                txtMa.Text = "";
                txtTen.Text = "";
                txtCT.Text = "";
                btnXoa.Actived = true;
            }
        }

        private void LoadData()
        {
            dgvHV.DataSource = DTO.TrinhDoHocVan.Get_HocVan();
        }

        private void UCHocVan_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSave_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                hocvan.Ma = txtMa.Text;
                hocvan.Ten = txtTen.Text;
                hocvan.Chuthich = txtCT.Text;
                switch (btnSave.Text)
                {
                    case "Thêm":
                        MessageBox.Show("Đã thêm " + hocvan.Them().ToString());
                        txtMa.Text = "hv" + string.Format("{0:d3}", int.Parse(txtMa.Text.Replace("hv", "00")) + 1);
                        txtTen.Text = "";
                        txtCT.Text = "";
                        LoadData();
                        break;
                    case "Sửa":
                        hocvan.Sua();
                        MessageBox.Show("Đã sửa " + hocvan.Sua().ToString());
                        txtMa.Text = "";
                        txtTen.Text = "";
                        txtCT.Text = "";
                        btnXoa.Actived = true;
                        pnlInput.Visible = false;
                        LoadData();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
