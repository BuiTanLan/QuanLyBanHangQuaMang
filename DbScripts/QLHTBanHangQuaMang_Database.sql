create database QuanLyBanHangQuaMang
go

use QuanLyBanHangQuaMang
go

/*---------------------------------------------- THIẾT KẾ CƠ SỞ DỮ LIỆU ------------------------------------------- */

/* Bảng KHACH_HANG */
create table KHACH_HANG
(
	MaKH int not null identity(100,1),
	TenKH nvarchar(50) not null,
	Email varchar(50) not null,
	MatKhau varchar(50) not null,
	SDT_KH char(10) not null,
	TinhTrangCMT int not null,		-- (0 - ko dc cmt, 1 - duoc cmt)
	XetTangQua int not null			-- (0 - ko tang qua, 1 - duoc tang qua)
	primary key (MaKH)
)

/* Bảng NHAN_VIEN */
create table NHAN_VIEN
(
	MaNV int not null identity(1000,1),
	TenNV nvarchar(50) not null,
	Email varchar(50) not null,
	MatKhau varchar(50) not null,
	SDT_NV char(10) not null,
	LoaiNV nvarchar(30) not null		-- Loai nhan vien
	primary key (MaNV)
)
/* Bảng NCC */
create table NCC
(
	MaNCC int not null identity(100,1),
	TenNCC nvarchar(50) not null,
	GioiThieu nvarchar(100)			--có thể giới thiệu 1 vài thông tin về NCC
	primary key (MaNCC)
)

/* Bảng MAT_HANG */
create table MAT_HANG
(
	MaMH int not null identity(100,1),
	TenMH nvarchar(100) not null,
	NCC int not null,
	LoaiMH nvarchar(50),
	SoLuongTon int not null,			--số lượng mat hang đang còn trong kho ở hiện tại
	SoLuongHangToiThieu int not null,	--so luong mat hang toi thieu cua 1 mat hang
	GiaTien money not null						
	primary key (MaMH)
)

/* Bảng COMMENT */
create table COMMENT
(
	--MaCMT int not null identity(1,1),
	MaMH_CMT int not null,							--cho biet mat hang nao duoc cmt
	MaKH_CMT int not null,							--cho biết khách hàng nào cmt
	LoaiCMT int not null,							-- false (0): Xau, true (1): Tot, (2) - chua phan loai 
	NgayCMT datetime not null,						--cho biết ngày khách hàng cmt
	NoiDungCMT nvarchar(100) not null,				--nội dung khách hàng góp ý (comment) cho sản phẩm
	primary key (MaMH_CMT,MaKH_CMT, NgayCMT)
)

/* Bảng THANH_TOAN */
create table THANH_TOAN
(
	HoaDon int not null,					-- Hoa don duoc thanh toan
	KH_ThanhToan int not null,				-- KH nao thanh toan
	NV_ThanhToan int not null,				-- NV nao thuc hien thanh toan
	LoaiThanhToan int not null,				-- (0 - Dung the, 1 - Tien mat, 2 - Chua biet)
	SoTienNhan money not null,				
	SoTaiKhoan char(14)
	primary key (HoaDon,KH_ThanhToan)
)

/* Bảng TIN_NHAN_QC */
create table TIN_NHAN_QC
(
	MaTN int not null identity(1,2),			
	NgayPhatTN datetime not null,				-- ngay phat tin nhan
	KH_TN int not null,							-- ma KH duoc nhan tin
	NguoiQL int not null,						-- NV chiu trach nhiem nhan tin
	MatHang_TN int not null						-- Mat hang duoc nhan tin QC					
	primary key (MaTN,NgayPhatTN)
)

/* Bảng DOITAC_QUANGCAO */
create table DOITAC_QUANGCAO
(
	MaDTac int not null identity(200,2),		-- ma doi tac
	TenDTac nvarchar(50) not null,				-- ten doi tac
	NgayKyHD datetime not null,					-- ngay ky hop dong
	ThoiHan datetime not null,					-- thoi han hop dong
	ViTriDang int not null,						-- Vi tri dang tin
	NguoiQL int not null						-- NV chiu trach nhiem quan ly
	primary key (MaDTac)
)

