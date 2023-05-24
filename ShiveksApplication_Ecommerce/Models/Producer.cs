using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShiveksApplication_Ecommerce.Models
{
    public class Producer
    {
        [Key]
        public int ProducerId { get; set; }
        public string profilePictureURL { get; set; }
        public string Name { get; set; }
        public string Biography { get; set; }

        //relationship
        public List<Movie> movies { get; set; }

    }
}
