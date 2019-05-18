using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Food_Manaer.DTO;

namespace Food_Manaer.DAO
{
    class InfoDAO
    {
        private static InfoDAO instance;

        public static InfoDAO Instance
        {
            get { if (instance == null) instance = new InfoDAO(); return InfoDAO.instance; }
            private set { InfoDAO.instance = value; }
        }
        private InfoDAO() { }
    }
}
