using Microsoft.EntityFrameworkCore;

namespace Eau-Claire.Models
{
  public class EauClaire: DbContext
  {
    public DbSet<Client> Items { get; set; }
    public virtual DbSet<Stylist> Categories { get; set; }

    public ToDoListContext(DbContextOptions options) : base(options) { }
  }
}