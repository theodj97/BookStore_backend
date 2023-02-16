using Application.Common.Interfaces;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Users.Commands.CreateUser
{
    public record CreateUserCommand : IRequest<Guid>
    {
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Phone { get; set; }
        public int Role { get; set; }
    }

    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, Guid>
    {
        private readonly IApplicationDbContext _context;

        public CreateUserCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Guid> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var entity = new User
            {
                Name = request.Name,
                LastName = request.LastName,
                Email = request.Email,
                Password = request.Password,
                Phone = request.Phone,
                Role = request.Role
            };

            _context.Users.Add(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return entity.Id;
        }
    }
}
