using GetAHomeApi.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GetAHomeApi.Data;

public class Context : IdentityDbContext<AppUser>
{
    public DbSet<AppUser> AppUsers => Set<AppUser>();

    public Context(DbContextOptions options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<AppUser>()
            .Property(a => a.Email)
            .IsRequired();
        modelBuilder.Entity<AppUser>()
            .Property(a => a.FirstName)
            .IsRequired();
        modelBuilder.Entity<AppUser>()
            .Property(a => a.LastName)
            .IsRequired();
    }
}
