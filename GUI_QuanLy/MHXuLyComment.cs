using BUS_QuanLy;
using DTO_QuanLy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QuanLy
{
    public partial class MHXuLyComment : Form
    {
        public MHXuLyComment()
        {
            InitializeComponent();
        }


        private void MHXuLyComment_Load(object sender, EventArgs e)
        {
            DateTo.Value = DateTime.Now;
            DateFrom.Value = DateTime.Now.AddDays(-6);
            HienThi(DateFrom.Value, DateTo.Value);


        }
        public void HienThi(DateTime dateFrom, DateTime dateTo)
        {
            // BUS_Comment.Instance.LayDanhSachComment();
            dsComment.DataSource = BUS_Comment.Instance.TimKiemTheoThoiGian(dateFrom, dateTo);

        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            DateTime dateFrom = DateFrom.Value;
            DateTime dateTo = DateTo.Value;
            dsComment.DataSource = BUS_Comment.Instance.TimKiemTheoThoiGian(dateFrom, dateTo);
        }

        private void taoDsCommentXau_Click(object sender, EventArgs e)
        {
            List<DTO_Comment> Cmt = new List<DTO_Comment>();
            dsBadComment.Rows.Clear();
            foreach (DataGridViewRow item in dsComment.Rows)
            {
                if (Convert.ToBoolean(item.Cells[0].Value))
                {
                    Cmt.Add(new DTO_Comment
                    {
                        Id = Convert.ToInt32(item.Cells[1].Value),
                        TenKH = item.Cells[2].Value.ToString(),
                        MaMH = item.Cells[3].Value.ToString(),
                        NgayCMT = (DateTime)item.Cells[4].Value,
                        NoiDungCMT = item.Cells[5].Value.ToString(),
                    });


                }


            }
            if (Cmt != null)
            {
                foreach (var item in Cmt)
                {
                    int n = dsBadComment.Rows.Add();
                    dsBadComment.Rows[n].Cells[1].Value = item.Id;
                    dsBadComment.Rows[n].Cells[2].Value = item.TenKH;
                    dsBadComment.Rows[n].Cells[3].Value = item.MaMH;
                    dsBadComment.Rows[n].Cells[4].Value = item.NgayCMT.ToString();
                    dsBadComment.Rows[n].Cells[5].Value = item.NoiDungCMT;

                }
            }
        }

        private void taoDsCommentTot_Click(object sender, EventArgs e)
        {
            List<DTO_Comment> Cmt = new List<DTO_Comment>();
            dsGoodComment.Rows.Clear();
            foreach (DataGridViewRow item in dsComment.Rows)
            {
                if (Convert.ToBoolean(item.Cells[0].Value))
                {
                    Cmt.Add(new DTO_Comment
                    {

                        Id = Convert.ToInt32(item.Cells[1].Value),
                        TenKH = item.Cells[2].Value.ToString(),
                        MaMH = item.Cells[3].Value.ToString(),
                        NgayCMT = (DateTime)item.Cells[4].Value,
                        NoiDungCMT = item.Cells[5].Value.ToString(),
                    });


                }

            }
            if (Cmt != null)
            {
                foreach (var item in Cmt)
                {
                    int n = dsGoodComment.Rows.Add();
                    dsGoodComment.Rows[n].Cells[1].Value = item.Id;
                    dsGoodComment.Rows[n].Cells[2].Value = item.TenKH;
                    dsGoodComment.Rows[n].Cells[3].Value = item.MaMH;
                    dsGoodComment.Rows[n].Cells[4].Value = item.NgayCMT.ToString();
                    dsGoodComment.Rows[n].Cells[5].Value = item.NoiDungCMT;

                }
            }
        }

        private void hienDsNhanQua_Click(object sender, EventArgs e)
        {
            dsNhanQua.DataSource = BUS_Comment.Instance.LayDanhSachNhanQua(DateFrom.Value, DateTo.Value);

        }

        private void xoaKhoiDsCommentXau_Click(object sender, EventArgs e)
        {
            List<DTO_Comment> Cmt = new List<DTO_Comment>();
            foreach (DataGridViewRow item in dsBadComment.Rows)
            {
                if (Convert.ToBoolean(item.Cells[0].Value) == false)
                {

                    Cmt.Add(new DTO_Comment
                    {
                        Id = Convert.ToInt32(item.Cells[1].Value),
                        TenKH = item.Cells[1].Value.ToString(),
                        MaMH = item.Cells[2].Value.ToString(),
                        NgayCMT = Convert.ToDateTime(item.Cells[3].Value),
                        NoiDungCMT = item.Cells[4].Value.ToString()
                    });


                }


            }
            dsBadComment.Rows.Clear();

            if (Cmt != null)
            {
                foreach (var item in Cmt)
                {
                    int n = dsBadComment.Rows.Add();
                    dsBadComment.Rows[n].Cells[1].Value = item.Id;
                    dsBadComment.Rows[n].Cells[2].Value = item.TenKH;
                    dsBadComment.Rows[n].Cells[3].Value = item.MaMH;
                    dsBadComment.Rows[n].Cells[4].Value = item.NgayCMT.ToString("dd'/'MM'/'yyyy");
                    dsBadComment.Rows[n].Cells[5].Value = item.NoiDungCMT;

                }
            }
        }

        private void xoaComment_Click(object sender, EventArgs e)
        {
            List<int> Id = new List<int>();
            foreach (DataGridViewRow item in dsBadComment.Rows)
            {
                if (Convert.ToBoolean(item.Cells[0].Value) == false)
                {
                    Id.Add(Convert.ToInt32(item.Cells[1].Value));
                }
            }
            BUS_Comment.Instance.XoaComment(Id);
        }

        private void xoaKhoiDsCommentTot_Click(object sender, EventArgs e)
        {
            List<DTO_Comment> Cmt = new List<DTO_Comment>();
            foreach (DataGridViewRow item in dsGoodComment.Rows)
            {
                if (Convert.ToBoolean(item.Cells[0].Value) == false)
                {

                    Cmt.Add(new DTO_Comment
                    {
                        Id = Convert.ToInt32(item.Cells[1].Value),
                        TenKH = item.Cells[2].Value.ToString(),
                        MaMH = item.Cells[3].Value.ToString(),
                        NgayCMT = Convert.ToDateTime(item.Cells[4].Value),
                        NoiDungCMT = item.Cells[5].Value.ToString()
                    });


                }

            }
            dsGoodComment.Rows.Clear();

            if (Cmt != null)
            {
                foreach (var item in Cmt)
                {
                    int n = dsGoodComment.Rows.Add();
                    dsGoodComment.Rows[n].Cells[1].Value = item.Id;
                    dsGoodComment.Rows[n].Cells[2].Value = item.TenKH;
                    dsGoodComment.Rows[n].Cells[3].Value = item.MaMH;
                    dsGoodComment.Rows[n].Cells[4].Value = item.NgayCMT.ToString("dd'/'MM'/'yyyy");
                    dsGoodComment.Rows[n].Cells[5].Value = item.NoiDungCMT;

                }
            }
        }

        private void chonNhanQua_Click(object sender, EventArgs e)
        {
            List<int> Id = new List<int>();
            foreach (DataGridViewRow item in dsGoodComment.Rows)
            {
                if (Convert.ToBoolean(item.Cells[0].Value) == false)
                {
                    Id.Add(Convert.ToInt32(item.Cells[1].Value));
                }
            }
            BUS_Comment.Instance.ThemDanhSachNhanQua(Id);
        }


    }
}

