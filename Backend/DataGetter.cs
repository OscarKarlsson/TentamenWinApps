using Backend.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class DataGetter
    {
        public List<Movie> GetMovies()
        {
            using (var context = new CinemaContext("CinemaContext"))
            {
                var Movies = (from m in context.Movies
                              select m).ToList();
                return Movies;
            }
        }
        public DbQuery<Event> GetEvents(CinemaContext context)
        {
            using (context)
            {
                var events = context.Events.Include("Movie");
                return events;
            }
        }
        public List<Seat> GetSeats()
        {
            using (var context = new CinemaContext("CinemaContext"))
            {
                var seats = context.Seats.Where(e => e.EventReservation.EventId == Order.EventId).ToList();
                return seats;
            }
        }
    }
}
