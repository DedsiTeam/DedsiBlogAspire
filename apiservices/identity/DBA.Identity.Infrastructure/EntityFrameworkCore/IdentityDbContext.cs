using DBA.EFCore.EntityFrameworkCore;
using DBA.Identity.Domain.Users;
using Microsoft.EntityFrameworkCore;

namespace DBA.Identity.Infrastructure.EntityFrameworkCore;

public class IdentityDbContext(DbContextOptions<IdentityDbContext> options) : DbaEfCoreDbContext(options)
{
    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>(b =>
        {
            b.ToTable("Users", "Identity");
            b.HasKey(a => a.Id);
        });
    }
}
