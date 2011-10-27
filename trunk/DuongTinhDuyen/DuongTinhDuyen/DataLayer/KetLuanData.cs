using System;
using System.Data;
using System.Data.SqlClient;
using DuongTinhDuyen.Components;

namespace DuongTinhDuyen.DataLayer
{
    public class KetLuanData
    {
        DataService m_KetLuanData = new DataService();

        public DataTable LayDsKetLuan()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM KETLUAN");
            m_KetLuanData.Load(cmd);
            return m_KetLuanData;
        }

        public DataRow ThemDongMoi()
        {
            return m_KetLuanData.NewRow();
        }

        public void ThemKetLuan(DataRow m_Row)
        {
            m_KetLuanData.Rows.Add(m_Row);
        }

        public bool LuuKetLuan()
        {
            return m_KetLuanData.ExecuteNoneQuery() == 0;
        }
    }
}
