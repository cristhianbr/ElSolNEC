using ElSolNEC.Application.DTOs;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace ElSolNEC.Application.Products.Queries
{
    public record GetProductByProductIdQuery(
        [Required] int ProductId
    ) : IRequest<ProductDto>;
}
