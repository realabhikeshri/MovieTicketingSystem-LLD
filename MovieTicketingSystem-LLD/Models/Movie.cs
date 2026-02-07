using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicketingSystem_LLD.Models
{
    public class Movie
    {
        public Guid Id { get; } = Guid.NewGuid();
        public string Title { get; }

        public Movie(string title)
        {
            Title = title;
        }
    }
}
