using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Category> Category { get; set; }

    public DbSet<Question> Question { get; set; }

    public DbSet<Quiz> Quiz { get; set; }

    public DbSet<Response> Response { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(
            typeof(ApplicationDbContext).Assembly
        );

        //    builder.Entity<Category>(entity =>
        //    {
        //        entity.HasMany(u => u.Quiz)
        //            .WithMany(p => p.Category);
        //    });
    }
}

