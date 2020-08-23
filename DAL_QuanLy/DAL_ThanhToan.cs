using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QuanLy
{
    class DAL_ThanhToan
    {
        public static DAL_ThanhToan instance;
        public static DAL_ThanhToan Instance
        {
            get
            {
                if (instance == null)
                    instance = new DAL_ThanhToan();
                return instance;
            }
        }
        private DAL_ThanhToan() { }
    }
}
