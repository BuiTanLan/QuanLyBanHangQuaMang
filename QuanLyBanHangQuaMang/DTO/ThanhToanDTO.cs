using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHangQuaMang.DTO
{
    class ThanhToanDTO
    {
        private int _maHoaDon;
        private string _loaiThanhToan;
        private double _soTienNhan;
        private string _soTaiKhoan;

        public int maHoaDon
        {
            get { return _maHoaDon; }
            set { _maHoaDon = value; }
        }

        public string loaiThanhToan
        {
            get { return _loaiThanhToan; }
            set { _loaiThanhToan = value; }
        }

        public double soTienNhan
        {
            get { return _soTienNhan; }
            set { _soTienNhan = value; }
        }

        public string soTaiKhoan
        {
            get { return _soTaiKhoan; }
            set { _soTaiKhoan = value; }
        }

        public ThanhToanDTO()
        {
            _maHoaDon = -1;
            _loaiThanhToan = "";
            _soTienNhan = 0;
            _soTaiKhoan = "";
        }

        public ThanhToanDTO(int maHoaDon, string loaiThanhToan, double soTienNhan, string soTaiKhoan)
        {
            _maHoaDon = maHoaDon;
            _loaiThanhToan = loaiThanhToan;
            _soTienNhan = soTienNhan;
            _soTaiKhoan = soTaiKhoan;
        }
    }
}
