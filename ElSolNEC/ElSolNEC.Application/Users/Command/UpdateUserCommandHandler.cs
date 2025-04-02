using ElSolNEC.Application.DTOs;
using ElSolNEC.Domain.Services;
using ElSolNEC.Infrastructure;
using MediatR;

namespace ElSolNEC.Application.Users.Command
{
    public class UpdateUserCommandHandler(
        UserService service
    ) : IRequestHandler<UpdateUserCommand, UserDto>
    {
        public async Task<UserDto> Handle(
            UpdateUserCommand command,
            CancellationToken cancellationToken
        )
        {
            User user = await service.UpdateUserAsync(
                command.UserId,
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
