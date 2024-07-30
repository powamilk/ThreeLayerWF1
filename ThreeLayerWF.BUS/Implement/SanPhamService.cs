using ThreeLayerWF.BUS.Interface;
using ThreeLayerWF.BUS.Utils;
using ThreeLayerWF.BUS.ViewModel;
using ThreeLayerWF.DAL;
using ThreeLayerWF.DAL.Entities;
using ThreeLayerWF.DAL.Repositories.Implement;
using ThreeLayerWF.DAL.Repositories.Interface;


namespace ThreeLayerWF.BUS.Implement
{
    public class SanPhamServices : ISanPhamService
    {
        private readonly ISanPhamRepo _repo;
        private readonly AppDbContext _appDbContext;
        public SanPhamServices()
        {
            _repo = new SanPhamRepo();
            _appDbContext = new AppDbContext();
        }
        public string Create(SanPhamCreateVM createVM)
        {
            SanPham entity = SanPhamMapping.MapCreateVMToEntity(createVM);
            var result = _repo.Create(entity);
            return result;
        }

        public bool Delete(int code)
        {
            var result = _repo.Delete(code);
            return result;
        }

        public SanPhamVM GetByCode(int code)
        {
            var entity = _repo.GetByCode(code);
            return entity != null ? SanPhamMapping.MapEntityToVM(entity) : null;
        }

        public List<SanPhamVM> GetList()
        {
            return _repo.GetList().Select(SanPhamMapping.MapEntityToVM).ToList();
        }

        //public List<SanPhamVM> GetListByName(string tenSanPham)
        //{
        //    var sanPhams = _repo.GetAll()
        //        .Where(pham => pham.TenSanPham.Contains(tenSanPham).ToList();

        //    return sanPhams.Select(pham => new SanPhamVM
        //    {
        //        MaSanPham = pham.maSanPham,
        //        TenSanPham = pham.tenSanPham,
        //        GiaBan = pham.giaBan,
        //        SoLuongTon = pham.soLuongTon,
        //        NhaSanXuat = pham.nhaSanXuat,
        //        XuatXu = pham.xuatXu,
        //        TrangThai = pham.trangThai,
        //        MoTa = pham.moTa,
        //        MaLoai = pham.maLoai,

        //    }).ToList();
        //}

        public List<SanPhamVM> GetListOrderByName()
        {
            return _repo.GetListOrderByName().Select(SanPhamMapping.MapEntityToVM).ToList();
        }

        public bool Update(SanPhamUpdateVM updateVM)
        {
            SanPham entity = SanPhamMapping.MapUpdateVMToEntity(updateVM);
            var result = _repo.Update(entity);
            return result;
        }
        public string GetLoaiSanPhamName(int? maLoai)
        {
            if (maLoai == null)
                return "không xác định";

            var loaiSanPham = _appDbContext.LoaiSanPhams.FirstOrDefault(lsp => lsp.MaLoai == maLoai);
            return loaiSanPham?.TenLoai ?? "không xác định";
        }
    }
}
