using ElSolNEC.Application.DTOs;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace ElSolNEC.Application.Users.Queries
{
    public record GetUserByUserIdQuery(
        [Required] int UserId
    ) : IRequest<UserDto>;
}
