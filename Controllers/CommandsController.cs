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
    private readonly MockBrainDrainRepo _repository = new MockBrainDrainRepo();

    // Get: api/commands
    [HttpGet]
    public ActionResult <IEnumerable<Command>> GetAllCommands()
    {

    }

    // Get: api/commands/{id}
    [HttpGet("{id}")]
    public ActionResult <Command> GetCommandById(int id)
    {

    }
  }
}