using ElSolNEC.Application.DTOs;
using ElSolNEC.Domain.Services;
using ElSolNEC.Infrastructure;
using MediatR;

namespace ElSolNEC.Application.Users.Queries
{
    public class GetUserByUserIdQueryHandler(
        UserService service
    ) : IRequestHandler<GetUserByUserIdQuery, UserDto>
    {
        public async Task<UserDto> Handle(
            GetUserByUserIdQuery query,
            CancellationToken cancellationToken
        )
        {
            User user = await service.GetUserByUserIdAsync(query.UserId);

            List<RoleDto> roles = user.Usersinroles
                .Select(role => new RoleDto
                {
                    RoleId = role.Roleid,
                    RolName = role.Role.Rolename
                })
                .ToList();

            return new UserDto()
            {
                UserId = user.Userid,
                UserName = user.Username,
                Email = user.Email,
                Password = user.Passwordhash,
                Roles = roles
            };
        }
    }
}
