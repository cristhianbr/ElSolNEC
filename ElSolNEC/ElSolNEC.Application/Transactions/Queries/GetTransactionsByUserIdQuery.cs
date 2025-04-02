using ElSolNEC.Application.DTOs;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace ElSolNEC.Application.Transactions.Queries
{
    public record GetTransactionsByUserIdQuery(
        [Required] int UserId
    ) : IRequest<List<TransactionDto>>;
}
