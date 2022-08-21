using Microsoft.EntityFrameworkCore;
using Customer.Domain.Entities;

namespace Customer.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Customers?> Customers { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
