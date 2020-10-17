using AutoMapper;
using BrainDrain.Dtos;
using BrainDrain.Models;
namespace BrainDrain.Profiles
{
  public class BrainDrainProfile: Profile
  {
    public BrainDrainProfile()
    {
      //Source => Target
      CreateMap<Command, CommandReadDto>();
      CreateMap<CommandCreateDto, Command>();
      CreateMap<CommandUpdateDto, Command>();
      CreateMap<Command, CommandUpdateDto>();
    }
  }
}