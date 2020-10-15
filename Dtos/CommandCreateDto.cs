using System.ComponentModel.DataAnnotations;
namespace BrainDrain.Dtos
{
  public class CommandCreateDto
  {
        // constraints are important because if bad data is passed it will show a 500 server error, when really the client is at fault.  Add the constraints will show a client 400 error if bad data is passed
        [Required]
        [MaxLength(250)]
        public string HowTo { get; set; }

        [Required]
        public string Line { get; set; }

        [Required]
        public string Platform { get; set; }
  }
}