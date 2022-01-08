using Microsoft.EntityFrameworkCore;

namespace FactoryManager.Models
{
  public class FactoryManagerContext : DbContext
  {
    public DbSet<Engineer> Engineers {get;set;}
    public DbSet<Machine> Machines {get;set;}
    public DbSet<EngineerMachine> EngineerMachine {get;set;}

    public FactoryManagerContext(DbContextOptions options) : base(options) {}

    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
      builder.UseLazyLoadingProxies();
    }
  }
}