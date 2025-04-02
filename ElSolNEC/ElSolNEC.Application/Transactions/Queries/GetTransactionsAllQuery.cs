using ElSolNEC.Application.DTOs;
using MediatR;

namespace ElSolNEC.Application.Transactions.Queries
{
    public record GetTransactionsAllQuery() : IRequest<List<TransactionDto>>;
}
