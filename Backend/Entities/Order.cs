using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Entities
{
    public static class Order
    {
        public static Customer Customer { get; set; }
        public static List<EventReservation> Reservations { get; set; }

        public static string MovieName { get; set; }
        public static int EventId { get; set; }
    }
}
