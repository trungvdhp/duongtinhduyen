using System;
using System.Collections.Generic;
using System.Text;

//Hoàn chỉnh
namespace DuongTinhDuyen.Bussiness
{
    public class LuatInfo
    {
        public LuatInfo()
        {

        }

        private int m_MaLuat;
        public int MaLuat
        {
            get { return m_MaLuat; }
            set { m_MaLuat = value; }
        }

        private String m_GiaThiet;
        public String NoiDung
        {
            get { return m_GiaThiet; }
            set { m_GiaThiet = value; }
        }

        private String m_KetLuan;
        public String KetLuan
        {
            get { return m_KetLuan; }
            set { m_KetLuan = value; }
        }
    }
}
