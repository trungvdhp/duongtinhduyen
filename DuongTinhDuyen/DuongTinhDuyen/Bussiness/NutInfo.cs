using System;
using System.Collections.Generic;
using System.Text;

//Hoàn chỉnh
namespace DuongTinhDuyen.Bussiness
{
    public class NutInfo
    {
        public NutInfo()
        {

        }

        private String m_MaNut;
        public String MaNut
        {
            get { return m_MaNut; }
            set { m_MaNut = value; }
        }

        private String m_NoiDung;
        public String NoiDung
        {
            get { return m_NoiDung; }
            set { m_NoiDung = value; }
        }
    }
}
