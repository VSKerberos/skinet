using Core.Entities;

namespace Core.Specifications
{
    public class ProductsWithTypesAndBrandsSpecification : BaseSpecification<Product>
    {
        public ProductsWithTypesAndBrandsSpecification(int id) : base(x => x.Id == id)
        {

            AddInclude(x => x.ProductType);
            AddInclude(v => v.ProductBrand);
        }
        public ProductsWithTypesAndBrandsSpecification()
        {
            AddInclude(x => x.ProductType);
            AddInclude(v => v.ProductBrand);

        }
    }
}