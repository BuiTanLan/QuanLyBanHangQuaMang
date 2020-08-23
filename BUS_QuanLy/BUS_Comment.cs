using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using DAL_QuanLy;
using DTO_QuanLy;

namespace BUS_QuanLy
{
    public class BUS_Comment
    {
        private static BUS_Comment instance;
        public static BUS_Comment Instance
        {
            get
            {
                if (instance == null)
                    instance = new BUS_Comment();
                return instance;
            }
        }
        private BUS_Comment() { }

        //Lay danh sach mat hang
        public DataTable LayDanhSachComment()
        {
            return DAL_Comment.Instance.LayDanhSachComment();
        }

        //Tìm kiếm MH theo tên mặt hàng
        public DataTable TimKiemTheoTenMH(string tenmh)
        {
            return DAL_Comment.Instance.TimKiemTheoTenMH(tenmh);
        }

        //Tìm kiếm MH theo tên NCC
        public DataTable TimKiemTheoTenNCC(string tenncc)
        {
            return DAL_Comment.Instance.TimKiemTheoTenNCC(tenncc);
        }

        //Tìm kiếm MH theo tên NV quan ly
        public DataTable TimKiemTheoTenNVQuanLy(string tennv)
        {
            return DAL_Comment.Instance.TimKiemTheoTenNVQuanLy(tennv);
        }

        //Them mat hang
        public bool ThemComment(DTO_Comment mh)
        {
            return DAL_Comment.Instance.ThemComment(mh);
        }

        //Kiem tra mat hang da ton tai truoc do chua
        public bool KiemTraTonTai(string tenmh, int ncc)
        {
            DTO_Comment mh = DAL_Comment.Instance.DocThongTinMH(tenmh, ncc);
            if (mh == null)
            {
                return false;        //Chưa tồn tại 
            }
            return true;
        }

        //Cap nhat mat hang
        public bool CapNhatMH(DTO_Comment mh)
        {
            return DAL_Comment.Instance.CapNhatMH(mh);
        }

        //Xóa mặt hàng
        public bool XoaComment(int mamh)
        {
            return DAL_Comment.Instance.XoaComment(mamh);
        }

    }
}
