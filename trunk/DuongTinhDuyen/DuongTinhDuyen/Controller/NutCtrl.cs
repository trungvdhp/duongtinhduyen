using System;
using System.Text;
using System.Data;
using System.Windows.Forms;
using DuongTinhDuyen.DataLayer;
using DuongTinhDuyen.Components;

namespace DuongTinhDuyen.Controller
{
    public class NutCtrl
    {
        NutData m_NutData = new NutData();
        LuatData m_LuatData = new LuatData();

        #region Hien thi ComboBox
        public void HienThiComboBox(ComboBox comboBox)
        {
            comboBox.DataSource = m_NutData.LayDsNut();
            comboBox.DisplayMember = "NoiDung";
            comboBox.ValueMember = "MaNut";
        }
        #endregion

        #region Hien thi ComboBox trong DataGridView
        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = m_NutData.LayDsNut();
            cmbColumn.DisplayMember = "NoiDung";
            cmbColumn.ValueMember = "MaNut";
            cmbColumn.DataPropertyName = "MaNut";
            cmbColumn.HeaderText = "Giả thiết";
        }
        #endregion

        #region Do du lieu vao DataGridView
        public void HienThi(DataGridView dGV, BindingNavigator bN)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_NutData.LayDsNut();
            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        #endregion
        #region Kiểm tra xem 1 nút có được sử dụng trong các Luật hay không?
        public bool DaSuDungNut(int maNut)
        {
            DataTable dt = m_LuatData.LayDsLuat();
            foreach (DataRow dr in dt.Rows)
            {
                String s = dr[1].ToString();
                String[] s1 = s.Split('&');
                foreach (String s2 in s1)
                {
                    if (Math.Abs(Convert.ToInt32(s2)) == maNut) return true;
                }
            }
            return false;
        }
        #endregion
        #region Them moi
        public DataRow ThemDongMoi()
        {
            return m_NutData.ThemDongMoi();
        }

        public void ThemNut(DataRow m_Row)
        {
            m_NutData.ThemNut(m_Row);
        }
        #endregion

        #region Luu du lieu
        public bool LuuNut()
        {
            return m_NutData.LuuNut();
        }
        #endregion
    }
}
