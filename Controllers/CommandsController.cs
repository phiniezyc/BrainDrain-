using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using BrainDrain.Data;
using BrainDrain.Dtos;
using BrainDrain.Models;

namespace BrainDrain.Controllers
{
  [Route("api/commands")]
  [ApiController]
  // Use ControllerBase instead of Controller to keep it as lean as possible
  public class CommandsController : ControllerBase
  {
    private readonly IBrainDrainRepo _repository; // TODO: lookup readonly?
    private readonly IMapper _mapper;
    public CommandsController(IBrainDrainRepo repository, IMapper mapper) //constructor
    {
      _repository = repository; // _ denotes that it is private
      _mapper = mapper;
    }
    // private readonly MockBrainDrainRepo _repository = new MockBrainDrainRepo();  // This is the less useful way so commented out

    // Get: api/commands
    [HttpGet]
    public ActionResult <IEnumerable<CommandReadDto>> GetAllCommands()
    {
      var commandItems = _repository.GetAllCommands();

      return Ok(_mapper.Map<IEnumerable<CommandReadDto>>(commandItems));
    }

    // Get: api/commands/{id}
    [HttpGet("{id}")]
    public ActionResult <CommandReadDto> GetCommandById(int id) //id comes from the request
    {
      var commandItem = _repository.GetCommandById(id);
      if (commandItem != null) {
        return Ok(_mapper.Map<CommandReadDto>(commandItem));
      }
      return NotFound();
    }

    //POST api/commands
    [HttpPost]
    public ActionResult <CommandReadDto> CreateCommand(CommandCreateDto commandCreateDto)
    {
      var commandModel = _mapper.Map<Command>(commandCreateDto);
      _repository.CreateCommand(commandModel);
      _repository.SaveChanges();

      return Ok(commandModel);
    }
  }
}