/* Bảng DON_HANG */
create table DON_HANG
(
	MaDH int not null identity(1000,1),
	MaKH_DatHang int not null,						--cho biết đơn hàng của khách nào
	NgayDatHang datetime not null,					--cho biết ngày khách hàng đặt đơn hàng
	SDT_KH char(10) not null,
	DiaChi_KH nvarchar(100) not null,
	Email_KH varchar(50) not null,
	TongTien money not null,						-- tổng tiền của các CTDH
	HinhThucThanhToan int not null,					-- (0 - tien mat, 1 - qua thẻ)
	TrangThaiDH int not null						-- (0 – Đã xác nhận, 1 – Đã thanh toán, 2 – Đang chuyển hàng, 3 – Giao dịch thành công, 4 - Giao dịch thất bại, Hủy đơn hàng)
	primary key (MaDH)
)

/* Bảng CHI_TIET_DON_HANG */
create table CHI_TIET_DON_HANG
(
	MaDH int not null,						--cho biet ma don hang chua CTDH
	MaMH_CTDH int not null,					--cho biết mat hang trong CTDH
	SoLuong int not null,					--số lượng của mat hang đó là bao nhiêu
	DonGia money not null,					--so luong * gia cua 1 mat hang
	TinhTrangMH nvarchar(50)				--ghi tinh trang mat hang
	primary key (MaDH, MaMH_CTDH)
)

/* Bảng HOADON_BANHANG */
create table HOADON_BANHANG
(
	MaHD int not null identity(1000,1),
	MaDH int not null,								--cho biết ma đơn hàng cua hoa don
	TinhTrangHD int not null,						-- (0 - chua thanh toan, 1 - Da thanh toan)
	NgayGiaoHang datetime,
	NhanVienGiaoHang int not null,
	NhanVienBanHang int not null,
	KhachHang int not null,							--cho biet hoa don cua KH nao
	ThuQuy int not null,
	LoaiHD int not null,							-- (0 - HD thuong, 1 - HD thanh toan the)
	TongTien money not null,						-- tổng tiền của các CTDH
	TrangThaiGiaoHang int not null					-- (0 – Chua giao, 1 – Đã giao)
	primary key (MaHD)
)

/* Bảng CHI_TIET_HOA_DON */
create table CHI_TIET_HOA_DON
(
	MaHD int not null,						--cho biet ma hoa don chua CTHD
	MaMH_CTHD int not null,					--cho biết mat hang trong CTHD
	SoLuong int not null,					--số lượng của mat hang đó là bao nhiêu
	DonGia money not null					--so luong * gia cua 1 mat hang				
	primary key (MaHD,MaMH_CTHD)
)

/* Bảng DON_NHAP_HANG */
create table DON_NHAP_HANG
(
	MaDNH int not null identity(1000,3),
	NgayNhap datetime not null,
	TongSLHangNhap int not null,
	LyDoNhap nvarchar(50),
	TrangThaiDuyet int not null,			-- (0 - chua duyet, 1 - da duyet)
	NguoiQL int not null					-- NV chiu trach nhiem quan ly
	primary key (MaDNH)
)

/* Bảng CHI_TIET_DON_NHAP_HANG */
create table CHI_TIET_DON_NHAP_HANG
(
	MaDNH int not null,						-- cho biet ma don nhap hang chua CTDNH
	MaMH_CTDNH int not null,				--cho biết mat hang se nhap
	SoLuong int not null					--số lượng của mat hang đó là bao nhiêu				
	primary key (MaDNH,MaMH_CTDNH)
)

/* Bảng DON_TRA_HANG */
create table DON_TRA_HANG
(
	MaDTH int not null identity(1000,5),
	NgayLap datetime not null,
	DoiTac int not null,
	LyDoTra nvarchar(50),
	NguoiQL int not null
	primary key (MaDTH)
)

