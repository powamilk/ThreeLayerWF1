using ThreeLayerWF.DAL.Entities;

namespace ThreeLayerWF.DAL.Repositories.Interface
{
    public interface ISanPhamRepo
    {
        List<SanPham> GetList();
        List<SanPham> GetListOrderByName();
        string Create(SanPham pham);
        bool Update(SanPham pham);
        bool Delete(int code);
        List<SanPham> GetAll();
        SanPham GetByCode(int code);

    }
}
