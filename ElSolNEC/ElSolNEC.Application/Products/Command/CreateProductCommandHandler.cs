using ElSolNEC.Application.DTOs;
using ElSolNEC.Domain.Services;
using ElSolNEC.Infrastructure;
using MediatR;

namespace ElSolNEC.Application.Products.Command
{
    public class CreateProductCommandHandler(
        ProductService service
    ) : IRequestHandler<CreateProductCommand, ProductDto>
    {
        public async Task<ProductDto> Handle(
            CreateProductCommand command,
            CancellationToken cancellationToken
        )
        {
            Product product = await service.CreateProductAsync(
                command.ProductName,
                command.Inventory,
                command.Price
            );

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
