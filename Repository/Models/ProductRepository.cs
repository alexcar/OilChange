using Contracts;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository.Models
{
    internal sealed class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public async Task<Product?> GetByIdAsync(Guid productManufacturerId, Guid id, bool trackChanges) =>
            await FindByCondition(p => p.ProductManufacturerId.Equals(productManufacturerId) &&
                p.Id.Equals(id), trackChanges).SingleOrDefaultAsync();


        //public async Task<PagedList<Product>> GetAllAsync(
        //    Guid productManufacturerId,
        //    ProductParameters productParameters,
        //    bool trackChanges)
        //{
        //    var products = await FindByCondition(
        //        p => p.ProductManufacturerId.Equals(productManufacturerId), trackChanges)
        //        .FilterProducts(productParameters.MinPrice, productParameters.MaxPrice)
        //        .Search(productParameters.SearchTerm)
        //        .Sort(productParameters.OrderBy)
        //        .ToListAsync();

        //    return PagedList<Product>
        //        .ToPagedList(products, productParameters.PageNumber, productParameters.PageSize);
        //}


        public void CreateProductForProductManufacturer(Guid productManufacturerId, Product product)
        {
            product.ProductManufacturerId = productManufacturerId;
            Create(product);
        }

        public void DeleteProduct(Product product) => Delete(product);

    }
}
