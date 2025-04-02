using ElSolNEC.Application.DTOs;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace ElSolNEC.Application.Products.Command
{
    public record CreateProductCommand(
        [Required] string ProductName,
        [Required] int Inventory,
        [Required] int Price
    ) : IRequest<ProductDto>;
}
