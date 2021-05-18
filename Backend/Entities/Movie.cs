using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Entities
{
    public class Movie
    {
        [Key]
        public int ID { get; set; }
        [MinLength(1), MaxLength(64),Required]
        public string Name { get; set; }
        public TimeSpan Duration { get; set; }
        [MinLength(10), MaxLength(250), Required]
        public string Description { get; set; }
        public string FilePath { get; set; }
    }
}
