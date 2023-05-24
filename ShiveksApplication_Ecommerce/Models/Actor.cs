using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShiveksApplication_Ecommerce.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        public string profilePictureURL { get; set; }
        public string Name { get; set; }
        public string Biography { get; set; }

        //relationship
        public List<Actor_movie> Actor_Movies { get; set; }

    }
}
