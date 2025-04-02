using MediatR;
using System.ComponentModel.DataAnnotations;

namespace ElSolNEC.Application.Transactions.Command
{
    public record DeleteTransactionCommand(
        [Required] int TransactionId,
        [Required] int UserId
    ) : IRequest<Unit>;
}
