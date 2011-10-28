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
    public partial class frmChuyenGia : Form
    {
        #region Fields
        LuatCtrl m_LuatCtrl = new LuatCtrl();
        NutCtrl m_NutCtrl = new NutCtrl();
        KetLuanCtrl m_KetLuanCtrl = new KetLuanCtrl();
        LuatData m_LuatData = new LuatData();
        DataTable dtLuat = new DataTable();
        List<int> lstNut;
        String strKetLuan;
        #endregion
        #region Constructor
        public frmChuyenGia()
        {
            InitializeComponent();
        }
        #endregion

        #region Load
        private void frmChuyenGia_Load(object sender, EventArgs e)
        {
            //m_LuatCtrl.HienThi(dgvLuat, bindingNavigatorLuat);
            lstNut = new List<int>();
            strKetLuan = "";
            //dtNut = (DataTable)cboGiaThiet.DataSource;
            dtLuat = m_LuatData.LayDsLuat();
            dgvGiaThiet.Rows.Clear();
            dgvKetLuan.Rows.Clear();
            m_NutCtrl.HienThiDataGridViewComboBoxColumn(colNoiDungGiaThiet);
            m_NutCtrl.HienThiDataGridViewComboBoxColumn(colGiaThiet);
            m_KetLuanCtrl.HienThiDataGridViewComboBoxColumn(colNoiDungKL);
            LayDsNutTiep();
        }
        #endregion

        #region BindingNavigatorItems
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            //if (dgvLuat.RowCount == 0)
                //bindingNavigatorDeleteItem.Enabled = false;
            //else if (MessageBox.Show("Bạn có chắc chắn xóa luật này không?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //{
                //bindingNavigatorLuat.BindingSource.RemoveCurrent();
            //}
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            //if (dgvLuat.RowCount == 0)
                //bindingNavigatorDeleteItem.Enabled = true;

            DataRow m_Row = m_LuatCtrl.ThemDongMoi();
            //m_Row["MaLuat"] = ;
            m_Row["GiaThiet"] = "";
            m_Row["KetLuan"] = "";
            m_LuatCtrl.ThemLuat(m_Row);
            //bindingNavigatorLuat.BindingSource.MoveLast();
        }

        public Boolean KiemTraTruocKhiLuu(DataGridView dgv, String cellString)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if ((row.Cells[cellString].Value == null) || (row.Cells[cellString].Value != null && row.Cells[cellString].Value.ToString() == ""))
                {
                    MessageBox.Show("Giá trị của ô không được rỗng!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dgv.CurrentCell = row.Cells[cellString];
                    return false;
                }
            }
            return true;
        }

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            /*if (KiemTraTruocKhiLuu(dgvLuat,"colGiaThiet") == true)
            {
                bindingNavigatorPositionItem.Focus();
                m_LuatCtrl.LuuLuat();
                frmChuyenGia_Load(sender, e);
            }*/
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
            frmChuyenGia_Load(sender, e);
        }

        private void bindingNavigatorAddNewItemNut_Click(object sender, EventArgs e)
        {
            dgvGiaThiet.Rows.Add();
            dgvGiaThiet.Rows[dgvGiaThiet.RowCount - 1].Cells[0].Value = "Có";
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
            /*try
            {
                dgvGiaThiet.Rows.Clear();
                dgvKetLuan.Rows.Clear();
                String[] giaThiet = dgvLuat.CurrentRow.Cells[1].Value.ToString().Split('&');
                String[] ketLuan = dgvLuat.CurrentRow.Cells[2].Value.ToString().Split(new char[] { '&', '|' });
                for (int i = 0; i < giaThiet.Length; ++i)
                {
                    dgvGiaThiet.Rows.Add();
                    dgvGiaThiet.Rows[i].Cells[0].Value = "Có";
                    if (giaThiet[i] != "")
                    {
                        dgvGiaThiet.Rows[i].Cells[0].Value = Convert.ToInt32(giaThiet[i]) > 0 ? "Có" : "Không";
                        dgvGiaThiet.Rows[i].Cells[1].Value = Math.Abs(Convert.ToInt32(giaThiet[i]));
                    }
                }
                String s = dgvLuat.CurrentRow.Cells[2].Value.ToString();
                
            }
            catch
            {
            }*/
        }

        private void bindingNavigatorAddNewItemKetLuan_Click(object sender, EventArgs e)
        {
            dgvKetLuan.Rows.Add();
            dgvKetLuan.Rows[dgvKetLuan.RowCount - 1].Cells[1].Value = "và";
        }

        private void bindingNavigatorDeleteItemKetLuan_Click(object sender, EventArgs e)
        {
            /*if (dgvGiaThiet.RowCount == 0)
                bindingNavigatorDeleteItemKetLuan.Enabled = false;
            else if (MessageBox.Show("Bạn có chắc chắn xóa kết luận này không?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dgvKetLuan.Rows.Remove(dgvKetLuan.CurrentRow);
            }*/
        }

        private void bindingNavigatorDeleteItemGiaThiet_Click(object sender, EventArgs e)
        {
            /*if (dgvGiaThiet.RowCount == 0)
                bindingNavigatorDeleteItemGiaThiet.Enabled = false;
            else if (MessageBox.Show("Bạn có chắc chắn xóa giả thiết này không?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dgvGiaThiet.Rows.Remove(dgvGiaThiet.CurrentRow);
            }*/
        }
        public bool DaCoGiaThiet(String maGiaThiet)
        {
            foreach (DataGridViewRow dr in dgvGiaThiet.Rows)
            {
                if (dr.Cells[1].Value.ToString() == maGiaThiet)
                    return true;
            }
            return false;
        }
        private void saveToolStripButtonGiaThiet_Click(object sender, EventArgs e)
        {
            dgvGiaThiet.EndEdit(DataGridViewDataErrorContexts.Commit);
            if( KiemTraTruocKhiLuu(dgvGiaThiet,"colNoiDungGiaThiet") == true)
            {
                String strGiaThiet = "";
                String strNut = "";
                foreach (DataGridViewRow dr in dgvGiaThiet.Rows)
                {
                    strNut = (dr.Cells[0].Value.ToString() == "Có" ? "" : "-") + dr.Cells[1].Value.ToString();
                    if (dr != dgvGiaThiet.Rows[0])
                        strGiaThiet += "&" + strNut;
                    else
                        strGiaThiet += strNut;
                }
                if (DaCoGiaThiet(strGiaThiet) == true)
                    MessageBox.Show("Giả thiết này đã có trong LUẬT!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    //dgvLuat.CurrentRow.Cells[1].Value = strGiaThiet;
                }
            }
            
        }
        private void saveToolStripButtonKetLuan_Click(object sender, EventArgs e)
        {
            dgvKetLuan.EndEdit(DataGridViewDataErrorContexts.Commit);
            if (KiemTraTruocKhiLuu(dgvKetLuan, "colNoiDungKL") == true)
            {
                String strKetLuan = "";
                foreach (DataGridViewRow dr in dgvKetLuan.Rows)
                {
                    if (dr != dgvKetLuan.Rows[dgvKetLuan.RowCount-1])
                        strKetLuan += dr.Cells[0].Value.ToString() + (dr.Cells[1].Value.ToString() == "và" ? "&" : "|");
                    else
                        strKetLuan += dr.Cells[0].Value.ToString();
                }
                //dgvLuat.CurrentRow.Cells[2].Value = strKetLuan;
            }
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
                    if (i != dgvGiaThiet.CurrentCell.RowIndex && dgvGiaThiet.Rows[i].Cells[1].Value != null && dgvGiaThiet.Rows[i].Cells[1].Value.ToString() == dgvGiaThiet.CurrentCell.Value.ToString())
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
                    if (i != dgvKetLuan.CurrentCell.RowIndex && dgvKetLuan.Rows[i].Cells[0].Value != null && dgvKetLuan.Rows[i].Cells[0].Value.ToString() == dgvKetLuan.CurrentCell.Value.ToString())
                    {
                        MessageBox.Show("Kết luận hiện tại trùng với kết luận tại hàng " + (i + 1), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dgvKetLuan.CurrentCell.Value = "";
                    }
                }
            }
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            frmChuyenGia_Load(sender, e);
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {

        }
        private void LayDsNutTiep()
        {
            foreach (int i in lstNut)
            {
                MessageBox.Show(i.ToString() + ";");
            }
            try
            {
                dgvNut.Rows.Clear();
                List<DataRow> lstLuat = new List<DataRow>();
                foreach (DataRow dr in dtLuat.Rows)
                {
                    String[] strNut = dr[1].ToString().Split('&');
                    int dem = 0;
                    bool[] danhdau = new bool[strNut.Length];
                    for (int i = 0; i < strNut.Length; ++i)
                    {
                        for (int j = 0; j < lstNut.Count; ++j)
                        {
                            if (lstNut[j].ToString() == strNut[i])
                            {
                                danhdau[i] = true;
                                dem++;
                            }
                            else
                            {
                                danhdau[i] = false;
                            }
                        }
                    }
                    if (dem == lstNut.Count || dem == 0)
                    {
                        for (int i = 0; i < strNut.Length; ++i)
                        {
                            bool check = false;
                            if (danhdau[i] == false)
                            {
                                foreach (DataGridViewRow dvr in dgvNut.Rows)
                                {
                                    int d = Convert.ToInt32(strNut[i]);
                                    if (dvr.Cells[1].Value != null)
                                    {
                                        if (((d > 0 && dvr.Cells[0].Value.ToString() == "Có") ||
                                            (d < 0 && dvr.Cells[0].Value.ToString() == "Không")) &&
                                            Math.Abs(d) == Convert.ToInt32(dvr.Cells[1].Value.ToString()))
                                        {
                                            check = true;
                                            break;
                                        }
                                    }
                                }
                                MessageBox.Show(strNut[i] + ", "+ check.ToString());
                                if (check == false)
                                {
                                    dgvNut.Rows.Add();
                                    int rid = dgvNut.RowCount - 1;
                                    dgvNut.Rows[rid].Cells[0].Value = Convert.ToInt32(strNut[i]) > 0 ? "Có" : "Không";
                                    dgvNut.Rows[rid].Cells[1].Value = Math.Abs(Convert.ToInt32(strNut[i]));
                                }
                            }
                        }
                    }
                    if (dem == strNut.Length)
                    {
                        dgvNut.Rows.Add();
                        strKetLuan = dr[2].ToString();
                    }
                    if (dem != lstNut.Count)
                    {
                        lstLuat.Add(dr);
                    }
                }
                MessageBox.Show("So luat loai bo la: " + lstLuat.Count);
                for (int i = 0; i < lstLuat.Count; ++i)
                {
                    dtLuat.Rows.Remove(lstLuat[i]);
                }
                MessageBox.Show("Con lai so Luat la: " + dtLuat.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            int rid;
            if (dgvNut.Rows[dgvNut.CurrentCell.RowIndex].Cells[1].Value == null)
            {
                String[] ketLuan = strKetLuan.Split(new char[] { '&', '|' });
                rid = 0;
                if (ketLuan.Length == 1)
                {
                    dgvKetLuan.Rows.Add();
                    dgvKetLuan.Rows[rid].Cells[1].Value = "và";
                    if (ketLuan[rid] != "")
                        dgvKetLuan.Rows[rid].Cells[0].Value = Math.Abs(Convert.ToInt32(ketLuan[rid]));
                    rid++;
                }
                for (int i = 0; i < strKetLuan.Length; ++i)
                {
                    if (strKetLuan[i] == '&')
                    {
                        dgvKetLuan.Rows.Add();
                        dgvKetLuan.Rows[rid].Cells[1].Value = "và";
                        dgvKetLuan.Rows[rid].Cells[0].Value = Math.Abs(Convert.ToInt32(ketLuan[rid]));
                        rid++;
                    }
                    else if (strKetLuan[i] == '|')
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
                MessageBox.Show("Hãy xem kết luận của chuyên gia trong bảng bên dưới", "Kết luận của chuyên gia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            lstNut.Add(Convert.ToInt32((dgvNut.Rows[dgvNut.CurrentCell.RowIndex].Cells[0].Value.ToString() == "Có" ? "" : "-") + 
                dgvNut.Rows[dgvNut.CurrentCell.RowIndex].Cells[1].Value.ToString()));
            dgvGiaThiet.Rows.Add();
            rid = dgvGiaThiet.RowCount - 1;
            dgvGiaThiet.Rows[rid].Cells[0].Value = dgvNut.Rows[dgvNut.CurrentCell.RowIndex].Cells[0].Value.ToString();
            dgvGiaThiet.Rows[rid].Cells[1].Value = Math.Abs(Convert.ToInt32(dgvNut.Rows[dgvNut.CurrentCell.RowIndex].Cells[1].Value.ToString()));
            LayDsNutTiep();
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {

        }
    }
}
