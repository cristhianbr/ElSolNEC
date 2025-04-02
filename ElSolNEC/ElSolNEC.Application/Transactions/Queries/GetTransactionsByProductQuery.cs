using ElSolNEC.Application.DTOs;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace ElSolNEC.Application.Transactions.Queries
{
    public record GetTransactionsByProductQuery(
        [Required] int ProductId
    ) : IRequest<List<TransactionDto>>;
}
