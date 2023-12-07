using InMemoryAPIDonet.Entities;
using Microsoft.EntityFrameworkCore;

namespace InMemoryAPIDonet.Database;

public class ApplicationContextDb : DbContext
{
    public DbSet<User> users { get; set; }

    public ApplicationContextDb(DbContextOptions<ApplicationContextDb> options) : base(options)
    { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationContextDb).Assembly);

    }

}
