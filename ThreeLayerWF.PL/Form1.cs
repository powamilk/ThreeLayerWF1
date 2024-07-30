using ThreeLayerWF.BUS.Implement;
using ThreeLayerWF.BUS.Interface;
using ThreeLayerWF.BUS.ViewModel;
using ThreeLayerWF.PL.Extensions;

namespace ThreeLayerWF.PL
{
    public partial class Form1 : Form
    {
        List<SanPhamVM> _sanPhams;
        ISanPhamService _sanPhamServices;
        int _maSanPhamChon;

        public Form1()
        {
            InitializeComponent();
            _sanPhamServices = new SanPhamServices();
            _sanPhams = new List<SanPhamVM>();
            LoadFromData();
            LoadGridData();
        }

        private void LoadFromData()
        {
            cb_giaban.Items.Clear();
            cb_giaban.Items.Add("0");
            cb_giaban.Items.Add("1");
            cb_giaban.Items.Add("2");
            cb_giaban.SelectedIndex = 0;  // Chọn giá trị đầu tiên hoặc giá trị mặc định

            cb_soluongton.Items.Clear();
            cb_soluongton.Items.Add("0");
            cb_soluongton.Items.Add("1");
            cb_soluongton.Items.Add("2");
            cb_soluongton.SelectedIndex = 0;  // Chọn giá trị đầu tiên hoặc giá trị mặc định

            cb_trangthai.Items.Clear();
            cb_trangthai.Items.Add("1");
            cb_trangthai.Items.Add("2");
            cb_trangthai.SelectedIndex = 0;

            txt_timkiem.PlaceholderText = HienThi("tên sản phẩm cần tìm");
            txt_tensanpham.PlaceholderText = HienThi("tên sản phẩm");
            txt_nhasanxuat.PlaceholderText = HienThi("nhà sản xuất");
            txt_xuatxu.PlaceholderText = HienThi("xuất xứ");
            txt_mota.PlaceholderText = HienThi("mô tả");

            dgv_sanpham.Columns.Clear();
            dgv_sanpham.Columns.Add("CLm1", "STT");
            dgv_sanpham.Columns.Add("CLm2", "Tên");
            dgv_sanpham.Columns.Add("CLm3", "Giá Bán");
            dgv_sanpham.Columns.Add("CLm4", "Số Lượng Tồn");
            dgv_sanpham.Columns.Add("CLm5", "Nhà Sản Xuất");
            dgv_sanpham.Columns.Add("clm6", "Xuất Xứ");
            dgv_sanpham.Columns.Add("CLm7", "Trạng Thái");
            dgv_sanpham.Columns.Add("CLm8", "Mô tả");
            dgv_sanpham.Columns.Add("clm9", "Mã Loại");
        }



        private string HienThi(string text)
        {
            return $"Nhập {text}";
        }

        private int TaoMaSanPham()
        {
            var sanPhams = _sanPhamServices.GetList();
            var lastMaSanPham = sanPhams
                .Select(sp => sp.MaSanPham)
                .OrderByDescending(ma => ma)
                .FirstOrDefault();
            return lastMaSanPham + 1;
        }

