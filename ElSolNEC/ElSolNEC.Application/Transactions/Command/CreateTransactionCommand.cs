using ElSolNEC.Application.DTOs;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace ElSolNEC.Application.Transactions.Command
{
    public record CreateTransactionCommand(
        [Required] int ProductId,
        [Required] int UserId,
        [Required] int Quantity
    ) : IRequest<TransactionDto>;
}
