using System;
using System.Text;
using System.Data;
using System.Windows.Forms;
using DuongTinhDuyen.DataLayer;

namespace DuongTinhDuyen.Controller
{
    public class LuatCtrl
    {
        LuatData m_LuatData = new LuatData();
        #region Do du lieu vao DataGridView
        public void HienThi(DataGridView dGV, BindingNavigator bN)
        {
            BindingSource bS = new BindingSource();

            bS.DataSource = m_LuatData.LayDsLuat();
            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        #endregion
        #region Them moi
        public DataRow ThemDongMoi()
        {
            return m_LuatData.ThemDongMoi();
        }

        public void ThemLuat(DataRow m_Row)
        {
            m_LuatData.ThemLuat(m_Row);
        }
        public void ThemLuat(String giaThiet, String ketLuan)
        {
            m_LuatData.ThemLuat(giaThiet, ketLuan);
        }
        #endregion

        #region Luu du lieu
        public bool LuuLuat()
        {
            return m_LuatData.LuuLuat();
        }
        #endregion
    }
}
