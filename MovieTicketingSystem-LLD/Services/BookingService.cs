using MovieTicketingSystem_LLD.Models;
using MovieTicketingSystem_LLD.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicketingSystem_LLD.Services
{
    public class BookingService
    {
        private readonly IShowRepository _repo;

        public BookingService(IShowRepository repo)
        {
            _repo = repo;
        }

        public Booking CreateBooking(Guid showId, List<int> seats)
        {
            var show = _repo.GetShow(showId) ?? throw new ArgumentException("Show not found");

            show.LockSeats(seats);
            show.BookSeats(seats);

            var booking = new Booking(showId, seats);
            booking.Confirm();
            return booking;
        }
    }
}
