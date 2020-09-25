using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using BrainDrain.Models;
using BrainDrain.Data;
namespace BrainDrain.Controllers
{
  [Route("api/commands")]
  [ApiController]
  // Use ControllerBase instead of Controller to keep it as lean as possible
  public class CommandsController : ControllerBase
  {
    private readonly IBrainDrainRepo _repository;
    public CommandsController(IBrainDrainRepo repository)
    {
      _repository = repository;
    }
    // private readonly MockBrainDrainRepo _repository = new MockBrainDrainRepo();  // This is the less useful way so commented out

    // Get: api/commands
    [HttpGet]
    public ActionResult <IEnumerable<Command>> GetAllCommands()
    {
      var commandItems = _repository.GetAllCommands();

      return Ok(commandItems);
    }

    // Get: api/commands/{id}
    [HttpGet("{id}")]
    public ActionResult <Command> GetCommandById(int id) //id comes from the request
    {
      var commandItem = _repository.GetCommandById(id);

      return Ok(commandItem);
    }
  }
}