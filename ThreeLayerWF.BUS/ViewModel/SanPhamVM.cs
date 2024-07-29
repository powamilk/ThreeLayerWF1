namespace ThreeLayerWF.BUS.ViewModel
{
    public class SanPhamVM
    {
        public int MaSanPham { get; set; }
        public string TenSanPham { get; set; } = null!;
        public int GiaBan { get; set; }
        public int SoLuongTon { get; set; }
        public string? NhaSanXuat { get; set; }
        public string? XuatXu { get; set; }
        public int TrangThai { get; set; }
        public string? MoTa { get; set; }
        public int? MaLoai { get; set; }
    }
}
