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
    public ActionResult <IEnumerable<Command>> GetAllCommands()
    {

    }
  }
}