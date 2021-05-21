using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Entities
{
    public class CinemaContext : DbContext
    {
        public CinemaContext(string connection) : base(connection)
        {
        }
        public DbSet<Auditorium> Auditoriums { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<EventReservation> EventReservations { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Seat> Seats { get; set; }
        public DbSet<ReservationHistory> ReservationHistoriy { get; set; }
    }
}
