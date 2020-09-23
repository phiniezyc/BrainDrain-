using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using BrainDrain.Models;
namespace BrainDrain.Controllers
{
  [Route("api/commands")]
  [ApiController]
  // Use ControllerBase instead of Controller to keep it as lean as possible
  public class CommandsController : ControllerBase
  {
    [HttpGet]
    public ActionResult <IEnumerable<Command>> GetAllCommands()
    {

    }
    [HttpGet]
    public ActionResult <Command> GetCommandById(int id)
    {

    }
  }
}