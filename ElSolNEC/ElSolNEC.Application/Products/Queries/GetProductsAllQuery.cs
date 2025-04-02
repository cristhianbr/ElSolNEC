using ElSolNEC.Application.DTOs;
using MediatR;

namespace ElSolNEC.Application.Products.Queries
{
    public record GetProductsAllQuery() : IRequest<List<ProductDto>>;
}
