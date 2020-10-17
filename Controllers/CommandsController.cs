using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using BrainDrain.Data;
using BrainDrain.Dtos;
using BrainDrain.Models;
using Microsoft.AspNetCore.JsonPatch;

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
    [HttpGet("{id}", Name="GetCommandById")]
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

      var commandReadDto = _mapper.Map<CommandReadDto>(commandModel);

      return CreatedAtRoute(nameof(GetCommandById), new {Id = commandReadDto.Id}, commandReadDto);
      //return Ok(commandReadDto);
    }

    //PUT api/commands/{id}
    [HttpPut("{id}")]
    public ActionResult UpdateCommand(int id, CommandUpdateDto commandUpdateDto)
    {
      var commandModelFromRepo = _repository.GetCommandById(id);

      if(commandModelFromRepo == null)
      {
        return NotFound();
      }
      _mapper.Map(commandUpdateDto, commandModelFromRepo);

      _repository.UpdateCommand(commandModelFromRepo);
      _repository.SaveChanges();
      return NoContent();
    }

    //PATCH api/commands/{id}
    //Patch is more efficient updating because don't have to supply the whole object each times as in the Put method

    //EX: localhost:5000/api/commands/7
    /* payload to pass to the api from client (postman). Replace = operation. Path = what key to target
      [
      {
        "op": "replace",
        "path": "/howto",
        "value": "Some new value"
      }
      ]
    */
    [HttpPatch("{id}")]
    public ActionResult PartialCommandUpdate(int id, JsonPatchDocument<CommandUpdateDto> patchDoc)
    {
      var commandModelFromRepo = _repository.GetCommandById(id);

      if(commandModelFromRepo == null)
      {
        return NotFound();
      }

      var CommandToPatch = _mapper.Map<CommandUpdateDto>(commandModelFromRepo);
      patchDoc.ApplyTo(CommandToPatch, ModelState);

      if(!TryValidateModel(CommandToPatch))
      {
        return ValidationProblem(ModelState);
      }

      _mapper.Map(CommandToPatch, commandModelFromRepo);
      _repository.UpdateCommand(commandModelFromRepo);
      _repository.SaveChanges();

      return NoContent();
    }

    
  }
}