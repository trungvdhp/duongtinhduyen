using System;
using System.Data;
using System.Data.SqlClient;
using DuongTinhDuyen.Components;

namespace DuongTinhDuyen.DataLayer
{
    public class LuatData
    {
        DataService m_LuatData = new DataService();

        public DataTable LayDsLuat()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM LUAT");
            m_LuatData.Load(cmd);
            return m_LuatData;
        }

        public DataRow ThemDongMoi()
        {
            return m_LuatData.NewRow();
        }

        public void ThemLuat(DataRow m_Row)
        {
            m_LuatData.Rows.Add(m_Row);
        }

        public bool LuuLuat()
        {
            return m_LuatData.ExecuteNoneQuery() == 0;
        }
    }
}
