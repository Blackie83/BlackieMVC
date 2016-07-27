namespace BlackieMVC.Models
{
  using System;
  using System.Data.Entity;
  using System.ComponentModel.DataAnnotations.Schema;
  using System.Linq;

  public partial class DBInfoQuest : DbContext
  {
    public DBInfoQuest()
        : base("name=InfoQuestMOSSConnectionString")
    {
    }

    public virtual DbSet<Administration_Unit> Administration_Unit { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
    }
  }
}
