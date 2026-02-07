using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicketingSystem_LLD.Models
{
    public class Screen
    {
        public Guid Id { get; } = Guid.NewGuid();
        public string Name { get; }
        public List<Seat> Seats { get; }

        public Screen(string name, int seatCount)
        {
            Name = name;
            Seats = Enumerable.Range(1, seatCount)
                              .Select(i => new Seat(i))
                              .ToList();
        }
    }
}
