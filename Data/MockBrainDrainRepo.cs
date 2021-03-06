using System.Collections.Generic;
using BrainDrain.Models;

namespace BrainDrain.Data
{
  public class MockBrainDrainRepo : IBrainDrainRepo
  {
    public void CreateCommand(Command cmd)
    {
      throw new System.NotImplementedException();
    }

    public void DeleteCommand(Command cmd)
    {
      throw new System.NotImplementedException();
    }

    public IEnumerable<Command> GetAllCommands()
    {
      var commands = new List<Command>
      {
        new Command {Id=0,HowTo="Play Guitar Well",Line="Practice",Platform="Music Theory"},
        new Command {Id=1,HowTo="Play Jazz",Line="Play Over The Changes",Platform="Jazz"},
        new Command {Id=2,HowTo="Play Blues",Line="Major Chords",Platform="Blues"}
      };

      return commands;
    }
    public Command GetCommandById(int id)
    {
      return new Command
      {
        Id=0,
        HowTo="Play Guitar Well",
        Line="Practice",
        Platform="Music Theory"
      };
    }

    public bool SaveChanges()
    {
      throw new System.NotImplementedException();
    }

    public void UpdateCommand(Command cmd)
    {
      throw new System.NotImplementedException();
    }
  }
}