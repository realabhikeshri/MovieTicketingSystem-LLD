using MovieTicketingSystem_LLD.Models;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicketingSystem_LLD.Repositories
{
    public class InMemoryShowRepository : IShowRepository
    {
        private readonly ConcurrentDictionary<Guid, Show> _shows = new();

        public void AddShow(Show show) => _shows.TryAdd(show.Id, show);
        public Show? GetShow(Guid showId) => _shows.GetValueOrDefault(showId);
    }
}
