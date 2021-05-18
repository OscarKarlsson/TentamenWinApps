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
    public class Customer
    {
        [Key]
        public int ID { get; set; }
        [MinLength(1), MaxLength(20), Required(ErrorMessage = "Firstname cannot be empty.")]
        public string FirstName { get; set; }
        [MinLength(1), MaxLength(32), Required(ErrorMessage = "Lastname cannot be empty.")]
        public string LastName { get; set; }
        [MinLength(5), MaxLength(12), Required(ErrorMessage = "Phonenumber cannot be empty.")]
        public string PhoneNr { get; set; }

    }
}
