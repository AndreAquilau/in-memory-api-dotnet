O "DataBase InMemory EF" é uma ótima opção para desenvolvedores que precisam testar e prototipar funcionalidades de banco de dados sem se preocupar com a infraestrutura e configuração de um banco de dados real.

### ApplicationContextDb
```csharp
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
```

### UserConfiguration
```csharp
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using InMemoryAPIDonet.Entities;

namespace InMemoryAPIDonet.Database.Configuration;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Name);

        builder.Property(p => p.Email);

    }
}
```