        private void LoadGridData()
        {
            _sanPhams = _sanPhamServices.GetList();

            dgv_sanpham.Rows.Clear();

            foreach (var pham in _sanPhams)
            {
                string trangThai;

                // Kiểm tra trạng thái và thiết lập giá trị hiển thị
                switch (pham.TrangThai)
                {
                    case 1:
                        trangThai = "Đang bán";
                        break;
                    case 2:
                        trangThai = "Tạm dừng";
                        break;
                    default:
                        trangThai = "Không xác định";
                        break;
                }

                // Lấy tên loại sản phẩm từ dịch vụ
                string maLoaiDisplay = _sanPhamServices.GetLoaiSanPhamName(pham.MaLoai);

                // Thêm dữ liệu vào DataGridView
                dgv_sanpham.Rows.Add(
                    (_sanPhams.IndexOf(pham) + 1),
                    pham.TenSanPham,
                    pham.GiaBan,
                    pham.SoLuongTon,
                    pham.NhaSanXuat,
                    pham.XuatXu,
                    trangThai,
                    pham.MoTa,
                    maLoaiDisplay
                );
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            LoadFromData();
            LoadGridData();
        }

        private void dgv_sanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = e.RowIndex;

            if (index < 0 || index >= _sanPhams.Count)
            {
                _maSanPhamChon = 0;
                return;
            }

            var sanPhamChon = _sanPhams.ElementAt(index);

            _maSanPhamChon = sanPhamChon.MaSanPham;
            txt_tensanpham.Text = sanPhamChon.TenSanPham;
            cb_giaban.Text = sanPhamChon.GiaBan.ToString();
            cb_soluongton.Text = sanPhamChon.SoLuongTon.ToString();
            txt_nhasanxuat.Text = sanPhamChon.NhaSanXuat;
            cb_trangthai.Text = sanPhamChon.TrangThai.ToString();
            txt_xuatxu.Text = sanPhamChon.XuatXu;
            txt_mota.Text = sanPhamChon.MoTa;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            bool isGiaBanValid = int.TryParse(cb_giaban.Text, out int giaBan);
            bool isSoLuongTonValid = int.TryParse(cb_soluongton.Text, out int soLuongTon);
            bool isTrangThaiValid = int.TryParse(cb_trangthai.Text, out int trangThai);

            if (!isGiaBanValid || giaBan <= 0 ||
                !isSoLuongTonValid || soLuongTon <= 0 ||
                !isTrangThaiValid || trangThai <= 0)
            {
                MessageBoxExtension.Notification("THÊM", "Các trường số phải là số nguyên dương.");
                return;
            }

            if (MessageBoxExtension.Confirm("thêm"))
            {
                var newMaSanPham = TaoMaSanPham();

                var sanPhamCreate = new SanPhamCreateVM
                {
                    MaSanPham = newMaSanPham,
                    TenSanPham = txt_tensanpham.Text,
                    GiaBan = giaBan,
                    SoLuongTon = soLuongTon,
                    NhaSanXuat = txt_nhasanxuat.Text,
                    XuatXu = txt_xuatxu.Text,
                    TrangThai = trangThai,
                    MoTa = txt_mota.Text
                };

                var result = _sanPhamServices.Create(sanPhamCreate);
                MessageBoxExtension.Notification("THÊM", result);
                LoadGridData();
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (_maSanPhamChon == 0)
            {
                MessageBoxExtension.Notification("CHỈNH SỬA", "Vui lòng chọn sản phẩm cần chỉnh sửa.");
                return;
            }

            bool isGiaBanValid = int.TryParse(cb_giaban.Text, out int giaBan);
            bool isSoLuongTonValid = int.TryParse(cb_soluongton.Text, out int soLuongTon);
            bool isTrangThaiValid = int.TryParse(cb_trangthai.Text, out int trangThai);

            if (!isGiaBanValid || giaBan <= 0 ||
                !isSoLuongTonValid || soLuongTon <= 0 ||
                !isTrangThaiValid || trangThai <= 0)
            {
                MessageBoxExtension.Notification("CHỈNH SỬA", "Các trường số phải là số nguyên dương.");
                return;
            }

            var spUpdate = new SanPhamUpdateVM
            {
                MaSanPham = _maSanPhamChon,
                TenSanPham = txt_tensanpham.Text,
                GiaBan = giaBan,
                SoLuongTon = soLuongTon,
                NhaSanXuat = txt_nhasanxuat.Text,
                XuatXu = txt_xuatxu.Text,
                TrangThai = trangThai,
                MoTa = txt_mota.Text
            };

            var result = _sanPhamServices.Update(spUpdate);

            string msg = result ? "Chỉnh sửa thành công" : "Chỉnh sửa thất bại";
            MessageBoxExtension.Notification("CHỈNH SỬA", msg);

            LoadGridData();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (_maSanPhamChon == 0)
            {
                MessageBoxExtension.Notification("XÓA", "Vui lòng chọn sản phẩm cần xóa.");
                return;
            }

            if (MessageBoxExtension.Confirm("xóa"))
            {
                var result = _sanPhamServices.Delete(_maSanPhamChon);

                string msg = result ? "Xóa thành công" : "Xóa thất bại";
                MessageBoxExtension.Notification("XÓA", msg);

                LoadGridData();
            }
        }

        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
            _sanPhams = _sanPhamServices.GetList().Where(sp => sp.TenSanPham.Contains(txt_timkiem.Text)).ToList();

            dgv_sanpham.Rows.Clear();

            foreach (var sp in _sanPhams)
            {
                dgv_sanpham.Rows.Add(
                    (_sanPhams.IndexOf(sp) + 1),
                    sp.TenSanPham,
                    sp.GiaBan,
                    sp.SoLuongTon,
                    sp.NhaSanXuat,
                    sp.TrangThai,
                    sp.MoTa
                );
            }
        }
    }
}
