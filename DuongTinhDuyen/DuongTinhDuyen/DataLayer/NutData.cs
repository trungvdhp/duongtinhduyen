using System;
using System.Data;
using System.Data.SqlClient;
using DuongTinhDuyen.Components;

namespace DuongTinhDuyen.DataLayer
{
    public class NutData
    {
        DataService m_NutData = new DataService();

        public DataTable LayDsNut()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM NUT");
            m_NutData.Load(cmd);
            return m_NutData;
        }

        public DataRow ThemDongMoi()
        {
            return m_NutData.NewRow();
        }

        public void ThemNut(DataRow m_Row)
        {
            m_NutData.Rows.Add(m_Row);
        }

        public bool LuuNut()
        {
            return m_NutData.ExecuteNoneQuery() == 0;
        }
    }
}
