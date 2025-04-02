using ElSolNEC.Application.DTOs;
using ElSolNEC.Domain.Services;
using ElSolNEC.Infrastructure;
using MediatR;

namespace ElSolNEC.Application.Users.Command
{
    public class CreateUserCommandHandler(
        UserService service
    ) : IRequestHandler<CreateUserCommand, UserDto>
    {
        public async Task<UserDto> Handle(
            CreateUserCommand command,
            CancellationToken cancellationToken
        )
        {
            User user = await service.CreateUserAsync(
                command.UserName,
                command.Email,
                command.PasswordHash,
                command.Roles
            );

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
