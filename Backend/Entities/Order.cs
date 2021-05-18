using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Entities
{
    public class Order
    {
        public Customer Customer { get; set; }
        public List<EventReservation> Reservations { get; set; }
    }
}
