using GetAHomeApi.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GetAHomeApi.Data;

public class Context : IdentityDbContext<AppUser>
{
    public DbSet<AppUser> AppUsers => Set<AppUser>();
    public DbSet<SaleStatus> SaleStatuses => Set<SaleStatus>();
    public DbSet<Tenure> Tenures => Set<Tenure>();
    public DbSet<ResidenceType> ResidenceTypes => Set<ResidenceType>();
    public DbSet<Address> Adresses => Set<Address>();
    public DbSet<ExpressionOfInterest> ExpressionOfInterests => Set<ExpressionOfInterest>();
    public DbSet<Image> Images => Set<Image>();
    public DbSet<Residence> Residences => Set<Residence>();

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

        // Skapar kompositnyckel av de två FK.
        modelBuilder.Entity<ExpressionOfInterest>()
            .HasKey(eoi => new { eoi.AppUserId, eoi.ResidenceId });
        // Konfigurera Foreign Keys i kopplingstabellen.
        modelBuilder.Entity<ExpressionOfInterest>()
            .HasOne(eoi => eoi.AppUser)
            .WithMany(au => au.ExpressionOfInterests)
            .HasForeignKey(eoi => eoi.AppUserId);
        modelBuilder.Entity<ExpressionOfInterest>()
            .HasOne(eoi => eoi.Residence)
            .WithMany(r => r.ExpressionOfInterests)
            .HasForeignKey(eoi => eoi.ResidenceId);

        // Gör att mäklaren inte kan raderas innan objektet har raderats.
        modelBuilder.Entity<Residence>()
            .HasOne(r => r.EstateAgent)
            .WithMany(ea => ea.Residences)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
