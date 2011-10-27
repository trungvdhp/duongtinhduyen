using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DuongTinhDuyen.Controller;
using DuongTinhDuyen.DataLayer;

namespace DuongTinhDuyen
{
    public partial class frmLuat : Form
    {
        #region Fields
        LuatCtrl m_LuatCtrl = new LuatCtrl();
        NutCtrl m_NutCtrl = new NutCtrl();
        KetLuanCtrl m_KetLuanCtrl = new KetLuanCtrl();
        #endregion
        #region Constructor
        public frmLuat()
        {
            InitializeComponent();
        }
        #endregion

        #region Load
        private void frmLuat_Load(object sender, EventArgs e)
        {
            m_LuatCtrl.HienThi(dgvLuat, bindingNavigatorLuat);
            m_NutCtrl.HienThiDataGridViewComboBoxColumn(colNoiDungGiaThiet);
            m_KetLuanCtrl.HienThiDataGridViewComboBoxColumn(colNoiDungKL);
        }
        #endregion

        #region BindingNavigatorItems
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (dgvLuat.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = false;
            else if (MessageBox.Show("Bạn có chắc chắn xóa luật này không?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigatorLuat.BindingSource.RemoveCurrent();
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (dgvLuat.RowCount == 0)
                bindingNavigatorDeleteItem.Enabled = true;

            DataRow m_Row = m_LuatCtrl.ThemDongMoi();
            //m_Row["MaLuat"] = ;
            m_Row["GiaThiet"] = "";
            m_Row["KetLuan"] = "";
            m_LuatCtrl.ThemLuat(m_Row);
            bindingNavigatorLuat.BindingSource.MoveLast();
        }

        public Boolean KiemTraTruocKhiLuu(DataGridView dgv, String cellString)
        {
            foreach (DataGridViewRow row in dgv.Rows)
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
            if (KiemTraTruocKhiLuu(dgvLuat,"colGiaThiet") == true &&
                KiemTraTruocKhiLuu(dgvLuat,"colKetLuan") == true)
            {
                bindingNavigatorPositionItem.Focus();
                m_LuatCtrl.LuuLuat();
                frmLuat_Load(sender, e);
            }
        }
        #endregion

        #region DataError event
        private void dgvLuat_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
        #endregion

        private void bindingNavigatorRefreshItem_Click(object sender, EventArgs e)
        {
            frmLuat_Load(sender, e);
        }

        private void bindingNavigatorAddNewItemNut_Click(object sender, EventArgs e)
        {
            dgvGiaThiet.Rows.Add();
        }

        private void dgvGiaThiet_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void dgvLuat_SelectionChanged(object sender, EventArgs e)
        {
            dgvGiaThiet.Rows.Clear();
            dgvKetLuan.Rows.Clear();
            String[] giaThiet = dgvLuat.CurrentRow.Cells[1].Value.ToString().Split('&');
            String[] ketLuan = dgvLuat.CurrentRow.Cells[2].Value.ToString().Split(new char[]{'&','|'});
            for(int i=0;i<giaThiet.Length;++i)
            {
                dgvGiaThiet.Rows.Add();
                if (giaThiet[i] != "")
                {
                    dgvGiaThiet.Rows[i].Cells[0].Value = Convert.ToInt32(giaThiet[i]) > 0 ? "Có" : "Không";
                    dgvGiaThiet.Rows[i].Cells[1].Value = Math.Abs(Convert.ToInt32(giaThiet[i]));
                }
            }
            String s = dgvLuat.CurrentRow.Cells[2].Value.ToString();
            int rid = 0;
            if (ketLuan.Length ==1)
            {
                dgvKetLuan.Rows.Add();
                if(ketLuan[rid] != "")
                    dgvKetLuan.Rows[rid].Cells[0].Value = Math.Abs(Convert.ToInt32(ketLuan[rid]));
                rid++;
            }
            for (int i = 0; i < s.Length; ++i)
            {
                if(s[i]=='&')
                {
                    dgvKetLuan.Rows.Add();
                    dgvKetLuan.Rows[rid].Cells[1].Value = "và";
                    dgvKetLuan.Rows[rid].Cells[0].Value = Math.Abs(Convert.ToInt32(ketLuan[rid]));
                    rid++;
                }
                else if (s[i] == '|')
                {
                    dgvKetLuan.Rows.Add();
                    dgvKetLuan.Rows[rid].Cells[1].Value = "hoặc";
                    dgvKetLuan.Rows[rid].Cells[0].Value = Math.Abs(Convert.ToInt32(ketLuan[rid]));
                    rid++;
                }
            }
            if (ketLuan.Length > 1)
            {
                dgvKetLuan.Rows.Add();
                dgvKetLuan.Rows[rid].Cells[0].Value = Math.Abs(Convert.ToInt32(ketLuan[rid]));
            }
        }

        private void bindingNavigatorAddNewItemKetLuan_Click(object sender, EventArgs e)
        {
            dgvKetLuan.Rows.Add();
        }

        private void bindingNavigatorDeleteItemKetLuan_Click(object sender, EventArgs e)
        {
            if (dgvGiaThiet.RowCount == 0)
                bindingNavigatorDeleteItemKetLuan.Enabled = false;
            else if (MessageBox.Show("Bạn có chắc chắn xóa kết luận này không?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dgvKetLuan.Rows.Remove(dgvKetLuan.CurrentRow);
            }
        }

        private void bindingNavigatorDeleteItemGiaThiet_Click(object sender, EventArgs e)
        {
            if (dgvGiaThiet.RowCount == 0)
                bindingNavigatorDeleteItemGiaThiet.Enabled = false;
            else if (MessageBox.Show("Bạn có chắc chắn xóa giả thiết này không?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dgvGiaThiet.Rows.Remove(dgvGiaThiet.CurrentRow);
            }
        }

        private void saveToolStripButtonGiaThiet_Click(object sender, EventArgs e)
        {
        }

        private void saveToolStripButtonKetLuan_Click(object sender, EventArgs e)
        {

        }

        private void dgvGiaThiet_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvGiaThiet.CurrentCell == null)
            {
                return;
            }
            if (e.ColumnIndex == 1 && dgvGiaThiet.CurrentCell.Value != null)
            {
                for (int i = 0; i < dgvGiaThiet.RowCount; ++i)
                {
                    if (i != e.RowIndex && dgvGiaThiet.Rows[i].Cells[1].Value != null && dgvGiaThiet.Rows[i].Cells[1].Value.ToString() == dgvGiaThiet.CurrentCell.Value.ToString())
                    {
                        MessageBox.Show("Giả thiết hiện tại trùng với giả thiết tại hàng " + (i + 1), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dgvGiaThiet.CurrentCell.Value = "";
                    }
                }
            }
        }

        private void dgvKetLuan_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvKetLuan.CurrentCell == null)
            {
                return;
            }
            if (e.ColumnIndex == 0 && dgvKetLuan.CurrentCell.Value != null)
            {
                for (int i = 0; i < dgvKetLuan.RowCount; ++i)
                {
                    if (i != e.RowIndex && dgvKetLuan.Rows[i].Cells[0].Value != null && dgvKetLuan.Rows[i].Cells[0].Value.ToString() == dgvKetLuan.CurrentCell.Value.ToString())
                    {
                        MessageBox.Show("Kết luận hiện tại trùng với kết luận tại hàng " + (i + 1), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dgvKetLuan.CurrentCell.Value = "";
                    }
                }
            }
        }
    }
}
