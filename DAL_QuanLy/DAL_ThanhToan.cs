using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QuanLy;
using System.Data;
using System.Data.SqlClient;

namespace DAL_QuanLy
{
    public class DAL_ThanhToan
    {
        //public enum PaymentAttribute
        //{
        //    hoaDon,
        //    khThanhToan,
        //    nvThanhToan,
        //    loaiThanhToan
        //}

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
        
        public bool insertThanhToan(DTO_ThanhToan thanhToan)
        {
            string query = "Insert INTO THANH_TOAN(HoaDon, KH_ThanhToan, NV_ThanhToan, LoaiThanhToan, SoTienNhan, SoTaiKhoan) " +
                "VALUES ( @HoaDon , @KH_ThanhToan , @NV_ThanhToan , @LoaiThanhToan , @SoTienNhan , @SoTaiKhoan )";
            object[] para = new object[] { thanhToan.maHoaDon, thanhToan.khThanhToan, thanhToan.nvThanhToan,
                thanhToan.loaiThanhToan, thanhToan.soTienNhan, thanhToan.soTaiKhoan };
            if (DBConnect.Instance.ExecuteNonQuery(query, para) > 0)
                return true;
            return false;
        }

        //public DataTable paymentQuery(PaymentAttribute attr, int value)
        //{
        //    //connect
        //    SqlConnection connection;
        //    connection = DBConnect.Connect();

        //    //tao cau truy van
        //    DataTable table = new DataTable();
        //    string query = "Select MaNV, TenNV, Email, MatKhau, SDT_NV, LoaiNV from NHAN_VIEN where TenNV like N'%" + tennv + "%'";
        //    string queryString = "select HoaDon, KH_ThanhToan, NV_ThanhToan, LoaiThanhToan, SoTienNhan, SoTaiKhoan from THANH_TOAN";
        //    switch (attr)
        //    {
        //        case PaymentAttribute.hoaDon:
        //            queryString += " where HoaDon "
        //        default:
        //            break;
        //    }
        //    //thuc thi cau truy van
        //    SqlDataAdapter adp = new SqlDataAdapter(query, connection);
        //    DataSet a = new DataSet();
        //    adp.Fill(a);

        //    //lay du lieu tra ve
        //    table = a.Tables[0];
        //    connection.Close();
        //    return connection;
        //}
    }
}
