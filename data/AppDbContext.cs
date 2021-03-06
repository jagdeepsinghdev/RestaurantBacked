using Microsoft.EntityFrameworkCore;
public class AppDbContext : DbContext
{
    public DbSet<MenuItem> MenuItems { set; get; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .UseMySQL(@"server=localhost;user=root;password=password;database=AngularAppbackend;");
        base.OnConfiguring(optionsBuilder);
    }
}