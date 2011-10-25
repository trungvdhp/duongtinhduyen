using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DuongTinhDuyen.Controller;
using DuongTinhDuyen.Components;

namespace DuongTinhDuyen
{
    public partial class frmNguoiDung : Form
    {
        #region Fields
        NguoiDungCtrl m_NguoiDungCtrl = new NguoiDungCtrl();
        LoaiNguoiDungCtrl m_LoaiNguoiDungCtrl = new LoaiNguoiDungCtrl();
        #endregion
        public frmNguoiDung()
        {
            InitializeComponent();
        }

        private void frmNguoiDung_Load(object sender, EventArgs e)
        {
            m_LoaiNguoiDungCtrl.HienThiDataGridViewComboBoxColumn(colMaLoai);
            m_NguoiDungCtrl.HienThi(dgvNguoiDung, bindingNavigatorNguoiDung);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (dgvNguoiDung.RowCount > 0)
            {
                if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bindingNavigatorNguoiDung.BindingSource.RemoveCurrent();
                }
            }
            if (dgvNguoiDung.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = false;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            DataRow m_Row = m_NguoiDungCtrl.ThemDongMoi();
            m_Row["MaND"] = "ND";
            m_Row["MaLoai"] = null;
            m_Row["TenND"] = "";
            m_Row["TenDNhap"] = "";
            m_Row["MatKhau"] = "";
            m_NguoiDungCtrl.ThemNguoiDung(m_Row);
            bindingNavigatorNguoiDung.BindingSource.MoveLast();
            if (dgvNguoiDung.RowCount > 0)
                bindingNavigatorDeleteItem.Enabled = true;
        }

        public Boolean KiemTraTruocKhiLuu(String cellString)
        {
            foreach (DataGridViewRow row in dgvNguoiDung.Rows)
            {
                if (row.Cells[cellString].Value != null)
                {
                    String str = row.Cells[cellString].Value.ToString();
                    if (str == "")
                    {
                        MessageBox.Show("Thông tin người dùng không hợp lệ!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (KiemTraTruocKhiLuu("colMaND") == true &&
               KiemTraTruocKhiLuu("colMaLoai") == true &&
               KiemTraTruocKhiLuu("colTenND") == true &&
               KiemTraTruocKhiLuu("colTenDNhap") == true &&
               KiemTraTruocKhiLuu("colMatKhau") == true)
            {
                bindingNavigatorPositionItem.Focus();
                m_NguoiDungCtrl.LuuNguoiDung();
            }
        }

        private void dgvNguoiDung_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void bindingNavigatorRefreshItem_Click(object sender, EventArgs e)
        {
            frmNguoiDung_Load(sender, e);
        }





    }
}
