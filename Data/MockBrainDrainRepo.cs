using System.Collections.Generic;
using BrainDrain.Models;

namespace BrainDrain.Data
{
  public class MockBrainDrainRepo : IBrainDrainRepo
  {
    public IEnumerable<Command> GetAllCommands()
    {

    }
    public Command GetCommandById(int id)
    {
      return new Command
      {
        Id=0,
        HowTo="Play Guitar Well",
        Line="Practice",
        Platform="Blues"
      };
    }
  }
}