/* Bảng CHI_TIET_DON_TRA_HANG */
create table CHI_TIET_DON_TRA_HANG
(
	MaDTH int not null,						-- cho biet ma don tra hang chua CTDTH
	MaMH_CTDTH int not null,				--cho biết mat hang se tra lai (mat hang lay tu CTDH)
	CTDH int not null,						--cho biet ma cua CTDH chua mat hang bi tra lai
	SoLuong int not null					--số lượng của mat hang đó là bao nhiêu				
	primary key (MaDTH, MaMH_CTDTH,CTDH)
)

/***** DEFAULT *****/
GO
ALTER TABLE [dbo].[COMMENT] ADD DEFAULT ((2)) FOR [LoaiCMT]	-- CMT chua phan loai
GO
ALTER TABLE [dbo].[KHACH_HANG] ADD  DEFAULT ((0)) FOR [XetTangQua]	-- khong duoc tang qua
GO
ALTER TABLE [dbo].[KHACH_HANG] ADD  DEFAULT ((1)) FOR [TinhTrangCMT]	-- duoc phep cmt
GO
ALTER TABLE [dbo].[THANH_TOAN] ADD  DEFAULT ((2)) FOR [LoaiThanhToan]	-- Chua chon loai thanh toan
GO
ALTER TABLE [dbo].[DON_HANG] ADD  DEFAULT ((0)) FOR [HinhThucThanhToan]	-- tien mat
GO
ALTER TABLE [dbo].[DON_HANG] ADD  DEFAULT ((0)) FOR [TrangThaiDH]	-- Da xac nhan don hang
GO
ALTER TABLE [dbo].[HOADON_BANHANG] ADD  DEFAULT ((0)) FOR [TinhTrangHD]	-- Chua thanh toan
GO
ALTER TABLE [dbo].[HOADON_BANHANG] ADD  DEFAULT ((0)) FOR [TrangThaiGiaoHang]	-- Chua giao hang
GO
ALTER TABLE [dbo].[HOADON_BANHANG] ADD  DEFAULT ((0)) FOR [LoaiHD]	-- Hoa don thuong
GO
ALTER TABLE [dbo].[DON_NHAP_HANG] ADD  DEFAULT ((0)) FOR [TrangThaiDuyet]	-- chua duyet don nhap hang

/*---------------------------------------------- CÀI ĐẶT KHÓA NGOẠI ------------------------------------------- */
-- MAT_HANG --
go
alter table MAT_HANG add constraint FK_MAT_HANG_NCC foreign key(NCC) REFERENCES NCC(MaNCC)

-- COMMENT --
alter table COMMENT add constraint FK_COMMENT_KHACH_HANG foreign key(MaKH_CMT) REFERENCES KHACH_HANG(MaKH)
alter table COMMENT add constraint FK_COMMENT_MAT_HANG foreign key(MaMH_CMT) REFERENCES MAT_HANG(MaMH)

-- TIN_NHAN_QC --
alter table TIN_NHAN_QC add constraint FK_TIN_NHAN_QC_KHACH_HANG foreign key(KH_TN) REFERENCES KHACH_HANG(MaKH)
alter table TIN_NHAN_QC add constraint FK_TIN_NHAN_QC_MAT_HANG foreign key(MatHang_TN) REFERENCES MAT_HANG(MaMH)
alter table TIN_NHAN_QC add constraint FK_TIN_NHAN_QC_NHAN_VIEN foreign key(NguoiQL) REFERENCES NHAN_VIEN(MaNV)

-- DOITAC_QUANGCAO --
alter table DOITAC_QUANGCAO add constraint FK_DOITAC_QUANGCAO_NHAN_VIEN foreign key(NguoiQL) REFERENCES NHAN_VIEN(MaNV)

-- DON_HANG --
alter table DON_HANG add constraint FK_DON_HANG_KHACH_HANG foreign key(MaKH_DatHang) REFERENCES KHACH_HANG(MaKH)

