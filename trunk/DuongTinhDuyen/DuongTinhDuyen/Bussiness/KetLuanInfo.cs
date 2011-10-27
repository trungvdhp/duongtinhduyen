using System;
using System.Collections.Generic;
using System.Text;

//Hoàn chỉnh
namespace DuongTinhDuyen.Bussiness
{
    public class KetLuanInfo
    {
        public KetLuanInfo()
        {

        }

        private String m_MaKL;
        public String MaNut
        {
            get { return m_MaKL; }
            set { m_MaKL = value; }
        }

        private String m_NoiDung;
        public String NoiDung
        {
            get { return m_NoiDung; }
            set { m_NoiDung = value; }
        }
    }
}
