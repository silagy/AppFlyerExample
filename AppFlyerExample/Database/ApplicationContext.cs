using AppFlyerExample.Models;
using Microsoft.EntityFrameworkCore;

namespace AppFlyerExample.Database;

public class ApplicationContext : DbContext
{

    public DbSet<Question> Questions { get; set; }
    public DbSet<Content> Contents { get; set; }
    public DbSet<Answer> Answers { get; set; }
    public DbSet<QuestionAnswer> QuestionAnswers { get; set; }
    public DbSet<ContentAnswer> ContentAnswers { get; set; }

    public ApplicationContext(DbContextOptions options) : base(options)
    {
        
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }
}