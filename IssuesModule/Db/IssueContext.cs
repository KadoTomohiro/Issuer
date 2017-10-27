using Microsoft.EntityFrameworkCore;

namespace IssuesModule.Db
{
  public class IssueContext : DbContext
  {
    private DbSet<IssueSchema> Issue { get; set; }
    private static bool _created = false;

    public IssueContext()
    {
      if (_created) return;
      _created = true;

      Database.EnsureDeleted();
      Database.EnsureCreated();
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
    {
      optionBuilder.UseSqlite("Data Source=Issue.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);

      SQLitePCL.Batteries_V2.Init();
    }
  }
}
