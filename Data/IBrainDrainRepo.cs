using System.Collections.Generic;
using BrainDrain.Models;
namespace  BrainDrain.Data
{
  // Interface is just a list of the methods provided to the consumer of the interface
    public interface IBrainDrainRepo
      {

        bool SaveChanges();
        
        // TODO: What is an IEnumerable?
        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(int id);

        void CreateCommand(Command cmd);
      }
}