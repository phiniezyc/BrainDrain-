namespace BrainDrain.Dtos
{
  public class CommandReadDto
  {

        public int Id { get; set; }


        public string HowTo { get; set; }

        public string Line { get; set; }

        //public string Platform { get; set; } //removed because don't need to expose to client
  }
}