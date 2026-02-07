using MovieTicketingSystem_LLD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicketingSystem_LLD.Repositories
{
    public interface IShowRepository
    {
        void AddShow(Show show);
        Show? GetShow(Guid showId);
    }
}
