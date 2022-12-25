namespace Laba3;

public class ApplicationContext : DbContext
{
    public DbSet<Car> Cars => Set<Car>();
    public DbSet<Stock> Stocks => Set<Stock>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=AllCars.db");
    }
}