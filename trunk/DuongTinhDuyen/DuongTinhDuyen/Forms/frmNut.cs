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
    public partial class frmNut : Form
    {
        #region Fields
        NutCtrl m_NutCtrl = new NutCtrl();
        #endregion
        #region Constructor
        public frmNut()
        {
            InitializeComponent();
        }
        #endregion
        #region Load
        private void frmNut_Load(object sender, EventArgs e)
        {
            m_NutCtrl.HienThi(dgvNut, bindingNavigatorNut);
        }
        #endregion
        #region BindingNavigatorItems
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (dgvNut.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = false;
            else if (dgvNut.CurrentRow.Cells[0].Value.ToString() != "" && m_NutCtrl.DaSuDungNut(Convert.ToInt32(dgvNut.CurrentRow.Cells[0].Value.ToString())))
                    MessageBox.Show("Không thể xóa nút này vì nó đã được sử dụng trong các Luật", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (MessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorNut.BindingSource.RemoveCurrent();
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (dgvNut.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = true;

            DataRow m_Row = m_NutCtrl.ThemDongMoi();
            //m_Row["MaNut"] = ;
            m_Row["NoiDung"] = "";
            m_NutCtrl.ThemNut(m_Row);
            bindingNavigatorNut.BindingSource.MoveLast();
        }

        public Boolean KiemTraTruocKhiLuu(String cellString)
        {
            foreach (DataGridViewRow row in dgvNut.Rows)
            {
                if (row.Cells[cellString].Value != null)
                {
                    String str = row.Cells[cellString].Value.ToString();
                    if (str == "")
                    {
                        MessageBox.Show("Giá trị của ô không được rỗng!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dgvNut.CurrentCell = row.Cells[cellString];
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
                m_NutCtrl.LuuNut();
                frmNut_Load(sender, e);
                bindingNavigatorNut.BindingSource.MoveLast();
            }
        }

        private void bindingNavigatorRefreshItem_Click(object sender, EventArgs e)
        {
            frmNut_Load(sender, e);
        }
        #endregion
        #region DataError event
        private void dgvNut_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
        #endregion

    }
}
