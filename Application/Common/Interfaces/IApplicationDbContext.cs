using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<User> Users { get; }

        DbSet<Book> Books { get; }

        DbSet<Login> Login { get; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
