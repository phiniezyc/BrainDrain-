using AutoMapper;
using BrainDrain.Dtos;
using BrainDrain.Models;
namespace BrainDrain.Profiles
{
  public class BrainDrainProfile: Profile
  {
    public BrainDrainProfile()
    {
      CreateMap<Command, CommandReadDto>();
    }
  }
}