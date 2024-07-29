using ThreeLayerWF.BUS.ViewModel;

namespace ThreeLayerWF.BUS.Interface
{
    public interface ISanPhamServices
    {
        SanPhamVM GetByCode(int code);
        List<SanPhamVM> GetList();
        string Create(SanPhamCreateVM createVM);
        bool Delete(int code);
        bool Update(SanPhamUpdateVM updateVM);
        List<SanPhamVM> GetListOrderByName();
        //List<SanPhamVM> GetListByName();

        string GetLoaiSanPhamName(int? maLoai);
    }
}
