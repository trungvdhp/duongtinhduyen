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
