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
            lstNut = new List<int>();
            strKetLuan = "0";
            dtLuat = m_LuatData.LayDsLuat();
            dgvGiaThiet.Rows.Clear();
            dgvKetLuan.Rows.Clear();
            m_NutCtrl.HienThiDataGridViewComboBoxColumn(colNoiDungGiaThiet);
            m_NutCtrl.HienThiDataGridViewComboBoxColumn(colGiaThiet);
            m_KetLuanCtrl.HienThiDataGridViewComboBoxColumn(colNoiDungKL);
            LayDsNutTiep();
            btnTiepTuc.Enabled = true;
            btnQuayLai.Enabled = false;
        }
        #endregion
        #region DataError event
        private void dgvLuat_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
        
        private void dgvGiaThiet_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void dgvKetLuan_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
        #endregion
        #region Button event
        private void btnLamLai_Click(object sender, EventArgs e)
        {
            frmChuyenGia_Load(sender, e);
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            lstNut.RemoveAt(lstNut.Count - 1);
            dtLuat = m_LuatData.LayDsLuat();
            dgvGiaThiet.Rows.RemoveAt(dgvGiaThiet.RowCount - 1);
            dgvKetLuan.Rows.Clear();
            strKetLuan = "0";
            LayDsNutTiep();
            btnTiepTuc.Enabled = true;
            btnKetThuc.Enabled = true;
            if (lstNut.Count == 0)
                btnQuayLai.Enabled = false;
        }

        private void LayDsNutTiep()
        {
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
                                break;
                            }
                        }
                    }
                    if (dem == lstNut.Count)
                    {
                        if (dem == strNut.Length)
                        {
                            dgvNut.Rows.Add();
                            strKetLuan = dr[2].ToString();
                        }
                        for (int i = 0; i < strNut.Length; ++i)
                        {
                            bool check = false;
                            if (danhdau[i] == false)
                            {
                                int d = Convert.ToInt32(strNut[i]);
                                foreach (DataGridViewRow dvr in dgvNut.Rows)
                                {
                                    if (dvr.Cells[1].Value != null)
                                    {
                                        if (((d > 0 && dvr.Cells[0].Value.ToString() == "Có") ||
                                            (d < 0 && dvr.Cells[0].Value.ToString() == "Không")) &&
                                            Math.Abs(d).ToString() == dvr.Cells[1].Value.ToString())
                                        {
                                            check = true;
                                            break;
                                        }
                                    }
                                }
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
                    else
                    {
                        lstLuat.Add(dr);
                    }
                }
                for (int i = 0; i < lstLuat.Count; ++i)
                {
                    dtLuat.Rows.Remove(lstLuat[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void HienThiKetLuan()
        {
            String[] ketLuan = strKetLuan.Split(new char[] { '&', '|' });
            int rid = 0;
            if (ketLuan.Length == 1)
            {
                dgvKetLuan.Rows.Add();
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
            btnTiepTuc.Enabled = false;
            btnKetThuc.Enabled = false;
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            if (dgvNut.Rows[dgvNut.CurrentCell.RowIndex].Cells[1].Value == null)
            {
                HienThiKetLuan();
                return;
            }
            lstNut.Add(Convert.ToInt32((dgvNut.Rows[dgvNut.CurrentCell.RowIndex].Cells[0].Value.ToString() == "Có" ? "" : "-") +
                dgvNut.Rows[dgvNut.CurrentCell.RowIndex].Cells[1].Value.ToString()));
            dgvGiaThiet.Rows.Add();
            int rid = dgvGiaThiet.RowCount - 1;
            dgvGiaThiet.Rows[rid].Cells[0].Value = dgvNut.Rows[dgvNut.CurrentCell.RowIndex].Cells[0].Value.ToString();
            dgvGiaThiet.Rows[rid].Cells[1].Value = Math.Abs(Convert.ToInt32(dgvNut.Rows[dgvNut.CurrentCell.RowIndex].Cells[1].Value.ToString()));
            LayDsNutTiep();
            btnQuayLai.Enabled = true;
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            if (strKetLuan != "0")
            {
                HienThiKetLuan();
            }
            else if (lstNut.Count != 0 && (MessageBox.Show("Rất tiếc chuyên gia chưa thể tư vấn ngay cho bạn về trường hợp này được.\n" +
                "Bạn có muốn lưu lại thông tin để lần sau chuyên gia tư vấn cho bạn không?", "Kết luận của chuyên gia",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                String strGiaThiet = "";
                foreach (int iNut in lstNut)
                {
                    if (iNut != lstNut[0])
                        strGiaThiet += "&" + iNut.ToString();
                    else
                        strGiaThiet += iNut;
                }
                m_LuatData.ThemLuat(strGiaThiet, "");
                MessageBox.Show("Đã lưu lại thông tin. Hẹn gặp lại bạn trong lần tư vấn tiếp theo!");
                btnKetThuc.Enabled = false;
            }
        }
        #endregion
    }
}
