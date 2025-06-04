using Microsoft.EntityFrameworkCore;
using WebApi.Data.Entities;

namespace WebApi.Data;

public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
{
    public DbSet<TermEntity> Terms { get; set; }
    public DbSet<TermDetailEntity> TermDetails { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TermDetailEntity>()
            .HasOne(t => t.Term)
            .WithMany(t => t.Details)
            .HasForeignKey(t => t.TermId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
