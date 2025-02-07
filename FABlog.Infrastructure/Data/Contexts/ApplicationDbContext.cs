using FABlog.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace FABlog.Infrastructure.Data.Contexts;

internal class ApplicationDbContext : DbContext
{
    private readonly IConfiguration _configuration;

    public ApplicationDbContext(in IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = _configuration.GetConnectionString("Default")
                               ?? throw new InvalidOperationException("The connection string is not defined!");
        optionsBuilder.UseNpgsql(connectionString: connectionString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>(userEntity =>
        {
            userEntity.HasKey(user => user.UserID);

            userEntity.Property(user => user.UserName)
                      .HasMaxLength(255)
                      .IsRequired();

            userEntity.Property(user => user.UserPassword)
                      .HasMaxLength(255)
                      .IsRequired();

            userEntity.Property(user => user.UserEmail)
                      .IsRequired();
        });
    }
}
