﻿using System;
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
    public partial class frmKetLuan : Form
    {
        #region Fields
        KetLuanCtrl m_KetLuanCtrl = new KetLuanCtrl();
        #endregion
        #region Constructor
        public frmKetLuan()
        {
            InitializeComponent();
        }
        #endregion

        #region Load
        private void frmKetLuan_Load(object sender, EventArgs e)
        {
            m_KetLuanCtrl.HienThi(dgvKetLuan, bindingNavigatorNut);
        }
        #endregion

        #region BindingNavigatorItems
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (dgvKetLuan.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = false;
            else if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorNut.BindingSource.RemoveCurrent();
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (dgvKetLuan.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = true;

            DataRow m_Row = m_KetLuanCtrl.ThemDongMoi();
            //m_Row["MaKetLuan"] = ;
            m_Row["NoiDung"] = "";
            m_KetLuanCtrl.ThemKetLuan(m_Row);
            bindingNavigatorNut.BindingSource.MoveLast();
        }

        public Boolean KiemTraTruocKhiLuu(String cellString)
        {
            foreach (DataGridViewRow row in dgvKetLuan.Rows)
            {
                if (row.Cells[cellString].Value != null)
                {
                    String str = row.Cells[cellString].Value.ToString();
                    if (str == "")
                    {
                        MessageBox.Show("Giá trị của ô không được rỗng!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (KiemTraTruocKhiLuu("colNoiDung") == true)
            {
                bindingNavigatorPositionItem.Focus();
                m_KetLuanCtrl.LuuKetLuan();
            }
        }
        #endregion

        #region DataError event
        private void dgvKetLuan_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
        #endregion

        private void bindingNavigatorRefreshItem_Click(object sender, EventArgs e)
        {
            frmKetLuan_Load(sender, e);
        }
    }
}
