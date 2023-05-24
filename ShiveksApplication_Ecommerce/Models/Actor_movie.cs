using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShiveksApplication_Ecommerce.Models
{
    //joining for many to many from movies and actors
    public class Actor_movie
    {
        public int ActorId { get; set; }
        public Movie Movie { get; set; }

        public Actor Actor { get; set; }
        public int MovieId { get; set; }
    }
}
