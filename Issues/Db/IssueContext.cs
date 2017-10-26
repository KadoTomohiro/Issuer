using Microsoft.EntityFrameworkCore;

namespace Issues.Db
{
    public class IssueContext: DbContext
    {
        private DbSet<IssueSchema> Issue { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlite("Data Source=Issue.db");
        }
    }
}