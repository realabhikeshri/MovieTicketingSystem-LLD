using MovieTicketingSystem_LLD.Enums;
using MovieTicketingSystem_LLD.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicketingSystem_LLD.Models
{
    public class Show
    {
        public Guid Id { get; } = Guid.NewGuid();
        public Movie Movie { get; }
        public Screen Screen { get; }
        public DateTime StartTime { get; }

        private readonly object _lock = new();

        public Show(Movie movie, Screen screen, DateTime startTime)
        {
            Movie = movie;
            Screen = screen;
            StartTime = startTime;
        }

        public void LockSeats(List<int> seatNumbers)
        {
            lock (_lock)
            {
                foreach (var seatNo in seatNumbers)
                {
                    var seat = Screen.Seats.First(s => s.SeatNumber == seatNo);
                    if (seat.Status != SeatStatus.Available)
                        throw new SeatUnavailableException("Seat already booked or locked");
                }

                foreach (var seatNo in seatNumbers)
                    Screen.Seats.First(s => s.SeatNumber == seatNo).Lock();
            }
        }

        public void BookSeats(List<int> seatNumbers)
        {
            lock (_lock)
            {
                foreach (var seatNo in seatNumbers)
                    Screen.Seats.First(s => s.SeatNumber == seatNo).Book();
            }
        }
    }
}
