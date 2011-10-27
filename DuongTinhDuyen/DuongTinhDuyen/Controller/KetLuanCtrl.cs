using System;
using System.Text;
using System.Data;
using System.Windows.Forms;
using DuongTinhDuyen.DataLayer;

namespace DuongTinhDuyen.Controller
{
    public class KetLuanCtrl
    {
        KetLuanData m_KetLuanData = new KetLuanData();
        LuatData m_LuatData = new LuatData();
        #region Hien thi ComboBox
        public void HienThiComboBox(ComboBox comboBox)
        {
            comboBox.DataSource = m_KetLuanData.LayDsKetLuan();
            comboBox.DisplayMember = "NoiDung";
            comboBox.ValueMember = "MaKL";
        }
        #endregion

        #region Hien thi ComboBox trong DataGridView
        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = m_KetLuanData.LayDsKetLuan();
            cmbColumn.DisplayMember = "NoiDung";
            cmbColumn.ValueMember = "MaKL";
            cmbColumn.DataPropertyName = "MaKL";
            cmbColumn.HeaderText = "Kết luận";
        }
        #endregion

        #region Do du lieu vao DataGridView
        public void HienThi(DataGridView dGV, BindingNavigator bN)
        {
            BindingSource bS = new BindingSource();

            bS.DataSource = m_KetLuanData.LayDsKetLuan();
            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        #endregion
        #region Kiểm tra xem 1 kết luận có được sử dụng trong các Luật hay không?
        public bool DaSuDungKetLuan(int maKL)
        {
            DataTable dt = m_LuatData.LayDsLuat();
            foreach (DataRow dr in dt.Rows)
            {
                String s = dr[2].ToString();
                String[] s1 = s.Split(new char[]{'&','|'});
                foreach (String s2 in s1)
                {
                    if (Math.Abs(Convert.ToInt32(s2)) == maKL) return true;
                }
            }
            return false;
        }
        #endregion
        #region Them moi
        public DataRow ThemDongMoi()
        {
            return m_KetLuanData.ThemDongMoi();
        }

        public void ThemKetLuan(DataRow m_Row)
        {
            m_KetLuanData.ThemKetLuan(m_Row);
        }
        #endregion

        #region Luu du lieu
        public bool LuuKetLuan()
        {
            return m_KetLuanData.LuuKetLuan();
        }
        #endregion
    }
}
