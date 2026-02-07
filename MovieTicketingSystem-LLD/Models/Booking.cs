using MovieTicketingSystem_LLD.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicketingSystem_LLD.Models
{
    public class Booking
    {
        public Guid Id { get; } = Guid.NewGuid();
        public Guid ShowId { get; }
        public List<int> SeatNumbers { get; }
        public BookingStatus Status { get; private set; }

        public Booking(Guid showId, List<int> seatNumbers)
        {
            ShowId = showId;
            SeatNumbers = seatNumbers;
            Status = BookingStatus.Created;
        }

        public void Confirm() => Status = BookingStatus.Confirmed;
        public void Cancel() => Status = BookingStatus.Cancelled;
    }
}
