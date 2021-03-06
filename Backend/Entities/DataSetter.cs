using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Entities
{
    public class DataSetter
    {
        public void SetCustomer(string phoneNr, string firstName, string lastName)
        {
            Customer customer = new Customer() { FirstName = firstName, LastName = lastName, PhoneNr = phoneNr };
            using (var context = new CinemaContext("CinemaContext"))
            {
                context.Customers.Add(customer);
                context.SaveChanges();
            }
            
        }
        public void SetEventReservation()
        {
            using (var context = new CinemaContext("CinemaContext"))
            {
                var customer = context.Customers.Where(c => c.PhoneNr == Order.Customer.PhoneNr)
                    .First();
                foreach (var reservation in Order.Reservations)
                {
                    reservation.CustomerId = customer.ID;
                    context.EventReservations.Add(reservation);
                    context.SaveChanges();
                }
                
            }  
        }
        public void RemoveEventReservations(int seat)
        {
            using (var context = new CinemaContext("CinemaContext"))
            {
                var reservation = context.EventReservations.Where(c => c.CustomerId == Order.Customer.ID)
                    .Where(s => s.SeatId == seat).First();
                
                context.EventReservations.Remove(reservation);
                context.SaveChanges();
            }
        }
    }
}
