using EVP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EVP.ViewModels
{
    public class EventsBookings
    {
        public IEnumerable<Event> Events { get; set; }

        public IEnumerable<Booking> Bookings { get; set; }
    }
}