-- CHI_TIET_DON_HANG --
alter table CHI_TIET_DON_HANG add constraint FK_CHI_TIET_DON_HANG_DON_HANG foreign key(MaDH) REFERENCES DON_HANG(MaDH)
alter table CHI_TIET_DON_HANG add constraint FK_CHI_TIET_DON_HANG_MAT_HANG foreign key(MaMH_CTDH) REFERENCES MAT_HANG(MaMH)

-- HOADON_BANHANG --
alter table HOADON_BANHANG add constraint FK_HOADON_BANHANG_NHAN_VIEN1 foreign key(NhanVienGiaoHang) REFERENCES NHAN_VIEN(MaNV)
alter table HOADON_BANHANG add constraint FK_HOADON_BANHANG_NHAN_VIEN2 foreign key(NhanVienBanHang) REFERENCES NHAN_VIEN(MaNV)
alter table HOADON_BANHANG add constraint FK_HOADON_BANHANG_NHAN_VIEN3 foreign key(ThuQuy) REFERENCES NHAN_VIEN(MaNV)
alter table HOADON_BANHANG add constraint FK_HOADON_BANHANG_KHACH_HANG foreign key(KhachHang) REFERENCES KHACH_HANG(MaKH)
alter table HOADON_BANHANG add constraint FK_HOADON_BANHANG_DON_HANG foreign key(MaDH) REFERENCES DON_HANG(MaDH)

--CHI_TIET_HOA_DON--
alter table CHI_TIET_HOA_DON add constraint FK_CHI_TIET_HOA_DON_HOADON_BANHANG foreign key(MaHD) REFERENCES HOADON_BANHANG(MaHD)
alter table CHI_TIET_HOA_DON add constraint FK_CHI_TIET_HOA_DON_HOADON_MAT_HANG foreign key(MaMH_CTHD) REFERENCES MAT_HANG(MaMH)

-- DON_NHAP_HANG --
alter table DON_NHAP_HANG add constraint FK_DON_NHAP_HANG_NHAN_VIEN foreign key(NguoiQL) REFERENCES NHAN_VIEN(MaNV)

-- CHI_TIET_DON_NHAP_HANG --
alter table CHI_TIET_DON_NHAP_HANG add constraint FK_CHI_TIET_DON_NHAP_HANG_DON_NHAP_HANG foreign key(MaDNH) REFERENCES DON_NHAP_HANG(MaDNH)
alter table CHI_TIET_DON_NHAP_HANG add constraint FK_CHI_TIET_DON_NHAP_HANG_MAT_HANG foreign key(MaMH_CTDNH) REFERENCES MAT_HANG(MaMH)

-- DON_TRA_HANG --
alter table DON_TRA_HANG add constraint FK_DON_TRA_HANG_NCC foreign key(DoiTac) REFERENCES NCC(MaNCC)
alter table DON_TRA_HANG add constraint FK_DON_TRA_HANG_NHAN_VIEN foreign key(NguoiQL) REFERENCES NHAN_VIEN(MaNV)

-- CHI_TIET_DON_TRA_HANG --
alter table CHI_TIET_DON_TRA_HANG add constraint FK_CHI_TIET_DON_TRA_HANG_DON_TRA_HANG foreign key(MaDTH) REFERENCES DON_TRA_HANG(MaDTH)
alter table CHI_TIET_DON_TRA_HANG add constraint FK_CHI_TIET_DON_TRA_HANG_CHI_TIET_DON_HANG foreign key(CTDH, MaMH_CTDTH) REFERENCES CHI_TIET_DON_HANG(MaDH, MaMH_CTDH)

-- THANH_TOAN --
alter table THANH_TOAN add constraint FK_THANH_TOAN_HOADON_BANHANG foreign key(HoaDon) REFERENCES HOADON_BANHANG(MaHD)
alter table THANH_TOAN add constraint FK_THANH_TOAN_NHAN_VIEN foreign key(NV_ThanhToan) REFERENCES NHAN_VIEN(MaNV)
alter table THANH_TOAN add constraint FK_THANH_TOAN_KHACH_HANG foreign key(KH_ThanhToan) REFERENCES KHACH_HANG(MaKH)






