using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QuanLy;
using DAL_QuanLy;
using System.Data;

namespace BUS_QuanLy
{
    public class BUS_ThanhToan
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

        public bool insertThanhToan(DTO_ThanhToan thanhToan)
        {
            return DAL_ThanhToan.instance.insertThanhToan(thanhToan);
        }
    }
}
