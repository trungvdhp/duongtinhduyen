using System;
using System.Data;
using System.Data.SqlClient;
using DuongTinhDuyen.Components;
using System.Windows.Forms;

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

        public void ThemLuat(String giaThiet, String ketLuan)
        {
            DataService m_LuatData = new DataService();
            SqlCommand cmd = new SqlCommand("INSERT INTO LUAT(GiaThiet, KetLuan) VALUES(@giaThiet, @ketLuan)");
            cmd.Parameters.Add("giaThiet", SqlDbType.VarChar).Value = giaThiet;
            cmd.Parameters.Add("ketLuan", SqlDbType.VarChar).Value = ketLuan;
            m_LuatData.Load(cmd);
        }
        public bool LuuLuat()
        {
            return m_LuatData.ExecuteNoneQuery() == 0;
        }
    }
}
