using ElSolNEC.Application.DTOs;
using ElSolNEC.Domain.Services;
using ElSolNEC.Infrastructure;
using MediatR;

namespace ElSolNEC.Application.Products.Queries
{
    public class GetProductByProductIdQueryHandler(
        ProductService service
    ) : IRequestHandler<GetProductByProductIdQuery, ProductDto>
    {
        public async Task<ProductDto> Handle(
            GetProductByProductIdQuery query,
            CancellationToken cancellationToken
        )
        {
            Product product = await service.GetProductByProductIdAsync(query.ProductId);

            return new ProductDto()
            {
                ProductId = product.Productid,
                ProductName = product.Productname,
                Price = product.Price,
                Inventory = product.Inventory
            };
        }
    }
}
