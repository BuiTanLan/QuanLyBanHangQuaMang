using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QuanLy
{
    class BUS_ThanhToan
    {
        private static BUS_ThanhToan instance;
        public static BUS_ThanhToan Instance
        {
            get
            {
                if (instance == null)
                    instance = new BUS_ThanhToan();
                return instance;
            }
        }
        private BUS_ThanhToan() { }
    }
}
