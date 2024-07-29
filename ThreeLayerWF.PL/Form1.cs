using ThreeLayerWF.BUS.Implement;
using ThreeLayerWF.BUS.Interface;
using ThreeLayerWF.BUS.ViewModel;
using ThreeLayerWF.PL.Extensions;

namespace ThreeLayerWF.PL
{
    public partial class Form1 : Form
    {
        List<SanPhamVM> _sanPhams;
        ISanPhamServices _sanPhamServices;
        string _tenSPChon;

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

            txt_tensanpham.Text = string.Empty;
            txt_nhasanxuat.Text = string.Empty;
            txt_xuatxu.Text = string.Empty;
            txt_mota.Text = string.Empty;


            dgv_sanpham.Columns.Clear();
            dgv_sanpham.Columns.Add("CLm1", "STT");
            dgv_sanpham.Columns.Add("CLm2", "Tên");
            dgv_sanpham.Columns.Add("CLm3", "Giá Bán");
            dgv_sanpham.Columns.Add("CLm4", "Số Lượng Tồn");
            dgv_sanpham.Columns.Add("CLm5", "Nhà Sản Xuất");
            dgv_sanpham.Columns.Add("CLm6", "Trạng Thái");
            dgv_sanpham.Columns.Add("CLm7", "Mô tả");
            dgv_sanpham.Columns.Add("clm8", "Mã Loại");
        }

        private string HienThi(string text)
        {
            return $"Nhập {text}";
        }

        private void LoadGridData()
        {
            _sanPhams = _sanPhamServices.GetList(); // Lấy danh sách sản phẩm từ dịch vụ

            dgv_sanpham.Rows.Clear();

            foreach (var pham in _sanPhams)
            {
                string trangThai = pham.TrangThai == 1 ? "Đang bán" : "Tạm dừng";
                string maLoaiDisplay = _sanPhamServices.GetLoaiSanPhamName(pham.MaLoai);

                dgv_sanpham.Rows.Add(
                    (_sanPhams.IndexOf(pham) + 1),
                    pham.TenSanPham,
                    pham.GiaBan,
                    pham.SoLuongTon,
                    pham.NhaSanXuat,
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

        private void dgv_sanpham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = e.RowIndex;

            if (index < 0 || index > _sanPhams.Count - 1)
            {
                _tenSPChon = string.Empty;
                return;
            }
            var tenSPChon = _sanPhams.ElementAt(index);

            _tenSPChon = tenSPChon.TenSanPham;
            txt_tensanpham.Text = tenSPChon.TenSanPham;
            cb_giaban.Text = tenSPChon.GiaBan.ToString();
            cb_soluongton.Text = tenSPChon.SoLuongTon.ToString();
            txt_nhasanxuat.Text = tenSPChon.NhaSanXuat;
            cb_trangthai.Text = tenSPChon.TrangThai.ToString();
            txt_xuatxu.Text = tenSPChon.XuatXu;
            txt_mota.Text = tenSPChon.MoTa;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (MessageBoxExtension.Confirm("thêm"))
            {
                var sanPhamCreate = new SanPhamCreateVM
                {
                    TenSanPham = txt_tensanpham.Text,
                    GiaBan = int.Parse(cb_giaban.Text),
                    SoLuongTon = int.Parse(cb_soluongton.Text),
                    NhaSanXuat = txt_nhasanxuat.Text,
                    XuatXu = txt_xuatxu.Text,
                    TrangThai = int.Parse(cb_trangthai.Text),
                    MoTa = txt_mota.Text
                };

                var result = _sanPhamServices.Create(sanPhamCreate);
                MessageBoxExtension.Notification("THÊM", result);
                LoadGridData();
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_tenSPChon))
            {
                MessageBoxExtension.Notification("CHỈNH SỬA", "Vui lòng chọn sản phẩm cần chỉnh sửa.");
                return;
            }

            var spUpdate = new SanPhamUpdateVM
            {
                MaSanPham = _sanPhams.FirstOrDefault(p => p.TenSanPham == _tenSPChon)?.MaSanPham ?? 0,
                TenSanPham = txt_tensanpham.Text,
                GiaBan = int.Parse(cb_giaban.Text),
                SoLuongTon = int.Parse(cb_soluongton.Text),
                NhaSanXuat = txt_nhasanxuat.Text,
                XuatXu = txt_xuatxu.Text,
                TrangThai = int.Parse(cb_trangthai.Text),
                MoTa = txt_mota.Text
            };

            var result = _sanPhamServices.Update(spUpdate);

            string msg = result ? "Chỉnh sửa thành công" : "Chỉnh sửa thất bại";
            MessageBoxExtension.Notification("CHỈNH SỬA", msg);

            LoadGridData();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_tenSPChon))
            {
                MessageBoxExtension.Notification("XÓA", "Vui lòng chọn sản phẩm cần xóa.");
                return;
            }

            if (MessageBoxExtension.Confirm("xóa"))
            {
                var code = _sanPhams.FirstOrDefault(p => p.TenSanPham == _tenSPChon)?.MaSanPham ?? 0;
                var result = _sanPhamServices.Delete(code);

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

        private void dgv_sanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = e.RowIndex;

            if (index < 0 || index > _sanPhams.Count - 1)
            {
                _tenSPChon = string.Empty;
                return;
            }
            var tenSPChon = _sanPhams.ElementAt(index);

            _tenSPChon = tenSPChon.TenSanPham;
            txt_tensanpham.Text = tenSPChon.TenSanPham;
            cb_giaban.Text = tenSPChon.GiaBan.ToString();
            cb_soluongton.Text = tenSPChon.SoLuongTon.ToString();
            txt_nhasanxuat.Text = tenSPChon.NhaSanXuat;
            cb_trangthai.Text = tenSPChon.TrangThai.ToString();
            txt_xuatxu.Text = tenSPChon.XuatXu;
            txt_mota.Text = tenSPChon.MoTa;
        }
    }
}
