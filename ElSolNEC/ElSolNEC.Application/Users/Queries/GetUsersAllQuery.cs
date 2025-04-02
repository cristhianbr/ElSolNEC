using ElSolNEC.Application.DTOs;
using MediatR;

namespace ElSolNEC.Application.Users.Queries
{
    public record GetUsersAllQuery() : IRequest<List<UserDto>>;
}
