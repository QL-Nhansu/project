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
    public partial class UCDSNhanVien : UserControl
    {
        private DataView dataview;
        public UCDSNhanVien()
        {
            InitializeComponent();
        }

        private void UCDSNhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
            cbxView.SelectedIndex = 0;
        }

        private void btnThem_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                FormMain.stackControl.Push(this);
                this.Visible = false;
                UCThemSuaNV.chucnang = UCThemSuaNV.ChucNang.Them;
                if (dataview != null && dataview.Table.Rows.Count > 0) UCThemSuaNV.manv = (string)dataview.Table.Select("Mã is not null", "Mã DESC")[0].ItemArray[0];
                else UCThemSuaNV.manv = "nv001";
                UCThemSuaNV.manv = "nv" + string.Format("{0:d3}", int.Parse(UCThemSuaNV.manv.Replace("nv", "00")) + 1);
                this.Parent.Controls.Add(new UCThemSuaNV()
                {
                    Location = new Point(8, 8),
                    Width = this.Width,
                    Height = this.Height,
                    Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top
                });
            }
        }

        private void btnSua_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                FormMain.stackControl.Push(this);
                this.Visible = false;
                UCThemSuaNV.chucnang = UCThemSuaNV.ChucNang.Sua;
                UCThemSuaNV.manv = (string)dgvDSNV.CurrentRow.Cells[0].Value;
                this.Parent.Controls.Add(new UCThemSuaNV()
                {
                    Location = new Point(8, 8),
                    Width = this.Width,
                    Height = this.Height,
                    Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top
                });
            }
        }

        private void btnXoa_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MessageBox.Show("Đã xóa " + DTO.NhanVien.Xoa((string)dgvDSNV.CurrentRow.Cells[0].Value).ToString() + " nhân viên", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                btnSua.Actived = false;
            }
        }

        private void xemHoSoChiTietToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCXemNV uc;
            foreach (Control ctrl in this.Parent.Controls)
            {
                uc = ctrl as UCXemNV;
                if (uc == null) ctrl.Visible = false;
            }
            UCXemNV.manv = (string)dgvDSNV.CurrentRow.Cells[0].Value;
            this.Parent.Controls.Add(new UCXemNV()
            {
                Location = new Point(8, 8),
                Width = this.Width,
                Height = this.Height,
                Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top
            });
        }

        private void LoadData()
        {
            dataview = DTO.NhanVien.Get_DSNhanVien().DefaultView;
            dgvDSNV.DataSource = dataview;
            dgvDSNV.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvDSNV.Columns[0].Width = 50;
            dgvDSNV.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvDSNV.Columns[1].MinimumWidth = 133;
            dgvDSNV.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dgvDSNV.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dgvDSNV.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvDSNV.Columns[4].MinimumWidth = 133;
            dgvDSNV.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvDSNV.Columns[5].MinimumWidth = 133;
            dgvDSNV.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dgvDSNV.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvDSNV.Columns[7].MinimumWidth = 110;
            dgvDSNV.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvDSNV.Columns[8].MinimumWidth = 110;
        }

        private void cbxView_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                switch (cbxView.Text)
                {
                    case "Phòng ban, mã nv":
                        if (dataview != null)
                        {
                            dataview.Sort = "[Phòng ban] ASC, [Mã] ASC";
                            dgvDSNV.DataSource = dataview;
                        }
                        break;
                    case "Chức vụ, mã nv":
                        if (dataview != null)
                        {
                            dataview.Sort = "[Chức danh] ASC, [Mã] ASC";
                            dgvDSNV.DataSource = dataview;
                        }
                        break;
                    default:
                        break;
                }
            }
            catch (Exception)
            {

            }
        }

        private void UCDSNhanVien_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                LoadData();
                switch (cbxView.Text)
                {
                    case "Phòng ban, mã nv":
                        if (dataview != null)
                        {
                            dataview.Sort = "[Phòng ban] ASC, [Mã] ASC";
                            dgvDSNV.DataSource = dataview;
                        }
                        break;
                    case "Chức vụ, mã nv":
                        if (dataview != null)
                        {
                            dataview.Sort = "[Chức danh] ASC, [Mã] ASC";
                            dgvDSNV.DataSource = dataview;
                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
