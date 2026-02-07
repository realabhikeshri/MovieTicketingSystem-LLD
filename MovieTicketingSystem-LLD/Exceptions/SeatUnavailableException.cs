using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicketingSystem_LLD.Exceptions
{
    public class SeatUnavailableException : Exception
    {
        public SeatUnavailableException(string message) : base(message) { }
    }
}
