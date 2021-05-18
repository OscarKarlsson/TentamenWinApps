using Backend.ValidationAttributes;
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
    public class Seat
    {
        [Key]
        public int ID { get; set; }
        [CustomValidation(typeof(SeatNumberValidationAttribute), "IsValidSeatNumber")]
        public int SeatNumber { get; set; }
        
        public int EventReservationId { get; set; }
        [ForeignKey("EventReservationId")]
        public virtual EventReservation EventReservation { get; set; }

    }
}
