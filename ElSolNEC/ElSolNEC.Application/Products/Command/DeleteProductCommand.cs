using MediatR;
using System.ComponentModel.DataAnnotations;

namespace ElSolNEC.Application.Products.Command
{
    public record DeleteProductCommand(
        [Required] int Id
    ) : IRequest<Unit>;
}
