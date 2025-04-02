using ElSolNEC.Application.DTOs;
using ElSolNEC.Domain.Services;
using ElSolNEC.Infrastructure;
using MediatR;

namespace ElSolNEC.Application.Products.Queries
{
    public class GetProductsAllQueryHandler(
        ProductService service
    ) : IRequestHandler<GetProductsAllQuery, List<ProductDto>>
    {
        public async Task<List<ProductDto>> Handle(
            GetProductsAllQuery query,
            CancellationToken cancellationToken
        )
        {
            List<Product> products = await service.GetProductsAllAsync();

            List<ProductDto> productsDtos = products.Select(product =>
                new ProductDto()
                {
                    ProductId = product.Productid,
                    ProductName = product.Productname,
                    Price = product.Price,
                    Inventory = product.Inventory
                }            
            ).ToList();

            return productsDtos;
        }
    }
}
