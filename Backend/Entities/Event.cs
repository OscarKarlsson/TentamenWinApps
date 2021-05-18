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
    public class Event
    {
        [Key]
        public int ID { get; set; }        
        public int AuditoriumId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int MovieId { get; set; }
        [ForeignKey("MovieId")]
        public virtual Movie Movie { get; set; }
        public int EventReservationId { get; set; }
        [ForeignKey("EventReservationId")]
        public virtual List<EventReservation> EventReservations { get; set; }
        [ForeignKey("AuditoriumId")]
        public virtual Auditorium Auditorium { get; set; }
    }
}
