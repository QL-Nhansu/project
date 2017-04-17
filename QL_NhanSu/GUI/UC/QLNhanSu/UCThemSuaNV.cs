using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.UC.QLNhanSu
{
    public partial class UCThemSuaNV : UserControl
    {
        public enum ChucNang { Them, Sua }
        public static ChucNang chucnang = ChucNang.Them;
        public static string manv;
        private DTO.NhanVien nhanvien = new DTO.NhanVien();

        public UCThemSuaNV()
        {
            InitializeComponent();
        }

        private void UCThemSuaNV_Load(object sender, EventArgs e)
        {
            cbxChucVu.DataSource = DTO.ChucDanh.Get_ChucDanh();
            cbxChucVu.DisplayMember = "Tên chức danh";
            cbxChucVu.ValueMember = "Mã";
            cbxNgoaiNgu.DataSource = DTO.TrinhDoNgoaiNgu.Get_NgoaiNgu();
            cbxNgoaiNgu.DisplayMember = "Tên ngoại ngữ";
            cbxNgoaiNgu.ValueMember = "Mã";
            cbxHocVan.DataSource = DTO.TrinhDoHocVan.Get_HocVan();
            cbxHocVan.DisplayMember = "Tên học vấn";
            cbxHocVan.ValueMember = "Mã";
            txtMa.Text = manv;
            txtMa.Enabled = false;

            if (chucnang == ChucNang.Sua)
            {
                DataTable tb = DTO.NhanVien.Get_NhanVien(manv);
                if (tb.Rows[0].ItemArray[0] != DBNull.Value)
                    ptrAnh.Image = Image.FromStream(new System.IO.MemoryStream((byte[])tb.Rows[0].ItemArray[0]));
                txtHT.Text = (string)tb.Rows[0].ItemArray[2];
                if (tb.Rows[0].ItemArray[3] != DBNull.Value)
                {
                    txtNgay.Text = ((DateTime)tb.Rows[0].ItemArray[3]).Day.ToString();
                    txtThang.Text = ((DateTime)tb.Rows[0].ItemArray[3]).Month.ToString();
                    txtNam.Text = ((DateTime)tb.Rows[0].ItemArray[3]).Year.ToString();
                }
                rdbNu.Checked = ((string)tb.Rows[0].ItemArray[4] == "Nữ");
                rdbNam.Checked = !rdbNu.Checked;
                txtCMT.Text = (string)tb.Rows[0].ItemArray[5];
                cbxChucVu.Text = (tb.Rows[0].ItemArray[6] != DBNull.Value && (string)tb.Rows[0].ItemArray[6] != "") ? (string)tb.Rows[0].ItemArray[6] : "";
                txtDT.Text = (tb.Rows[0].ItemArray[7] != DBNull.Value) ? (string)tb.Rows[0].ItemArray[7] : "";
                txtTG.Text = (tb.Rows[0].ItemArray[8] != DBNull.Value) ? (string)tb.Rows[0].ItemArray[8] : "";
                txtSDT.Text = (tb.Rows[0].ItemArray[9] != DBNull.Value) ? (string)tb.Rows[0].ItemArray[9] : "";
                txtEmail.Text = (tb.Rows[0].ItemArray[10] != DBNull.Value) ? (string)tb.Rows[0].ItemArray[10] : "";
                cbxHocVan.Text = (tb.Rows[0].ItemArray[11] != DBNull.Value) ? (string)tb.Rows[0].ItemArray[11] : "";
                cbxNgoaiNgu.Text = (tb.Rows[0].ItemArray[12] != DBNull.Value) ? (string)tb.Rows[0].ItemArray[12] : "";
                if (tb.Rows[0].ItemArray[13] != DBNull.Value)
                {
                    txtNgayKHD.Text = ((DateTime)tb.Rows[0].ItemArray[13]).Day.ToString();
                    txtThangKHD.Text = ((DateTime)tb.Rows[0].ItemArray[13]).Month.ToString();
                    txtNamKHD.Text = ((DateTime)tb.Rows[0].ItemArray[13]).Year.ToString();
                }
                if (tb.Rows[0].ItemArray[14] != DBNull.Value)
                {
                    txtNgayHHD.Text = ((DateTime)tb.Rows[0].ItemArray[14]).Day.ToString();
                    txtThangHHD.Text = ((DateTime)tb.Rows[0].ItemArray[14]).Month.ToString();
                    txtNamHHD.Text = ((DateTime)tb.Rows[0].ItemArray[14]).Year.ToString();
                }
            }
        }

        private void btnBack_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Control ctrl = FormMain.stackControl.Pop();
                ctrl.Dispose();
                FormMain.stackControl.Pop().Visible = true;
            }
        }

        private void btnAnh_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                OpenFileDialog ifile = new OpenFileDialog();
                ifile.Title = "Chọn ảnh";
                ifile.Multiselect = false;
                ifile.Filter = "jpg files(*.jpg)|*.jpg| png files(*.png)|*.png";
                ifile.ShowDialog();
                try
                {
                    nhanvien.Anh = System.IO.File.ReadAllBytes(ifile.FileName);
                    ptrAnh.Image = Image.FromStream(new System.IO.MemoryStream(nhanvien.Anh));
                    btnAnh.Refresh();
                }
                catch (Exception)
                {
                    nhanvien.Anh = null;
                    ptrAnh.Image = null;
                    btnAnh.Refresh();
                }
            }
        }

        private void btnSave_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                nhanvien.Ma = txtMa.Text;
                nhanvien.Ten = txtHT.Text;
                nhanvien.Gioitinh = rdbNam.Checked ? 1 : 0;
                if (txtNam.Text != null && txtNam.Text.Trim() != "" && txtThang.Text != null && txtThang.Text.Trim() != "" && txtNgay.Text != null && txtNgay.Text.Trim() != "")
                    nhanvien.Ngaysinh = new DateTime(int.Parse(txtNam.Text), int.Parse(txtThang.Text), int.Parse(txtNgay.Text));
                else nhanvien.Ngaysinh = new DateTime(1000, 1, 1);
                nhanvien.Cmnd = txtCMT.Text;
                nhanvien.Dantoc = txtDT.Text;
                nhanvien.Tongiao = txtTG.Text;
                nhanvien.Matkhau = txtMK.Text;
                nhanvien.Sdt = txtSDT.Text;
                nhanvien.Email = txtEmail.Text;
                if (txtNamKHD.Text != null && txtNamKHD.Text.Trim() != "" && txtThangKHD.Text != null && txtThangKHD.Text.Trim() != "" && txtNgayKHD.Text != null && txtNgayKHD.Text.Trim() != "")
                    nhanvien.Ngaykihopdong = new DateTime(int.Parse(txtNamKHD.Text), int.Parse(txtThangKHD.Text), int.Parse(txtNgayKHD.Text));
                else nhanvien.Ngaykihopdong = new DateTime(1000, 1, 1);
                if (txtNamHHD.Text != null && txtNamHHD.Text.Trim() != "" && txtThangHHD.Text != null && txtThangHHD.Text.Trim() != "" && txtNgayHHD.Text != null && txtNgayHHD.Text.Trim() != "")
                    nhanvien.Ngayhethanhopdong = new DateTime(int.Parse(txtNamHHD.Text), int.Parse(txtThangHHD.Text), int.Parse(txtNgayHHD.Text));
                else nhanvien.Ngayhethanhopdong = new DateTime(1000, 1, 1);
                nhanvien.Mangoaingu = (string)cbxNgoaiNgu.SelectedValue;
                nhanvien.Mahocvan = (string)cbxHocVan.SelectedValue;
                nhanvien.Machucdanh = (string)cbxChucVu.SelectedValue;

                switch (chucnang)
                {
                    case ChucNang.Them:
                        MessageBox.Show("Đã thêm " + nhanvien.Them().ToString() + " nhân viên", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case ChucNang.Sua:
                        MessageBox.Show("Đã sửa " + nhanvien.Sua().ToString() + " nhân viên", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (e.Button == MouseButtons.Left)
                        {
                            Control ctrl = FormMain.stackControl.Pop();
                            ctrl.Dispose();
                            FormMain.stackControl.Pop().Visible = true;
                        }
                        break;
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Ngày tháng nhâp sai");
            }
        }

        private void txtCMT_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyValue < 48 || e.KeyValue > 57) && e.KeyData != Keys.Back)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
