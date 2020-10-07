using Microsoft.EntityFrameworkCore;
namespace BrainDrain.Data
{
  public class BrainDrainContext : DbContext
  {
    public BrainDrainContext(DbContextOptions<BrainDrainContext> opt) : base(opt)
    {

    }
  }
}