
using Shared.DataTransferobjects.Products;

namespace ServicesAbstractions
{
    public interface IProductService
    {
        Task<IEnumerable<ProductResponse>> GetAllProductsAsync();
        Task<ProductResponse> GetProductAsync(int id);
        Task<IEnumerable<BrandResponse> >GetBrandsAsync(int id);
        Task<IEnumerable<TypeResponse>> GetTypesAsync(int id);
         
    }
}
