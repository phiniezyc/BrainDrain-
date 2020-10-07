using Microsoft.EntityFrameworkCore;
using BrainDrain.Models;
namespace BrainDrain.Data
{
  public class BrainDrainContext : DbContext
  {
    public BrainDrainContext(DbContextOptions<BrainDrainContext> opt) : base(opt)
    {

    }

    public DbSet<Command> Commands { get; set;}
  }
}