using MovieTicketingSystem_LLD.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicketingSystem_LLD.Models
{
    public class Seat
    {
        public int SeatNumber { get; }
        public SeatStatus Status { get; private set; } = SeatStatus.Available;

        public Seat(int seatNumber)
        {
            SeatNumber = seatNumber;
        }

        public void Lock() => Status = SeatStatus.Locked;
        public void Book() => Status = SeatStatus.Booked;
        public void Release() => Status = SeatStatus.Available;
    }
}
