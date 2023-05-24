using ShiveksApplication_Ecommerce.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShiveksApplication_Ecommerce.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string CInemaName { get; set; }
        public string Actor { get; set; }
        public MovieCategory Movie_Category { get; set; }
        public string Producer { get; set; }
        public string ImageUrl { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }

        //relationship
        public List<Actor_movie> Actor_Movies { get; set; }
        public int cinemaId { get; set; }
        [ForeignKey("cinemaID")]

      //  public Cinema cinema { get; set; }

        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]

       // public Producer producer { get; set; }




    }
}
