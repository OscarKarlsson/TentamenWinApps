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
        public List<EventReservation> GetSeats()
        {
            using (var context = new CinemaContext("CinemaContext"))
            {
                var reservations = context.EventReservations.Where(e => e.EventId == Order.EventId).ToList();
                return reservations;
            }
        }
        public IQueryable<HistoryInfo> GetHistory(string phoneNr, CinemaContext context)
        {
            var query = from eventRes in context.EventReservations
                        join events in context.Events on eventRes.EventId equals events.ID
                        join movies in context.Movies on events.MovieId equals movies.ID
                        join customer in context.Customers on eventRes.CustomerId equals customer.ID
                        where customer.PhoneNr.Contains(phoneNr)
                        select new HistoryInfo { EventId = events.ID, movieName = movies.Name, StartTime = events.StartTime };
            return query;
            //var query = from history in context.ReservationHistoriy
            //            join events in context.Events on history.EventId equals events.ID
            //            join movies in context.Movies on events.MovieId equals movies.ID
            //            where history.PhoneNr.Contains(phoneNr)
            //            select new HistoryInfo { EventId = events.ID, movieName = movies.Name, StartTime = events.StartTime };
            //return query;            
        }
        public IQueryable<HistoryInfo> GetHistoryRemove(CinemaContext context)
        {
            var query = from eventsRes in context.EventReservations
                        join events in context.Events on eventsRes.EventId equals events.ID
                        join movies in context.Movies on events.MovieId equals movies.ID                        
                        join customer in context.Customers on eventsRes.CustomerId equals customer.ID
                        where eventsRes.Customer.PhoneNr.Contains(Order.Customer.PhoneNr)
                        where eventsRes.EventId.Equals(Order.EventIdRemove)
                        select new HistoryInfo { EventId = events.ID, movieName = movies.Name, StartTime = events.StartTime, Seat = eventsRes.SeatId, CustomerId = customer.ID };
            return query;
            //var query = from history in context.ReservationHistoriy
            //            join events in context.Events on history.EventId equals events.ID
            //            join movies in context.Movies on events.MovieId equals movies.ID
            //            join eventRes in context.EventReservations on events.ID equals eventRes.EventId
            //            join customer in context.Customers on eventRes.CustomerId equals customer.ID
            //            where eventRes.Customer.PhoneNr.Contains(Order.Customer.PhoneNr)
            //            where eventRes.EventId.Equals(Order.EventIdRemove)
            //            select new HistoryInfo { EventId = events.ID, movieName = movies.Name, StartTime = events.StartTime, Seat = eventRes.SeatId, CustomerId = customer.ID };
            //return query;
        }
        public Customer GetCustomer(string phoneNr)
        {
            using (var context = new CinemaContext("CinemaContext"))
            {
                var customer = context.Customers.Where(p => p.PhoneNr == phoneNr).FirstOrDefault();
                return customer;
            }
        }
        
        public Event GetEvent(DateTime start, string movieName)
        {
            using (var context = new CinemaContext("CinemaContext"))
            {
                var events = context.Events.Where(e => e.StartTime == start)
                    .Where(e => e.Movie.Name == movieName)
                    .First();
                return events;
            }
        }
    }
}
