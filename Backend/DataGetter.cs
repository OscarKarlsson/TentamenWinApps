using Backend.Entities;
using System;
using System.Collections.Generic;
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

    }
}
