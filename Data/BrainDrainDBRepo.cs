using System;
using System.Collections.Generic;
using System.Linq;
using BrainDrain.Models;

namespace BrainDrain.Data {
  public class BrainDrainDBRepo : IBrainDrainRepo
  {
    private readonly BrainDrainContext _context;
    public BrainDrainDBRepo(BrainDrainContext context)
    {
      _context = context;
    }

    public void CreateCommand(Command cmd)
    {
      if (cmd == null)
      {
        throw new ArgumentNullException(nameof(cmd));
      }
      _context.Commands.Add(cmd);
    }

    public void DeleteCommand(Command cmd)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Command> GetAllCommands()
    {
      return _context.Commands.ToList();
    }

    public Command GetCommandById(int id)
    {
      return _context.Commands.FirstOrDefault(p => p.Id == id);
    }

    public bool SaveChanges()
    {
      return (_context.SaveChanges() >= 0);
    }

    public void UpdateCommand(Command cmd)
    {
      //Nothing
    }

  }
}