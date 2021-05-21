using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Entities
{
    public class ReservationHistory
    {
        [Key]
        public int Id { get; set; }
        public string PhoneNr { get; set; }
        public int EventId { get; set; }
        public int SeatId { get; set; }
    }
}
