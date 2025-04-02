using ElSolNEC.Application.DTOs;
using ElSolNEC.Domain.Services;
using ElSolNEC.Infrastructure;
using MediatR;

namespace ElSolNEC.Application.Products.Command
{
    public class UpdateProductCommandHandler(
        ProductService service
    ) : IRequestHandler<UpdateProductCommand, ProductDto>
    {
        public async Task<ProductDto> Handle(
            UpdateProductCommand command,
            CancellationToken cancellationToken
        )
        {
            Product product = await service.UpdateProductAsync(
                command.ProductId,
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
