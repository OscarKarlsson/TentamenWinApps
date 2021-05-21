using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Entities
{
    public class HistoryInfo
    {
        public int EventId { get; set; }
        public string movieName { get; set; }
        public DateTime StartTime { get; set; }
        public int Seat { get; set; }
        public int CustomerId { get; set; }
    }
}
