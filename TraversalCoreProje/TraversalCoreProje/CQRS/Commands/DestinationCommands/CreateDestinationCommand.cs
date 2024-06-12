using System.Collections.Generic;

namespace TraversalCoreProje.CQRS.Commands.DestinationCommands
{
    public class CreateDestinationCommand
    {
       
        public string City { get; set; }
        public string DayNight { get; set; }
        public double Price { get; set; }
        public int Capasity { get; set; }
   
    }
}
