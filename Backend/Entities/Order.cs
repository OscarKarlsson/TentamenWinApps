using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Entities
{
    public static class Order
    {
        public static Customer Customer { get; set; } = new Customer();
        public static List<EventReservation> Reservations { get; set; } = new List<EventReservation>();
        public static string MovieName { get; set; }
        public static int EventId { get; set; }

        static public void RemoveData()
        {
            MovieName = null;
            EventId = 0;
            Customer = null;
            Reservations.Clear();
        }
    }
}
