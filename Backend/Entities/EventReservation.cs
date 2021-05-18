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
    public class EventReservation
    {
        [Key]
        public int ID { get; set; }
        
        public int SeatId { get; set; }        
        
        public int CustomerId { get; set; }
        
        public int EventId { get; set; }
        [ForeignKey("EventId")]
        public virtual Event Event { get; set; }
        [ForeignKey("SeatId")]
        public virtual IQueryable<Seat> Seat { get; set; }
        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }
    }
}
