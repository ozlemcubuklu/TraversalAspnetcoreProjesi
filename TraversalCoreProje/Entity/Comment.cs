using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Comment
    {
        public int Id { get; set; }
        public string User { get; set; }
        public DateTime Date { get; set; }
        public string Content { get; set; }
        public bool State { get; set; }
        public int DestinationId { get; set; }
        public Destination Destination { get; set; }


        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}
